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
        private CustomPattern _AiOutput;
        private CustomPattern _DocPrintLines;
        private CustomPattern _BLogEntry;
        private CustomPattern _Name;
        private CustomPattern _Description;
        private CustomPattern _Text;
        private CustomPattern _AddChoice;
        private int[] _groupsWithText;

        public override string AiOutput => _AiOutput.Value;
        public override string DocPrintLines => _DocPrintLines.Value;
        public override string BLogEntry => _BLogEntry.Value;
        public override string Name => _Name.Value;
        public override string Description => _Description.Value;
        public override string Text => _Text.Value;
        public override string AddChoice => _AddChoice.Value;

        protected override int[] GroupsWithText => _groupsWithText;


        public SettingsTextPatternsProvider()
        {
            _AiOutput = SettingsManager.Instance.CPManager.GetPattern("CP_Text_AiOutput");
            _DocPrintLines = SettingsManager.Instance.CPManager.GetPattern("CP_Text_DocPrintLines");
            _BLogEntry = SettingsManager.Instance.CPManager.GetPattern("CP_Text_BLogEntry");
            _Name = SettingsManager.Instance.CPManager.GetPattern("CP_Text_Name");
            _Description = SettingsManager.Instance.CPManager.GetPattern("CP_Text_Description");
            _Text = SettingsManager.Instance.CPManager.GetPattern("CP_Text_Text");
            _AddChoice = SettingsManager.Instance.CPManager.GetPattern("CP_Text_AddChoice");

            _groupsWithText = new int[]
            {
                _AiOutput.Group,
                _DocPrintLines.Group,
                _BLogEntry.Group,
                _Name.Group,
                _Description.Group,
                _Text.Group,
                _AddChoice.Group,
            };

        }
    }

    public class SettingsDubbingPatternsProvider : DubbingPatternsProvider
    {
        private CustomPattern _OutputOther ;
        private CustomPattern _OutputSelf  ;
        private CustomPattern _OutputAtypical;
        private CustomPattern _TrialogStart ;
        private CustomPattern _TrialogFinish ;
        private CustomPattern _TrialogNext ;
        private CustomPattern _DiaFileName;

        public override string OutputOther => _OutputOther.Value;
        public override string OutputSelf => _OutputSelf.Value;
        public override string OutputAtypical => _OutputAtypical.Value;
        public override string TrialogStart => _TrialogStart.Value;
        public override string TrialogFinish => _TrialogFinish.Value;
        public override string TrialogNext => _TrialogNext.Value;
        public override string DiaFileName => _DiaFileName.Value;

        private int[] _groupsWithText;
        protected override int[] GroupsWithText => _groupsWithText;

        public SettingsDubbingPatternsProvider()
        {
            _OutputOther = SettingsManager.Instance.CPManager.GetPattern("CP_Dubbing_OutputOther");
            _OutputSelf = SettingsManager.Instance.CPManager.GetPattern("CP_Dubbing_OutputSelf");
            _OutputAtypical = SettingsManager.Instance.CPManager.GetPattern("CP_Dubbing_OutputAtypical");
            _TrialogStart = SettingsManager.Instance.CPManager.GetPattern("CP_Dubbing_TrialogStart");
            _TrialogFinish = SettingsManager.Instance.CPManager.GetPattern("CP_Dubbing_TrialogFinish");
            _TrialogNext = SettingsManager.Instance.CPManager.GetPattern("CP_Dubbing_TrialogNext");
            _DiaFileName = SettingsManager.Instance.CPManager.GetPattern("CP_Dubbing_DiaFileName");

            _groupsWithText = new int[]
            {
                _OutputOther.Group,
                _OutputSelf.Group,
                _OutputAtypical.Group,
                _TrialogStart.Group,
                _TrialogFinish.Group,
                _TrialogNext.Group,
                _DiaFileName.Group
            };
        }
    }

    public class SettingsItemPatternsProvider : ItemPatternsProvider
    {
        private CustomPattern _InstanceItem;
        private CustomPattern _ZenVobName;
        private CustomPattern _ZenItemInstance;
        private CustomPattern _ZenContains;

        public virtual string InstanceItem => _InstanceItem.Value;
        public virtual string ZenVobName => _ZenVobName.Value;
        public virtual string ZenItemInstance => _ZenItemInstance.Value;
        public virtual string ZenContains => _ZenContains.Value;

        private int[] _groupsWithText;
        protected override int[] GroupsWithText => _groupsWithText;

        public SettingsItemPatternsProvider()
        {
            _InstanceItem= SettingsManager.Instance.CPManager.GetPattern("CP_Item_InstanceItem");
            _ZenVobName= SettingsManager.Instance.CPManager.GetPattern("CP_Item_ZenVobName");
            _ZenItemInstance = SettingsManager.Instance.CPManager.GetPattern("CP_Item_ZenItemInstance");
            _ZenContains = SettingsManager.Instance.CPManager.GetPattern("CP_Item_ZenContains");

            _groupsWithText = new int[]
            {
                _InstanceItem.Group,
                _ZenVobName.Group,
                _ZenItemInstance.Group,
                _ZenContains.Group,
            };
        }

    }
}
