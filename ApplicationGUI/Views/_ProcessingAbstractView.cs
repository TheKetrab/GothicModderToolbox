using System;
using System.Collections.Generic;
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
    public class ProcessingAbstractView : UserControl
    {
        protected virtual ReadOnlyRichTextBox InfoLabel { get; } = new();
        protected virtual AdvancedProgressBar ProgressBar { get; } = new();

        protected virtual void DisableButtons()
        {
        }

        protected virtual void EnableButtons()
        {
        }


        

        private void ProgressOnProgressChanged(object? sender, ProgressModel e)
        {
            ProgressBar.Percent = e.Percent;
            if (string.IsNullOrEmpty(e.Msg))
                return;

            Color color = e.Importance switch
            {
                Importance.Error => Color.Red,
                Importance.Normal => Color.Black,
                Importance.Warning => Color.Orange,
                _ => Color.Black
            };

            bool bold = e.Importance == Importance.Bold;

            InfoLabel.AppendFormattedText($"{Environment.NewLine}{e.Msg}", color, bold);
        }

        protected async Task Process(string beginMsg, string endMsg, Func<Progress<ProgressModel>, Task> action)
        {
            try
            {
                DisableButtons();

                ProgressBar.Percent = 0;
                string newline = string.IsNullOrEmpty(InfoLabel.Text) ? "" : Environment.NewLine + Environment.NewLine;
                InfoLabel.AppendFormattedText($"{newline}{beginMsg}",Color.Black,true);

                Progress<ProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                await action(progress);

                ProgressOnProgressChanged(this, new ProgressModel(endMsg, 100) { Importance = Importance.Bold});
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
