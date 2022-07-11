using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace GothicDecibelsModulator
{
    public class Program
    {
        private static int _timeXPos;
        private static int _timeYPos;
        private static int _percentXPos;
        private static int _percentYPos;

        private static double _remainingTime = 0;
        private static double _processingTime = 0;

        private static readonly object ConsoleWriterLock = new object();

        public static void Main(string[] args)
        {
            try
            {
                (string inputDir, string outputDir) = ParseArguments(args);
                string[] files = Directory.GetFiles(inputDir);

                Console.CursorVisible = false;

                PrintHeader("Gothic Decibels Modulator");
                SetPrintPositions();
                ProcessFiles(files, outputDir);

                Console.CursorVisible = true;

                Console.WriteLine(" > Press ENTER to exit. <");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n\n\n{new string('-',30)}");
                Console.WriteLine("Program failed.\n");
                do
                {
                    Console.WriteLine($"\n{e.Message}\n{e.StackTrace}");
                    e = e.InnerException;
                } while (e != null);
            }
            finally
            {
                Console.ReadKey();
            }
        }
        private static void ProcessFiles(string[] files, string outputDir)
        {
            FFmpeg ffmpeg = new FFmpeg("ffmpeg.exe", outputDir);

            var timer = InitClock();
            for (int i = 0; i < files.Length; i++)
            {
                PercentLog(i, files.Length);
                FileInfo fi = new FileInfo(files[i]);

                if (!fi.Extension.Equals(".WAV", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Error - wrong extension of file: {0}; required WAV.", fi.Name);
                    continue;
                }

                double maxVolume = ffmpeg.GetMaxVolume(fi);
                ffmpeg.RunVolumeIncrease(fi, maxVolume);
            }

            timer.Stop();
            PrintPercentage(100);
            PrintRemainedTime();

            Console.WriteLine($"\n Done. Processing time: {TimeSpan.FromSeconds(_processingTime):hh\\:mm\\:ss}");
        }

        private static (string, string) ParseArguments(string[] args)
        {
            //if (args.Length < 3)
            //{
            //    throw new ArgumentException("Run program with: app.exe \"inputDir\" \"outputDir\"");
            //}

            //string inputDir = args[1];
            //string outputDir = args[2];

            string inputDir = @"C:\Users\ketra\Desktop\dialogi\input\";
            string outputDir = @"C:\Users\ketra\Desktop\dialogi\output\";

            if (!Directory.Exists(inputDir))
            {
                throw new ArgumentException($"Input directory ({inputDir}) does not exist!");
            }

            if (!Directory.Exists(outputDir))
            {
                throw new ArgumentException($"Output directory ({outputDir}) does not exist!");
            }

            return (inputDir, outputDir);
        }

        private static void PrintHeader(string msg)
        {
            Console.WriteLine();
            Console.WriteLine($" ----- ===== {new string('#',Math.Max(0,msg.Length-14))} ===== ----- ");
            Console.Write(" ---- ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(msg);
            Console.ResetColor();
            Console.Write(" ---- \n\r");
            Console.WriteLine($" ----- ===== {new string('#', Math.Max(0, msg.Length - 14))} ===== ----- ");
        }

        private static void SetPrintPositions()
        {
            Console.Write(" > Processing: ");
            _percentXPos = Console.CursorLeft;
            _percentYPos = Console.CursorTop;

            Console.WriteLine();

            Console.Write(" > Remaining time: ");
            _timeXPos = Console.CursorLeft;
            _timeYPos = Console.CursorTop;
        }
        private static System.Timers.Timer InitClock()
        {
            var timer = new System.Timers.Timer(1000);
            timer.Elapsed += (s, e) => {

                lock (ConsoleWriterLock)
                {
                    PrintRemainedTime();
                    _processingTime++;
                }
            };

            timer.Start();
            return timer;
        }

        private static void PrintPercentage(int percentage)
        {
            Console.SetCursorPosition(_percentXPos, _percentYPos);
            Console.Write($"{percentage}%");
        }

        private static void PercentLog(int iter, int total)
        {
            int percentage = (int)Math.Floor(iter * 100.0 / total);
            if (percentage > (int)Math.Floor((iter - 1) * 100.0 / total))
            {
                lock (ConsoleWriterLock)
                {
                    PrintPercentage(percentage);
                }

                if (iter != 0)
                {
                    _remainingTime = Math.Floor(((double) (total - iter) / (double) iter) * _processingTime);
                }
            }
        }

        private static void PrintRemainedTime()
        {
            Console.SetCursorPosition(_timeXPos, _timeYPos);
            Console.WriteLine($"{TimeSpan.FromSeconds(_remainingTime):hh\\:mm\\:ss}");
            _remainingTime--;
        }

    }
}
