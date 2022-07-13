using System;
using System.Collections.Generic;
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
        protected virtual TextBox InfoLabel { get; } = new();
        protected virtual AdvancedProgressBar ProgressBar { get; } = new();

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            InfoLabel.GotFocus += (s1, e1) => { HideCaret(InfoLabel.Handle); };
        }

        protected virtual void DisableButtons()
        {
        }

        protected virtual void EnableButtons()
        {
        }

        private void ProgressOnProgressChanged(object? sender, ProgressModel e)
        {
            ProgressBar.Percent = e.Percent;
            InfoLabel.AppendText($"{Environment.NewLine}{e.Msg}");
        }

        protected async Task Process(string beginMsg, string endMsg, Func<Progress<ProgressModel>, Task> action)
        {
            try
            {
                DisableButtons();

                ProgressBar.Percent = 0;
                InfoLabel.Text = beginMsg;

                Progress<ProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                await action(progress);

                ProgressOnProgressChanged(this, new ProgressModel(endMsg, 100));
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
