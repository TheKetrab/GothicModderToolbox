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
    public class FFmpegProcessor
    {
        private string _path;

        public FFmpegProcessor(string ffmpegPath)
        {
            _path = ffmpegPath;
            TestFFmpegPath();
        }

        private void TestFFmpegPath()
        {
            try
            {
                Run("-loglevel quiet");
            }
            catch (Exception e)
            {
                throw new Exception($"Invalid path to ffmpeg. ({_path})", e);
            }

        }

        public void Run(string arguments)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = _path;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                process.WaitForExit();
            }
        }

        public string RunWithCapture(string arguments)
        {
            string output = "";

            using (Process process = new Process())
            {
                process.StartInfo.FileName = _path;
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

    }
}
