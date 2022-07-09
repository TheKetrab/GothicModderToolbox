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
        private SettingsDubbingCheckerView settingsDCView = new SettingsDubbingCheckerView();

        public SettingsDialog()
        {
            InitializeComponent();

            settingsDCView.Parent = this.settingsDCtabPage;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            settingsDCView.Width = this.settingsDCtabPage.Width;
        }
    }
}
