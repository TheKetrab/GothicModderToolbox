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

        private AutoTranslatorManager autoTranslatorManager = new();

        public AutoTranslatorView()
        {
            InitializeComponent();
            AT_InfoLabel.GotFocus += (s1, e1) => { HideCaret(AT_InfoLabel.Handle); };
        }


        private async void AT_TranslateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DisableButtons();
                AT_ProgressBar.Percent = 0;
                AT_InfoLabel.Text = "Translating...";

                if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Progress<TranslationProgressModel> progress = new();
                    progress.ProgressChanged += ProgressOnProgressChanged;

                    await autoTranslatorManager.Translate(progress);
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                EnableButtons();
            }

        }

        private async void AT_AnalyzeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DisableButtons();
                AT_ProgressBar.Percent = 0;
                AT_InfoLabel.Text = "Analyzing scripts...";

                Progress<TranslationProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                await autoTranslatorManager.InvokeTranslator(progress);

                AT_SummaryLabel.Text = autoTranslatorManager.GetSummary();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                EnableButtons();
            }

        }

        private void DisableButtons()
        {
            AT_AnalyzeBtn.Enabled = false;
            AT_TranslateBtn.Enabled = false;
            AT_ReplaceBtn.Enabled = false;
        }

        private void EnableButtons()
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
                DisableButtons();
                AT_ProgressBar.Percent = 0;
                AT_InfoLabel.Text = "Replacing scripts...";

                Progress<TranslationProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                await autoTranslatorManager.Replace(progress);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                EnableButtons();
            }
        }

        private void AT_SpellcheckerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DisableButtons();
                AT_ProgressBar.Percent = 0;
                AT_InfoLabel.Text = "Spellchecking...";

                Progress<TranslationProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                var errors = autoTranslatorManager.Spellcheck();
                foreach (var error in errors)
                {
                    AT_InfoLabel.AppendText($"{Environment.NewLine}{error}");
                }

                AT_InfoLabel.AppendText($"{Environment.NewLine}--- DONE ---");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                EnableButtons();
            }
        }

    }
}
