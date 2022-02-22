using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;
using System.Reflection;
using GothicChecker.Models;

namespace GothicChecker
{
    public class StatsPrinter
    {
        private readonly string _outputPath;

        public StatsPrinter(string outputPath)
        {
            _outputPath = outputPath;
        }

        private void PrintCollectionToFile<T>(IEnumerable<T> collection, string filename, Func<T,string> printFunc=null)
        {
            using StreamWriter sw = new StreamWriter($"{_outputPath}/{filename}", false, Encoding.Default);
            foreach (var item in collection)
            {
                sw.WriteLine(printFunc!=null ? printFunc(item) : item.ToString());
            }
        }

        private void PrintCollectionToFileWithAction<T>(IEnumerable<T> collection, string filename, Action<StreamWriter,T> printAction)
        {
            using StreamWriter sw = new StreamWriter($"{_outputPath}/{filename}", false, Encoding.Default);
            foreach (var item in collection)
                printAction(sw, item);
        }


        public void PrintMissingWavs(List<string> missingWavs)
        {
            PrintCollectionToFile(missingWavs, "Wavs_Missing.txt");
        }

        public void PrintUnnecessaryWavs(List<string> unnecessaryWavs)
        {
            PrintCollectionToFile(unnecessaryWavs, "Wavs_Unnecessary.txt");
        }

        private void PrintStatsToFile(NpcDictionary npcs, string filename)
        {
            using StreamWriter sw = new StreamWriter($"{_outputPath}/{filename}", true, Encoding.Default);

            int total = npcs.Sum(x => x.Dialogs.Count);
            int done = npcs.Sum(x => x.DialogesDone);

            sw.WriteLine();
            sw.WriteLine(" --- === Stats: === --- ");

            double heroPercent = npcs[0].DialogesDone * 100.0 / npcs[0].Dialogs.Count;
            double npcsPercent = (done - npcs[0].DialogesDone) * 100.0 / (total - npcs[0].Dialogs.Count);
            double totalPercent = done * 100.0 / total;

            sw.WriteLine("HERO:  " + Math.Round(heroPercent, 2) + "%");
            sw.WriteLine("NPCS: " + Math.Round(npcsPercent, 2) + "%");
            sw.WriteLine("TOTAL: " + Math.Round(totalPercent, 2) + "%");

        }


        public void PrintInfo(NpcDictionary npcs, bool deleteComplete, bool printMissingList)
        {
            PrintCollectionToFile(npcs,"Info.txt",npc => GetNpcInfoString(npc,deleteComplete,printMissingList));
            PrintStatsToFile(npcs, "Info.txt");
        }

        public string GetNpcInfoString(NpcModel npc, bool deleteComplete = true, bool printMissingList = false)
        {
            StringBuilder sb = new StringBuilder();
            if (deleteComplete && npc.Percent >= 80)
            {
;               sb.Append(npc.Missing.Count == 0
                    ? "----- ----- ----- ----- -----"
                    : "***** ***** ALMOST ***** *****");
            }
            else
            {
                sb.Append(npc.BuildNpcInfo());
            }

            if (printMissingList)
            {
                foreach (var aio in npc.Missing)
                    sb.Append($"\n{aio}");
            }

            return sb.ToString();
        }


        public void PrintMissingHero(NpcDictionary npcs)
        {
            PrintCollectionToFileWithAction(npcs.Where(x => x.Id == 0),
                "Hero_Missing.txt", (sw, hero) =>
                {
                    string actFile = "";
                    foreach (var dialog in hero.Missing)
                    {
                        if (actFile != dialog.FileName)
                        {
                            actFile = dialog.FileName;
                            PrintHeaderToStream(sw, new FileInfo(actFile).Name);
                        }
                        sw.WriteLine(dialog.ToString());
                    }

                });
        }


        public void PrintAllHero(NpcDictionary npcs)
        {
            PrintCollectionToFileWithAction(npcs.Where(x => x.Id == 0),
                "Hero_All.txt", (sw, hero) =>
                {
                    string actFile = "";
                    foreach (var dialog in hero.Dialogs)
                    {
                        if (actFile != dialog.FileName)
                        {
                            actFile = dialog.FileName;
                            PrintHeaderToStream(sw, new FileInfo(actFile).Name);
                        }
                        sw.WriteLine(dialog.ToString());
                    }

                });
        }

        public void PrintMissingNpcs(NpcDictionary npcs)
        {
            PrintCollectionToFileWithAction(npcs.Where(x => x.Id != 0),
                "Npcs_Missing.txt", (sw, npc) =>
                {
                    PrintHeaderToStream(sw, npc.Name);
                    foreach (var dialog in npc.Missing)
                        sw.WriteLine(dialog.ToString());
                } );
        }

        public void PrintAllNpcs(NpcDictionary npcs)
        {
            PrintCollectionToFileWithAction(npcs.Where(x => x.Id != 0),
                "Npcs_All.txt", (sw, npc) =>
                {
                    PrintHeaderToStream(sw, npc.Name);
                    foreach (var dialog in npc.Dialogs)
                        sw.WriteLine(dialog.ToString());
                });
        }

        public void PrintAlphabetical(List<AIOutputModel> dialogs)
        {
            PrintCollectionToFile(dialogs.OrderBy(x => x.Instance), "Alphabetical.txt");
        }

        public void PrintAllItems(Dictionary<string,int> items)
        {
            int longest = items.Max(x => x.Key.Length);
            PrintCollectionToFile(items.OrderBy(x => x.Key), "Items_All.txt",
                x => $"{x.Key}{new string(' ',longest + 10 - x.Key.Length)}{x.Value}");
        }

        public void PrintUnusedItems(Dictionary<string, int> items)
        {
            var unused = items.Where(x => x.Value == 0);
            int longest = unused.Max(x => x.Key.Length);
            PrintCollectionToFile(unused.OrderBy(x => x.Key), "Items_Unused.txt",
                x => $"{x.Key}{new string(' ', longest + 10 - x.Key.Length)}{x.Value}");
        }


        private void PrintHeaderToStream(StreamWriter streamWriter, string header)
        {
            streamWriter.WriteLine("***** ***** ***** ***** *****");
            streamWriter.WriteLine($" --- { header } --- ");
            streamWriter.WriteLine("***** ***** ***** ***** *****");
        }



    }
}
