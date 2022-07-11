using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationGUI.Views
{
    public partial class SettingsAutoTranslatorView : UserControl
    {
        public SettingsAutoTranslatorView()
        {
            InitializeComponent();
        }


        protected override void OnResize(EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.inputPath.Width = this.Width;
            this.outputPath.Width = this.Width;
            this.spellcheckerPath.Width = this.Width;
            this.advancedGroupBox.Width = this.Width;
        }


        public void LoadOptions()
        {
            this.advancedApiKeyTextBox.Text = SettingsManager.Instance.AT_ApiKey;
            this.advancedEncodingTextBox.Text = SettingsManager.Instance.AT_Encoding.ToString();
            this.advancedMaxTransCharsTextBox.Text = SettingsManager.Instance.AT_MaxCharacters.ToString();

            this.inputPath.Path = SettingsManager.Instance.AT_TranslateInputPath;
            this.outputPath.Path = SettingsManager.Instance.AT_TranslateOutputPath;
            this.spellcheckerPath.Path = SettingsManager.Instance.AT_SpellcheckerDictionaryDir;
        }

        public void SaveOptions()
        {
            SettingsManager.Instance.AT_ApiKey = this.advancedApiKeyTextBox.Text;
            SettingsManager.Instance.AT_Encoding = int.Parse(this.advancedEncodingTextBox.Text);
            SettingsManager.Instance.AT_MaxCharacters = int.Parse(this.advancedMaxTransCharsTextBox.Text);

            SettingsManager.Instance.AT_TranslateInputPath = this.inputPath.Path;
            SettingsManager.Instance.AT_TranslateOutputPath = this.outputPath.Path;
            SettingsManager.Instance.AT_SpellcheckerDictionaryDir = this.spellcheckerPath.Path;

        }
    }
}
