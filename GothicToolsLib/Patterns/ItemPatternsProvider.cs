using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothicToolsLib.Patterns
{
    public class ItemPatternsProvider : PatternsProvider
    {
        private const int cnt = 4;

        public virtual string InstanceItem => @"(?i)instance\s+(.*)\s*\(c_item\)";
        public virtual string ZenVobName => @"vobName=string:(.*)";
        public virtual string ZenItemInstance => @"itemInstance=string:(.*)";
        public virtual string ZenContains => @"contains=string:(.*)";

        private string[] _patterns => new string[cnt]
        {
            InstanceItem,
            ZenVobName,
            ZenItemInstance,
            ZenContains
        };

        private string[] _patternNames => new string[cnt]
        {
            "InstanceItem",
            "ZenVobName",
            "ZenItemInstance",
            "ZenContains"
        };

        private int[] _groupsWithText => new int[cnt]
        {
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
