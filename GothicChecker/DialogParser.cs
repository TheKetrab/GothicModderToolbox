using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using GothicChecker.Models;
using NPOI.SS.Formula.Functions;
using Match = System.Text.RegularExpressions.Match;

namespace GothicChecker
{
    public class DialogParser
    {
        public bool Parsed { get; private set; }
        private struct TrialogData
        {
            public string Filename { get; set; }
            public string Line { get; set; }
            public string TrialogFakeName { get; set; }
        }

        public event EventHandler<string> ParsingScriptEvt;

        public List<AIOutputModel> AllDialogs = new();

        public NpcDictionary Npcs { get; } = new();
//        public GothicPaths Paths { get; }

        public HashSet<string> WavNames;

        private List<TrialogData> trialogsToResolve = new();
        private const RegexOptions RegexOpt = RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace;
        private readonly string _dubbingPath;
        private readonly string _scriptsPath;

        public DialogParser(string scriptsPath, string dubbingPath)
        {
            _scriptsPath = scriptsPath;
            _dubbingPath = dubbingPath;

            InitWavNames();
        }

        private void InitWavNames()
        {
            WavNames = Directory.GetFiles(_dubbingPath)
                .Select(f => new FileInfo(f).Name.ToUpper())
                .ToHashSet();
        }


        private void ParseHeroLine(string line,string filename)
        {
            Match match = Regex.Match(line, GothicPatterns.OutputOther, RegexOpt);

            string instance = match.Groups[2].Value;

            AIOutputModel aio = new AIOutputModel(instance, "other,self", match.Groups[3].Value,filename);
            Npcs.AddLine(0,aio);

            if (!WavNames.Contains($"{instance.ToUpper()}.WAV"))
                Npcs[0].Missing.Add(aio);

            AllDialogs.Add(aio);
        }

        private void ParseNpcLine(string line, string file, string trialogName="")
        {
            Match match = Regex.Match(line, GothicPatterns.OutputSelf, RegexOpt);

            string instance = match.Groups[2].Value;
            string filename = new FileInfo(file).Name;

            AIOutputModel aio;
            if (!string.IsNullOrEmpty(trialogName))
            {
                int id = Npcs.GetIdByName(trialogName);
                aio = new AIOutputModel(instance, "self,other", match.Groups[3].Value,file);

                Npcs.AddLine(id, aio, trialogName);

                if (!WavNames.Contains($"{instance.ToUpper()}.WAV"))
                    Npcs[id].Missing.Add(aio);

            }
            else if (Regex.IsMatch(filename, GothicPatterns.DiaFileName, RegexOpt))
            {
                Match matchFileName = Regex.Match(filename, GothicPatterns.DiaFileName, RegexOpt);

                int id = Int32.Parse(matchFileName.Groups[2].Value);
                string name = matchFileName.Groups[3].Value;

                aio = new AIOutputModel(instance, "self,other", match.Groups[3].Value,file);

                Npcs.AddLine(id,aio,name);

                if (!WavNames.Contains($"{instance.ToUpper()}.WAV"))
                    Npcs[id].Missing.Add(aio);
            }
            else
            {
                ParsingScriptEvt?.Invoke(this,$"Atypical file name: {filename}");
                aio = new AIOutputModel(instance, "self,other", match.Groups[3].Value,file);

                Npcs.AddLine(-1,aio);

                if (!WavNames.Contains($"{instance.ToUpper()}.WAV"))
                    Npcs[-1].Missing.Add(aio);
            }

            AllDialogs.Add(aio);
        }

        private void ParseScript(string file)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            StreamReader sr = new StreamReader(file, Encoding.GetEncoding(1250));
            bool trialogMode = false;
            string trialogFakeName = "";

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (Regex.IsMatch(line, GothicPatterns.OutputOther, RegexOpt))
                {
                    ParseHeroLine(line,file);
                }

                else if (Regex.IsMatch(line, GothicPatterns.OutputSelf, RegexOpt))
                {
                    if (trialogMode)
                    {
                        trialogsToResolve.Add(new TrialogData()
                        {
                            Filename = file,
                            Line = line,
                            TrialogFakeName = trialogFakeName
                        });
                    }
                    else
                    {
                        ParseNpcLine(line, file);
                    }
                }

                else if (Regex.IsMatch(line, GothicPatterns.TrialogStart, RegexOpt))
                {
                    trialogMode = true;
                }

                else if (Regex.IsMatch(line, GothicPatterns.TrialogFinish, RegexOpt))
                {
                    trialogMode = false;
                }

                else if (Regex.IsMatch(line, GothicPatterns.TrialogNext, RegexOpt))
                {
                    if (!trialogMode) continue;
                    Match match = Regex.Match(line, GothicPatterns.TrialogNext, RegexOpt);
                    trialogFakeName = match.Groups[1].Value;
                }


            }

        }

        private void ParseTrialogs()
        {
            foreach (var td in trialogsToResolve)
            {
                ParseNpcLine(td.Line, td.Filename, td.TrialogFakeName);
            }

        }

        public void Parse(IProgress<ParserProgressModel> progress)
        {
            string[] files = Directory.GetFiles(_scriptsPath, "*.d", SearchOption.AllDirectories);
            long total = files.Sum(x => new FileInfo(x).Length);
            long done = 0;

            Parallel.ForEach<string>(files, (file) =>
            {
                FileInfo fi = new FileInfo(file);
                ParseScript(file);
                done += fi.Length;

                ParserProgressModel progressModel = new()
                {
                    File = file,
                    Msg = $"Parsed script: {fi.Name}",
                    Percent = (int)(done * 100 / total)
                };

                progress.Report(progressModel);
            });

            ParseTrialogs();

            progress.Report(new ParserProgressModel("Parsed trialogs.",100));

            Parsed = true;
        }


        public List<string> GetMissingWavs()
        {
            var result = new List<string>();

            foreach (AIOutputModel aio in AllDialogs)
            {
                if (!WavNames.Contains($"{aio.Instance.ToUpper()}.WAV"))
                {
                    result.Add(aio.Instance.ToUpper());
                }
            }

            return result;
        }

        public List<string> GetUnnecessaryWavs()
        {
            var result = new List<string>();
            var files = Directory.GetFiles(_dubbingPath)
                .Select(f => new FileInfo(f));
            
            var instances = AllDialogs.Select(aio => $"{aio.Instance.ToUpper()}.WAV");
            var hashSetInstances = new HashSet<string>(instances);

            foreach (FileInfo fi in files)
            {
                if (fi.Extension.ToUpper() != ".WAV")
                {
                    result.Add(fi.Name);
                }
                else if (!hashSetInstances.Contains(fi.Name.ToUpper()))
                {
                    result.Add(fi.Name);
                }
            }

            return result;
        }

    }
}
