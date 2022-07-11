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

        public SettingsDialog()
        {
            InitializeComponent();

            settingsDCView.Parent = this.settingsDCtabPage;
            settingsATView.Parent = this.settingsATtabPage;

            LoadOptions();

            this.tabControl1.SelectedIndexChanged += (s, a) =>
            {
                // TODO: ta sama szerokosc wszystkich tabow sie dostosowuje
            };
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            settingsDCView.Width = this.settingsDCtabPage.Width;
            settingsATView.Width = this.settingsATtabPage.Width;
        }


        public void LoadOptions()
        {
            settingsDCView.LoadOptions();
            settingsATView.LoadOptions();
        }

        public void SaveOptions()
        {
            settingsDCView.SaveOptions();
            settingsATView.SaveOptions();
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
        }
    }
}
