
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
            this.AT_SrcLangText = new System.Windows.Forms.TextBox();
            this.AT_DstLangText = new System.Windows.Forms.TextBox();
            this.AT_SaveEntriesBtn = new System.Windows.Forms.Button();
            this.AT_LoadEntriesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AT_SpellcheckerBtn
            // 
            this.AT_SpellcheckerBtn.Location = new System.Drawing.Point(251, 101);
            this.AT_SpellcheckerBtn.Name = "AT_SpellcheckerBtn";
            this.AT_SpellcheckerBtn.Size = new System.Drawing.Size(90, 30);
            this.AT_SpellcheckerBtn.TabIndex = 26;
            this.AT_SpellcheckerBtn.Text = "Spellcheck";
            this.AT_SpellcheckerBtn.UseVisualStyleBackColor = true;
            this.AT_SpellcheckerBtn.Click += new System.EventHandler(this.AT_SpellcheckerBtn_Click);
            // 
            // AT_InfoLabel
            // 
            this.AT_InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AT_InfoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.AT_InfoLabel.Location = new System.Drawing.Point(3, 135);
            this.AT_InfoLabel.Name = "AT_InfoLabel";
            this.AT_InfoLabel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.AT_InfoLabel.Size = new System.Drawing.Size(564, 82);
            this.AT_InfoLabel.TabIndex = 24;
            this.AT_InfoLabel.Text = "";
            // 
            // AT_ReplaceBtn
            // 
            this.AT_ReplaceBtn.Location = new System.Drawing.Point(444, 101);
            this.AT_ReplaceBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AT_ReplaceBtn.Name = "AT_ReplaceBtn";
            this.AT_ReplaceBtn.Size = new System.Drawing.Size(90, 30);
            this.AT_ReplaceBtn.TabIndex = 21;
            this.AT_ReplaceBtn.Text = "Replace";
            this.AT_ReplaceBtn.UseVisualStyleBackColor = true;
            this.AT_ReplaceBtn.Click += new System.EventHandler(this.AT_ReplaceBtn_Click);
            // 
            // AT_AnalyzeBtn
            // 
            this.AT_AnalyzeBtn.Location = new System.Drawing.Point(4, 28);
            this.AT_AnalyzeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AT_AnalyzeBtn.Name = "AT_AnalyzeBtn";
            this.AT_AnalyzeBtn.Size = new System.Drawing.Size(70, 30);
            this.AT_AnalyzeBtn.TabIndex = 20;
            this.AT_AnalyzeBtn.Text = "Analyze";
            this.AT_AnalyzeBtn.UseVisualStyleBackColor = true;
            this.AT_AnalyzeBtn.Click += new System.EventHandler(this.AT_AnalyzeBtn_Click);
            // 
            // AT_TranslateBtn
            // 
            this.AT_TranslateBtn.Location = new System.Drawing.Point(348, 101);
            this.AT_TranslateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AT_TranslateBtn.Name = "AT_TranslateBtn";
            this.AT_TranslateBtn.Size = new System.Drawing.Size(90, 30);
            this.AT_TranslateBtn.TabIndex = 19;
            this.AT_TranslateBtn.Text = "Translate";
            this.AT_TranslateBtn.UseVisualStyleBackColor = true;
            this.AT_TranslateBtn.Click += new System.EventHandler(this.AT_TranslateBtn_Click);
            // 
            // AT_ProgressBar
            // 
            this.AT_ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AT_ProgressBar.InsideMargin = 3;
            this.AT_ProgressBar.LabelWidth = 40;
            this.AT_ProgressBar.Location = new System.Drawing.Point(3, 224);
            this.AT_ProgressBar.Name = "AT_ProgressBar";
            this.AT_ProgressBar.Percent = 0;
            this.AT_ProgressBar.Size = new System.Drawing.Size(565, 40);
            this.AT_ProgressBar.TabIndex = 27;
            // 
            // AT_SummaryLabel
            // 
            this.AT_SummaryLabel.AutoSize = true;
            this.AT_SummaryLabel.Location = new System.Drawing.Point(4, 69);
            this.AT_SummaryLabel.Name = "AT_SummaryLabel";
            this.AT_SummaryLabel.Size = new System.Drawing.Size(38, 20);
            this.AT_SummaryLabel.TabIndex = 28;
            this.AT_SummaryLabel.Text = "Info:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
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
            this.AT_SrcLangCombo.Location = new System.Drawing.Point(328, 30);
            this.AT_SrcLangCombo.Name = "AT_SrcLangCombo";
            this.AT_SrcLangCombo.Size = new System.Drawing.Size(153, 28);
            this.AT_SrcLangCombo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
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
            this.AT_DstLangCombo.Location = new System.Drawing.Point(328, 66);
            this.AT_DstLangCombo.Name = "AT_DstLangCombo";
            this.AT_DstLangCombo.Size = new System.Drawing.Size(153, 28);
            this.AT_DstLangCombo.TabIndex = 18;
            // 
            // AT_SrcLangText
            // 
            this.AT_SrcLangText.Location = new System.Drawing.Point(487, 30);
            this.AT_SrcLangText.Name = "AT_SrcLangText";
            this.AT_SrcLangText.Size = new System.Drawing.Size(47, 27);
            this.AT_SrcLangText.TabIndex = 19;
            // 
            // AT_DstLangText
            // 
            this.AT_DstLangText.Location = new System.Drawing.Point(487, 66);
            this.AT_DstLangText.Name = "AT_DstLangText";
            this.AT_DstLangText.Size = new System.Drawing.Size(47, 27);
            this.AT_DstLangText.TabIndex = 20;
            // 
            // AT_SaveEntriesBtn
            // 
            this.AT_SaveEntriesBtn.Location = new System.Drawing.Point(156, 28);
            this.AT_SaveEntriesBtn.Name = "AT_SaveEntriesBtn";
            this.AT_SaveEntriesBtn.Size = new System.Drawing.Size(70, 30);
            this.AT_SaveEntriesBtn.TabIndex = 29;
            this.AT_SaveEntriesBtn.Text = "Save";
            this.AT_SaveEntriesBtn.UseVisualStyleBackColor = true;
            this.AT_SaveEntriesBtn.Click += new System.EventHandler(this.AT_SaveEntriesBtn_Click);
            // 
            // AT_LoadEntriesBtn
            // 
            this.AT_LoadEntriesBtn.Location = new System.Drawing.Point(80, 28);
            this.AT_LoadEntriesBtn.Name = "AT_LoadEntriesBtn";
            this.AT_LoadEntriesBtn.Size = new System.Drawing.Size(70, 30);
            this.AT_LoadEntriesBtn.TabIndex = 30;
            this.AT_LoadEntriesBtn.Text = "Load";
            this.AT_LoadEntriesBtn.UseVisualStyleBackColor = true;
            this.AT_LoadEntriesBtn.Click += new System.EventHandler(this.AT_LoadEntriesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "ENTRIES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "OPERATIONS";
            // 
            // AutoTranslatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AT_AnalyzeBtn);
            this.Controls.Add(this.AT_LoadEntriesBtn);
            this.Controls.Add(this.AT_SaveEntriesBtn);
            this.Controls.Add(this.AT_DstLangText);
            this.Controls.Add(this.AT_SummaryLabel);
            this.Controls.Add(this.AT_SrcLangText);
            this.Controls.Add(this.AT_ProgressBar);
            this.Controls.Add(this.AT_DstLangCombo);
            this.Controls.Add(this.AT_SpellcheckerBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AT_InfoLabel);
            this.Controls.Add(this.AT_SrcLangCombo);
            this.Controls.Add(this.AT_ReplaceBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AT_TranslateBtn);
            this.Name = "AutoTranslatorView";
            this.Size = new System.Drawing.Size(571, 267);
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
        private System.Windows.Forms.TextBox AT_SrcLangText;
        private System.Windows.Forms.TextBox AT_DstLangText;
        private System.Windows.Forms.Button AT_SaveEntriesBtn;
        private System.Windows.Forms.Button AT_LoadEntriesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
