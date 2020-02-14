using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Norm.Extensions;
using Npgsql;

namespace PgComment
{
    internal class Update
    {
        public static async Task UpdateFromAllMarkups(IConfiguration config, bool dump)
        {
            foreach (var connString in config.GetSection("ConnectionStrings").GetChildren())
            {
                await UpdateFromMarkupFile(connString.Value, dump);
            }
        }

        private static async Task UpdateFromMarkupFile(string connectionString, bool dump)
        {
            var settings = Settings.Value;
            await using var connection = new NpgsqlConnection(connectionString);
            await connection.OpenAsync();
            var file = Settings.FileName(connection);
            Program.Dump("Reading file", file);
            Console.WriteLine();
            if (!File.Exists(file))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"File {file} does not exists, skipping ...");
                Console.ResetColor();
                return;
            }
            var content = await File.ReadAllTextAsync(file);

            var comments = new Dictionary<string, string>();

            foreach (var schema in settings.Schemas.Distinct())
            {
                var dict = await connection
                    .GetTables(schema, settings.SkipPattern)
                    .ValuesAsync
                    .Where(t => t.comment != null)
                    .ToDictionaryAsync(
                        t => $"{schema}.{t.table}{(t.column == null ? "" : $".{t.column}")}",
                        t => t.comment);

                dict.ToList().ForEach(x => comments.Add(x.Key, x.Value));
            }

            
            Console.WriteLine("do $comments_update$");
            Console.WriteLine("begin");
            Console.WriteLine("");
            
            if (!dump)
            {
                await connection.ExecuteAsync("begin");
            }

            var start = 0;
            var search = $"{Settings.Open}{Settings.CommentStatement}";
            var close = Settings.Close;
            var endTag = Settings.EndTag;
            while (true)
            {
                start = content.IndexOf(search, start, StringComparison.Ordinal);
                if (start == -1)
                {
                    break;
                }
                var end = content.IndexOf(close, start, StringComparison.Ordinal);
                if (end == -1)
                {
                    break;
                }
                var commentTag = content.Substring(start, end - start + close.Length);
                start = end + close.Length;
                end = content.IndexOf(endTag, start, StringComparison.Ordinal);
                if (end == -1)
                {
                    break;
                }
                var comment = content.Substring(start, end - start).Trim();
                start = end;

                var statement = commentTag
                    .Replace(Settings.Open, "")
                    .Replace(Settings.Close, "");
                var part = statement
                    .Replace(Settings.CommentStatement, "")
                    .Replace(Settings.CommentIs, "");
                var sep = part.IndexOf(" ", StringComparison.Ordinal) + 1;
                var entry = part.Substring(sep, part.Length - sep);

                try
                {
                    if (comments.TryGetValue(entry, out var old))
                    {
                        if (!string.Equals(comment, old.Trim()))
                        {
                            Execute(connection, statement, comment, dump);
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(comment))
                        {
                            Execute(connection, statement, comment, dump);
                        }
                    }
                }
                catch (Exception)
                {
                    connection.Execute("rollback");
                    throw;
                }
            }


            Console.WriteLine();
            Console.WriteLine("end");
            Console.WriteLine("$comments_update$;");
            
            if (!dump)
            {
                await connection.ExecuteAsync("end");
                Console.WriteLine();
                Console.WriteLine("Database updated successfully!");
            }
            
        }

        private static void Execute(NpgsqlConnection connection, string statement, string comment, bool dump)
        {
            var command = statement.Replace(Settings.Param, $"$${comment}$$");
            Console.WriteLine($"    {command}");
            if (!dump)
            {
                connection.Execute(command);
            }
        }
    }
}
