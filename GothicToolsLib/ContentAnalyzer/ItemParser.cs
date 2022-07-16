using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using GothicToolsLib.Models;
using GothicToolsLib.Patterns;

namespace GothicToolsLib.ContentAnalyzer
{
    public class ItemParser
    {

        private ItemPatternsProvider _itemPP;

        public bool Parsed { get; private set; }
        public event EventHandler<string> ParsingScriptEvt;
        public Dictionary<string, int> AllItems = new();

        private HashSet<string> customItems;

        private const RegexOptions RegexOpt = RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace;


        private string _itemsPath;
        private string _lookupDirectory;

        public ItemParser(string itemsPath, string lookupDirectory, ItemPatternsProvider provider)
        {
            _itemsPath = itemsPath;
            _lookupDirectory = lookupDirectory;
            _itemPP = provider;

            InitCustomItems();
        }

        private List<string> GetItemInstances(string file)
        {
            List<string> result = new();
            using StreamReader sr = new StreamReader(file, Encoding.Default);
            ParsingScriptEvt?.Invoke(this, file);

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (Regex.IsMatch(line, _itemPP.InstanceItem, RegexOpt))
                {
                    Match match = Regex.Match(line, _itemPP.InstanceItem, RegexOpt);
                    string itemInstance = match.Groups[1].Value.Trim();
                    result.Add(itemInstance);
                }
                
            }

            return result;
        }

        private void InitCustomItems()
        {
            List<string> allItems = new();
            string[] files = Directory.GetFiles(_itemsPath);

            foreach (string file in files)
            {
                var instances = GetItemInstances(file);
                allItems = allItems.Concat(instances).ToList();
            }

            customItems = allItems.Select(x => x.ToUpper()).ToHashSet();

            foreach (var item in allItems)
            {
                ItemFound(item,0); // init empty with 0
            }
        }

        private void ParseZenContains(string line)
        {
            Match match = Regex.Match(line, _itemPP.ZenContains, RegexOpt);

            string[] instances = match.Groups[1].Value.Split(',');

            foreach (string x in instances)
            {
                string[] xy = x.Split(":");
                if (xy.Length == 1)
                {
                    string instance = xy[0];
                    if (!customItems.Contains(instance.ToUpper()))
                        continue;

                    ItemFound(instance);
                }
                else
                {
                    string instance = xy[0];
                    int count = int.Parse(xy[1]);
                    if (!customItems.Contains(instance.ToUpper()))
                        continue;

                    ItemFound(instance,count);
                }
            }
        }

        private void ItemFound(string instance, int count=1)
        {
            if (AllItems.ContainsKey(instance.ToUpper()))
            {
                AllItems[instance.ToUpper()] += count;
            }
            else
            {
                AllItems.Add(instance.ToUpper(),count);
            }
        }

        private void ParseZenItemInstance(string line)
        {
            Match match = Regex.Match(line, _itemPP.ZenItemInstance, RegexOpt);

            string instance = match.Groups[1].Value;

            if (!customItems.Contains(instance.ToUpper()))
                return;

            ItemFound(instance);
        }

        private void ParseZEN(string zenFile)
        {
            using StreamReader sr = new StreamReader(zenFile, Encoding.Default);

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (Regex.IsMatch(line, _itemPP.ZenContains, RegexOpt))
                {
                    ParseZenContains(line);
                }

                else if (Regex.IsMatch(line, _itemPP.ZenItemInstance, RegexOpt))
                {
                    ParseZenItemInstance(line);
                }
            }

        }
        private void ParseScript(string scriptFile)
        {
            using StreamReader sr = new StreamReader(scriptFile, Encoding.Default);
            string str = sr.ReadToEnd();

            foreach (var itemInstance in customItems)
            {
                string substr = str;
                int count = 0;
                int offset = 0;
                while ((offset = substr.IndexOf(itemInstance, StringComparison.CurrentCultureIgnoreCase)) != -1)
                {
                    count++;
                    substr = substr.Substring(offset + itemInstance.Length);
                }

                ItemFound(itemInstance, count);
            }

        }


        public void Parse(IProgress<ProgressModel> progress)
        {
            const int initPercent = 5;
            const int zensPercent = 20;
            const int scriptsPercent = 100 - initPercent - zensPercent;


            progress.Report(new ProgressModel(
                $"Found { customItems.Count } items.",initPercent));

            string[] scripts = Directory.GetFiles(_lookupDirectory, "*.d", SearchOption.AllDirectories);
            string[] zens = Directory.GetFiles(_lookupDirectory, "*.ZEN", SearchOption.AllDirectories);

            long total = scripts.Sum(x => new FileInfo(x).Length);
            long done = 0;

            long totalZens = scripts.Sum(x => new FileInfo(x).Length);
            long doneZens = 0;

            Parallel.ForEach<string>(scripts, (script) =>
            {
                FileInfo fi = new FileInfo(script);
                ParseScript(script);
                done += fi.Length;

                ProgressModel progressModel = new()
                {
                    File = script,
                    Msg = $"Parsed script: {fi.Name}",
                    Percent = initPercent + (int)(done * scriptsPercent / total)
                };

                progress.Report(progressModel);
            });

            Parallel.ForEach<string>(zens, (zen) =>
            {
                FileInfo fi = new FileInfo(zen);
                ParseZEN(zen);
                doneZens += fi.Length;

                ProgressModel progressModel = new()
                {
                    File = zen,
                    Msg = $"Parsed ZEN: {fi.Name}",
                    Percent = initPercent + zensPercent + (int)(doneZens * zensPercent / totalZens)
                };

                progress.Report(progressModel);
            });

            Parsed = true;
        }

    }
}
