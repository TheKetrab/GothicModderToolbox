using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothicToolsLib.DecibelsModulator
{
    public static class Converter
    {
        public static void ToMp3(FFmpegProcessor ffmpeg, FileInfo fi, string outputDir)
        {
            string outputFile = $"{Path.Combine(outputDir, fi.Name)}.mp3";
            ffmpeg.Run($"-i {fi.FullName} -vn -ar 44100 -ac 2 -b:a 192k {outputFile}");
        }

        public static void ToWav(FFmpegProcessor ffmpeg, FileInfo fi, string outputDir)
        {
            string outputFile = $"{Path.Combine(outputDir,fi.Name)}.wav";
            ffmpeg.Run($"-i {fi.FullName} -ar 44100 -ac 1 -map_metadata -1 -f wav -acodec adpcm_ima_wav -b:a 177k {outputFile}");
        }

        public static void ToMp3Pararell(FFmpegProcessor ffmpeg, string inputDir, string outputDir)
        {
            string[] files = Directory.GetFiles(inputDir);

            Parallel.ForEach<string>(files, (file) =>
            {
                FileInfo fi = new FileInfo(file);
                ToMp3(ffmpeg, fi, outputDir);
            });
        }

        public static void ToWavPararell(FFmpegProcessor ffmpeg, string inputDir, string outputDir)
        {
            string[] files = Directory.GetFiles(inputDir);

            Parallel.ForEach<string>(files, (file) =>
            {
                FileInfo fi = new FileInfo(file);
                ToWav(ffmpeg, fi, outputDir);
            });
        }


    }
}
