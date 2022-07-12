using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothicToolsLib.DecibelsModulator
{
    public static class VolumeModifier
    {
        public static void IncreaseVolumeGothicWav(FFmpegProcessor ffmpeg, FileInfo fi, double dB)
        {
            string newFile = Path.Combine(ffmpeg.OutputDir,fi.Name);
            string dbModifier = (-dB).ToString("0.0", CultureInfo.InvariantCulture);

            string arguments = $"-i {fi.FullName} "
                               + $"-filter:a \"volume={dbModifier}dB\" " // ....... increase volume
                               + "-ar 44100 " // .......................... sampling
                               + "-ac 1 -map_metadata -1 " // ............. destroy metadata
                               + "-f wav -acodec adpcm_ima_wav " // ....... codec
                               + "-b:a 177k " // .......................... bitrate audio
                               + newFile;

            ffmpeg.Run(arguments);
        }

        public static void IncreaseVolumeGothicWavMax(FFmpegProcessor ffmpeg, FileInfo fi)
        {
            double maxVolume = DetailsExplorer.GetMaxVolume(ffmpeg,fi);
            IncreaseVolumeGothicWav(ffmpeg, fi, maxVolume);
        }

        public static void IncreaseVolumeGothicWav(FFmpegProcessor ffmpeg, string inputDir, string outputDir, Action<FileInfo> modifyVolumeFunc)
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
            }
            
        }

    }
}
