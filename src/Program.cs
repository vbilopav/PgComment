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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("PgComment ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(typeof(Program).Assembly.GetName().Version.ToString());
            Console.ResetColor();
            Console.WriteLine();

            var currentDir = Directory.GetCurrentDirectory();
            var pull = ArgsInclude(args, "-p", "--pull");
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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Type pgcomment --help for options");
                Console.ResetColor();
                Console.WriteLine();
                return;
            }
            
            string settingsFile = null;
            foreach (var arg in args)
            {
                if (!arg.StartsWith("--settings="))
                {
                    continue;
                }
                settingsFile = arg.Split("=").Last();
                break;
            }

            var usingSettingFile = false;
            string SettingFile(string name, bool showError = false)
            {
                var fullName = Path.Join(currentDir, name);
                if (File.Exists(fullName))
                {
                    if (!usingSettingFile)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Using setting files:");
                        usingSettingFile = true;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"    - {name}");
                } 
                else if (showError)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"File {fullName} could not be found");
                }
                return fullName;
            }

            IConfigurationBuilder configBuilder;
            if (settingsFile == null)
            {
                
                configBuilder = new ConfigurationBuilder()
                    .AddJsonFile(SettingFile("settings.json"), optional: true,
                        reloadOnChange: false)
                    .AddJsonFile(SettingFile("appsettings.json"), optional: true,
                        reloadOnChange: false)
                    .AddJsonFile(SettingFile("settings.private.json"), optional: true,
                        reloadOnChange: false)
                    .AddJsonFile(SettingFile("appsettings.Development.json"), optional: true,
                        reloadOnChange: false)
                    .AddCommandLine(args);
            }
            else
            {
                configBuilder = new ConfigurationBuilder()
                    .AddJsonFile(SettingFile(settingsFile, true), optional: true, reloadOnChange: false)
                    .AddCommandLine(args);
            }
            Console.ResetColor();

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

        public static void Dump(string msg, string item)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(msg);
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(item);
            Console.ResetColor();
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
            PrintItem("pgcomment:markdownname=[name]", "File name to generate or to search. {0} placeholder for database name. Default value is \"DB DICTIONARY {0}.md\"", 40);
            PrintItem("pgcomment:schemas[index]=[schema]", "Database schemas to include in generated file.. Multiple schemas separated by zero based index. Default is \"public\"", 40);
            PrintItem("pgcomment:skippattern=[pattern]", "Skip object that are similar with this pattern when generating file. Default is \"pg_%\".", 40);
            PrintItem("pgcomment:includeviews=[true|false]", "Include views?.", 40);
            PrintItem("pgcomment:includeroutines=[true|false]", "Include routines (functions and procedures)?", 40);
            PrintItem("connectionstrings:[name]=[connection]", "Connection strings in ADO.NET (Npgsql) format: `Server=;Database=;Port=;User Id=;Password=;`. Each connection have unique name.", 40);
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
