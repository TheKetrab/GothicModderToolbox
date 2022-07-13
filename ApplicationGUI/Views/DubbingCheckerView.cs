using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationGUI.Controls;
using GothicToolsLib.Models;

namespace ApplicationGUI
{
    public partial class DubbingCheckerView : ProcessingAbstractView
    {
        private DubbingCheckerManager dubbingCheckerManager = new();

        public DubbingCheckerView()
        {
            InitializeComponent();
        }

        protected override TextBox InfoLabel => DC_InfoLabel;
        protected override AdvancedProgressBar ProgressBar => DC_ProgressBar;

        protected override void DisableButtons()
        {
            DC_ParseBtn.Enabled = false;
            DC_ParseItemsBtn.Enabled = false;
        }

        protected override void EnableButtons()
        {
            DC_ParseBtn.Enabled = true;
            DC_ParseItemsBtn.Enabled = true;
        }

        private void EnableSavingButtons()
        {
            DC_SaveBtn.Enabled = true;
            DC_ExcelBtn.Enabled = true;
        }
        private void DisableSavingButtons()
        {
            DC_SaveBtn.Enabled = false;
            DC_ExcelBtn.Enabled = false;
        }

        private async void DC_ParseBtn_Click(object sender, EventArgs e)
        {
            await Process("Parsing scripts...", "Parsing dialogs completed.", async (progress) =>
            {
                DisableSavingButtons();
                await dubbingCheckerManager.InvokeDialogParser(progress);
                EnableSavingButtons();
            });
        }

        private void DC_SaveBtn_Click(object sender, EventArgs e)
        {
            dubbingCheckerManager.SaveData(DC_HideCompleted.Checked, DC_PrintMissing.Checked);
        }

        private void DC_ExcelBtn_Click(object sender, EventArgs e)
        {
            dubbingCheckerManager.SaveExcelData();
        }

        private async void DC_ParseItemsBtn_Click(object sender, EventArgs e)
        {
            await Process("Parsing items...", "Parsing items completed.", async (progress) =>
            {
                DisableSavingButtons();
                await dubbingCheckerManager.InvokeItemParser(progress);
                EnableSavingButtons();
            });
        }


    }
}
