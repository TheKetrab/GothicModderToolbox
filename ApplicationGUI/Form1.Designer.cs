
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
            this.InfoLabel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DM_FFmpegPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DC_SaveBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.AT_ReplaceBtn = new System.Windows.Forms.Button();
            this.AT_AnalyzeBtn = new System.Windows.Forms.Button();
            this.AT_TranslateBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DM_RunBtn
            // 
            this.DM_RunBtn.Location = new System.Drawing.Point(65, 50);
            this.DM_RunBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DM_RunBtn.Name = "DM_RunBtn";
            this.DM_RunBtn.Size = new System.Drawing.Size(82, 22);
            this.DM_RunBtn.TabIndex = 0;
            this.DM_RunBtn.Text = "Run";
            this.DM_RunBtn.UseVisualStyleBackColor = true;
            this.DM_RunBtn.Click += new System.EventHandler(this.DM_RunBtn_Click);
            // 
            // DC_ParseBtn
            // 
            this.DC_ParseBtn.Location = new System.Drawing.Point(17, 110);
            this.DC_ParseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DC_ParseBtn.Name = "DC_ParseBtn";
            this.DC_ParseBtn.Size = new System.Drawing.Size(92, 22);
            this.DC_ParseBtn.TabIndex = 1;
            this.DC_ParseBtn.Text = "Parse Dialogs";
            this.DC_ParseBtn.UseVisualStyleBackColor = true;
            this.DC_ParseBtn.Click += new System.EventHandler(this.DC_ParseBtn_Click);
            // 
            // DC_HideCompleted
            // 
            this.DC_HideCompleted.AutoSize = true;
            this.DC_HideCompleted.Location = new System.Drawing.Point(6, 20);
            this.DC_HideCompleted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DC_HideCompleted.Name = "DC_HideCompleted";
            this.DC_HideCompleted.Size = new System.Drawing.Size(111, 19);
            this.DC_HideCompleted.TabIndex = 2;
            this.DC_HideCompleted.Text = "Hide completed";
            this.DC_HideCompleted.UseVisualStyleBackColor = true;
            // 
            // DC_PrintMissing
            // 
            this.DC_PrintMissing.AutoSize = true;
            this.DC_PrintMissing.Location = new System.Drawing.Point(6, 43);
            this.DC_PrintMissing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DC_PrintMissing.Name = "DC_PrintMissing";
            this.DC_PrintMissing.Size = new System.Drawing.Size(95, 19);
            this.DC_PrintMissing.TabIndex = 3;
            this.DC_PrintMissing.Text = "Print missing";
            this.DC_PrintMissing.UseVisualStyleBackColor = true;
            // 
            // InfoLabel
            // 
            this.InfoLabel.Location = new System.Drawing.Point(6, 193);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoLabel.Multiline = true;
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.ReadOnly = true;
            this.InfoLabel.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InfoLabel.Size = new System.Drawing.Size(660, 73);
            this.InfoLabel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DM_FFmpegPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DM_RunBtn);
            this.groupBox1.Location = new System.Drawing.Point(93, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(219, 89);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decibels Modulator";
            // 
            // DM_FFmpegPath
            // 
            this.DM_FFmpegPath.Location = new System.Drawing.Point(104, 17);
            this.DM_FFmpegPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DM_FFmpegPath.Name = "DM_FFmpegPath";
            this.DM_FFmpegPath.Size = new System.Drawing.Size(110, 23);
            this.DM_FFmpegPath.TabIndex = 2;
            this.DM_FFmpegPath.Text = "ffmpeg.exe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "FFmpeg path:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DC_HideCompleted);
            this.groupBox2.Controls.Add(this.DC_PrintMissing);
            this.groupBox2.Location = new System.Drawing.Point(17, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(200, 65);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Print options";
            // 
            // DC_SaveBtn
            // 
            this.DC_SaveBtn.Enabled = false;
            this.DC_SaveBtn.Location = new System.Drawing.Point(108, 154);
            this.DC_SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DC_SaveBtn.Name = "DC_SaveBtn";
            this.DC_SaveBtn.Size = new System.Drawing.Size(82, 22);
            this.DC_SaveBtn.TabIndex = 2;
            this.DC_SaveBtn.Text = "Save to files";
            this.DC_SaveBtn.UseVisualStyleBackColor = true;
            this.DC_SaveBtn.Click += new System.EventHandler(this.DC_SaveBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(185, 21);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(219, 94);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Autotranslator";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 314);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
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
            this.tabPage2.Controls.Add(this.InfoLabel);
            this.tabPage2.Controls.Add(this.DC_ParseBtn);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dubbing Checker";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DC_ItemsLookupPathBtn
            // 
            this.DC_ItemsLookupPathBtn.Location = new System.Drawing.Point(631, 138);
            this.DC_ItemsLookupPathBtn.Name = "DC_ItemsLookupPathBtn";
            this.DC_ItemsLookupPathBtn.Size = new System.Drawing.Size(22, 23);
            this.DC_ItemsLookupPathBtn.TabIndex = 24;
            this.DC_ItemsLookupPathBtn.Text = "O";
            this.DC_ItemsLookupPathBtn.UseVisualStyleBackColor = true;
            this.DC_ItemsLookupPathBtn.Click += new System.EventHandler(this.DC_ItemsLookupPathBtn_Click);
            // 
            // DC_ItemsLookupPath
            // 
            this.DC_ItemsLookupPath.Location = new System.Drawing.Point(344, 138);
            this.DC_ItemsLookupPath.Name = "DC_ItemsLookupPath";
            this.DC_ItemsLookupPath.Size = new System.Drawing.Size(281, 23);
            this.DC_ItemsLookupPath.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Items lookup:";
            // 
            // DC_ItemsPathBtn
            // 
            this.DC_ItemsPathBtn.Location = new System.Drawing.Point(631, 109);
            this.DC_ItemsPathBtn.Name = "DC_ItemsPathBtn";
            this.DC_ItemsPathBtn.Size = new System.Drawing.Size(22, 23);
            this.DC_ItemsPathBtn.TabIndex = 21;
            this.DC_ItemsPathBtn.Text = "O";
            this.DC_ItemsPathBtn.UseVisualStyleBackColor = true;
            this.DC_ItemsPathBtn.Click += new System.EventHandler(this.DC_ItemsPathBtn_Click);
            // 
            // DC_ItemsPath
            // 
            this.DC_ItemsPath.Location = new System.Drawing.Point(344, 109);
            this.DC_ItemsPath.Name = "DC_ItemsPath";
            this.DC_ItemsPath.Size = new System.Drawing.Size(281, 23);
            this.DC_ItemsPath.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Items path:";
            // 
            // DC_DubbingPathBtn
            // 
            this.DC_DubbingPathBtn.Location = new System.Drawing.Point(631, 80);
            this.DC_DubbingPathBtn.Name = "DC_DubbingPathBtn";
            this.DC_DubbingPathBtn.Size = new System.Drawing.Size(22, 23);
            this.DC_DubbingPathBtn.TabIndex = 18;
            this.DC_DubbingPathBtn.Text = "O";
            this.DC_DubbingPathBtn.UseVisualStyleBackColor = true;
            this.DC_DubbingPathBtn.Click += new System.EventHandler(this.DC_DubbingPathBtn_Click);
            // 
            // DC_DubbingPath
            // 
            this.DC_DubbingPath.Location = new System.Drawing.Point(344, 80);
            this.DC_DubbingPath.Name = "DC_DubbingPath";
            this.DC_DubbingPath.Size = new System.Drawing.Size(281, 23);
            this.DC_DubbingPath.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dubbing path:";
            // 
            // DC_DialogsPathBtn
            // 
            this.DC_DialogsPathBtn.Location = new System.Drawing.Point(631, 51);
            this.DC_DialogsPathBtn.Name = "DC_DialogsPathBtn";
            this.DC_DialogsPathBtn.Size = new System.Drawing.Size(22, 23);
            this.DC_DialogsPathBtn.TabIndex = 15;
            this.DC_DialogsPathBtn.Text = "O";
            this.DC_DialogsPathBtn.UseVisualStyleBackColor = true;
            this.DC_DialogsPathBtn.Click += new System.EventHandler(this.DC_DialogsPathBtn_Click);
            // 
            // DC_DialogsPath
            // 
            this.DC_DialogsPath.Location = new System.Drawing.Point(344, 51);
            this.DC_DialogsPath.Name = "DC_DialogsPath";
            this.DC_DialogsPath.Size = new System.Drawing.Size(281, 23);
            this.DC_DialogsPath.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dialogs path:";
            // 
            // DC_OutputPathBtn
            // 
            this.DC_OutputPathBtn.Location = new System.Drawing.Point(631, 22);
            this.DC_OutputPathBtn.Name = "DC_OutputPathBtn";
            this.DC_OutputPathBtn.Size = new System.Drawing.Size(22, 23);
            this.DC_OutputPathBtn.TabIndex = 12;
            this.DC_OutputPathBtn.Text = "O";
            this.DC_OutputPathBtn.UseVisualStyleBackColor = true;
            this.DC_OutputPathBtn.Click += new System.EventHandler(this.DC_OutputPathBtn_Click);
            // 
            // DC_OutputPath
            // 
            this.DC_OutputPath.Location = new System.Drawing.Point(344, 22);
            this.DC_OutputPath.Name = "DC_OutputPath";
            this.DC_OutputPath.Size = new System.Drawing.Size(281, 23);
            this.DC_OutputPath.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Output";
            // 
            // DC_ParseItemsBtn
            // 
            this.DC_ParseItemsBtn.Location = new System.Drawing.Point(115, 109);
            this.DC_ParseItemsBtn.Name = "DC_ParseItemsBtn";
            this.DC_ParseItemsBtn.Size = new System.Drawing.Size(75, 23);
            this.DC_ParseItemsBtn.TabIndex = 9;
            this.DC_ParseItemsBtn.Text = "Parse Items";
            this.DC_ParseItemsBtn.UseVisualStyleBackColor = true;
            this.DC_ParseItemsBtn.Click += new System.EventHandler(this.DC_ParseItemsBtn_Click);
            // 
            // DC_ExcelBtn
            // 
            this.DC_ExcelBtn.Enabled = false;
            this.DC_ExcelBtn.Location = new System.Drawing.Point(17, 154);
            this.DC_ExcelBtn.Name = "DC_ExcelBtn";
            this.DC_ExcelBtn.Size = new System.Drawing.Size(82, 23);
            this.DC_ExcelBtn.TabIndex = 8;
            this.DC_ExcelBtn.Text = "Make Excel";
            this.DC_ExcelBtn.UseVisualStyleBackColor = true;
            this.DC_ExcelBtn.Click += new System.EventHandler(this.DC_ExcelBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.AT_ReplaceBtn);
            this.tabPage3.Controls.Add(this.AT_AnalyzeBtn);
            this.tabPage3.Controls.Add(this.AT_TranslateBtn);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(672, 286);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AT_ReplaceBtn
            // 
            this.AT_ReplaceBtn.Location = new System.Drawing.Point(219, 187);
            this.AT_ReplaceBtn.Name = "AT_ReplaceBtn";
            this.AT_ReplaceBtn.Size = new System.Drawing.Size(75, 23);
            this.AT_ReplaceBtn.TabIndex = 11;
            this.AT_ReplaceBtn.Text = "Replace";
            this.AT_ReplaceBtn.UseVisualStyleBackColor = true;
            // 
            // AT_AnalyzeBtn
            // 
            this.AT_AnalyzeBtn.Location = new System.Drawing.Point(219, 129);
            this.AT_AnalyzeBtn.Name = "AT_AnalyzeBtn";
            this.AT_AnalyzeBtn.Size = new System.Drawing.Size(75, 23);
            this.AT_AnalyzeBtn.TabIndex = 10;
            this.AT_AnalyzeBtn.Text = "Analyze";
            this.AT_AnalyzeBtn.UseVisualStyleBackColor = true;
            this.AT_AnalyzeBtn.Click += new System.EventHandler(this.AT_AnalyzeBtn_Click);
            // 
            // AT_TranslateBtn
            // 
            this.AT_TranslateBtn.Location = new System.Drawing.Point(219, 158);
            this.AT_TranslateBtn.Name = "AT_TranslateBtn";
            this.AT_TranslateBtn.Size = new System.Drawing.Size(75, 23);
            this.AT_TranslateBtn.TabIndex = 9;
            this.AT_TranslateBtn.Text = "Translate";
            this.AT_TranslateBtn.UseVisualStyleBackColor = true;
            this.AT_TranslateBtn.Click += new System.EventHandler(this.AT_TranslateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox InfoLabel;
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
    }
}

