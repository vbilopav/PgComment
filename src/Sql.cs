using System;
using System.Collections.Generic;
using System.Text;
using Norm.Extensions;
using Npgsql;

namespace PgComment
{
    public class TableResults
    {
        public IAsyncEnumerable<(
                string table,
                string column,
                string constraintMarkup,
                string columnType,
                string nullable,
                string defaultMarkup,
                string comment)>
            ValuesAsync { get; set; }
    }

    public class RoutineResults
    {
        public IAsyncEnumerable<(
                string type,
                string name,
                string signature,
                string returns,
                string language,
                string comment)>
            ValuesAsync { get; set; }
    }

    public static class Sql
    {
        public static TableResults GetTables(this NpgsqlConnection connection, string schema, string skipPattern) => new TableResults
        {
            ValuesAsync = connection.ReadAsync<string, string, string, string, string, string, string>(@"

                with table_constraints as (
                    
                    select 
                        sub.table_name,
                        sub.column_name,
                        string_agg(
                            sub.description_markup, 
                            ', ' 
                            order by 
                                case 
                                    when sub.description_markup = '**PK**' then ' ' 
                                    else sub.description_markup 
                                end
                        ) as description_markup
                    from (
                        select 
                            tc.table_name, 
                            coalesce(kcu.column_name, ccu.column_name) as column_name,
                            case    when tc.constraint_type = 'PRIMARY KEY' 
                                    then '**PK**'
                                    when tc.constraint_type = 'FOREIGN KEY' 
                                    then '**FK [➝](#table-' || ccu.table_schema || ccu.table_name || ') `' || 
                                        case    when tc.constraint_schema = ccu.table_schema 
                                                then ''
                                                else ccu.table_schema || '.'
                                        end 
                                        || ccu.table_name || '.' || ccu.column_name || '`**'
                                else tc.constraint_type
                            end as description_markup

                        from
                            information_schema.table_constraints tc
                            inner join information_schema.constraint_column_usage ccu 
                            on tc.constraint_schema = ccu.constraint_schema and tc.constraint_name = ccu.constraint_name
                            left outer join information_schema.key_column_usage kcu 
                            on tc.constraint_type = 'FOREIGN KEY' and tc.constraint_schema = kcu.constraint_schema and ccu.constraint_name = kcu.constraint_name
                        where
                            tc.constraint_schema = @schema
                        order by
                            description_markup
                    ) sub
                    group by 
                        sub.table_name, sub.column_name

                )
                select 
                    table_name_id as table_name,
                    c.column_name,
                    tc.description_markup,
                    c.data_type || 

                        case    when c.data_type <> 'integer' and c.data_type <> 'bigint' and c.data_type <> 'smallint' 
                                then
                                    case    when c.character_maximum_length is not null 
                                            then '(' || cast(c.character_maximum_length as varchar) || ')'
                                            else 
                                                case    when c.numeric_precision is not null 
                                                        then '(' || cast(c.numeric_precision as varchar) || ',' || cast(c.numeric_precision_radix as varchar) || ')' || 
                                                            case    when coalesce(c.numeric_scale, 0) = 0 
                                                                    then '' 
                                                                    else ',' || cast(c.numeric_scale as varchar) || ')'
                                                            end
                                                else ''
                                                end
                                    end
                                else ''
                        end as data_type,

                    case when c.is_nullable = 'NO' then '**NO**' else c.is_nullable end as nullableMarkup,
                    
                    case    when c.column_default like 'next%' or c.identity_generation = 'ALWAYS' 
                            then '*auto increment*' 
                            else '`' || c.column_default || '`' 
                    end as defaultMarkup,
                    
                    pgdesc.description
                    
                from (
                        select t1.table_name as table_name_id, t1.table_name
                        from information_schema.tables t1
                        where t1.table_schema = @schema
                        union all
                        select t2.table_name as table_name_id, null as table_name
                        from information_schema.tables t2
                        where t2.table_schema = @schema
                        order by table_name_id, table_name nulls first
                    ) t
                    
                    left outer join information_schema.columns c 
                    on t.table_name = c.table_name and c.table_schema = @schema 
                    
                    left outer join pg_catalog.pg_statio_user_tables pgtbl
                    on t.table_name_id = pgtbl.relname and pgtbl.schemaname = @schema
                    
                    left outer join pg_catalog.pg_description pgdesc
                    on pgtbl.relid = pgdesc.objoid and coalesce(c.ordinal_position, 0) = pgdesc.objsubid

                    left outer join table_constraints tc
                    on t.table_name = tc.table_name and c.column_name = tc.column_name
           
                where table_name_id not similar to @skipPattern
                        
                order by 
                    t.table_name_id, 
                    t.table_name nulls first, 
                    c.ordinal_position", ("schema", schema), ("skipPattern", skipPattern)
            )
        };

        public static RoutineResults GetRoutines(this NpgsqlConnection connection, string schema) => new RoutineResults
        {
            ValuesAsync = connection.ReadAsync<string, string, string, string, string, string>(@"

                select
                    lower(r.routine_type) as type,
                    r.routine_name,

                    r.routine_name || 
                        '(' || 
                        array_to_string(
                            array_agg(
                                case    when p.parameter_mode = 'IN' 
                                        then '' else lower(p.parameter_mode) || ' ' 
                                end || coalesce(p.data_type, '')
                                order by p.ordinal_position
                            ), 
                            ', '
                        ) ||
                        ')' as signature,
                        
                    case    when    r.data_type = 'USER-DEFINED' and 
                                    r.type_udt_catalog is not null and 
                                    r.type_udt_schema is not null and 
                                    r.type_udt_name is not null 
                            then 'setof ' || r.type_udt_name
                            else r.data_type
                    end as returns_type,
                    
                    lower(r.external_language) as language,
                    
                    pgdesc.description

                from 
                    information_schema.routines r
                    left outer join information_schema.parameters p 
                    on r.specific_name = p.specific_name and r.specific_schema = p.specific_schema

                    inner join pg_catalog.pg_proc proc on r.routine_name = proc.proname
                    left outer join pg_catalog.pg_description pgdesc on proc.oid = pgdesc.objoid
                where
                    r.specific_schema = @schema
                    and r.external_language <> 'INTERNAL'

                group by
                    r.specific_name, r.routine_type, r.external_language, r.routine_name, 
                    r.data_type, r.type_udt_catalog, r.type_udt_schema, r.type_udt_name,
                    pgdesc.description

            ", ("schema", schema))
        };
    }
}