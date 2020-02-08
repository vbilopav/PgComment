using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Norm.Extensions;
using Npgsql;

namespace PgComment
{
    public class Settings
    {
        public string MarkupName { get; set; } = "DB DICTIONARY {0}.md";
        public string[] Schemas { get; set; } = {"public"};
        public string SkipTablesPattern { get; set; } = "pg_%";
        public bool IncludeRoutines { get; set; } = true;
    }

    public class Program
    {
        public static Settings Settings { get; set; }

        public static async Task Main(string[] args)
        {
            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile(Path.Join(Directory.GetCurrentDirectory(), "settings.json"), optional: true, reloadOnChange: false)
                .AddJsonFile(Path.Join(Directory.GetCurrentDirectory(), "settings.private.json"), optional: true, reloadOnChange: false)
                .AddCommandLine(args);

            var config = configBuilder.Build();
            Settings = new Settings();
            config.Bind(Settings);

            foreach (var connString in config.GetSection("ConnectionStrings").GetChildren())
            {
                await CreateMarkupFile(connString.Value);
            }
        }

        private static async Task CreateMarkupFile(string connectionString)
        {
            await using var connection = new NpgsqlConnection(connectionString);
            await connection.OpenAsync();
            var file = string.Format(Settings.MarkupName, connection.Database);
            Console.WriteLine($"Creating file {file} ...");
            await using var outputFile = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), file));
            outputFile.WriteLine($"# Dictionary for database `{connection.Database}`");
            outputFile.WriteLine();
            outputFile.WriteLine($"- Server: PostgreSQL `{connection.Host}:{connection.Port}`, version `{connection.ServerVersion}`");
            outputFile.WriteLine($"- Local timestamp: `{DateTime.Now:o}`");
            foreach (var schema in Settings.Schemas.Distinct())
            {
                outputFile.WriteLine();
                outputFile.WriteLine($"## Schema `{schema}`");
                Console.WriteLine($"Writing schema {schema} ...");

                await foreach (var result in connection.GetTables(schema, Settings.SkipTablesPattern).ValuesAsync)
                {
                    if (result.column == null)
                    {
                        Console.WriteLine($"Writing table {result.table} ...");
                        outputFile.WriteLine();
                        outputFile.WriteLine($"### Table `{schema}.{result.table}`");
                        outputFile.WriteLine();
                        if (result.comment != null)
                        {
                            outputFile.WriteLine(result.comment);
                            outputFile.WriteLine();
                        }

                        outputFile.WriteLine("| Column |  Constraint | Type | Nullable | Default | Comment |");
                        outputFile.WriteLine("| ------ | ----------- | -----| -------- | ------- | ------- |");
                    }
                    else
                    {
                        outputFile.WriteLine($"| `{result.column}` | {result.constraintMarkup} | `{result.columnType}` | {result.nullable} | {result.defaultMarkup} | {result.comment} |");
                    }
                }

                if (!Settings.IncludeRoutines)
                {
                    continue;
                }

                await foreach (var result in connection.GetRoutines(schema).ValuesAsync)
                {
                    Console.WriteLine($"Writing routine {result.name} ...");
                    outputFile.WriteLine();
                    outputFile.WriteLine($"### {result.type.First().ToString().ToUpper()}{result.type.Substring(1)} `{schema}.{result.name}`");
                    if (result.comment != null)
                    {
                        outputFile.WriteLine();
                        outputFile.WriteLine(result.comment);
                    }
                }
            }

            await connection.CloseAsync();
            Console.WriteLine($"Done!");
        }
    }
}
