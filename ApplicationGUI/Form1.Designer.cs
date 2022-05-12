
using System.Windows.Forms;

namespace ApplicationGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DM_RunBtn = new System.Windows.Forms.Button();
            this.DC_ParseBtn = new System.Windows.Forms.Button();
            this.DC_HideCompleted = new System.Windows.Forms.CheckBox();
            this.DC_PrintMissing = new System.Windows.Forms.CheckBox();
            this.DC_InfoLabel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DM_FFmpegPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DC_SaveBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AT_DstLangCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AT_SrcLangCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DC_ProgressBarLbl = new System.Windows.Forms.Label();
            this.DC_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.DC_ItemsLookupPathBtn = new System.Windows.Forms.Button();
            this.DC_ItemsLookupPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DC_ItemsPathBtn = new System.Windows.Forms.Button();
            this.DC_ItemsPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DC_DubbingPathBtn = new System.Windows.Forms.Button();
            this.DC_DubbingPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DC_DialogsPathBtn = new System.Windows.Forms.Button();
            this.DC_DialogsPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DC_OutputPathBtn = new System.Windows.Forms.Button();
            this.DC_OutputPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DC_ParseItemsBtn = new System.Windows.Forms.Button();
            this.DC_ExcelBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AT_SummaryLbl = new System.Windows.Forms.Label();
            this.AT_InfoLabel = new System.Windows.Forms.TextBox();
            this.AT_ProgressBarLbl = new System.Windows.Forms.Label();
            this.AT_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.AT_ReplaceBtn = new System.Windows.Forms.Button();
            this.AT_AnalyzeBtn = new System.Windows.Forms.Button();
            this.AT_TranslateBtn = new System.Windows.Forms.Button();
            this.AT_SpellcheckerBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DM_RunBtn
            // 
            this.DM_RunBtn.Location = new System.Drawing.Point(74, 67);
            this.DM_RunBtn.Name = "DM_RunBtn";
            this.DM_RunBtn.Size = new System.Drawing.Size(94, 29);
            this.DM_RunBtn.TabIndex = 0;
            this.DM_RunBtn.Text = "Run";
            this.DM_RunBtn.UseVisualStyleBackColor = true;
            this.DM_RunBtn.Click += new System.EventHandler(this.DM_RunBtn_Click);
            // 
            // DC_ParseBtn
            // 
            this.DC_ParseBtn.Location = new System.Drawing.Point(19, 125);
            this.DC_ParseBtn.Name = "DC_ParseBtn";
            this.DC_ParseBtn.Size = new System.Drawing.Size(137, 29);
            this.DC_ParseBtn.TabIndex = 1;
            this.DC_ParseBtn.Text = "Parse Dialogs";
            this.DC_ParseBtn.UseVisualStyleBackColor = true;
            this.DC_ParseBtn.Click += new System.EventHandler(this.DC_ParseBtn_Click);
            // 
            // DC_HideCompleted
            // 
            this.DC_HideCompleted.AutoSize = true;
            this.DC_HideCompleted.Location = new System.Drawing.Point(7, 27);
            this.DC_HideCompleted.Name = "DC_HideCompleted";
            this.DC_HideCompleted.Size = new System.Drawing.Size(139, 24);
            this.DC_HideCompleted.TabIndex = 2;
            this.DC_HideCompleted.Text = "Hide completed";
            this.DC_HideCompleted.UseVisualStyleBackColor = true;
            // 
            // DC_PrintMissing
            // 
            this.DC_PrintMissing.AutoSize = true;
            this.DC_PrintMissing.Location = new System.Drawing.Point(7, 57);
            this.DC_PrintMissing.Name = "DC_PrintMissing";
            this.DC_PrintMissing.Size = new System.Drawing.Size(115, 24);
            this.DC_PrintMissing.TabIndex = 3;
            this.DC_PrintMissing.Text = "Print missing";
            this.DC_PrintMissing.UseVisualStyleBackColor = true;
            // 
            // DC_InfoLabel
            // 
            this.DC_InfoLabel.Location = new System.Drawing.Point(6, 242);
            this.DC_InfoLabel.Multiline = true;
            this.DC_InfoLabel.Name = "DC_InfoLabel";
            this.DC_InfoLabel.ReadOnly = true;
            this.DC_InfoLabel.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DC_InfoLabel.Size = new System.Drawing.Size(754, 96);
            this.DC_InfoLabel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DM_FFmpegPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DM_RunBtn);
            this.groupBox1.Location = new System.Drawing.Point(106, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decibels Modulator";
            // 
            // DM_FFmpegPath
            // 
            this.DM_FFmpegPath.Location = new System.Drawing.Point(119, 23);
            this.DM_FFmpegPath.Name = "DM_FFmpegPath";
            this.DM_FFmpegPath.Size = new System.Drawing.Size(125, 27);
            this.DM_FFmpegPath.TabIndex = 2;
            this.DM_FFmpegPath.Text = "ffmpeg.exe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "FFmpeg path:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DC_HideCompleted);
            this.groupBox2.Controls.Add(this.DC_PrintMissing);
            this.groupBox2.Location = new System.Drawing.Point(19, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 87);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Print options";
            // 
            // DC_SaveBtn
            // 
            this.DC_SaveBtn.Enabled = false;
            this.DC_SaveBtn.Location = new System.Drawing.Point(162, 163);
            this.DC_SaveBtn.Name = "DC_SaveBtn";
            this.DC_SaveBtn.Size = new System.Drawing.Size(120, 29);
            this.DC_SaveBtn.TabIndex = 2;
            this.DC_SaveBtn.Text = "Save to files";
            this.DC_SaveBtn.UseVisualStyleBackColor = true;
            this.DC_SaveBtn.Click += new System.EventHandler(this.DC_SaveBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.AT_DstLangCombo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.AT_SrcLangCombo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(21, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 176);
            this.groupBox3.TabIndex = 8;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 419);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(769, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DC_ProgressBarLbl);
            this.tabPage2.Controls.Add(this.DC_ProgressBar);
            this.tabPage2.Controls.Add(this.DC_ItemsLookupPathBtn);
            this.tabPage2.Controls.Add(this.DC_ItemsLookupPath);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.DC_ItemsPathBtn);
            this.tabPage2.Controls.Add(this.DC_ItemsPath);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.DC_DubbingPathBtn);
            this.tabPage2.Controls.Add(this.DC_DubbingPath);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.DC_DialogsPathBtn);
            this.tabPage2.Controls.Add(this.DC_DialogsPath);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.DC_OutputPathBtn);
            this.tabPage2.Controls.Add(this.DC_OutputPath);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.DC_ParseItemsBtn);
            this.tabPage2.Controls.Add(this.DC_ExcelBtn);
            this.tabPage2.Controls.Add(this.DC_SaveBtn);
            this.tabPage2.Controls.Add(this.DC_InfoLabel);
            this.tabPage2.Controls.Add(this.DC_ParseBtn);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(769, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dubbing Checker";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DC_ProgressBarLbl
            // 
            this.DC_ProgressBarLbl.AutoSize = true;
            this.DC_ProgressBarLbl.Location = new System.Drawing.Point(700, 347);
            this.DC_ProgressBarLbl.Name = "DC_ProgressBarLbl";
            this.DC_ProgressBarLbl.Size = new System.Drawing.Size(29, 20);
            this.DC_ProgressBarLbl.TabIndex = 26;
            this.DC_ProgressBarLbl.Text = "0%";
            // 
            // DC_ProgressBar
            // 
            this.DC_ProgressBar.Location = new System.Drawing.Point(6, 347);
            this.DC_ProgressBar.Name = "DC_ProgressBar";
            this.DC_ProgressBar.Size = new System.Drawing.Size(688, 29);
            this.DC_ProgressBar.TabIndex = 25;
            // 
            // DC_ItemsLookupPathBtn
            // 
            this.DC_ItemsLookupPathBtn.Location = new System.Drawing.Point(721, 184);
            this.DC_ItemsLookupPathBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DC_ItemsLookupPathBtn.Name = "DC_ItemsLookupPathBtn";
            this.DC_ItemsLookupPathBtn.Size = new System.Drawing.Size(25, 31);
            this.DC_ItemsLookupPathBtn.TabIndex = 24;
            this.DC_ItemsLookupPathBtn.Text = "O";
            this.DC_ItemsLookupPathBtn.UseVisualStyleBackColor = true;
            this.DC_ItemsLookupPathBtn.Click += new System.EventHandler(this.DC_ItemsLookupPathBtn_Click);
            // 
            // DC_ItemsLookupPath
            // 
            this.DC_ItemsLookupPath.Location = new System.Drawing.Point(411, 184);
            this.DC_ItemsLookupPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DC_ItemsLookupPath.Name = "DC_ItemsLookupPath";
            this.DC_ItemsLookupPath.Size = new System.Drawing.Size(303, 27);
            this.DC_ItemsLookupPath.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Items lookup:";
            // 
            // DC_ItemsPathBtn
            // 
            this.DC_ItemsPathBtn.Location = new System.Drawing.Point(721, 145);
            this.DC_ItemsPathBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DC_ItemsPathBtn.Name = "DC_ItemsPathBtn";
            this.DC_ItemsPathBtn.Size = new System.Drawing.Size(25, 31);
            this.DC_ItemsPathBtn.TabIndex = 21;
            this.DC_ItemsPathBtn.Text = "O";
            this.DC_ItemsPathBtn.UseVisualStyleBackColor = true;
            this.DC_ItemsPathBtn.Click += new System.EventHandler(this.DC_ItemsPathBtn_Click);
            // 
            // DC_ItemsPath
            // 
            this.DC_ItemsPath.Location = new System.Drawing.Point(411, 145);
            this.DC_ItemsPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DC_ItemsPath.Name = "DC_ItemsPath";
            this.DC_ItemsPath.Size = new System.Drawing.Size(303, 27);
            this.DC_ItemsPath.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Items path:";
            // 
            // DC_DubbingPathBtn
            // 
            this.DC_DubbingPathBtn.Location = new System.Drawing.Point(721, 107);
            this.DC_DubbingPathBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DC_DubbingPathBtn.Name = "DC_DubbingPathBtn";
            this.DC_DubbingPathBtn.Size = new System.Drawing.Size(25, 31);
            this.DC_DubbingPathBtn.TabIndex = 18;
            this.DC_DubbingPathBtn.Text = "O";
            this.DC_DubbingPathBtn.UseVisualStyleBackColor = true;
            this.DC_DubbingPathBtn.Click += new System.EventHandler(this.DC_DubbingPathBtn_Click);
            // 
            // DC_DubbingPath
            // 
            this.DC_DubbingPath.Location = new System.Drawing.Point(411, 107);
            this.DC_DubbingPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DC_DubbingPath.Name = "DC_DubbingPath";
            this.DC_DubbingPath.Size = new System.Drawing.Size(303, 27);
            this.DC_DubbingPath.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dubbing path:";
            // 
            // DC_DialogsPathBtn
            // 
            this.DC_DialogsPathBtn.Location = new System.Drawing.Point(721, 68);
            this.DC_DialogsPathBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DC_DialogsPathBtn.Name = "DC_DialogsPathBtn";
            this.DC_DialogsPathBtn.Size = new System.Drawing.Size(25, 31);
            this.DC_DialogsPathBtn.TabIndex = 15;
            this.DC_DialogsPathBtn.Text = "O";
            this.DC_DialogsPathBtn.UseVisualStyleBackColor = true;
            this.DC_DialogsPathBtn.Click += new System.EventHandler(this.DC_DialogsPathBtn_Click);
            // 
            // DC_DialogsPath
            // 
            this.DC_DialogsPath.Location = new System.Drawing.Point(411, 68);
            this.DC_DialogsPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DC_DialogsPath.Name = "DC_DialogsPath";
            this.DC_DialogsPath.Size = new System.Drawing.Size(303, 27);
            this.DC_DialogsPath.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dialogs path:";
            // 
            // DC_OutputPathBtn
            // 
            this.DC_OutputPathBtn.Location = new System.Drawing.Point(721, 29);
            this.DC_OutputPathBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DC_OutputPathBtn.Name = "DC_OutputPathBtn";
            this.DC_OutputPathBtn.Size = new System.Drawing.Size(25, 31);
            this.DC_OutputPathBtn.TabIndex = 12;
            this.DC_OutputPathBtn.Text = "O";
            this.DC_OutputPathBtn.UseVisualStyleBackColor = true;
            this.DC_OutputPathBtn.Click += new System.EventHandler(this.DC_OutputPathBtn_Click);
            // 
            // DC_OutputPath
            // 
            this.DC_OutputPath.Location = new System.Drawing.Point(411, 29);
            this.DC_OutputPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DC_OutputPath.Name = "DC_OutputPath";
            this.DC_OutputPath.Size = new System.Drawing.Size(303, 27);
            this.DC_OutputPath.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Output";
            // 
            // DC_ParseItemsBtn
            // 
            this.DC_ParseItemsBtn.Location = new System.Drawing.Point(162, 124);
            this.DC_ParseItemsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DC_ParseItemsBtn.Name = "DC_ParseItemsBtn";
            this.DC_ParseItemsBtn.Size = new System.Drawing.Size(120, 31);
            this.DC_ParseItemsBtn.TabIndex = 9;
            this.DC_ParseItemsBtn.Text = "Parse Items";
            this.DC_ParseItemsBtn.UseVisualStyleBackColor = true;
            this.DC_ParseItemsBtn.Click += new System.EventHandler(this.DC_ParseItemsBtn_Click);
            // 
            // DC_ExcelBtn
            // 
            this.DC_ExcelBtn.Enabled = false;
            this.DC_ExcelBtn.Location = new System.Drawing.Point(19, 162);
            this.DC_ExcelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DC_ExcelBtn.Name = "DC_ExcelBtn";
            this.DC_ExcelBtn.Size = new System.Drawing.Size(137, 31);
            this.DC_ExcelBtn.TabIndex = 8;
            this.DC_ExcelBtn.Text = "Make Excel";
            this.DC_ExcelBtn.UseVisualStyleBackColor = true;
            this.DC_ExcelBtn.Click += new System.EventHandler(this.DC_ExcelBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.AT_SpellcheckerBtn);
            this.tabPage3.Controls.Add(this.AT_SummaryLbl);
            this.tabPage3.Controls.Add(this.AT_InfoLabel);
            this.tabPage3.Controls.Add(this.AT_ProgressBarLbl);
            this.tabPage3.Controls.Add(this.AT_ProgressBar);
            this.tabPage3.Controls.Add(this.AT_ReplaceBtn);
            this.tabPage3.Controls.Add(this.AT_AnalyzeBtn);
            this.tabPage3.Controls.Add(this.AT_TranslateBtn);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(769, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Auto Translator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AT_SummaryLbl
            // 
            this.AT_SummaryLbl.AutoSize = true;
            this.AT_SummaryLbl.Location = new System.Drawing.Point(333, 207);
            this.AT_SummaryLbl.Name = "AT_SummaryLbl";
            this.AT_SummaryLbl.Size = new System.Drawing.Size(0, 20);
            this.AT_SummaryLbl.TabIndex = 16;
            // 
            // AT_InfoLabel
            // 
            this.AT_InfoLabel.Location = new System.Drawing.Point(21, 240);
            this.AT_InfoLabel.Multiline = true;
            this.AT_InfoLabel.Name = "AT_InfoLabel";
            this.AT_InfoLabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AT_InfoLabel.Size = new System.Drawing.Size(716, 96);
            this.AT_InfoLabel.TabIndex = 15;
            // 
            // AT_ProgressBarLbl
            // 
            this.AT_ProgressBarLbl.AutoSize = true;
            this.AT_ProgressBarLbl.Location = new System.Drawing.Point(708, 342);
            this.AT_ProgressBarLbl.Name = "AT_ProgressBarLbl";
            this.AT_ProgressBarLbl.Size = new System.Drawing.Size(29, 20);
            this.AT_ProgressBarLbl.TabIndex = 14;
            this.AT_ProgressBarLbl.Text = "0%";
            // 
            // AT_ProgressBar
            // 
            this.AT_ProgressBar.Location = new System.Drawing.Point(21, 342);
            this.AT_ProgressBar.Name = "AT_ProgressBar";
            this.AT_ProgressBar.Size = new System.Drawing.Size(681, 29);
            this.AT_ProgressBar.TabIndex = 13;
            // 
            // AT_ReplaceBtn
            // 
            this.AT_ReplaceBtn.Location = new System.Drawing.Point(226, 202);
            this.AT_ReplaceBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AT_ReplaceBtn.Name = "AT_ReplaceBtn";
            this.AT_ReplaceBtn.Size = new System.Drawing.Size(101, 31);
            this.AT_ReplaceBtn.TabIndex = 11;
            this.AT_ReplaceBtn.Text = "Replace";
            this.AT_ReplaceBtn.UseVisualStyleBackColor = true;
            this.AT_ReplaceBtn.Click += new System.EventHandler(this.AT_ReplaceBtn_Click);
            // 
            // AT_AnalyzeBtn
            // 
            this.AT_AnalyzeBtn.Location = new System.Drawing.Point(21, 202);
            this.AT_AnalyzeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AT_AnalyzeBtn.Name = "AT_AnalyzeBtn";
            this.AT_AnalyzeBtn.Size = new System.Drawing.Size(96, 31);
            this.AT_AnalyzeBtn.TabIndex = 10;
            this.AT_AnalyzeBtn.Text = "Analyze";
            this.AT_AnalyzeBtn.UseVisualStyleBackColor = true;
            this.AT_AnalyzeBtn.Click += new System.EventHandler(this.AT_AnalyzeBtn_Click);
            // 
            // AT_TranslateBtn
            // 
            this.AT_TranslateBtn.Location = new System.Drawing.Point(123, 202);
            this.AT_TranslateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AT_TranslateBtn.Name = "AT_TranslateBtn";
            this.AT_TranslateBtn.Size = new System.Drawing.Size(97, 31);
            this.AT_TranslateBtn.TabIndex = 9;
            this.AT_TranslateBtn.Text = "Translate";
            this.AT_TranslateBtn.UseVisualStyleBackColor = true;
            this.AT_TranslateBtn.Click += new System.EventHandler(this.AT_TranslateBtn_Click);
            // 
            // AT_SpellcheckerBtn
            // 
            this.AT_SpellcheckerBtn.Location = new System.Drawing.Point(339, 202);
            this.AT_SpellcheckerBtn.Name = "AT_SpellcheckerBtn";
            this.AT_SpellcheckerBtn.Size = new System.Drawing.Size(100, 29);
            this.AT_SpellcheckerBtn.TabIndex = 17;
            this.AT_SpellcheckerBtn.Text = "Spellcheck";
            this.AT_SpellcheckerBtn.UseVisualStyleBackColor = true;
            this.AT_SpellcheckerBtn.Click += new System.EventHandler(this.AT_SpellcheckerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DM_RunBtn;
        private System.Windows.Forms.Button DC_ParseBtn;
        private System.Windows.Forms.CheckBox DC_HideCompleted;
        private System.Windows.Forms.CheckBox DC_PrintMissing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DM_FFmpegPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DC_SaveBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox DC_InfoLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button DC_ExcelBtn;
        private System.Windows.Forms.Button DC_ItemsPathBtn;
        private System.Windows.Forms.TextBox DC_ItemsPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DC_DubbingPathBtn;
        private System.Windows.Forms.TextBox DC_DubbingPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DC_DialogsPathBtn;
        private System.Windows.Forms.TextBox DC_DialogsPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DC_OutputPathBtn;
        private System.Windows.Forms.TextBox DC_OutputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DC_ParseItemsBtn;
        private System.Windows.Forms.Button DC_ItemsLookupPathBtn;
        private System.Windows.Forms.TextBox DC_ItemsLookupPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AT_AnalyzeBtn;
        private System.Windows.Forms.Button AT_TranslateBtn;
        private System.Windows.Forms.Button AT_ReplaceBtn;
        private System.Windows.Forms.ProgressBar DC_ProgressBar;
        private System.Windows.Forms.Label DC_ProgressBarLbl;
        private System.Windows.Forms.Label AT_ProgressBarLbl;
        private System.Windows.Forms.ProgressBar AT_ProgressBar;
        private System.Windows.Forms.TextBox AT_InfoLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox AT_DstLangCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AT_SrcLangCombo;
        private System.Windows.Forms.Label label7;
        private Label AT_SummaryLbl;
        private Button AT_SpellcheckerBtn;
    }
}

