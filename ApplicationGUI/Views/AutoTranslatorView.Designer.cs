
namespace ApplicationGUI
{
    partial class AutoTranslatorView
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
            this.AT_SpellcheckerBtn = new System.Windows.Forms.Button();
            this.AT_InfoLabel = new ApplicationGUI.Controls.ReadOnlyRichTextBox();
            this.AT_ReplaceBtn = new System.Windows.Forms.Button();
            this.AT_AnalyzeBtn = new System.Windows.Forms.Button();
            this.AT_TranslateBtn = new System.Windows.Forms.Button();
            this.AT_ProgressBar = new ApplicationGUI.Controls.AdvancedProgressBar();
            this.AT_SummaryLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AT_SrcLangCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AT_DstLangCombo = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AT_SpellcheckerBtn
            // 
            this.AT_SpellcheckerBtn.Location = new System.Drawing.Point(278, 11);
            this.AT_SpellcheckerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AT_SpellcheckerBtn.Name = "AT_SpellcheckerBtn";
            this.AT_SpellcheckerBtn.Size = new System.Drawing.Size(88, 22);
            this.AT_SpellcheckerBtn.TabIndex = 26;
            this.AT_SpellcheckerBtn.Text = "Spellcheck";
            this.AT_SpellcheckerBtn.UseVisualStyleBackColor = true;
            this.AT_SpellcheckerBtn.Click += new System.EventHandler(this.AT_SpellcheckerBtn_Click);
            // 
            // AT_InfoLabel
            // 
            this.AT_InfoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.AT_InfoLabel.Location = new System.Drawing.Point(3, 64);
            this.AT_InfoLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AT_InfoLabel.Multiline = true;
            this.AT_InfoLabel.Name = "AT_InfoLabel";
            this.AT_InfoLabel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.AT_InfoLabel.Size = new System.Drawing.Size(494, 100);
            this.AT_InfoLabel.TabIndex = 24;
            // 
            // AT_ReplaceBtn
            // 
            this.AT_ReplaceBtn.Location = new System.Drawing.Point(278, 36);
            this.AT_ReplaceBtn.Name = "AT_ReplaceBtn";
            this.AT_ReplaceBtn.Size = new System.Drawing.Size(88, 23);
            this.AT_ReplaceBtn.TabIndex = 21;
            this.AT_ReplaceBtn.Text = "Replace";
            this.AT_ReplaceBtn.UseVisualStyleBackColor = true;
            this.AT_ReplaceBtn.Click += new System.EventHandler(this.AT_ReplaceBtn_Click);
            // 
            // AT_AnalyzeBtn
            // 
            this.AT_AnalyzeBtn.Location = new System.Drawing.Point(188, 10);
            this.AT_AnalyzeBtn.Name = "AT_AnalyzeBtn";
            this.AT_AnalyzeBtn.Size = new System.Drawing.Size(84, 23);
            this.AT_AnalyzeBtn.TabIndex = 20;
            this.AT_AnalyzeBtn.Text = "Analyze";
            this.AT_AnalyzeBtn.UseVisualStyleBackColor = true;
            this.AT_AnalyzeBtn.Click += new System.EventHandler(this.AT_AnalyzeBtn_Click);
            // 
            // AT_TranslateBtn
            // 
            this.AT_TranslateBtn.Location = new System.Drawing.Point(188, 36);
            this.AT_TranslateBtn.Name = "AT_TranslateBtn";
            this.AT_TranslateBtn.Size = new System.Drawing.Size(85, 23);
            this.AT_TranslateBtn.TabIndex = 19;
            this.AT_TranslateBtn.Text = "Translate";
            this.AT_TranslateBtn.UseVisualStyleBackColor = true;
            this.AT_TranslateBtn.Click += new System.EventHandler(this.AT_TranslateBtn_Click);
            // 
            // AT_ProgressBar
            // 
            this.AT_ProgressBar.InsideMargin = 3;
            this.AT_ProgressBar.LabelWidth = 40;
            this.AT_ProgressBar.Location = new System.Drawing.Point(3, 168);
            this.AT_ProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AT_ProgressBar.Name = "AT_ProgressBar";
            this.AT_ProgressBar.Percent = 0;
            this.AT_ProgressBar.Size = new System.Drawing.Size(494, 30);
            this.AT_ProgressBar.TabIndex = 27;
            // 
            // AT_SummaryLabel
            // 
            this.AT_SummaryLabel.AutoSize = true;
            this.AT_SummaryLabel.Location = new System.Drawing.Point(372, 13);
            this.AT_SummaryLabel.Name = "AT_SummaryLabel";
            this.AT_SummaryLabel.Size = new System.Drawing.Size(31, 15);
            this.AT_SummaryLabel.TabIndex = 28;
            this.AT_SummaryLabel.Text = "Info:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Source:";
            // 
            // AT_SrcLangCombo
            // 
            this.AT_SrcLangCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AT_SrcLangCombo.FormattingEnabled = true;
            this.AT_SrcLangCombo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AT_SrcLangCombo.Items.AddRange(new object[] {
            "Polish (pl)",
            "English (en)",
            "German (de)",
            "Russian (ru)",
            "Czech (cs)",
            "Other"});
            this.AT_SrcLangCombo.Location = new System.Drawing.Point(55, 10);
            this.AT_SrcLangCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AT_SrcLangCombo.Name = "AT_SrcLangCombo";
            this.AT_SrcLangCombo.Size = new System.Drawing.Size(88, 23);
            this.AT_SrcLangCombo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Target:";
            // 
            // AT_DstLangCombo
            // 
            this.AT_DstLangCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AT_DstLangCombo.FormattingEnabled = true;
            this.AT_DstLangCombo.Items.AddRange(new object[] {
            "English (en)",
            "Polish (pl)",
            "German (de)",
            "Russian (ru)",
            "Czech (cs)",
            "Other"});
            this.AT_DstLangCombo.Location = new System.Drawing.Point(55, 37);
            this.AT_DstLangCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AT_DstLangCombo.Name = "AT_DstLangCombo";
            this.AT_DstLangCombo.Size = new System.Drawing.Size(88, 23);
            this.AT_DstLangCombo.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 23);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 37);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 23);
            this.textBox2.TabIndex = 20;
            // 
            // AutoTranslatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.AT_SummaryLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AT_ProgressBar);
            this.Controls.Add(this.AT_DstLangCombo);
            this.Controls.Add(this.AT_SpellcheckerBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AT_InfoLabel);
            this.Controls.Add(this.AT_SrcLangCombo);
            this.Controls.Add(this.AT_ReplaceBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AT_AnalyzeBtn);
            this.Controls.Add(this.AT_TranslateBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AutoTranslatorView";
            this.Size = new System.Drawing.Size(500, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AT_SpellcheckerBtn;
        private ApplicationGUI.Controls.ReadOnlyRichTextBox AT_InfoLabel;
        private System.Windows.Forms.Button AT_ReplaceBtn;
        private System.Windows.Forms.Button AT_AnalyzeBtn;
        private System.Windows.Forms.Button AT_TranslateBtn;
        private Controls.AdvancedProgressBar AT_ProgressBar;
        private System.Windows.Forms.Label AT_SummaryLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AT_SrcLangCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AT_DstLangCombo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
