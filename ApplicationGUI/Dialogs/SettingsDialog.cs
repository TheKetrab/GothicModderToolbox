using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationGUI.Views;

namespace ApplicationGUI.Dialogs
{
    public partial class SettingsDialog : Form
    {
        private SettingsDubbingCheckerView settingsDCView = new();
        private SettingsAutoTranslatorView settingsATView = new();
        private SettingsCustomPatternsView settingsCPView = new();

        public SettingsDialog()
        {
            InitializeComponent();

            settingsDCView.Parent = this.settingsDCtabPage;
            settingsATView.Parent = this.settingsATtabPage;
            settingsCPView.Parent = this.settingsCPtabPage;

            LoadOptions();

            this.settingsDCtabPage.SizeChanged += (s, a) => AlignSize(settingsDCView, settingsDCtabPage);
            this.settingsATtabPage.SizeChanged += (s, a) => AlignSize(settingsATView, settingsATtabPage);
            this.settingsCPtabPage.SizeChanged += (s, a) => AlignSize(settingsCPView, settingsCPtabPage);

            AlignSize(settingsDCView, settingsDCtabPage);
            AlignSize(settingsATView, settingsATtabPage);
            AlignSize(settingsCPView, settingsCPtabPage);
        }



        public void LoadOptions()
        {
            settingsDCView.LoadOptions();
            settingsATView.LoadOptions();
            settingsCPView.LoadOptions();
        }

        public void SaveOptions()
        {
            settingsDCView.SaveOptions();
            settingsATView.SaveOptions();
            settingsCPView.SaveOptions();

            SettingsManager.Instance.WriteConfig();
        }

        private void settingsCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void settingsResetBtn_Click(object sender, EventArgs e)
        {
            LoadOptions();
        }

        private void settingsApplyBtn_Click(object sender, EventArgs e)
        {
            SaveOptions();
            Close();
        }


        private void AlignSize(Control child, Panel parent)
        {
            child.Width = parent.Width;
            child.Height = parent.Height;
            child.Invalidate();
        }
}
}
