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
<!-- comment on table public.table_name is @until-end-tag; -->
You comment here. Edit me.
<!-- end -->
```

From command line execute `pgcomment` with `--commit` option:

```
> pgcomment --commit
Reading file DB DICTIONARY database_name.md ...

do $comments_update$
begin

  comment on table public.table_name is $$You comment here. Edit me.$$;
  
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

## Building for source

Clone this repo and run build script. You'll find standalone executables for windows, linux and mac in `out` dir.

## Future plans

Update PostgreSQL object comments from markup file.

## Direct download

You can download zip archive with latest build [here](https://github.com/vbilopav/PgComment/releases/tag/v1.0)

