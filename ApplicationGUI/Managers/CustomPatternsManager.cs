using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GothicToolsLib.Patterns;
using IniParser.Model;

namespace ApplicationGUI.Managers
{
    public class CustomPatternsManager
    {
        private string[] patternIds = new string[]
        {
            "CP_Text_AiOutput",
            "CP_Text_DocPrintLines",
            "CP_Text_BLogEntry",
            "CP_Text_Name",
            "CP_Text_Description",
            "CP_Text_Text",
            "CP_Text_AddChoice",

            "CP_Dubbing_OutputOther",
            "CP_Dubbing_OutputSelf",
            "CP_Dubbing_OutputAtypical",
            "CP_Dubbing_TrialogStart",
            "CP_Dubbing_TrialogFinish",
            "CP_Dubbing_TrialogNext",
            "CP_Dubbing_DiaFileName",

            "CP_Item_InstanceItem",
            "CP_Item_ZenVobName",
            "CP_Item_ZenItemInstance",
            "CP_Item_ZenContains",
        };

        public CustomPatternsManager(IniData data)
        {
            ReadCustomPatternsFromIni(data);
        }

        public void ReadCustomPatternsFromIni(IniData data)
        {
            foreach (string id in patternIds)
            {
                CustomPattern cp = new CustomPattern(id);
                cp.Value = data["CustomPatterns"][id];

                string group = data["CustomPatterns"][$"{id}_Gr"];
                cp.Group = string.IsNullOrEmpty(group) ? 0 : Convert.ToInt32(group);
                Patterns.Add(id, cp);
            }
        }

        public void WriteCutomPatternsToIni(IniData data)
        {
            foreach (var x in Patterns)
            {
                CustomPattern cp = x.Value;
                data["CustomPatterns"][cp.Id] = cp.Value;
                data["CustomPatterns"][$"{cp.Id}_Gr"] = cp.Group.ToString();
            }
        }

        public Dictionary<string, CustomPattern> Patterns = new();

        public CustomPattern GetPattern(string id)
        {
            return Patterns[id];
        }

        public void SetPattern(string id, CustomPattern cp)
        {
            Patterns[id] = cp;
        }

    }
}
