using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GothicToolsLib.Models;

namespace GothicToolsLib.DecibelsModulator
{
    public static class VolumeModifier
    {
        public static void IncreaseVolumeSingleGothicWav(FFmpegProcessor ffmpeg, FileInfo fi, string outputDir, double dB)
        {
            string newFile = Path.Combine(outputDir,fi.Name);
            string dbModifier = (-dB).ToString("0.0", CultureInfo.InvariantCulture);

            string arguments = $"-i {fi.FullName} "
                               + $"-filter:a \"volume={dbModifier}dB\" " // increase volume
                               + "-ar 44100 " // .......................... sampling
                               + "-ac 1 -map_metadata -1 " // ............. destroy metadata
                               + "-f wav -acodec adpcm_ima_wav " // ....... codec
                               + "-b:a 177k " // .......................... bitrate audio
                               + newFile;

            ffmpeg.Run(arguments);
        }

        public static void IncreaseVolumeSingleGothicWavMax(FFmpegProcessor ffmpeg, FileInfo fi, string outputDir)
        {
            double maxVolume = DetailsExplorer.GetMaxVolume(ffmpeg,fi);
            IncreaseVolumeSingleGothicWav(ffmpeg, fi, outputDir, maxVolume);
        }

        public static void IncreaseVolumeGothicWawsMax(FFmpegProcessor ffmpeg, string inputDir, string outputDir,
            IProgress<ProgressModel> progress = null)
        {
            IncreaseVolumeGothicWavs(ffmpeg,inputDir, (fi) => IncreaseVolumeSingleGothicWavMax(ffmpeg, fi, outputDir), progress);
        }

        public static void IncreaseVolumeGothicWaws(FFmpegProcessor ffmpeg, string inputDir, string outputDir, double dB,
            IProgress<ProgressModel> progress = null)
        {
            IncreaseVolumeGothicWavs(ffmpeg, inputDir, (fi) => IncreaseVolumeSingleGothicWav(ffmpeg, fi, outputDir, dB), progress);
        }


        private static void IncreaseVolumeGothicWavs(FFmpegProcessor ffmpeg, string inputDir,
            Action<FileInfo> modifyVolumeFunc, IProgress<ProgressModel> progress = null)
        {
            string[] files = Directory.GetFiles(inputDir);

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo fi = new FileInfo(files[i]);

                if (!fi.Extension.Equals(".WAV", StringComparison.OrdinalIgnoreCase))
                {
                    // TODO: info error Console.WriteLine("Error - wrong extension of file: {0}; required WAV.", fi.Name);
                    continue;
                }

                modifyVolumeFunc(fi);

                progress?.Report(new ProgressModel()
                {
                    Msg = $"Increased file {fi.Name}",
                    Percent = (int)Math.Floor(((double)i / (double)files.Length) * 100)
                });
            }


        }

    }
}
