using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.OpenXmlFormats;

namespace GothicToolsLib.Patterns
{
    public class DubbingPatternsProvider : PatternsProvider
    {
        private const int cnt = 7;

        public virtual string OutputOther => @"AI_Output\s*\(\s*(other|hero)\s*,\s*self\s*,\s*""(.+)""\s*\)\s*;\s*//(.*)";
        public virtual string OutputSelf => @"AI_Output\s*\(\s*self\s*,\s*(other|hero)\s*,\s*""(.+)""\s*\)\s*;\s*//(.*)";
        public virtual string OutputAtypical => @"AI_Output\s*\(.*,.*,\s*""(.+)""\s*\)\s*;\s*//(.*)"; // eg. monologs
        public virtual string TrialogStart => @"TRIA_Start\(\);";
        public virtual string TrialogFinish => @"TRIA_Finish\(\);";
        public virtual string TrialogNext => @"TRIA_Next\(\s*(.*)\s*\);";
        public virtual string DiaFileName => @"DIA_(.+)_([0-9]+)_(.+).d";


        private string[] _patterns => new string[cnt]
        {
            OutputOther,
            OutputSelf,
            OutputAtypical,
            TrialogStart,
            TrialogFinish,
            TrialogNext,
            DiaFileName
        };

        private string[] _patternNames => new string[cnt]
        {
            "OutputOther",
            "OutputSelf",
            "OutputAtypical",
            "TrialogStart",
            "TrialogFinish",
            "TrialogNext",
            "DiaFileName"
        };

        private int[] _groupsWithText => new int[cnt]
        {
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };


        protected override int Cnt => cnt;
        protected override string[] Patterns => _patterns;
        protected override string[] PatternNames => _patternNames;
        protected override int[] GroupsWithText => _groupsWithText;
    }
}
