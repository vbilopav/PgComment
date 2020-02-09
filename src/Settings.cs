using System.IO;
using Npgsql;

namespace PgComment
{
    public class Settings
    {
        public string MarkupName { get; set; } = "DB DICTIONARY {0}.md";
        public string[] Schemas { get; set; } = null;
        public string SkipTablesPattern { get; set; } = "pg_%";
        public bool IncludeRoutines { get; set; } = true;

        public static Settings Value { get; set; }
        public static string StartTag(string on, string name) => $"<!-- comment on {on} {name} is @until-end-tag; -->";
        public static string EndTag => "<!-- end -->";
        public static string FileName(NpgsqlConnection connection) =>
            Path.Combine(Directory.GetCurrentDirectory(), string.Format(Value.MarkupName, connection.Database));
    }
}