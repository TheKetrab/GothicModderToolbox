﻿
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
            this.AT_SummaryLbl = new System.Windows.Forms.Label();
            this.AT_InfoLabel = new System.Windows.Forms.TextBox();
            this.AT_ReplaceBtn = new System.Windows.Forms.Button();
            this.AT_AnalyzeBtn = new System.Windows.Forms.Button();
            this.AT_TranslateBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AT_DstLangCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AT_SrcLangCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AT_ProgressBar = new ApplicationGUI.Controls.AdvancedProgressBar();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AT_SpellcheckerBtn
            // 
            this.AT_SpellcheckerBtn.Location = new System.Drawing.Point(321, 186);
            this.AT_SpellcheckerBtn.Name = "AT_SpellcheckerBtn";
            this.AT_SpellcheckerBtn.Size = new System.Drawing.Size(100, 29);
            this.AT_SpellcheckerBtn.TabIndex = 26;
            this.AT_SpellcheckerBtn.Text = "Spellcheck";
            this.AT_SpellcheckerBtn.UseVisualStyleBackColor = true;
            this.AT_SpellcheckerBtn.Click += new System.EventHandler(this.AT_SpellcheckerBtn_Click);
            // 
            // AT_SummaryLbl
            // 
            this.AT_SummaryLbl.AutoSize = true;
            this.AT_SummaryLbl.Location = new System.Drawing.Point(315, 191);
            this.AT_SummaryLbl.Name = "AT_SummaryLbl";
            this.AT_SummaryLbl.Size = new System.Drawing.Size(0, 20);
            this.AT_SummaryLbl.TabIndex = 25;
            // 
            // AT_InfoLabel
            // 
            this.AT_InfoLabel.Location = new System.Drawing.Point(3, 224);
            this.AT_InfoLabel.Multiline = true;
            this.AT_InfoLabel.Name = "AT_InfoLabel";
            this.AT_InfoLabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AT_InfoLabel.Size = new System.Drawing.Size(716, 96);
            this.AT_InfoLabel.TabIndex = 24;
            // 
            // AT_ReplaceBtn
            // 
            this.AT_ReplaceBtn.Location = new System.Drawing.Point(208, 186);
            this.AT_ReplaceBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AT_ReplaceBtn.Name = "AT_ReplaceBtn";
            this.AT_ReplaceBtn.Size = new System.Drawing.Size(101, 31);
            this.AT_ReplaceBtn.TabIndex = 21;
            this.AT_ReplaceBtn.Text = "Replace";
            this.AT_ReplaceBtn.UseVisualStyleBackColor = true;
            this.AT_ReplaceBtn.Click += new System.EventHandler(this.AT_ReplaceBtn_Click);
            // 
            // AT_AnalyzeBtn
            // 
            this.AT_AnalyzeBtn.Location = new System.Drawing.Point(3, 186);
            this.AT_AnalyzeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AT_AnalyzeBtn.Name = "AT_AnalyzeBtn";
            this.AT_AnalyzeBtn.Size = new System.Drawing.Size(96, 31);
            this.AT_AnalyzeBtn.TabIndex = 20;
            this.AT_AnalyzeBtn.Text = "Analyze";
            this.AT_AnalyzeBtn.UseVisualStyleBackColor = true;
            this.AT_AnalyzeBtn.Click += new System.EventHandler(this.AT_AnalyzeBtn_Click);
            // 
            // AT_TranslateBtn
            // 
            this.AT_TranslateBtn.Location = new System.Drawing.Point(105, 186);
            this.AT_TranslateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AT_TranslateBtn.Name = "AT_TranslateBtn";
            this.AT_TranslateBtn.Size = new System.Drawing.Size(97, 31);
            this.AT_TranslateBtn.TabIndex = 19;
            this.AT_TranslateBtn.Text = "Translate";
            this.AT_TranslateBtn.UseVisualStyleBackColor = true;
            this.AT_TranslateBtn.Click += new System.EventHandler(this.AT_TranslateBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.AT_DstLangCombo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.AT_SrcLangCombo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 176);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Autotranslator";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 27);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 27);
            this.textBox1.TabIndex = 19;
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
            this.AT_DstLangCombo.Location = new System.Drawing.Point(26, 132);
            this.AT_DstLangCombo.Name = "AT_DstLangCombo";
            this.AT_DstLangCombo.Size = new System.Drawing.Size(151, 28);
            this.AT_DstLangCombo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Target Language";
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
            this.AT_SrcLangCombo.Location = new System.Drawing.Point(28, 63);
            this.AT_SrcLangCombo.Name = "AT_SrcLangCombo";
            this.AT_SrcLangCombo.Size = new System.Drawing.Size(151, 28);
            this.AT_SrcLangCombo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Source Language:";
            // 
            // AT_ProgressBar
            // 
            this.AT_ProgressBar.LabelWidth = 40;
            this.AT_ProgressBar.Location = new System.Drawing.Point(3, 326);
            this.AT_ProgressBar.Name = "AT_ProgressBar";
            this.AT_ProgressBar.Percent = 0;
            this.AT_ProgressBar.Size = new System.Drawing.Size(716, 45);
            this.AT_ProgressBar.TabIndex = 27;
            // 
            // AutoTranslatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AT_ProgressBar);
            this.Controls.Add(this.AT_SpellcheckerBtn);
            this.Controls.Add(this.AT_SummaryLbl);
            this.Controls.Add(this.AT_InfoLabel);
            this.Controls.Add(this.AT_ReplaceBtn);
            this.Controls.Add(this.AT_AnalyzeBtn);
            this.Controls.Add(this.AT_TranslateBtn);
            this.Controls.Add(this.groupBox3);
            this.Name = "AutoTranslatorView";
            this.Size = new System.Drawing.Size(722, 428);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AT_SpellcheckerBtn;
        private System.Windows.Forms.Label AT_SummaryLbl;
        private System.Windows.Forms.TextBox AT_InfoLabel;
        private System.Windows.Forms.Button AT_ReplaceBtn;
        private System.Windows.Forms.Button AT_AnalyzeBtn;
        private System.Windows.Forms.Button AT_TranslateBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox AT_DstLangCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AT_SrcLangCombo;
        private System.Windows.Forms.Label label7;
        private Controls.AdvancedProgressBar AT_ProgressBar;
    }
}
