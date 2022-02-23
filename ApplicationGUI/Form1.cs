﻿using System;
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
using System.Windows.Forms.VisualStyles;
using GothicAutoTranslator;
using GothicChecker;
using GothicChecker.Models;
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

        private int _encoding;

        private DialogParser _dialogParser;
        private ItemParser _itemParser;
        private Translator _translator;

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public Form1()
        {
            InitializeComponent();
            InitConfig();

            TextBoxPathsFromObject();
            InitEvents();

            DC_InfoLabel.GotFocus += (s1, e1) => { HideCaret(DC_InfoLabel.Handle); };
            AT_InfoLabel.GotFocus += (s1, e1) => { HideCaret(AT_InfoLabel.Handle); };

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

            _encoding = int.Parse(data["Encoding"]["InputScripts"]); // TODO: default if not set + message
        }

        private void DM_RunBtn_Click(object sender, EventArgs e)
        {

        }

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
                DC_ProgressBar.Value = 0;
                DC_InfoLabel.Text = "Parsing scripts...";

                Progress<ParserProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                _dialogParser = new DialogParser(_dialogsPath, _dubbingPath);
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
            DC_ProgressBar.Value = e.Percent;
            DC_ProgressBarLbl.Text = $"{e.Percent}%";
            DC_InfoLabel.AppendText($"{Environment.NewLine}{e.Msg}");
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

        private async void DC_ParseItemsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DisableButtons();
                DC_ProgressBar.Value = 0;
                DC_InfoLabel.Text = "Parsing items...";

                Progress<ParserProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                _itemParser = new ItemParser(_itemsDirectory, _itemsLookupDirectory);
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

        private async void AT_TranslateBtn_Click(object sender, EventArgs e)
        {
            if (_translator == null)
                return;

            MessageBox.Show($"Total characters {_translator.TotalCharacters}");
            if (_translator.TotalCharacters > 300000)
            {
                MessageBox.Show("Too many characters! Forbidden translation.");
                return;
            }

            if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo) != DialogResult.OK)
                return;

            await _translator.TranslateAsync(_apiKey);
        }

        private async void AT_AnalyzeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DisableATButtons();
                AT_ProgressBar.Value = 0;
                AT_InfoLabel.Text = "Analyzing scripts...";

                Progress<TranslationProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                _translator = new Translator(_translateInputPath, _translateOutputPath, 1250); // TODO encoding
                _translator.InfoEvt += (o, s) => { AT_SummaryLbl.Text = s; };

                await _translator.AnalyzeAsync(progress);

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                EnableATButtons();
            }

        }

        private void DisableATButtons()
        {
            AT_AnalyzeBtn.Enabled = false;
            AT_TranslateBtn.Enabled = false;
            AT_ReplaceBtn.Enabled = false;
        }

        private void EnableATButtons()
        {
            AT_AnalyzeBtn.Enabled = true;
            AT_TranslateBtn.Enabled = true;
            AT_ReplaceBtn.Enabled = true;
        }

        private void ProgressOnProgressChanged(object? sender, TranslationProgressModel e)
        {
            AT_ProgressBar.Value = e.Percent;
            AT_ProgressBarLbl.Text = $"{e.Percent}%";
            AT_InfoLabel.AppendText($"{Environment.NewLine}{e.Msg}");
        }

        private void AT_ReplaceBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
