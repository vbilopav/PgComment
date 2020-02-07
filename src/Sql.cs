using System;
using System.Collections.Generic;
using System.Text;

namespace PgComment
{
    public class Sql
    {
        public static string Tables => @"
        select 
            table_name_id,
            t.table_name,
            c.column_name,

            c.data_type || 

                case when c.data_type <> 'integer' and c.data_type <> 'bigint' then
                
                    case when c.character_maximum_length is not null then '(' || cast(c.character_maximum_length as varchar) || ')'
                         else   case when c.numeric_precision is not null 
                                then '(' || cast(c.numeric_precision as varchar) || ',' || cast(c.numeric_precision_radix as varchar) || ')' || 
                                    case when coalesce(c.numeric_scale, 0) = 0 then '' else ',' || cast(c.numeric_scale as varchar) || ')' end
                                else ''
                                end
                         end
                    else ''
                end,

            case when c.is_nullable = 'YES' then 'NULL' when c.is_nullable = 'NO' then 'NOT NULL' else '' end as nullable,
            case when c.column_default like 'next%' or c.identity_generation = 'ALWAYS' then 'auto increment' else c.column_default end as default,
            
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
            
            left outer join pg_catalog.pg_statio_all_tables pgtbl
            on t.table_name_id = pgtbl.relname and pgtbl.schemaname = @schema
            
            left outer join pg_catalog.pg_description pgdesc
            on pgtbl.relid = pgdesc.objoid and coalesce(c.ordinal_position, 0) = pgdesc.objsubid
   
        where table_name_id not similar to @skipPattern
                
        order by 
            table_name_id, 
            table_name nulls first, 
            c.ordinal_position
        ";
    }
}
