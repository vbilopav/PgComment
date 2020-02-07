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
    }

    public class Program
    {
        public static Settings Settings { get; set; }

        public static async Task Main(string[] args)
        {
            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile(Path.Join(Directory.GetCurrentDirectory(), "settings.json"), optional: true, reloadOnChange: false)
                .AddJsonFile(Path.Join(Directory.GetCurrentDirectory(), "settings.private.json"), optional: true, reloadOnChange: false)
                .AddCommandLine(args)
                .AddEnvironmentVariables("PGCOMMENT_");

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
                await foreach (var (tableId, table, column, columnType, nullable, defaultValue, comment) in 
                    connection.ReadAsync<string, string, string, string, string, string, string>(Sql.Tables,
                    ("schema", schema), ("skipPattern", Settings.SkipTablesPattern)))
                {
                    if (column == null)
                    {

                        outputFile.WriteLine();
                        outputFile.WriteLine($"### Table `{tableId}`");
                        outputFile.WriteLine();
                        if (comment != null)
                        {
                            outputFile.WriteLine(comment);
                            outputFile.WriteLine();
                        }

                        outputFile.WriteLine("| Column | Type | Nullable | Default | Comment |");
                        outputFile.WriteLine("| ------ | ---- | -------- | ------- | ------- |");
                    }
                    else
                    {
                        outputFile.WriteLine($"| {column} | {columnType} | {nullable} | {defaultValue} | {comment} |");
                    }
                }
            }

            await connection.CloseAsync();
            Console.WriteLine($"Done!");
        }
    }
}
