using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GothicToolsLib.DecibelsModulator;
using GothicToolsLib.Models;

namespace ApplicationGUI.Managers
{
    public class DecibelsModulatorManager
    {
        private FFmpegProcessor ffmpeg;

        public DecibelsModulatorManager()
        {
            ffmpeg = new FFmpegProcessor(SettingsManager.Instance.DM_FfmpegPath);
        }

        public async Task IncreaseVolumeMaxAsync(IProgress<ProgressModel> progress)
        {
            ffmpeg = new FFmpegProcessor(SettingsManager.Instance.DM_FfmpegPath);

            await Task.Run(() => VolumeModifier.IncreaseVolumeGothicWawsMax(
                ffmpeg,
                SettingsManager.Instance.DM_InputDirectory,
                SettingsManager.Instance.DM_OutputDirectory,
                progress));
        }

        public async Task IncreaseVolumeAsync(double dB, IProgress<ProgressModel> progress)
        {
            ffmpeg = new FFmpegProcessor(SettingsManager.Instance.DM_FfmpegPath);

            await Task.Run(() => VolumeModifier.IncreaseVolumeGothicWaws(
                ffmpeg,
                SettingsManager.Instance.DM_InputDirectory,
                SettingsManager.Instance.DM_OutputDirectory,
                dB, progress));
        }

        public async Task ConvertToMp3(IProgress<ProgressModel> progress)
        {
            ffmpeg = new FFmpegProcessor(SettingsManager.Instance.DM_FfmpegPath);

            await Task.Run(() => Converter.ToMp3Pararell(
                ffmpeg,
                SettingsManager.Instance.DM_InputDirectory,
                SettingsManager.Instance.DM_OutputDirectory));
        }

        public async Task ConvertToWav(IProgress<ProgressModel> progress)
        {
            ffmpeg = new FFmpegProcessor(SettingsManager.Instance.DM_FfmpegPath);

            await Task.Run(() => Converter.ToWavPararell(
                ffmpeg,
                SettingsManager.Instance.DM_InputDirectory,
                SettingsManager.Instance.DM_OutputDirectory));
        }


    }
}
