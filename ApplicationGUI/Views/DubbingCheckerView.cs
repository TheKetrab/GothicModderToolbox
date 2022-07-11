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
using GothicChecker;
using GothicChecker.Models;

namespace ApplicationGUI
{
    public partial class DubbingCheckerView : UserControl
    {
        
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        private DubbingCheckerManager dubbingCheckerManager = new();

        public DubbingCheckerView()
        {
            InitializeComponent();
            DC_InfoLabel.GotFocus += (s1, e1) => { HideCaret(DC_InfoLabel.Handle); };

        }

        private void DisableParsingButtons()
        {
            DC_ParseBtn.Enabled = false;
            DC_ParseItemsBtn.Enabled = false;
        }

        private void EnableParsingButtons()
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
            try
            {
                DisableParsingButtons();
                DisableSavingButtons();

                DC_ProgressBar.Percent = 0;
                DC_InfoLabel.Text = "Parsing scripts...";

                Progress<ParserProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                await dubbingCheckerManager.InvokeDialogParser(progress);

                EnableSavingButtons();

                ProgressOnProgressChanged(this,
                    new ParserProgressModel("Parsing dialogs completed.", 100));
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                EnableParsingButtons();
            }

        }

        private void ProgressOnProgressChanged(object? sender, ParserProgressModel e)
        {
            DC_ProgressBar.Percent = e.Percent;
            DC_InfoLabel.AppendText($"{Environment.NewLine}{e.Msg}");
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
            try
            {
                DisableParsingButtons();
                DisableSavingButtons();

                DC_ProgressBar.Percent = 0;
                DC_InfoLabel.Text = "Parsing items...";

                Progress<ParserProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                await dubbingCheckerManager.InvokeItemParser(progress);

                EnableSavingButtons();

                ProgressOnProgressChanged(this,
                    new ParserProgressModel("Parsing items completed.", 100));
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error occured during parsing. Try again.");
            }
            finally
            {
                EnableParsingButtons();
            }
        }


    }
}
