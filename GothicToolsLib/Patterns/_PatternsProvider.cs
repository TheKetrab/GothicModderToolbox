using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GothicToolsLib.Patterns
{
    public abstract class PatternsProvider
    {
        public struct MatchData
        {
            public int GroupWithText;
            public string PatternName;
            public string Pattern;
            public Match Match;
        }

        public MatchData? MatchAny(string str)
        {
            for (int i = 0; i < Cnt; i++)
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

        private const RegexOptions RegexOpt = RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace;

        protected abstract int Cnt { get; }
        protected abstract string[] Patterns { get; }
        protected abstract string[] PatternNames { get; }

        protected abstract int[] GroupsWithText { get; }
    }

}
