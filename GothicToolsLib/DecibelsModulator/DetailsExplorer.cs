using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GothicToolsLib.DecibelsModulator
{
    public static class DetailsExplorer
    {
        private static string patternMaxVolume = @"max_volume: ([-+]?[0-9]*\.?[0-9]*) dB";

        public static double GetMaxVolume(FFmpegProcessor ffmpeg, FileInfo fi)
        {
            string ffmpegOutput = RunVolumeDetect(ffmpeg, fi);
            Regex regex = new Regex(patternMaxVolume);
            if (!regex.IsMatch(ffmpegOutput)) return 0;
            Match m = regex.Match(ffmpegOutput);
            return double.Parse(m.Groups[1].Value, CultureInfo.InvariantCulture);
        }

        private static string RunVolumeDetect(FFmpegProcessor ffmpeg, FileInfo fi)
        {
            return ffmpeg.RunWithCapture($"-i {fi.FullName} -filter:a volumedetect -f null /dev/null");
        }


    }
}
