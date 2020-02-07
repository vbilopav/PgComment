# pgcomment

PostgreSQL tool for database dictionary in your markup file.

This tool will read comments for each table and columns and create nicely formatted markup file that you can use as database dictionary.

## Basic usage

Run following command from command line:

```
pgcomment connectionstrings:="server=localhost;database=database_name;port=5432;user id=user;password=password;"
Creating file DB DICTIONARY database_name.md ...
Writing schema public ...
Done!
```

Settings file `settings.json` instead of command line:

```json
{
  "ConnectionStrings": {
    "MyConnection": "server=localhost;database=database_name;port=5432;user id=user;password=password;"
  }
}
```

Then just run:

```
pgcomment"
Creating file DB DICTIONARY database_name.md ...
Writing schema public ...
Done!
```

## Options

Options can be defined in `settings.json` or as command line parameter. Command line will override  `settings.json`.

| Name | Default | Description |
| ---- | ------- | ----------- |
| MarkupName | DB DICTIONARY {0}.md | File name that will be created. `DB DICTIONARY database_name.md` |
| Schemas | public | CSV list of schema names to include in output file |
| SkipTablesPattern | pg_% | Skip tables that are similar with this pattern |
| ConnectionStrings | none | ConnectionStrings section with connections defined by ADO.NET (Npgsql) convention. See example above. |

## Building for source

Clone this repo and run build script. You'll find standalone executables for windows, linux and mac in `out` dir.

## Future plans

Update PostgreSQL object comments from markup file.

## Example output

Example of output is bellow:

# Dictionary for database `my_database`

- Server: PostgreSQL `localhost:5432`, version `11.6`
- Local timestamp: `2020-02-07T18:39:10.6471909+01:00`

## Schema `public`

### Table `__EFMigrationsHistory`

Internal .NET table. Holds a list of all applied migrations in this database.

| Column | Type | Nullable | Default | Comment |
| ------ | ---- | -------- | ------- | ------- |
| MigrationId | character varying(150) | NOT NULL |  |  Matches miragtion file from source code `Data/Migrations/MigrationId.cs` |
| ProductVersion | character varying(32) | NOT NULL |  |  |

### Table `role`

| Column | Type | Nullable | Default | Comment |
| ------ | ---- | -------- | ------- | ------- |
| id | bigint | NOT NULL |  |  |
| name | character varying(256) | NULL |  |  |
| normalized_name | character varying(256) | NULL |  |  |
| concurrency_stamp | text | NULL |  |  |

### Table `role_claim`

| Column | Type | Nullable | Default | Comment |
| ------ | ---- | -------- | ------- | ------- |
| id | integer | NOT NULL |  |  |
| role_id | bigint | NOT NULL |  |  |
| claim_type | text | NULL |  |  |
| claim_value | text | NULL |  |  |

### Table `user`

| Column | Type | Nullable | Default | Comment |
| ------ | ---- | -------- | ------- | ------- |
| id | bigint | NOT NULL |  |  |
| user_name | character varying(256) | NULL |  |  |
| normalized_user_name | character varying(256) | NULL |  |  |
| email | character varying(256) | NULL |  |  |
| normalized_email | character varying(256) | NULL |  |  |
| password_hash | text | NULL |  |  |
| security_stamp | text | NULL |  |  |
| concurrency_stamp | text | NULL |  |  |
| lockout_end | timestamp with time zone | NULL |  |  |
| lockout_enabled | boolean | NOT NULL |  |  |
| access_failed_count | integer | NOT NULL |  |  |
| name | text | NULL |  |  |
| given_name | text | NULL |  |  |
| picture_url | text | NULL |  |  |
| culture | text | NULL |  |  |
| timezone | text | NULL |  |  |
| data | json | NULL |  |  |

### Table `user_claim`

| Column | Type | Nullable | Default | Comment |
| ------ | ---- | -------- | ------- | ------- |
| id | integer | NOT NULL |  |  |
| user_id | bigint | NOT NULL |  |  |
| claim_type | text | NULL |  |  |
| claim_value | text | NULL |  |  |

### Table `user_login`

| Column | Type | Nullable | Default | Comment |
| ------ | ---- | -------- | ------- | ------- |
| login_provider | text | NOT NULL |  |  |
| provider_key | text | NOT NULL |  |  |
| provider_display_name | text | NULL |  |  |
| user_id | bigint | NOT NULL |  |  |

### Table `user_role`

| Column | Type | Nullable | Default | Comment |
| ------ | ---- | -------- | ------- | ------- |
| user_id | bigint | NOT NULL |  |  |
| role_id | bigint | NOT NULL |  |  |

### Table `user_token`

| Column | Type | Nullable | Default | Comment |
| ------ | ---- | -------- | ------- | ------- |
| user_id | bigint | NOT NULL |  |  |
| login_provider | text | NOT NULL |  |  |
| name | text | NOT NULL |  |  |
| value | text | NULL |  |  |
