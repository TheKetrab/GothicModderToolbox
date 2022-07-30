using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationGUI.Managers;
using GothicToolsLib.AutoTranslator;
using GothicToolsLib.Models;
using GothicToolsLib.Patterns;

namespace ApplicationGUI
{
    public class AutoTranslatorManager
    {
        private Translator translator;

        public async Task InvokeTranslator(IProgress<ProgressModel> progress)
        {
            TextPatternsProvider patternsProvider =
                (SettingsManager.Instance.ADV_CustomPatternsEnabled)
                    ? new SettingsTextPatternsProvider()
                    : new TextPatternsProvider();

            translator = new Translator(
                SettingsManager.Instance.AT_TranslateInputPath,
                SettingsManager.Instance.AT_TranslateOutputPath,
                SettingsManager.Instance.AT_Encoding,
                patternsProvider);

            await translator.AnalyzeAsync(progress);

        }

        public string GetSummary()
        {
            return $"Total chars: {translator.TotalCharacters}{Environment.NewLine}" +
                   $"Total entries: {translator.TotalLines}";
        }

        public async Task Translate(IProgress<ProgressModel> progress)
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

        public async Task Replace(IProgress<ProgressModel> progress)
        {
            await translator.ReplaceAsync(progress);
        }


        public async Task<List<string>> Spellcheck(IProgress<ProgressModel> progress)
        {
            List<string> errors = new List<string>();

            progress.Report(new ProgressModel()
            {
                Msg = "Initializing dictionary...",
                Percent = 1
            });

            Spellchecker spellchecker = new Spellchecker();
            await spellchecker.InitializeHashMap(SettingsManager.Instance.AT_SpellcheckerDictionaryDir);

            spellchecker.SpellcheckerEvt += (o, model) =>
            {
                switch (model.Reason)
                {
                    case SpellcheckerEvtReason.Typo:
                        errors.Add($"Typo: [{model.Args[0]}] {new string('\t',3)} (file {new FileInfo(model.Args[2]).Name}, line: {model.Args[3]})");
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
            await spellchecker.AnalyzeTyposAsync(entries,progress:progress);
            //spellchecker.AnalyzeCapitalsAndDots(entries,SpellcheckerFilters.ForUppercaseAndDot);

            return errors;
        }
    }
}
