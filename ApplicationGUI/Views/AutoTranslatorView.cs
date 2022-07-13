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
using ApplicationGUI.Controls;
using GothicToolsLib.Models;

namespace ApplicationGUI
{
    public partial class AutoTranslatorView : ProcessingAbstractView
    {
        private AutoTranslatorManager autoTranslatorManager = new();

        public AutoTranslatorView()
        {
            InitializeComponent();
        }

        protected override TextBox InfoLabel => AT_InfoLabel;
        protected override AdvancedProgressBar ProgressBar => AT_ProgressBar;

        private async void AT_TranslateBtn_Click(object sender, EventArgs e)
        {
            await Process("Translating...", "", async (progress) =>
            {
                if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await autoTranslatorManager.Translate(progress);
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
        }

        protected override void DisableButtons()
        {
            AT_AnalyzeBtn.Enabled = false;
            AT_TranslateBtn.Enabled = false;
            AT_ReplaceBtn.Enabled = false;
            AT_SpellcheckerBtn.Enabled = false;
        }

        protected override void EnableButtons()
        {
            AT_AnalyzeBtn.Enabled = true;
            AT_TranslateBtn.Enabled = true;
            AT_ReplaceBtn.Enabled = true;
            AT_SpellcheckerBtn.Enabled = true;
        }

        private async void AT_ReplaceBtn_Click(object sender, EventArgs e)
        {
            await Process("Replacing scripts...", "", async (progress) =>
            {
                await autoTranslatorManager.Replace(progress);
            });
        }

        private async void AT_SpellcheckerBtn_Click(object sender, EventArgs e)
        {
            await Process("Spellchecking...", "--- DONE ---", async (progress) =>
            {
                var errors = autoTranslatorManager.Spellcheck();
                foreach (var error in errors)
                {
                    AT_InfoLabel.AppendText($"{Environment.NewLine}{error}");
                }
            });

        }

    }
}
