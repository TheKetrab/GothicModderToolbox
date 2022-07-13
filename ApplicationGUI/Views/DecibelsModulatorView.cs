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
using ApplicationGUI.Managers;
using GothicToolsLib.Models;

namespace ApplicationGUI
{
    public partial class DecibelsModulatorView : UserControl
    {
        private DecibelsModulatorManager decibelsModulatorManager = new DecibelsModulatorManager();

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public DecibelsModulatorView()
        {
            InitializeComponent();
            DM_InfoLabel.GotFocus += (s1, e1) => { HideCaret(DM_InfoLabel.Handle); };
        }

        private void DisableButtons()
        {
            DM_IncVolumeBtn.Enabled = false;
        }

        private void EnableButtons()
        {
            DM_IncVolumeBtn.Enabled = true;
        }

        private void ProgressOnProgressChanged(object? sender, ProgressModel e)
        {
            DM_ProgressBar.Percent = e.Percent;
            DM_InfoLabel.AppendText($"{Environment.NewLine}{e.Msg}");
        }


        private async void DM_IncVolumeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DisableButtons();
                DisableButtons();

                DM_ProgressBar.Percent = 0;
                DM_InfoLabel.Text = "Increasing volume...";

                Progress<ProgressModel> progress = new();
                progress.ProgressChanged += ProgressOnProgressChanged;

                if (DM_IncVolumeMaxRadioBtn.Checked)
                {
                    await decibelsModulatorManager.IncreaseVolumeMaxAsync(progress);
                }
                else if (DM_IncVolumeDbRadioBtn.Checked)
                {
                    await decibelsModulatorManager.IncreaseVolumeAsync(DM_IncVolumeSlider.Value, progress);
                }

                EnableButtons();

                ProgressOnProgressChanged(this,
                    new ProgressModel("Parsing dialogs completed.", 100));
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
