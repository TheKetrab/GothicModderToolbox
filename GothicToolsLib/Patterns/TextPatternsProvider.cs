using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothicToolsLib.Patterns
{
    public class TextPatternsProvider : PatternsProvider
    {
        private const int cnt = 7;

        public virtual string AiOutput => @"^.*AI_Output\s*\(.*,.*,.*\);\s*//(.*)$";
        public virtual string DocPrintLines => "^.*Doc_PrintLines\\s*\\(.*,.*,\\s*\"(.*)\"\\s*\\)\\s*;.*$";
        public virtual string BLogEntry => "^.*B_LogEntry\\s*\\(.*,\\s*\"(.*)\"\\s*\\)\\s*;.*$";
        public virtual string Name => "^\\s*name\\s*=\\s*\"(.*)\"\\s*;.*$";
        public virtual string Description => "^\\s*description\\s*=\\s*\"(.*)\"\\s*;.*$";
        public virtual string Text => "^\\s*TEXT\\s*\\[\\s*[0-9]*\\s*\\]\\s*=\\s*\"(.*)\"\\s*;.*$";
        public virtual string AddChoice => "^.*Info_AddChoice\\s*\\(.*,\\s*\"(.*)\"\\s*,.*\\)\\s*;.*$";


        private string[] _patterns => new string[cnt]
        {
            AiOutput,
            DocPrintLines,
            BLogEntry,
            Name,
            Description,
            Text,
            AddChoice
        };

        private string[] _patternNames => new string[cnt]
        {
            "AiOutput",
            "DocPrintLines",
            "BLogEntry",
            "Name",
            "Description",
            "Text",
            "AddChoice"
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
