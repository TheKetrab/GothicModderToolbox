using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Google.Api.Gax.Grpc;
using Google.Api.Gax.ResourceNames;
using Google.Cloud.Translate.V3;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GothicAutoTranslator
{
    public class Translator
    {
        private string _inputPath;
        private string _outputPath;

        private int _inputEncoding;

        private static readonly HttpClient client = new HttpClient();

        public event EventHandler<string> InfoEvt;

        private struct ItemData
        {
            public int Id;
            public string File;
            public int Line;
            public string Text;
            public string TranslatedText;
        }

        private List<ItemData> _entries = new();

        public Translator(string inputPath, string outputPath, int inputEncoding)
        {
            _inputPath = inputPath;
            _outputPath = outputPath;
            _inputEncoding = inputEncoding;
        }

        public long TotalCharacters => _entries?.Sum(x => x.Text.Length) ?? 0;


        private void AnalyzeSingleFile(string file, ref int total)
        {
            StreamReader sr = new StreamReader(file, Encoding.GetEncoding(_inputEncoding));

            string line;
            int lineNum = 0;
            while ((line = sr.ReadLine()) != null)
            {
                var m = GothicPatterns.MatchAny(line);
                if (!m.HasValue) continue;

                string text = m.Value.Match.Groups[m.Value.GroupWithText].Value;

                _entries.Add(new ItemData()
                {
                    File = file,
                    Id = ++total,
                    Line = ++lineNum,
                    Text = text
                });
            }

        }

        public async Task AnalyzeAsync(IProgress<TranslationProgressModel> progress = null)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);


            // TODO: read it asynchronously

            string[] files = Directory.GetFiles(_inputPath, "*.d", SearchOption.AllDirectories);
            int total = 0;

            long totalToRead = files.Sum(x => new FileInfo(x).Length);
            long dataRead = 0;

            foreach (string file in files)
            {
                await Task.Run(() => AnalyzeSingleFile(file, ref total));

                FileInfo fi = new FileInfo(file);
                dataRead += fi.Length;
                progress?.Report(new TranslationProgressModel()
                {
                    Msg = $"Parsed file {fi.Name}",
                    Percent = (int) (dataRead * 100 / totalToRead)
                });
            }

            InfoEvt?.Invoke(this,$"All characters: {_entries.Sum(x => x.Text.Length)}");

        }

        public async Task TranslateAsync(string apiKey)
        {
            var converter = new ExpandoObjectConverter();
            for (int i=0; i< _entries.Count; i++)
            {
                ItemData entry = _entries[i];

                var values = new Dictionary<string, string>
                {
                    { "q", entry.Text },
                    { "source", "pl" },
                    { "target", "en" },
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
                }
                catch (Exception e)
                {
                    
                }

            }

            
        }

        public async Task ReplaceAsync()
        {
            // foreach file if match then replace using the same 'i'
        }

    }
}
