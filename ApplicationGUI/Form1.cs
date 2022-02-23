using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GothicAutoTranslator;
using GothicChecker;

using IniParser;
using IniParser.Model;

namespace ApplicationGUI
{
    public partial class Form1 : Form
    {
        private string _dialogsPath;
        private string _dubbingPath;
        private string _itemsDirectory;
        private string _itemsLookupDirectory;

        private string _outputDirectory;


        private string _translateInputPath;
        private string _translateOutputPath;
        private string _apiKey;

        private DialogParser _dialogParser;
        private ItemParser _itemParser;

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public Form1()
        {
            InitializeComponent();
            InitConfig();

            TextBoxPathsFromObject();
            InitEvents();

            InfoLabel.GotFocus += (s1, e1) => { HideCaret(InfoLabel.Handle); };

        }

        private void InitEvents()
        {
            DC_OutputPath.TextChanged += (s,e) => TextBoxPathsToObject();
            DC_DialogsPath.TextChanged += (s,e) => TextBoxPathsToObject();
            DC_DubbingPath.TextChanged += (s,e) => TextBoxPathsToObject();
            DC_ItemsPath.TextChanged += (s, e) => TextBoxPathsToObject();
            DC_ItemsLookupPath.TextChanged += (s, e) => TextBoxPathsToObject();
        }

        private void InitConfig()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("config.ini");

            _dialogsPath = data["Paths"]["dialogsPath"];
            _dubbingPath = data["Paths"]["dubbingPath"];

            _itemsDirectory = data["Paths"]["itemsDirectory"];
            _itemsLookupDirectory = data["Paths"]["itemsLookupDirectory"];
            
            _outputDirectory = data["Paths"]["outputDirectory"];

            _translateInputPath = data["Paths"]["translateInputPath"];
            _translateOutputPath = data["Paths"]["translateOutputPath"];
            _apiKey = data["GCP"]["ApiKey"];

        }

        private void DM_RunBtn_Click(object sender, EventArgs e)
        {

        }

        private void DC_ParseBtn_Click(object sender, EventArgs e)
        {
            _dialogParser = new DialogParser(_dialogsPath, _dubbingPath);
            _dialogParser.ParsingScriptEvt += DialogParserOnParsingScriptEvt;
            _dialogParser.Parse();

            DC_SaveBtn.Enabled = true;
            DC_ExcelBtn.Enabled = true;

            string text = _dialogParser.AllDialogs.Sum(x => x.Text.Length).ToString();
            MessageBox.Show($"Total characters: {text}");

        }

        private void DialogParserOnParsingScriptEvt(object? sender, string e)
        {
            InfoLabel.AppendText($"\r\n{e}");
        }

        private void DC_SaveBtn_Click(object sender, EventArgs e)
        {

            StatsPrinter printer = new StatsPrinter(_outputDirectory);

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
                FileName = _outputDirectory,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void DC_ExcelBtn_Click(object sender, EventArgs e)
        {
            if (_dialogParser != null)
            {
                ExcelMaker.WriteDialogsExcel(_outputDirectory, _dialogParser);
            }

            if (_itemParser != null)
            {
                ExcelMaker.WriteItemsExcel(_outputDirectory, _itemParser);
            }

            Process.Start(new ProcessStartInfo()
            {
                FileName = _outputDirectory,
                UseShellExecute = true,
                Verb = "open"
            });

        }

        private void DC_ParseItemsBtn_Click(object sender, EventArgs e)
        {
            _itemParser = new ItemParser(_itemsDirectory, _itemsLookupDirectory);
            _itemParser.ParsingScriptEvt += DialogParserOnParsingScriptEvt;
            _itemParser.Parse();

            DC_SaveBtn.Enabled = true;
            DC_ExcelBtn.Enabled = true;

            MessageBox.Show("Finished");
        }

        private void TextBoxPathsFromObject()
        {
            DC_OutputPath.Text = _outputDirectory;
            DC_ItemsPath.Text = _itemsDirectory;
            DC_ItemsLookupPath.Text = _itemsLookupDirectory;
            DC_DialogsPath.Text = _dialogsPath;
            DC_DubbingPath.Text = _dubbingPath;
        }
        private void TextBoxPathsToObject()
        {
            _outputDirectory = DC_OutputPath.Text;
            _itemsDirectory = DC_ItemsPath.Text;
            _itemsLookupDirectory = DC_ItemsLookupPath.Text;
            _dialogsPath = DC_DialogsPath.Text;
            _dubbingPath = DC_DubbingPath.Text;
        }


        private void FillPathTextBox(TextBox textBox)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void DC_OutputPathBtn_Click(object sender, EventArgs e)
        {
            FillPathTextBox(DC_OutputPath);
        }

        private void DC_DialogsPathBtn_Click(object sender, EventArgs e)
        {
            FillPathTextBox(DC_DialogsPath);
        }

        private void DC_DubbingPathBtn_Click(object sender, EventArgs e)
        {
            FillPathTextBox(DC_DubbingPath);
        }

        private void DC_ItemsPathBtn_Click(object sender, EventArgs e)
        {
            FillPathTextBox(DC_ItemsPath);
        }

        private void DC_ItemsLookupPathBtn_Click(object sender, EventArgs e)
        {
            FillPathTextBox(DC_ItemsLookupPath);
        }

        private void AT_TranslateBtn_Click(object sender, EventArgs e)
        {
            Translator t = new Translator(_translateInputPath,_translateOutputPath);
            t.Translate(_apiKey);
        }

        private void AT_AnalyzeBtn_Click(object sender, EventArgs e)
        {
            Translator t = new Translator(_translateInputPath, _translateOutputPath);
            t.Analyze();
        }
    }
}
