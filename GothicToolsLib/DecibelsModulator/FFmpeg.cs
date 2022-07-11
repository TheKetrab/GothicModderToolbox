using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GothicDecibelsModulator
{
    public class FFmpeg
    {
        private static string patternMaxVolume = @"max_volume: ([-+]?[0-9]*\.?[0-9]*) dB";

        private readonly string _outputDir;
        private readonly string _ffmpegPath;

        public FFmpeg(string ffmpegPath, string outputDir)
        {
            this._ffmpegPath = ffmpegPath;
            this._outputDir = outputDir;
            TestFFmpegPath();
        }

        public double GetMaxVolume(FileInfo fi)
        {
            string ffmpegOutput = RunVolumeDetect(fi);
            Regex regex = new Regex(patternMaxVolume);
            if (!regex.IsMatch(ffmpegOutput)) return 0;
            Match m = regex.Match(ffmpegOutput);
            return double.Parse(m.Groups[1].Value, CultureInfo.InvariantCulture);
        }

        private string RunVolumeDetect(FileInfo fi)
        {
            string output = "";
            string arguments = $"-i {fi.FullName} -filter:a volumedetect -f null /dev/null";

            using (Process process = new Process())
            {
                process.StartInfo.FileName = _ffmpegPath;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardError = true;

                process.ErrorDataReceived += ((s, e) => { output += e.Data; });

                process.Start();
                process.BeginErrorReadLine();
                process.WaitForExit();
            }

            return output;
        }

        public void RunVolumeIncrease(FileInfo fi, double maxVolume)
        {
            string newFile = $"{_outputDir}/{fi.Name}";
            string dbModifier = (-maxVolume).ToString("0.0", CultureInfo.InvariantCulture);

            string arguments = $"-i {fi.FullName} "
                + $"-filter:a \"volume={dbModifier}dB\" " // increase volume
                + "-ar 44100 " // .......................... sampling
                + "-ac 1 -map_metadata -1 " // ............. destroy metadata
                + "-f wav -acodec adpcm_ima_wav " // ....... codec
                + "-b:a 177k " // .......................... bitrate audio
                 + newFile;

            using (Process process = new Process())
            {
                process.StartInfo.FileName = _ffmpegPath;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                process.WaitForExit();
            }

        }

        private void TestFFmpegPath()
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = _ffmpegPath;
                    process.StartInfo.Arguments = "-loglevel quiet";

                    process.Start();
                    process.WaitForExit();
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Invalid path to Ffmpeg. ({_ffmpegPath})", e);
            }

        }

    }
}
