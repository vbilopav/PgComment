using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace PgComment
{
    internal class Markup
    {
        public static async Task CreateAllMarkups(IConfiguration config)
        {
            foreach (var connString in config.GetSection("ConnectionStrings").GetChildren())
            {
                await CreateMarkupFile(connString.Value);
            }
        }

        private static async Task CreateMarkupFile(string connectionString)
        {
            var content = new StringBuilder();
            var header = new StringBuilder();

            var settings = Settings.Value;
            var schemas = settings.Schemas.Distinct().ToArray();
            await using var connection = new NpgsqlConnection(connectionString);
            await connection.OpenAsync();
            var file = Settings.FileName(connection);

            header.AppendLine($"# Dictionary for database `{connection.Database}`");
            header.AppendLine();
            header.AppendLine(
                $"- Server: PostgreSQL `{connection.Host}:{connection.Port}`, version `{connection.ServerVersion}`");
            header.AppendLine($"- Local timestamp: `{DateTime.Now:o}`");
            header.AppendLine($"- Schemas: {string.Join(", ", schemas.Select(s => $"`{s}`"))}");
            header.AppendLine();
            header.AppendLine("## Table of Contents");
            header.AppendLine();

            var tablesHeader = false;
            var writeToc = false;
            var anyTables = false;
            var anyViews = false;

            foreach (var schema in schemas)
            {
                await foreach (var result in connection.GetTables(schema, settings.SkipPattern).ValuesAsync)
                {
                    if (!tablesHeader)
                    {
                        //content.AppendLine();
                        content.AppendLine("## Tables");
                        tablesHeader = true;
                    }

                    if (result.column == null)
                    {
                        //<a href="#table-of-contents" title="Table of Contents">&#8673;</a>

                        Console.WriteLine($"Writing table {result.table} ...");
                        content.AppendLine();

                        if (writeToc)
                        {
                            content.AppendLine("<a href=\"#table-of-contents\" title=\"Table of Contents\">&#8673;</a>");
                            content.AppendLine();
                        }
                        else
                        {
                            writeToc = true;
                        }

                        content.AppendLine($"### Table `{schema}.{result.table}`");
                        header.AppendLine($"- Table [`{schema}.{result.table}`](#table-{schema.ToLower()}{result.table.ToLower()})");
                        content.AppendLine();
                        content.AppendLine(Settings.StartTag("table", $"{schema}.{result.table}"));
                        if (result.comment != null)
                        {
                            content.AppendLine(result.comment);
                        }

                        if (!anyTables)
                        {
                            anyTables = true;
                        }
                        content.AppendLine(Settings.EndTag);
                        content.AppendLine();
                        content.AppendLine("| Column |             | Type | Nullable | Default | Comment |");
                        content.AppendLine("| ------ | ----------- | -----| -------- | ------- | ------- |");
                    }
                    else
                    {
                        var name = $"{schema.ToLower()}-{result.table.ToLower()}-{result.column.ToLower()}";
                        content.AppendLine(
                            $"| {Settings.Hashtag(name)}`{result.column}` " +
                            $"| {result.constraintMarkup} " +
                            $"| `{result.columnType}` " +
                            $"| {result.nullable} " +
                            $"| {result.defaultMarkup} " +
                            $"| {Settings.StartTag("column", $"{schema}.{result.table}.{result.column}")}{result.comment}{Settings.EndTag} |");
                    }
                }
            }

            if (anyTables)
            {
                content.AppendLine();
                content.AppendLine("<a href=\"#table-of-contents\" title=\"Table of Contents\">&#8673;</a>");
            }

            foreach (var schema in schemas)
            {
                if (!settings.IncludeViews)
                {
                    break;
                }
                var viewsHeader = false;
                await foreach (var result in connection.GetTables(schema, settings.SkipPattern, "VIEW").ValuesAsync)
                {
                    if (!viewsHeader)
                    {
                        content.AppendLine();
                        content.AppendLine("## Views");
                        viewsHeader = true;
                    }

                    if (result.column == null)
                    {
                        Console.WriteLine($"Writing view {result.table} ...");
                        content.AppendLine();

                        if (writeToc)
                        {
                            content.AppendLine("<a href=\"#table-of-contents\" title=\"Table of Contents\">&#8673;</a>");
                            content.AppendLine();
                        }
                        else
                        {
                            writeToc = true;
                        }
                        if (!anyViews)
                        {
                            anyViews = true;
                        }

                        content.AppendLine($"### View `{schema}.{result.table}`");
                        header.AppendLine($"- View [`{schema}.{result.table}`](#view-{schema.ToLower()}{result.table.ToLower()})");
                        content.AppendLine();
                        content.AppendLine(Settings.StartTag("view", $"{schema}.{result.table}"));
                        if (result.comment != null)
                        {
                            content.AppendLine(result.comment);
                        }

                        content.AppendLine(Settings.EndTag);
                        content.AppendLine();
                        content.AppendLine("| Column | Type | Comment |");
                        content.AppendLine("| ------ | ---- | --------|");
                    }
                    else
                    {
                        content.AppendLine(
                            $"| `{result.column}` " +
                            $"| `{result.columnType}` " +
                            $"| {Settings.StartTag("column", $"{schema}.{result.table}.{result.column}")}{result.comment}{Settings.EndTag} |");
                    }
                }
            }

            if (anyViews)
            {
                content.AppendLine();
                content.AppendLine("<a href=\"#table-of-contents\" title=\"Table of Contents\">&#8673;</a>");
            }


            foreach (var schema in schemas)
            {
                if (!settings.IncludeRoutines)
                {
                    break;
                }
                var routinesHeader = false;
                await foreach (var result in connection.GetRoutines(schema, settings.SkipPattern).ValuesAsync)
                {
                    if (!routinesHeader)
                    {
                        content.AppendLine();
                        content.AppendLine("## Routines");
                        routinesHeader = true;
                    }

                    Console.WriteLine($"Writing routine {result.name} ...");
                    content.AppendLine();
                    content.AppendLine(
                        $"### {result.type.First().ToString().ToUpper()}{result.type.Substring(1)} `{schema}.{result.signature}`");
                    var routineAnchor = result.signature.ToLower().Replace("(", "").Replace(")", "").Replace(",", "").Replace(" ", "-");
                    header.AppendLine($"- {result.type.First().ToString().ToUpper()}{result.type.Substring(1)} [`{schema}.{result.signature}`](#{result.type.ToLower()}-{schema.ToLower()}{routineAnchor})");
                    content.AppendLine();
                    content.AppendLine($"- Returns `{result.returns}`");
                    content.AppendLine();
                    content.AppendLine($"- Language is `{result.language}`");
                    content.AppendLine();
                    content.AppendLine(Settings.StartTag(result.type, $"{schema}.{result.signature}"));
                    if (result.comment != null)
                    {
                        content.AppendLine(result.comment);
                    }

                    content.AppendLine(Settings.EndTag);
                }
            }
            content.AppendLine();
            content.AppendLine("<a href=\"#table-of-contents\" title=\"Table of Contents\">&#8673;</a>");


            await connection.CloseAsync();
            Console.WriteLine($"Creating file {file} ...");
            await File.WriteAllTextAsync(file, content.ToString());
            await using (var fileStream = new StreamWriter(file))
            {
                await fileStream.WriteLineAsync(header.ToString());
                await fileStream.WriteLineAsync(content.ToString());
            }
            Console.WriteLine("Done!");
        }
    }
}
