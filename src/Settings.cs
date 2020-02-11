using System.IO;
using Npgsql;

namespace PgComment
{
    public class Settings
    {
        public string MarkupName { get; set; } = "DB DICTIONARY {0}.md";
        public string[] Schemas { get; set; } = null;
        public string SkipPattern { get; set; } = "pg_%";
        public bool IncludeRoutines { get; set; } = true;
        public bool IncludeViews { get; set; } = true;

        public static Settings Value { get; set; }

        public static string Open => "<!-- ";
        public static string Close => " -->";
        public static string CommentStatement => "comment on ";
        public static string Param => "@until-end-tag";
        public static string CommentIs => $" is {Param};";
        public static string StartTag(string on, string name) => $"{Open}{CommentStatement}{on} {name}{CommentIs}{Close}";
        public static string EndTag => $"{Open}end{Close}";
        
        public static string FileName(NpgsqlConnection connection) =>
            Path.Combine(Directory.GetCurrentDirectory(), string.Format(Value.MarkupName, connection.Database));

        public static string Hashtag(string name) =>
            $"<a id=\"user-content-{name}\" href=\"#{name}\">#</a>";
    }
}