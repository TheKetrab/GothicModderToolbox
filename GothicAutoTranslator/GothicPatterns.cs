#nullable enable
using System.Text.RegularExpressions;

namespace GothicAutoTranslator
{
    public static class GothicPatterns
    {
        public struct MatchData
        {
            public int GroupWithText;
            public string Pattern;
            public Match Match;
        }

        public const string AiOutput = @"^.*AI_Output\s*\(.*,.*,.*\);\s*//(.*)$";
        public const string DocPrintLines = "^.*Doc_PrintLines\\s*\\(.*,.*,\\s*\"(.*)\"\\s*\\)\\s*;.*$";
        public const string BLogEntry = "^.*B_LogEntry\\s*\\(.*,\\s*\"(.*)\"\\s*\\)\\s*;.*$";
        public const string Name = "^\\s*name\\s*=\\s*\"(.*)\"\\s*;.*$";
        public const string Description = "^\\s*description\\s*=\\s*\"(.*)\"\\s*;.*$";
        public const string Text = "^\\s*TEXT\\s*\\[\\s*[0-9]*\\s*\\]\\s*=\\s*\"(.*)\"\\s*;.*$";

        private const int Cnt = 6;
        private const RegexOptions RegexOpt = RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace;
        private static readonly string[] Patterns = new string[Cnt]
        {
            AiOutput, DocPrintLines, BLogEntry, Name, Description, Text
        };
        private static readonly int[] GroupsWithText = new int[Cnt]
        {
            1,1,1,1,1,1
        };

        public static MatchData? MatchAny(string str)
        {
            for (int i=0; i<Cnt; i++)
                if (Regex.IsMatch(str, Patterns[i], RegexOpt))
                    return new MatchData()
                    {
                        Pattern = Patterns[i],
                        GroupWithText = GroupsWithText[i],
                        Match = Regex.Match(str, Patterns[i], RegexOpt)
                    };

            return null;
        }
    }
}