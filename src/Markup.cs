using System;
using System.IO;
using System.Linq;
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
            var settings = Settings.Value;
            await using var connection = new NpgsqlConnection(connectionString);
            await connection.OpenAsync();
            var file = Settings.FileName(connection);
            Console.WriteLine($"Creating file {file} ...");
            await using var outputFile = new StreamWriter(file);
            outputFile.WriteLine($"# Dictionary for database `{connection.Database}`");
            outputFile.WriteLine();
            outputFile.WriteLine(
                $"- Server: PostgreSQL `{connection.Host}:{connection.Port}`, version `{connection.ServerVersion}`");
            outputFile.WriteLine($"- Local timestamp: `{DateTime.Now:o}`");

            foreach (var schema in settings.Schemas.Distinct())
            {
                var schemaHeader = false;

                await foreach (var result in connection.GetTables(schema, settings.SkipTablesPattern).ValuesAsync)
                {
                    if (!schemaHeader)
                    {
                        outputFile.WriteLine();
                        outputFile.WriteLine($"## Schema `{schema}`");
                        Console.WriteLine($"Writing schema {schema} ...");
                        schemaHeader = true;
                    }

                    if (result.column == null)
                    {
                        Console.WriteLine($"Writing table {result.table} ...");
                        outputFile.WriteLine();
                        outputFile.WriteLine($"### Table `{schema}.{result.table}`");
                        outputFile.WriteLine();
                        outputFile.WriteLine(Settings.StartTag("table", $"{schema}.{result.table}"));
                        if (result.comment != null)
                        {
                            outputFile.WriteLine(result.comment);
                        }
                        outputFile.WriteLine(Settings.EndTag);
                        outputFile.WriteLine();
                        outputFile.WriteLine("| Column |  Constraint | Type | Nullable | Default | Comment |");
                        outputFile.WriteLine("| ------ | ----------- | -----| -------- | ------- | ------- |");
                    }
                    else
                    {
                        outputFile.WriteLine(
                            $"| `{result.column}` " +
                            $"| {result.constraintMarkup} " +
                            $"| `{result.columnType}` " +
                            $"| {result.nullable} " +
                            $"| {result.defaultMarkup} " +
                            $"| {Settings.StartTag("column", $"{schema}.{result.table}.{result.column}")}{result.comment}{Settings.EndTag} |");
                    }
                }

                if (!settings.IncludeRoutines)
                {
                    continue;
                }

                var routinesHeader = false;
                await foreach (var result in connection.GetRoutines(schema).ValuesAsync)
                {
                    if (!routinesHeader)
                    {
                        outputFile.WriteLine();
                        outputFile.WriteLine("### Routines");
                        routinesHeader = true;
                    }
                    Console.WriteLine($"Writing routine {result.name} ...");
                    outputFile.WriteLine();
                    outputFile.WriteLine(
                        $"#### {result.type.First().ToString().ToUpper()}{result.type.Substring(1)} `{schema}.{result.signature}`");
                    outputFile.WriteLine();
                    outputFile.WriteLine($"- Returns `{result.returns}`");
                    outputFile.WriteLine();
                    outputFile.WriteLine($"- Language is `{result.language}`");
                    outputFile.WriteLine();
                    outputFile.WriteLine(Settings.StartTag(result.type, $"{schema}.{result.signature}"));
                    if (result.comment != null)
                    {
                        outputFile.WriteLine(result.comment);
                    }
                    outputFile.WriteLine(Settings.EndTag);
                }
            }

            await connection.CloseAsync();
            Console.WriteLine("Done!");
        }
    }
}
