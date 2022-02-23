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

        private static readonly HttpClient client = new HttpClient();


        private struct ItemData
        {
            public int Id;
            public string File;
            public int Line;
            public string Text;
            public string TranslatedText;
        }

        private List<ItemData> _entries = new();

        public Translator(string inputPath, string outputPath)
        {
            _inputPath = inputPath;
            _outputPath = outputPath;
        }


        public void Analyze()
        {
            string[] files = Directory.GetFiles(_inputPath);
            int total = 0;

            foreach (string file in files)
            {
                StreamReader sr = new StreamReader(file, Encoding.Default);

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
            
        }

        public async void Translate(string apiKey)
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

        public void Replace()
        {
            // foreach file if match then replace using the same 'i'
        }

    }
}
