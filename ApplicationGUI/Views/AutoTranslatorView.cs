using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GothicAutoTranslator;

namespace ApplicationGUI
{
    public partial class AutoTranslatorView : UserControl
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private Translator _translator;


        public AutoTranslatorView()
        {
            InitializeComponent();

            AT_InfoLabel.GotFocus += (s1, e1) => { HideCaret(AT_InfoLabel.Handle); };

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

            if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            Progress<TranslationProgressModel> progress = new();
            progress.ProgressChanged += ProgressOnProgressChanged;
            await _translator.TranslateAsync(SettingsManager.Instance.AT_ApiKey, progress);
        }

        private async void AT_AnalyzeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DisableATButtons();
                AT_ProgressBar.Percent = 0;
                AT_InfoLabel.Text = "Analyzing scripts...";

                Progress<TranslationProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                _translator = new Translator(
                    SettingsManager.Instance.AT_TranslateInputPath,
                    SettingsManager.Instance.AT_TranslateOutputPath,
                    1250); // TODO encoding
                _translator.InfoEvt += (o, s) => { AT_SummaryLbl.Text = s; };

                await _translator.AnalyzeAsync(progress);

            }
            catch (Exception exc)
            {
                MessageBox.Show($"Error: {exc.Message}");
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
            AT_ProgressBar.Percent = e.Percent;
            AT_InfoLabel.AppendText($"{Environment.NewLine}{e.Msg}");
        }

        private async void AT_ReplaceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DisableATButtons();
                AT_ProgressBar.Percent = 0;
                AT_InfoLabel.Text = "Replacing scripts...";

                Progress<TranslationProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                await _translator.ReplaceAsync(progress);

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

        private void AT_SpellcheckerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DisableATButtons();
                AT_ProgressBar.Percent = 0;
                AT_InfoLabel.Text = "Spellchecking...";

                Progress<TranslationProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                Spellchecker spellchecker = new Spellchecker(@"C:\Users\ketra\Desktop\jezykpl");
                spellchecker.SpellcheckerEvt += (o, model) =>
                {
                    switch (model.Reason)
                    {
                        case SpellcheckerEvtReason.Typo:
                            AT_InfoLabel.AppendText($"{Environment.NewLine}Typo: {model.Args[0]}");
                            //for (int i = 1; i < model.Args.Length; i++)
                            //    AT_InfoLabel.AppendText($" {model.Args[i]}");
                            break;
                        case SpellcheckerEvtReason.StartsWithLowerCase:
                            AT_InfoLabel.AppendText($"{Environment.NewLine}LowerCase: {model.Args[0]}");
                            break;
                        case SpellcheckerEvtReason.EndsWithoutDot:
                            AT_InfoLabel.AppendText($"{Environment.NewLine}EndsWithDot: {model.Args[0]}");
                            break;
                        default:
                            AT_InfoLabel.AppendText($"{Environment.NewLine}...: {model.Args[0]}");
                            break;
                    }
                };

                var entries = _translator.GetEntries();
                spellchecker.AnalyzeTypos(entries);
                AT_InfoLabel.AppendText($"{Environment.NewLine}--- DONE ---");
                //spellchecker.AnalyzeCapitalsAndDots(entries,SpellcheckerFilters.ForUppercaseAndDot);

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

    }
}
