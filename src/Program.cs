using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace PgComment
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var pull = ArgsInclude(args, "-p", "-pull");
            var commit = ArgsInclude(args, "-c", "--commit");
            var dump = ArgsInclude(args, "-d", "--dump");

            if (ArgsInclude(args, "-h", "--help"))
            {
                PrintHelp();
                return;
            }
            if (!pull && !commit && !dump)
            {
                Console.WriteLine();
                Console.WriteLine("Type pgcomment --help for options");
                return;
            }
            
            string settingsFile = null;
            foreach (var arg in args)
            {
                if (arg.StartsWith("--settings="))
                {
                    settingsFile = arg.Split("=").Last();
                    break;
                }
            }

            IConfigurationBuilder configBuilder;
            if (settingsFile == null)
            {
                configBuilder = new ConfigurationBuilder()
                    .AddJsonFile(Path.Join(Directory.GetCurrentDirectory(), "settings.json"), optional: true,
                        reloadOnChange: false)
                    .AddJsonFile(Path.Join(Directory.GetCurrentDirectory(), "appsettings.json"), optional: true,
                        reloadOnChange: false)
                    .AddJsonFile(Path.Join(Directory.GetCurrentDirectory(), "settings.private.json"), optional: true,
                        reloadOnChange: false)
                    .AddJsonFile(Path.Join(Directory.GetCurrentDirectory(), "appsettings.Development.json"), optional: true,
                        reloadOnChange: false)
                    .AddCommandLine(args);
            }
            else
            {
                configBuilder = new ConfigurationBuilder()
                    .AddJsonFile(Path.Join(Directory.GetCurrentDirectory(), settingsFile), optional: true, reloadOnChange: false)
                    .AddCommandLine(args);
            }


            var config = configBuilder.Build();
            Settings.Value = new Settings();
            config.GetSection("PgComment").Bind(Settings.Value);
            if (Settings.Value.Schemas == null)
            {
                Settings.Value.Schemas = new[] {"public"};
            }

            if (commit || dump)
            {
                await Update.UpdateFromAllMarkups(config, dump);
            }
            else
            {
                await Markup.CreateAllMarkups(config);
            }
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

        private static void PrintHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Usage: pgcomment [options] [settings]");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("options:");
            Console.ResetColor();
            Console.WriteLine();
            PrintItem("-h --help", "This help");
            PrintItem("--settings=file", "Path to json settings file");
            PrintItem("-p --pull", "Builds markup files based on current settings from comments in database");
            PrintItem("-c --commit", "Commits current changes from markup files to database");
            PrintItem("-d --dump", "Dumps sql for manual comment update. Doesn't update database");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("settings:");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Settings will override setting.json file settings.");
            Console.WriteLine();
            PrintItem("pgcomment:markupname=[name]", "Markup file name. {0} placeholder for database name. Default value is \"DB DICTIONARY {0}.md\"", 40);
            PrintItem("pgcomment:schemas[index]=[schema]", "Schema name to include in markup. Multiple schemas separated by zero based index. Default is \"public\"", 40);
            PrintItem("pgcomment:skippattern=[pattern]", "Skip object that are similar with this pattern. Default is \"pg_%\". Only applied when building markup files.", 40);
            PrintItem("pgcomment:includeviews=[true|false]", "Should views be included? Only applied when building markup files.", 40);
            PrintItem("pgcomment:includeroutines=[true|false]", "Should routines (functions and procedure) be included? Only applied when building markup files.", 40);
            PrintItem("connectionstrings:[id]=[connection]", "ADO.NET (Npgsql) connection strings. Format: Server=;Database=;Port=;User Id=;Password=; Use id for multiple connections.", 40);
            Console.WriteLine();
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
