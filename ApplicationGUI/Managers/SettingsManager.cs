using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GothicToolsLib.Patterns;
using IniParser;
using IniParser.Model;
using System.Reflection;
using ApplicationGUI.Managers;
using NPOI.SS.Formula.Atp;

namespace ApplicationGUI
{
    public class SettingsManager
    {
        private string configFileName = "config.ini";
        
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

        #region DecibelsModulator
        public string DM_FfmpegPath { get; set; }
        public string DM_InputDirectory { get; set; }
        public string DM_OutputDirectory { get; set; }
        #endregion


        #region CustomPatterns
        public bool ADV_CustomPatternsEnabled { get; set; }
        public CustomPatternsManager CPManager;
        #endregion


        public void WriteConfig()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(configFileName);

            // Options
            var properties = this.GetType().GetProperties();
            foreach (var prop in properties)
            {
                string section = GetSectionName(prop.Name);
                if (section == "")
                    continue;

                data[section][prop.Name] = prop.GetValue(this).ToString();
            }

            // Custom Patterns
            CPManager.WriteCutomPatternsToIni(data);

            parser.WriteFile(configFileName,data);
        }

        private string GetSectionName(string propName)
        {
            int i = propName.IndexOf('_');
            string prefix = propName.Substring(0, i + 1);

            return prefix switch
            {
                "DC_" => "DubbingChecker",
                "AT_" => "AutoTranslator",
                "DM_" => "DubbingModulator",
                "GCP_" => "GoogleCloudPlatform",
                "ENC_" => "Encoding",
                "ADV_" => "Advanced", 
                _ => ""
            };
        }

        private void ReadConfig()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(configFileName);

            // Options
            var properties = this.GetType().GetProperties();
            foreach (var prop in properties)
            {
                string section = GetSectionName(prop.Name);
                if (string.IsNullOrEmpty(section))
                    continue;

                string value = data[section][prop.Name];

                if (prop.PropertyType == typeof(string))
                {
                    prop.SetValue(this, value);
                }
                else if (prop.PropertyType == typeof(int))
                {
                    prop.SetValue(this,Convert.ToInt32(value));
                }
                else if (prop.PropertyType == typeof(bool))
                {
                    prop.SetValue(this,Convert.ToBoolean(value));
                }

            }

            // Custom Patterns
            CPManager = new CustomPatternsManager(data);
        }


        private SettingsManager()
        {
            ReadConfig();
        }

        private static SettingsManager _instance;
        public static SettingsManager Instance 
            => _instance ??= new SettingsManager();


    }
}
