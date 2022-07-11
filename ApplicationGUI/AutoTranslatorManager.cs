using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GothicAutoTranslator;

namespace ApplicationGUI
{
    public class AutoTranslatorManager
    {
        private Translator translator;

        public async Task InvokeTranslator(IProgress<TranslationProgressModel> progress)
        {
            translator = new Translator(
                SettingsManager.Instance.AT_TranslateInputPath,
                SettingsManager.Instance.AT_TranslateOutputPath,
                SettingsManager.Instance.AT_Encoding);

            await translator.AnalyzeAsync(progress);

        }

        public string GetSummary()
        {
            return $"Total characters: {translator.TotalCharacters}{Environment.NewLine}" +
                   $"Total entries: {translator.TotalLines}";
        }

        public async Task Translate(IProgress<TranslationProgressModel> progress)
        {
            if (translator == null)
            {
                throw new Exception("Translator not set.");
            }

            if (translator.TotalCharacters > SettingsManager.Instance.AT_MaxCharacters)
            {
                throw new Exception("Too many characters! Forbidden translation. You can change maximum in settings.");
            }

            await translator.TranslateAsync(SettingsManager.Instance.AT_ApiKey, progress);
        }

        public async Task Replace(IProgress<TranslationProgressModel> progress)
        {
            await translator.ReplaceAsync(progress);
        }


        public List<string> Spellcheck()
        {
            List<string> errors = new List<string>();

            Spellchecker spellchecker = new Spellchecker(SettingsManager.Instance.AT_SpellcheckerDictionaryDir);
            spellchecker.SpellcheckerEvt += (o, model) =>
            {
                switch (model.Reason)
                {
                    case SpellcheckerEvtReason.Typo:
                        errors.Add($"Typo: {model.Args[0]}");
                        break;
                    case SpellcheckerEvtReason.StartsWithLowerCase:
                        errors.Add($"LowerCase: {model.Args[0]}");
                        break;
                    case SpellcheckerEvtReason.EndsWithoutDot:
                        errors.Add($"EndsWithDot: {model.Args[0]}");
                        break;
                    default:
                        errors.Add($"...: {model.Args[0]}");
                        break;
                }
            };

            var entries = translator.GetEntries();
            spellchecker.AnalyzeTypos(entries);
            //spellchecker.AnalyzeCapitalsAndDots(entries,SpellcheckerFilters.ForUppercaseAndDot);

            return errors;
        }
    }
}
