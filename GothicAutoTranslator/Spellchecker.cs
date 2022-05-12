using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GothicAutoTranslator
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

        private HashSet<string> _words = new();

        public event EventHandler<SpellcheckerEvtModel> SpellcheckerEvt;

        public Spellchecker(string wordsPath)
        {
            InitializeHashMap(wordsPath);
        }

        void InitializeHashMap(string wordsPath)
        {
            string[] files = Directory.GetFiles(wordsPath, "*", SearchOption.AllDirectories);
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

        public void AnalyzeTypos(List<EntryData> lst, SpellcheckerFilters filter = SpellcheckerFilters.None)
        {
            foreach (var entry in lst)
            {
                if (!ValidForFilter(entry, filter))
                    continue;

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
