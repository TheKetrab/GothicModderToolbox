using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothicChecker
{
    static class GothicPatterns
    {
        public static string OutputOther = @"AI_Output\s*\(\s*(other|hero)\s*,\s*self\s*,\s*""(.+)""\s*\)\s*;\s*//(.*)";
        public static string OutputSelf = @"AI_Output\s*\(\s*self\s*,\s*(other|hero)\s*,\s*""(.+)""\s*\)\s*;\s*//(.*)";
        public static string TrialogStart = @"TRIA_Start\(\);";
        public static string TrialogFinish = @"TRIA_Finish\(\);";
        public static string TrialogNext = @"TRIA_Next\(\s*(.*)\s*\);";
        public static string DiaFileName = @"DIA_(.+)_([0-9]+)_(.+).d";

        public static string InstanceItem = @"(?i)instance\s+(.*)\s*\(c_item\)";
        public static string ZenVobName = @"vobName=string:(.*)";
        public static string ZenItemInstance = @"itemInstance=string:(.*)";
        public static string ZenContains = @"contains=string:(.*)";
    }
}
