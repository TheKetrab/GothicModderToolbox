﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Google.Api.Gax.Grpc;
using Google.Api.Gax.ResourceNames;
using Google.Cloud.Translate.V3;
using GothicToolsLib.Models;
using GothicToolsLib.Patterns;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GothicToolsLib.AutoTranslator
{

    public struct EntryData
    {
        public string File;
        public int Line;
        public string Text;
        public string Kind;
    }

    public class Translator
    {
        private TextPatternsProvider _textPatternsProvider;

        private string _inputPath;
        private string _outputPath;

        private int _inputEncoding;

        private static readonly HttpClient client = new HttpClient();

        public event EventHandler<string> InfoEvt;

        public List<EntryData> GetEntries()
        {
            return _entries.ConvertAll(
                itd => new EntryData()
                {
                    File = itd.File,
                    Line = itd.Line,
                    Text = itd.Text,
                    Kind = itd.Kind
                });
        }

        [Serializable]
        private struct ItemData
        {
            public int Id;
            public string File;
            public int Line;
            public string Text;
            public string Kind;
            public string TranslatedText;
        }

        private List<ItemData> _entries = new();


        public void SerializeEntries()
        {
            string entriesFile = Path.Combine(Utils.GetExecutablePath(), "G2MT_AT_entries.dat");
            Stream stream = File.Open(entriesFile, FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(stream, _entries);
            stream.Close();
        }

        public void DeserializeEntries()
        {
            string entriesFile = Path.Combine(Utils.GetExecutablePath(), "G2MT_AT_entries.dat");
            Stream stream = File.Open(entriesFile,FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            _entries = (List<ItemData>) b.Deserialize(stream);
            stream.Close();

        }

        public Translator(string inputPath, string outputPath, int inputEncoding, TextPatternsProvider provider)
        {
            _inputPath = inputPath;
            _outputPath = outputPath;
            _inputEncoding = inputEncoding;
            _textPatternsProvider = provider;
        }

        public long TotalCharacters => _entries?.Sum(x => x.Text.Length) ?? 0;
        public long TotalLines => _entries?.Count ?? 0;


        private void AnalyzeSingleFile(string file, ref int total)
        {
            using StreamReader sr = new StreamReader(file, Encoding.GetEncoding(_inputEncoding));

            string line;
            int lineNum = -1;
            while ((line = sr.ReadLine()) != null)
            {
                lineNum++;
                var m = _textPatternsProvider.MatchAny(line);
                if (!m.HasValue) continue;

                string text = m.Value.Match.Groups[m.Value.GroupWithText].Value;
                string kind = m.Value.PatternName;

                _entries.Add(new ItemData()
                {
                    File = file,
                    Id = ++total,
                    Line = lineNum,
                    Text = text,
                    Kind = kind,
                });
            }

        }

        public async Task AnalyzeAsync(IProgress<ProgressModel> progress = null)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string[] files = Directory.GetFiles(_inputPath, "*.d", SearchOption.AllDirectories);
            int total = 0;

            long totalToRead = files.Sum(x => new FileInfo(x).Length);
            long dataRead = 0;

            foreach (string file in files)
            {
                await Task.Run(() => AnalyzeSingleFile(file, ref total));

                FileInfo fi = new FileInfo(file);
                dataRead += fi.Length;
                progress?.Report(new ProgressModel()
                {
                    Msg = $"Parsed file {fi.Name}",
                    Percent = (int)(dataRead * 100 / totalToRead)
                });
            }

            InfoEvt?.Invoke(this, $"All characters: {_entries.Sum(x => x.Text.Length)}");

        }

        public async Task TranslateAsync(string apiKey, string sourceLang, string targetLang, IProgress<ProgressModel> progress = null)
        {
            var converter = new ExpandoObjectConverter();
            for (int i=0; i< _entries.Count; i++)
            {
                ItemData entry = _entries[i];

                var values = new Dictionary<string, string>
                {
                    { "q", entry.Text },
                    { "source", sourceLang },
                    { "target", targetLang },
                    { "format", "text" }
                };

                var json = JsonConvert.SerializeObject(values);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var url = "https://translation.googleapis.com/language/translate/v2";
                var response = await client.PostAsync($"{url}?key={apiKey}", data);
                var result = await response.Content.ReadAsStringAsync();

                try
                {
                    dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(result, converter);
                    string translatedText = obj.data.translations[0].translatedText;
                    entry.TranslatedText = translatedText;

                    _entries[i] = entry;

                    progress?.Report(new ProgressModel()
                    {
                        Percent = (int)(i * 100 / _entries.Count)
                    });

                }
                catch (Exception e)
                {
                    
                }

            }

        }

        private void ReplaceSingleFile(IGrouping<string,ItemData> group)
        {
            string filename = group.Key;
            string[] lines = File.ReadAllLines(filename,Encoding.GetEncoding(_inputEncoding));

            foreach (var item in group)
            {
                lines[item.Line] = lines[item.Line].Replace(item.Text, item.TranslatedText);
            }

            File.WriteAllLines(filename,lines,Encoding.GetEncoding(_inputEncoding));
            
        }

        public async Task ReplaceAsync(IProgress<ProgressModel> progress = null)
        {
            var groups = _entries.GroupBy(x => x.File);
            int total = _entries.Count();
            int done = 0;
            foreach (var group in groups)
            {
                await Task.Run(() => ReplaceSingleFile(group));
                done += group.Count();

                progress?.Report(new ProgressModel()
                {
                    Msg = $"Translated file {group.Key}",
                    Percent = (int)(done * 100 / total)
                });
            }
        }


    }
}
