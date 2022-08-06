using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationGUI.Annotations;
using ApplicationGUI.Controls;
using GothicToolsLib.Models;

namespace ApplicationGUI
{
    public partial class AutoTranslatorView : ProcessingAbstractView
    {
        private AutoTranslatorManager autoTranslatorManager = new();

        private int _state = 0;
        private int State { get => _state;
            set { _state = value;
                EnableButtonsRespectingState();
            }
        } // 0 = nothing, 1 = entries loaded, 2 = translated


        public AutoTranslatorView()
        {
            InitializeComponent();
            InitializeBindings();

            DisableButtons();
            EnableButtons();
        }

        private void InitializeBindings()
        {
            BindLangComboAndText(AT_SrcLangCombo,AT_SrcLangText);
            BindLangComboAndText(AT_DstLangCombo,AT_DstLangText);
        }

        private void BindLangComboAndText(ComboBox combo, TextBox textBox)
        {
            // Bind Text With Combo

            Binding bindLangTextCombo = new Binding("Text", combo, "Text");
            bindLangTextCombo.Format += (sender, args) =>
            {
                string shortcut = GetLangShortcut(args.Value.ToString());
                if (shortcut == "Other")
                {
                    // don't update text
                    args.Value = ((Binding)sender).Control.Text;
                }

                else if (shortcut != "")
                    args.Value = shortcut;
            };

            textBox.DataBindings.Add(bindLangTextCombo);

            // Bind Combo With Text

            textBox.Leave += (sender, args) =>
            {
                int i = GetIndexOfItemWithShortcut(combo, textBox.Text);
                combo.SelectedIndex = i;
            };

        }

        private string GetLangShortcut(string langWithShortcut)
        {
            if (string.IsNullOrEmpty(langWithShortcut))
                return "";

            if (langWithShortcut == "Other")
                return "Other";
            
            Regex reg = new Regex(@"^.*\((.+)\)$");
            Match m = reg.Match(langWithShortcut);
            if (m.Groups.Count >= 2)
            {
                return m.Groups[1].Value;
            }

            return "";
        }

        private int GetIndexOfItemWithShortcut(ComboBox combo, string shortcut)
        {
            // Select item with shortcut
            for (int i = 0; i < combo.Items.Count; i++)
            {
                string x = combo.Items[i].ToString();
                if (combo.Items[i].ToString().Contains($"({shortcut})"))
                    return i;
            }

            // Select item with 'Other'
            for (int i = 0; i < combo.Items.Count; i++)
            {
                if (combo.Items[i].ToString().Equals("Other"))
                    return i;
            }

            // Select nothing, error
            return -1;
        }


        protected override ReadOnlyRichTextBox InfoLabel => AT_InfoLabel;
        protected override AdvancedProgressBar ProgressBar => AT_ProgressBar;

        private async void AT_TranslateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AT_SrcLangText.Text) || string.IsNullOrEmpty(AT_DstLangText.Text))
            {
                MessageBox.Show("First select source and destination languages!");
                return;
            }

            await Process("Translating...", "", async (progress) =>
            {
                if (MessageBox.Show(
                    $"You're going to translate from {AT_SrcLangText.Text} to {AT_DstLangText.Text}. Are you sure?",
                    "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await autoTranslatorManager.Translate(AT_SrcLangText.Text, AT_DstLangText.Text, progress);
                    State = 2;
                }
            });
        }

        private async void AT_AnalyzeBtn_Click(object sender, EventArgs e)
        {
            await Process("Analyzing scripts...", "", async (progress) =>
            {
                await autoTranslatorManager.InvokeTranslator(progress);
                AT_SummaryLabel.Text = autoTranslatorManager.GetSummary();
            });

            State = 1;
        }

        protected override void DisableButtons()
        {
            AT_AnalyzeBtn.Enabled = false;
            AT_TranslateBtn.Enabled = false;
            AT_ReplaceBtn.Enabled = false;
            AT_SpellcheckerBtn.Enabled = false;
            AT_SaveEntriesBtn.Enabled = false;
            AT_LoadEntriesBtn.Enabled = false;
        }

        protected override void EnableButtons()
        {
            EnableButtonsRespectingState();
        }

        private async void AT_ReplaceBtn_Click(object sender, EventArgs e)
        {
            await Process("Replacing scripts...", "", async (progress) =>
            {
                await autoTranslatorManager.Replace(progress);
            });

            State = 3;
        }

        private async void AT_SpellcheckerBtn_Click(object sender, EventArgs e)
        {
            await Process("Spellchecking...", "--- DONE ---", async (progress) =>
            {
                var errors = await autoTranslatorManager.Spellcheck(progress);
                foreach (var error in errors)
                {
                    AT_InfoLabel.AppendText($"{Environment.NewLine}{error}");
                }
            });

        }

        private void AT_LoadEntriesBtn_Click(object sender, EventArgs e)
        {
            autoTranslatorManager.LoadEntries();
            AT_SummaryLabel.Text = autoTranslatorManager.GetSummary();
            State = 1;
        }

        private void AT_SaveEntriesBtn_Click(object sender, EventArgs e)
        {
            autoTranslatorManager.SaveEntries();
            MessageBox.Show("Saved");
        }

        private void EnableButtonsRespectingState()
        {
            DisableButtons();
            if (State >= 0)
            {
                AT_AnalyzeBtn.Enabled = true;
                AT_LoadEntriesBtn.Enabled = true;
            }

            if (State >= 1)
            {
                AT_SaveEntriesBtn.Enabled = true;
                AT_SpellcheckerBtn.Enabled = true;
                AT_TranslateBtn.Enabled = true;
            }

            if (State >= 2)
            {
                AT_ReplaceBtn.Enabled = true;
            }
        }

    }
}
