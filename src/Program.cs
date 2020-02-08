using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace PgComment
{
    public class Settings
    {
        public string MarkupName { get; set; } = "DB DICTIONARY {0}.md";
        public string[] Schemas { get; set; } = null;
        public string SkipTablesPattern { get; set; } = "pg_%";
        public bool IncludeRoutines { get; set; } = true;
    }

    public static class Program
    {
        public static Settings Settings { get; set; }

        public static async Task Main(string[] args)
        {
            if (ArgsInclude(args, "-h", "--help"))
            {
                PrintHelp();
                return;
            }

            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile(Path.Join(Directory.GetCurrentDirectory(), "settings.json"), optional: true,
                    reloadOnChange: false)
                .AddJsonFile(Path.Join(Directory.GetCurrentDirectory(), "settings.private.json"), optional: true,
                    reloadOnChange: false)
                .AddCommandLine(args);

            var config = configBuilder.Build();
            Settings = new Settings();
            config.GetSection("PgComment").Bind(Settings);
            if (Settings.Schemas == null)
            {
                Settings.Schemas = new[] {"public"};
            }

            await CreateAllMarkups(config);
        }

        private static bool ArgsInclude(string[] args, params string[] values)
        {
            var lower = values.Select(v => v.ToLower()).ToList();
            var upper = values.Select(v => v.ToUpper()).ToList();
            foreach (var arg in args)
            {
                if (lower.Contains(arg))
                {
                    return true;
                }

                if (upper.Contains(arg))
                {
                    return true;
                }
            }

            return false;
        }

        private static async Task CreateAllMarkups(IConfiguration config)
        {
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
            outputFile.WriteLine(
                $"- Server: PostgreSQL `{connection.Host}:{connection.Port}`, version `{connection.ServerVersion}`");
            outputFile.WriteLine($"- Local timestamp: `{DateTime.Now:o}`");
            
            foreach (var schema in Settings.Schemas.Distinct())
            {
                var schemaHeader = false;

                await foreach (var result in connection.GetTables(schema, Settings.SkipTablesPattern).ValuesAsync)
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
                        outputFile.WriteLine(
                            $"| `{result.column}` | {result.constraintMarkup} | `{result.columnType}` | {result.nullable} | {result.defaultMarkup} | {result.comment} |");
                    }
                }

                if (!Settings.IncludeRoutines)
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
                    if (result.comment == null)
                    {
                        continue;
                    }

                    outputFile.WriteLine();
                    outputFile.WriteLine(result.comment);
                }
            }

            await connection.CloseAsync();
            Console.WriteLine("Done!");
        }

        private static void PrintHelp()
        {
            Console.WriteLine("Usage: pgcomment [options] [settings]");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("options:");
            Console.ResetColor();
            PrintItem("[no option]", "Builds markup files based on current settings");
            PrintItem("-c -commit", "Commits current changes from markup files to database");
            PrintItem("-d -dump", "Dumps sql for manual comment update");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("settings:");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Settings will override setting.json file settings. Only applied when building markup files.");
            Console.WriteLine();
            PrintItem("pgcomment:markupname=[name]", "Markup file name. {0} placeholder for database name. Default value is \"DB DICTIONARY {0}.md\"", 40);
            PrintItem("pgcomment:schemas[index]=[schema]", "Schema name to include in markup. Multiple schemas separated by zero based index. Default is \"public\"", 40);
            PrintItem("pgcomment:skiptablespattern=[pattern]", "Skip tables that are similar with this pattern. Default is \"pg_%\"", 40);
            PrintItem("pgcomment:includeroutines=[true|false]", "Should routines (functions and procedure) ne included?", 40);
            PrintItem("connectionstrings:[id]=[connection]", "ADO.NET (Npgsql) connection strings. Use id for multiple connections.", 40);
        }

        private static void PrintItem(string options, string description, int left = 20)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($" {options}");
            if (left == -1)
            {
                Console.WriteLine();
                Console.CursorLeft = 20;
            }
            else
            {
                Console.CursorLeft = left;
            }
            Console.ResetColor();
            Console.WriteLine(description);
        }
    }
}
