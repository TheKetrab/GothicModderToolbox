using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GothicToolsLib.Patterns;

namespace ApplicationGUI.Managers
{
    public class SettingsTextPatternsProvider : TextPatternsProvider
    {
        public override string AiOutput => SettingsManager.Instance.CP_Text_AiOutput;
        public override string DocPrintLines => SettingsManager.Instance.CP_Text_DocPrintLines;
        public override string BLogEntry => SettingsManager.Instance.CP_Text_BLogEntry;
        public override string Name => SettingsManager.Instance.CP_Text_Name;
        public override string Description => SettingsManager.Instance.CP_Text_Description;
        public override string Text => SettingsManager.Instance.CP_Text_Text;
        public override string AddChoice => SettingsManager.Instance.CP_Text_AddChoice;
    }

    public class SettingsDubbingPatternsProvider : DubbingPatternsProvider
    {
        public override string OutputOther => SettingsManager.Instance.CP_Dubbing_OutputOther;
        public override string OutputSelf => SettingsManager.Instance.CP_Dubbing_OutputSelf;
        public override string OutputAtypical => SettingsManager.Instance.CP_Dubbing_OutputAtypical;
        public override string TrialogStart => SettingsManager.Instance.CP_Dubbing_TrialogStart;
        public override string TrialogFinish => SettingsManager.Instance.CP_Dubbing_TrialogFinish;
        public override string TrialogNext => SettingsManager.Instance.CP_Dubbing_TrialogNext;
        public override string DiaFileName => SettingsManager.Instance.CP_Dubbing_DiaFileName;

    }

    public class SettingsItemPatternsProvider : ItemPatternsProvider
    {
        public virtual string InstanceItem => SettingsManager.Instance.CP_Item_InstanceItem;
        public virtual string ZenVobName => SettingsManager.Instance.CP_Item_ZenVobName;
        public virtual string ZenItemInstance => SettingsManager.Instance.CP_Item_ZenItemInstance;
        public virtual string ZenContains => SettingsManager.Instance.CP_Item_ZenContains;

    }
}
