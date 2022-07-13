using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GothicToolsLib.Models;

namespace GothicToolsLib.AutoTranslator
{
    public enum SpellcheckerFilters
    {
        None,
        OnlyDialogs,
        ForUppercaseAndDot,
        SimpleWords,
    }

    public class Spellchecker
    {

        public bool Inited { get; private set; }

        private HashSet<string> _words = new();

        public event EventHandler<SpellcheckerEvtModel> SpellcheckerEvt;

        public Spellchecker()
        {
        }

        public async Task InitializeHashMap(string wordsPath)
        {
            string[] files = Directory.GetFiles(wordsPath, "*", SearchOption.AllDirectories);

            await Task.Run(() =>
            {
                foreach (string file in files)
                {
                    var lines = File.ReadLines(file);
                    foreach (var line in lines)
                    {
                        var splitted = line.Split(',');
                        foreach (var s in splitted)
                        {
                            _words.Add(s.Trim().ToUpper());
                        }
                    }
                }
            });

            Inited = true;
        }

        public static bool ValidForFilter(EntryData entry, SpellcheckerFilters filters)
        {
            switch (filters)
            {
                case SpellcheckerFilters.None:
                    return true;

                case SpellcheckerFilters.OnlyDialogs:
                    return entry.Kind == "AiOutput";

                case SpellcheckerFilters.ForUppercaseAndDot:
                    return entry.Kind == "AiOutput"
                           || entry.Kind == "BLogEntry"
                           || entry.Kind == "AddChoice";

                case SpellcheckerFilters.SimpleWords:
                    return entry.Kind == "Name"
                           || entry.Kind == "Text";

            }

            return false;
        }


        public void AnalyzeTyposSingleEntry(EntryData entry)
        {
            string[] words = GetWords(entry.Text);
            foreach (var word in words)
            {
                if (!_words.Contains(word.ToUpper()))
                {
                    SpellcheckerEvt?.Invoke(this, new SpellcheckerEvtModel(
                        SpellcheckerEvtReason.Typo, word, entry.Text, entry.File, entry.Line.ToString()));
                }
            }
        }

        public async Task AnalyzeTyposAsync(List<EntryData> lst, SpellcheckerFilters filter = SpellcheckerFilters.None, IProgress<ProgressModel> progress = null)
        {
            if (!Inited)
                throw new Exception("Spellchecker hashmap is not inited.");

            int n = lst.Count, i = 0;
            foreach (var entry in lst)
            {
                ++i;
                if (!ValidForFilter(entry, filter))
                    continue;

                await Task.Run(() => AnalyzeTyposSingleEntry(entry));
                progress?.Report(new ProgressModel()
                {
                    Percent = (int)(i * 100 / n)
                });
            }
        }


        public void AnalyzeCapitalsAndDots(List<EntryData> lst, SpellcheckerFilters filter = SpellcheckerFilters.None)
        {
            foreach (var entry in lst)
            {
                if (!ValidForFilter(entry,filter))
                    continue;

                if (entry.Text[^1] != '.')
                    SpellcheckerEvt?.Invoke(this, new SpellcheckerEvtModel(
                        SpellcheckerEvtReason.EndsWithoutDot, entry.Text, entry.File, entry.Line.ToString()));

                if (!char.IsUpper(entry.Text[0]))
                    SpellcheckerEvt?.Invoke(this, new SpellcheckerEvtModel(
                        SpellcheckerEvtReason.StartsWithLowerCase, entry.Text, entry.File, entry.Line.ToString()));
            }
        }


        private static string[] GetWords(string sentence)
        {
            string[] removable = new string[] { ",", ".", "!", "?", "'", ":", "(", ")", "%" , "\"" };
            foreach (string r in removable)
                sentence = sentence.Replace(r, "");

            for (int i = 0; i < 10; i++)
                sentence = sentence.Replace(i.ToString(), "");

            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
            }

            return words;
        }

    }
}
