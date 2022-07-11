
namespace ApplicationGUI.Views
{
    partial class SettingsAutoTranslatorView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.spellcheckerPath = new ApplicationGUI.Controls.AdvancedPathField();
            this.outputPath = new ApplicationGUI.Controls.AdvancedPathField();
            this.inputPath = new ApplicationGUI.Controls.AdvancedPathField();
            this.advancedGroupBox = new System.Windows.Forms.GroupBox();
            this.advancedApiKeyTextBox = new System.Windows.Forms.TextBox();
            this.advancedEncodingTextBox = new System.Windows.Forms.TextBox();
            this.advancedMaxTransCharsTextBox = new System.Windows.Forms.TextBox();
            this.advancedApiKeyLabel = new System.Windows.Forms.Label();
            this.advancedEncodingLabel = new System.Windows.Forms.Label();
            this.advancedMaxTransCharsLabel = new System.Windows.Forms.Label();
            this.advancedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // spellcheckerPath
            // 
            this.spellcheckerPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spellcheckerPath.Label = "Spellchecker directory:";
            this.spellcheckerPath.LabelWidth = 140;
            this.spellcheckerPath.Location = new System.Drawing.Point(3, 64);
            this.spellcheckerPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spellcheckerPath.Name = "spellcheckerPath";
            this.spellcheckerPath.Path = null;
            this.spellcheckerPath.Size = new System.Drawing.Size(494, 26);
            this.spellcheckerPath.TabIndex = 67;
            // 
            // outputPath
            // 
            this.outputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputPath.Label = "Output directory:";
            this.outputPath.LabelWidth = 140;
            this.outputPath.Location = new System.Drawing.Point(3, 33);
            this.outputPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputPath.Name = "outputPath";
            this.outputPath.Path = null;
            this.outputPath.Size = new System.Drawing.Size(494, 26);
            this.outputPath.TabIndex = 66;
            // 
            // inputPath
            // 
            this.inputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPath.Label = "Input directory:";
            this.inputPath.LabelWidth = 140;
            this.inputPath.Location = new System.Drawing.Point(3, 2);
            this.inputPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputPath.Name = "inputPath";
            this.inputPath.Path = null;
            this.inputPath.Size = new System.Drawing.Size(494, 26);
            this.inputPath.TabIndex = 65;
            // 
            // advancedGroupBox
            // 
            this.advancedGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedGroupBox.Controls.Add(this.advancedApiKeyTextBox);
            this.advancedGroupBox.Controls.Add(this.advancedEncodingTextBox);
            this.advancedGroupBox.Controls.Add(this.advancedMaxTransCharsTextBox);
            this.advancedGroupBox.Controls.Add(this.advancedApiKeyLabel);
            this.advancedGroupBox.Controls.Add(this.advancedEncodingLabel);
            this.advancedGroupBox.Controls.Add(this.advancedMaxTransCharsLabel);
            this.advancedGroupBox.Location = new System.Drawing.Point(3, 101);
            this.advancedGroupBox.Name = "advancedGroupBox";
            this.advancedGroupBox.Size = new System.Drawing.Size(494, 120);
            this.advancedGroupBox.TabIndex = 68;
            this.advancedGroupBox.TabStop = false;
            this.advancedGroupBox.Text = "Advanced";
            // 
            // advancedApiKeyTextBox
            // 
            this.advancedApiKeyTextBox.Location = new System.Drawing.Point(183, 85);
            this.advancedApiKeyTextBox.Name = "advancedApiKeyTextBox";
            this.advancedApiKeyTextBox.Size = new System.Drawing.Size(305, 23);
            this.advancedApiKeyTextBox.TabIndex = 5;
            // 
            // advancedEncodingTextBox
            // 
            this.advancedEncodingTextBox.Location = new System.Drawing.Point(183, 54);
            this.advancedEncodingTextBox.Name = "advancedEncodingTextBox";
            this.advancedEncodingTextBox.Size = new System.Drawing.Size(305, 23);
            this.advancedEncodingTextBox.TabIndex = 4;
            // 
            // advancedMaxTransCharsTextBox
            // 
            this.advancedMaxTransCharsTextBox.Location = new System.Drawing.Point(183, 25);
            this.advancedMaxTransCharsTextBox.Name = "advancedMaxTransCharsTextBox";
            this.advancedMaxTransCharsTextBox.Size = new System.Drawing.Size(305, 23);
            this.advancedMaxTransCharsTextBox.TabIndex = 3;
            // 
            // advancedApiKeyLabel
            // 
            this.advancedApiKeyLabel.AutoSize = true;
            this.advancedApiKeyLabel.Location = new System.Drawing.Point(16, 88);
            this.advancedApiKeyLabel.Name = "advancedApiKeyLabel";
            this.advancedApiKeyLabel.Size = new System.Drawing.Size(50, 15);
            this.advancedApiKeyLabel.TabIndex = 2;
            this.advancedApiKeyLabel.Text = "Api Key:";
            // 
            // advancedEncodingLabel
            // 
            this.advancedEncodingLabel.AutoSize = true;
            this.advancedEncodingLabel.Location = new System.Drawing.Point(16, 57);
            this.advancedEncodingLabel.Name = "advancedEncodingLabel";
            this.advancedEncodingLabel.Size = new System.Drawing.Size(60, 15);
            this.advancedEncodingLabel.TabIndex = 1;
            this.advancedEncodingLabel.Text = "Encoding:";
            // 
            // advancedMaxTransCharsLabel
            // 
            this.advancedMaxTransCharsLabel.AutoSize = true;
            this.advancedMaxTransCharsLabel.Location = new System.Drawing.Point(16, 28);
            this.advancedMaxTransCharsLabel.Name = "advancedMaxTransCharsLabel";
            this.advancedMaxTransCharsLabel.Size = new System.Drawing.Size(149, 15);
            this.advancedMaxTransCharsLabel.TabIndex = 0;
            this.advancedMaxTransCharsLabel.Text = "Max translation characters:";
            // 
            // SettingsAutoTranslatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.advancedGroupBox);
            this.Controls.Add(this.spellcheckerPath);
            this.Controls.Add(this.outputPath);
            this.Controls.Add(this.inputPath);
            this.Name = "SettingsAutoTranslatorView";
            this.Size = new System.Drawing.Size(500, 250);
            this.advancedGroupBox.ResumeLayout(false);
            this.advancedGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.AdvancedPathField spellcheckerPath;
        private Controls.AdvancedPathField outputPath;
        private Controls.AdvancedPathField inputPath;
        private System.Windows.Forms.GroupBox advancedGroupBox;
        private System.Windows.Forms.TextBox advancedApiKeyTextBox;
        private System.Windows.Forms.TextBox advancedEncodingTextBox;
        private System.Windows.Forms.TextBox advancedMaxTransCharsTextBox;
        private System.Windows.Forms.Label advancedApiKeyLabel;
        private System.Windows.Forms.Label advancedEncodingLabel;
        private System.Windows.Forms.Label advancedMaxTransCharsLabel;
    }
}
