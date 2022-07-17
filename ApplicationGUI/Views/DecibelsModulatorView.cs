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
using ApplicationGUI.Managers;
using GothicToolsLib.Models;

namespace ApplicationGUI
{
    public partial class DecibelsModulatorView : ProcessingAbstractView
    {
        private DecibelsModulatorManager decibelsModulatorManager = new DecibelsModulatorManager();

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public DecibelsModulatorView()
        {
            InitializeComponent();
            //DM_InfoLabel.GotFocus += (s1, e1) => { HideCaret(DM_InfoLabel.Handle); };
        }

        protected override AdvancedProgressBar ProgressBar => DM_AdvancedProgressBar;
        protected override TextBox InfoLabel => DM_InfoLabel;

        protected override void DisableButtons()
        {
            DM_IncVolumeBtn.Enabled = false;
        }

        protected override void EnableButtons()
        {
            DM_IncVolumeBtn.Enabled = true;
        }

        private async void DM_IncVolumeBtn_Click(object sender, EventArgs e)
        {
            await Process("Increasing volume...","Increasing volume done.", async (progress) =>
            {
                if (DM_IncVolumeMaxRadioBtn.Checked)
                {
                    await decibelsModulatorManager.IncreaseVolumeMaxAsync(progress);
                }
                else if (DM_IncVolumeDbRadioBtn.Checked)
                {
                    await decibelsModulatorManager.IncreaseVolumeAsync(DM_IncVolumeSlider.Value, progress);
                }

            });
            
        }

        private async void DM_Mp3Btn_Click(object sender, EventArgs e)
        {
            await Process("Conversion to mp3.", "Conversion done.", async (progress) =>
            {
                await decibelsModulatorManager.ConvertToMp3(progress);
            });
        }

        private async void DM_WavBtn_Click(object sender, EventArgs e)
        {
            await Process("Conversion to wav.", "Conversion done.", async (progress) =>
            {
                await decibelsModulatorManager.ConvertToWav(progress);
            });
        }
    }
}
