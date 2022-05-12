#nullable enable
using System.Formats.Asn1;
using System.Text.RegularExpressions;

namespace GothicAutoTranslator
{
    public static class GothicPatterns
    {
        public struct MatchData
        {
            public int GroupWithText;
            public string PatternName;
            public string Pattern;
            public Match Match;
        }

        public const string AiOutput = @"^.*AI_Output\s*\(.*,.*,.*\);\s*//(.*)$";
        public const string DocPrintLines = "^.*Doc_PrintLines\\s*\\(.*,.*,\\s*\"(.*)\"\\s*\\)\\s*;.*$";
        public const string BLogEntry = "^.*B_LogEntry\\s*\\(.*,\\s*\"(.*)\"\\s*\\)\\s*;.*$";
        public const string Name = "^\\s*name\\s*=\\s*\"(.*)\"\\s*;.*$";
        public const string Description = "^\\s*description\\s*=\\s*\"(.*)\"\\s*;.*$";
        public const string Text = "^\\s*TEXT\\s*\\[\\s*[0-9]*\\s*\\]\\s*=\\s*\"(.*)\"\\s*;.*$";

        public const string AddChoice = "^.*Info_AddChoice\\s*\\(.*,\\s*\"(.*)\"\\s*,.*\\)\\s*;.*$";
        // TODO: AddChoice Pattern : Info_AddChoice	  (DIA_NASZ_002_Daryl_BrysonAfterGoAway, "To przez Brysona!", DIA_NASZ_002_Daryl_BrysonAfterGoAway_Bryson);

        private const int Cnt = 7;
        private const RegexOptions RegexOpt = RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace;
        private static readonly string[] Patterns = new string[Cnt]
        {
            AiOutput, DocPrintLines, BLogEntry, Name, Description, Text, AddChoice
        };

        private static readonly string[] PatternNames = new string[Cnt]
        {
            "AiOutput", "DocPrintLines", "BLogEntry", "Name", "Description", "Text", "AddChoice"
        };
        private static readonly int[] GroupsWithText = new int[Cnt]
        {
            1,1,1,1,1,1,1
        };

        public static MatchData? MatchAny(string str)
        {
            for (int i=0; i<Cnt; i++)
                if (Regex.IsMatch(str, Patterns[i], RegexOpt))
                    return new MatchData()
                    {
                        Pattern = Patterns[i],
                        PatternName = PatternNames[i],
                        GroupWithText = GroupsWithText[i],
                        Match = Regex.Match(str, Patterns[i], RegexOpt)
                    };

            return null;
        }
    }
}