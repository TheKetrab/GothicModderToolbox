
namespace ApplicationGUI
{
    partial class DubbingCheckerView
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
            this.DC_ParseItemsBtn = new System.Windows.Forms.Button();
            this.DC_ExcelBtn = new System.Windows.Forms.Button();
            this.DC_SaveBtn = new System.Windows.Forms.Button();
            this.DC_InfoLabel = new ApplicationGUI.Controls.ReadOnlyRichTextBox();
            this.DC_ParseBtn = new System.Windows.Forms.Button();
            this.DC_OptionsGroupbox = new System.Windows.Forms.GroupBox();
            this.DC_HideCompleted = new System.Windows.Forms.CheckBox();
            this.DC_PrintMissing = new System.Windows.Forms.CheckBox();
            this.DC_ProgressBar = new ApplicationGUI.Controls.AdvancedProgressBar();
            this.DC_OptionsGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DC_ParseItemsBtn
            // 
            this.DC_ParseItemsBtn.Location = new System.Drawing.Point(246, 38);
            this.DC_ParseItemsBtn.Name = "DC_ParseItemsBtn";
            this.DC_ParseItemsBtn.Size = new System.Drawing.Size(120, 23);
            this.DC_ParseItemsBtn.TabIndex = 33;
            this.DC_ParseItemsBtn.Text = "Parse Items";
            this.DC_ParseItemsBtn.UseVisualStyleBackColor = true;
            this.DC_ParseItemsBtn.Click += new System.EventHandler(this.DC_ParseItemsBtn_Click);
            // 
            // DC_ExcelBtn
            // 
            this.DC_ExcelBtn.Enabled = false;
            this.DC_ExcelBtn.Location = new System.Drawing.Point(371, 10);
            this.DC_ExcelBtn.Name = "DC_ExcelBtn";
            this.DC_ExcelBtn.Size = new System.Drawing.Size(120, 23);
            this.DC_ExcelBtn.TabIndex = 32;
            this.DC_ExcelBtn.Text = "Make Excel";
            this.DC_ExcelBtn.UseVisualStyleBackColor = true;
            this.DC_ExcelBtn.Click += new System.EventHandler(this.DC_ExcelBtn_Click);
            // 
            // DC_SaveBtn
            // 
            this.DC_SaveBtn.Enabled = false;
            this.DC_SaveBtn.Location = new System.Drawing.Point(371, 39);
            this.DC_SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DC_SaveBtn.Name = "DC_SaveBtn";
            this.DC_SaveBtn.Size = new System.Drawing.Size(120, 22);
            this.DC_SaveBtn.TabIndex = 30;
            this.DC_SaveBtn.Text = "Save to files";
            this.DC_SaveBtn.UseVisualStyleBackColor = true;
            this.DC_SaveBtn.Click += new System.EventHandler(this.DC_SaveBtn_Click);
            // 
            // DC_InfoLabel
            // 
            this.DC_InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_InfoLabel.Location = new System.Drawing.Point(3, 72);
            this.DC_InfoLabel.Multiline = true;
            this.DC_InfoLabel.Name = "DC_InfoLabel";
            this.DC_InfoLabel.ReadOnly = true;
            this.DC_InfoLabel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.DC_InfoLabel.Size = new System.Drawing.Size(494, 91);
            this.DC_InfoLabel.TabIndex = 28;
            // 
            // DC_ParseBtn
            // 
            this.DC_ParseBtn.Location = new System.Drawing.Point(246, 10);
            this.DC_ParseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DC_ParseBtn.Name = "DC_ParseBtn";
            this.DC_ParseBtn.Size = new System.Drawing.Size(120, 22);
            this.DC_ParseBtn.TabIndex = 29;
            this.DC_ParseBtn.Text = "Parse Dialogs";
            this.DC_ParseBtn.UseVisualStyleBackColor = true;
            this.DC_ParseBtn.Click += new System.EventHandler(this.DC_ParseBtn_Click);
            // 
            // DC_OptionsGroupbox
            // 
            this.DC_OptionsGroupbox.Controls.Add(this.DC_HideCompleted);
            this.DC_OptionsGroupbox.Controls.Add(this.DC_PrintMissing);
            this.DC_OptionsGroupbox.Location = new System.Drawing.Point(3, 2);
            this.DC_OptionsGroupbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DC_OptionsGroupbox.Name = "DC_OptionsGroupbox";
            this.DC_OptionsGroupbox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DC_OptionsGroupbox.Size = new System.Drawing.Size(230, 65);
            this.DC_OptionsGroupbox.TabIndex = 31;
            this.DC_OptionsGroupbox.TabStop = false;
            this.DC_OptionsGroupbox.Text = "Print options";
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
            // DC_ProgressBar
            // 
            this.DC_ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_ProgressBar.InsideMargin = 5;
            this.DC_ProgressBar.LabelWidth = 40;
            this.DC_ProgressBar.Location = new System.Drawing.Point(3, 168);
            this.DC_ProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DC_ProgressBar.Name = "DC_ProgressBar";
            this.DC_ProgressBar.Percent = 0;
            this.DC_ProgressBar.Size = new System.Drawing.Size(494, 30);
            this.DC_ProgressBar.TabIndex = 34;
            // 
            // DubbingCheckerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DC_ProgressBar);
            this.Controls.Add(this.DC_ParseItemsBtn);
            this.Controls.Add(this.DC_ExcelBtn);
            this.Controls.Add(this.DC_SaveBtn);
            this.Controls.Add(this.DC_InfoLabel);
            this.Controls.Add(this.DC_ParseBtn);
            this.Controls.Add(this.DC_OptionsGroupbox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DubbingCheckerView";
            this.Size = new System.Drawing.Size(500, 200);
            this.DC_OptionsGroupbox.ResumeLayout(false);
            this.DC_OptionsGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DC_ParseItemsBtn;
        private System.Windows.Forms.Button DC_ExcelBtn;
        private System.Windows.Forms.Button DC_SaveBtn;
        private ApplicationGUI.Controls.ReadOnlyRichTextBox DC_InfoLabel;
        private System.Windows.Forms.Button DC_ParseBtn;
        private System.Windows.Forms.GroupBox DC_OptionsGroupbox;
        private System.Windows.Forms.CheckBox DC_HideCompleted;
        private System.Windows.Forms.CheckBox DC_PrintMissing;
        private Controls.AdvancedProgressBar DC_ProgressBar;
    }
}
