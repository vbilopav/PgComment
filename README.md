# pgcomment

A **command-line tool** to create beautiful, professional and interactive (with navigation) **PostgreSQL database documentation.**

It can help you create a [Markdown document](https://guides.github.com/features/mastering-markdown/) from [`comment`](https://www.postgresql.org/docs/current/sql-comment.html) entries in your PostgreSQL database.

Include your generated document with your source code files and share it with a team and you will have the same comments in database and documentation.

To keep comments in sync with the database - you can **edit the document and commit to the database with one command.**

## See some examples

- [`northwind` database](https://github.com/vbilopav/PgComment/blob/e552fdb297cab84461334adfa0041a32be1648f3/DB%20DICTIONARY%20northwind.md)

- [`Adventureworks` database](https://github.com/vbilopav/PgComment/blob/master/DB%20DICTIONARY%20Adventureworks.md)

- [`dvdrental` database](https://github.com/vbilopav/PgComment/blob/e552fdb297cab84461334adfa0041a32be1648f3/DB%20DICTIONARY%20dvdrental.md)

## Basic usage

Create a JSON settings file named `settings.json` or `appsettings.json` to define you database connection:

```json
{
  "ConnectionStrings": {
    "MyConnection": "server=localhost;database=my_database;port=5432;user id=user;password=password;"
  }
}
```

Note that this file might already be part of your project if you using .NET Core settings system.

From command line execute `pgcomment` with `--pull` option:

```
> pgcomment --pull
Writing table table1 ...
Writing table table2 ...
Writing table table3 ...
...
Creating file DB DICTIONARY database_name.md ...
Done!
>
```

Your document is created.

To edit created markdown and update comments:

- Edit comments between folllowing tags:

```html
<!-- comment on table public."table_name" is @until-end-tag; -->
You comment here. Edit me.
<!-- end -->
```

From command line execute `pgcomment` with `--commit` option:

```
> pgcomment --commit
Reading file DB DICTIONARY database_name.md ...

do $comments_update$
begin

  comment on table public."table_name" is $$You comment here. Edit me.$$;
  
end
$comments_update$;

Database updated successfully!
>
```

Program will also dump SQL sent to the database. Only edited comments are updated.

## Command line options

| Name | Description |
| ---- | ----------- |
| -h --help | Show command line help.  |
| --settings=file | Use settings file from other location or with different name. Path is relative to command line. |
| -p --pull | Pulls comments from database and creates a markdown file. One for each connection in settings based on settings configuration. |
| -c --commit | Updates databases from existing markdown files and dumps SQL sent to database. Markdown file is defined in settings configurartion. |
| -d --dump | Same as commit but only dumps SQL generated, does not update database. |

## Settings

Settings can be set in a settings JSON file or from command line. 

Command line settings will override any setting in JSON file. Program will search dir from where command line is executed for following names:

- 'settings.json'
- 'appsettings.json'
- 'settings.private.json'
- 'settings.Development.json'

Multiple setting files will be merged in reveresed order.

| Command line setting | JSON settings | Default | Description | 
| -------------------- | ------------- | ------- | ----------- |
| `pgcomment:markdownname=[name]` | `"PgComment": {"MarkdownName": "name" }`  | `DB DICTIONARY {0}.md` | File name to generate or to search for. `{0}` placeholder is replaced with database name. |
| `pgcomment:schemas[index]=[schema]` | `"PgComment": {"Schemas": ["schema1", "schema2"] }`  | `DB DICTIONARY {0}.md` | Database schemas to include in generated file. Multiple schemas in command line settings are separated by zero based index. |
| `pgcomment:skippattern=[pattern]` | `"PgComment": {"SkipPattern": "pattern" }`  | `pg_%` | Skip object that are similar with this pattern when generating file. Uses `SIMILIAR TO` [syntax](https://www.postgresql.org/docs/current/functions-matching.html) |
| `pgcomment:includeviews=[true or false]` | `"PgComment": {"IncludeViews": true}`  | `true` | Include views? |
| `pgcomment:includeroutines=[true or false]` | `"PgComment": {"IncludeRoutines": true}`  | `true` | Include routines (functions and procedures)? |
| `connectionstrings:[name]=[connection]` | `"ConnectionStrings": {"ConnectionName": "connection"}`  | none | Connection strings in ADO.NET (Npgsql) format: `Server=;Database=;Port=;User Id=;Password=;`. Each connection have unique name. |


## Building for source

You need .NET Core 3.1. framework installed.

Clone this repo and run build script: `build.bat` for Windows or `build.sh` for Linux and Mac.

Build script will create following dirs with stand-alone (framewrok independent) executables:

- `/out/linux-x64`
- `/out/osx-x64`
- `/out/win10-x64`

## Direct download

You can download zip archivew with latest build here:
- [linux-x64](https://github.com/vbilopav/PgComment/releases/download/v2.1/linux-x64.zip)
- [osx-x64](https://github.com/vbilopav/PgComment/releases/download/v2.1/osx-x64.zip)
- [win10-x64](https://github.com/vbilopav/PgComment/releases/download/v2.1/win10-x64.zip)

Note:
Linux and Mac version may not be thoroughly tested, they should work without problems theoretically. If you find any issues or bug, please open [new issue here](https://github.com/vbilopav/PgComment/issues/new).

## Support

This is open-source software developed and maintained freely without any compensation whatsoever.

If you find it useful please consider rewarding me on my effort by [buying me a beer](https://www.paypal.me/vbsoftware/5)🍻 or [buying me a pizza](https://www.paypal.me/vbsoftware/10)🍕

Or if you prefer bitcoin:
bitcoincash:qp93skpzyxtvw3l3lqqy7egwv8zrszn3wcfygeg0mv

## Licence

Copyright (c) Vedran Bilopavlović - VB Consulting 2020
This source code is licensed under the [MIT license](https://github.com/vbilopav/PgComment/blob/master/LICENSE).

