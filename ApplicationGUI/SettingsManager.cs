using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;

namespace ApplicationGUI
{
    public class SettingsManager
    {
        #region DubbingChecker
        public string DC_DialogsPath { get; set; }
        public string DC_DubbingPath { get; set; }
        public string DC_ItemsDirectory { get; set; }
        public string DC_ItemsLookupDirectory { get; set; }
        public string DC_OutputDirectory { get; set; }
        #endregion


        #region AutoTranslator
        public string AT_TranslateInputPath { get; set; }
        public string AT_TranslateOutputPath { get; set; }
        public string AT_ApiKey { get; set; }

        public int AT_Encoding { get; set; }

        public int AT_MaxCharacters { get; set; }
        public string AT_SpellcheckerDictionaryDir { get; set; }
        #endregion


        public void UpdateConfigFile()
        {
            // TODO
        }

        private void InitConfig()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("config.ini");

            // # PATHS
            DC_DialogsPath = data["Paths"]["DC_dialogsPath"];
            DC_DubbingPath = data["Paths"]["DC_dubbingPath"];
            DC_ItemsDirectory = data["Paths"]["DC_itemsDirectory"];
            DC_ItemsLookupDirectory = data["Paths"]["DC_itemsLookupDirectory"];
            DC_OutputDirectory = data["Paths"]["outputDirectory"];

            // TODO
            AT_TranslateInputPath = data["Paths"]["AT_translateInputPath"];
            AT_TranslateOutputPath = data["Paths"]["AT_translateOutputPath"];
            AT_ApiKey = data["GCP"]["ApiKey"];

            AT_Encoding = int.Parse(data["Encoding"]["InputScripts"]); // TODO: default if not set + message
            AT_MaxCharacters = int.Parse(data["Translation"]["MaxTranslationCharacters"]);

            AT_SpellcheckerDictionaryDir = data["Paths"]["AT_spellcheckerDictionaryDir"];

        }


        private SettingsManager()
        {
            InitConfig();
        }

        private static SettingsManager _instance;
        public static SettingsManager Instance 
            => _instance ??= new SettingsManager();


    }
}
