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



        public DubbingCheckerView()
        {
            InitializeComponent();
            DC_InfoLabel.GotFocus += (s1, e1) => { HideCaret(DC_InfoLabel.Handle); };

        }

        private DialogParser _dialogParser;
        private ItemParser _itemParser;

        private void DisableButtons()
        {
            DC_ParseBtn.Enabled = false;
            DC_ParseItemsBtn.Enabled = false;
        }

        private void EnableButtons()
        {
            DC_ParseBtn.Enabled = true;
            DC_ParseItemsBtn.Enabled = true;

        }

        private async void DC_ParseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DisableButtons();
                DC_ProgressBar.Percent = 0;
                DC_InfoLabel.Text = "Parsing scripts...";

                Progress<ParserProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                _dialogParser = new DialogParser(
                    SettingsManager.Instance.DC_DialogsPath,
                    SettingsManager.Instance.DC_DubbingPath);
                await Task.Run(() => _dialogParser.Parse(progress));

                DC_SaveBtn.Enabled = true;
                DC_ExcelBtn.Enabled = true;

                ProgressOnProgressChanged(this,
                    new ParserProgressModel("Parsing dialogs completed.", 100));
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error occured during parsing. Try again.");
            }
            finally
            {
                EnableButtons();
            }

        }

        private void ProgressOnProgressChanged(object? sender, ParserProgressModel e)
        {
            DC_ProgressBar.Percent = e.Percent;
            DC_InfoLabel.AppendText($"{Environment.NewLine}{e.Msg}");
        }

        private void DC_SaveBtn_Click(object sender, EventArgs e)
        {

            StatsPrinter printer = new StatsPrinter(
                SettingsManager.Instance.DC_OutputDirectory);

            if (_dialogParser != null)
            {
                printer.PrintAlphabetical(_dialogParser.AllDialogs);
                printer.PrintInfo(_dialogParser.Npcs,
                    DC_HideCompleted.Checked, DC_PrintMissing.Checked);

                printer.PrintMissingWavs(_dialogParser.GetMissingWavs());
                printer.PrintUnnecessaryWavs(_dialogParser.GetUnnecessaryWavs());

                printer.PrintMissingHero(_dialogParser.Npcs);
                printer.PrintAllHero(_dialogParser.Npcs);

                printer.PrintMissingNpcs(_dialogParser.Npcs);
                printer.PrintAllNpcs(_dialogParser.Npcs);
            }

            if (_itemParser != null)
            {
                printer.PrintAllItems(_itemParser.AllItems);
                printer.PrintUnusedItems(_itemParser.AllItems);
            }

            Process.Start(new ProcessStartInfo()
            {
                FileName = SettingsManager.Instance.DC_OutputDirectory,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void DC_ExcelBtn_Click(object sender, EventArgs e)
        {
            if (_dialogParser != null)
            {
                ExcelMaker.WriteDialogsExcel(SettingsManager.Instance.DC_OutputDirectory, _dialogParser);
            }

            if (_itemParser != null)
            {
                ExcelMaker.WriteItemsExcel(SettingsManager.Instance.DC_OutputDirectory, _itemParser);
            }

            Process.Start(new ProcessStartInfo()
            {
                FileName = SettingsManager.Instance.DC_OutputDirectory,
                UseShellExecute = true,
                Verb = "open"
            });

        }

        private async void DC_ParseItemsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DisableButtons();
                DC_ProgressBar.Percent = 0;
                DC_InfoLabel.Text = "Parsing items...";

                Progress<ParserProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                _itemParser = new ItemParser(
                    SettingsManager.Instance.DC_ItemsDirectory,
                    SettingsManager.Instance.DC_ItemsLookupDirectory);
                await Task.Run(() => _itemParser.Parse(progress));

                DC_SaveBtn.Enabled = true;
                DC_ExcelBtn.Enabled = true;

                ProgressOnProgressChanged(this,
                    new ParserProgressModel("Parsing items completed.", 100));
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error occured during parsing. Try again.");
            }
            finally
            {
                EnableButtons();
            }
        }


    }
}
