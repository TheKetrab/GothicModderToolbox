﻿
using System.Drawing;

namespace ApplicationGUI
{
    partial class DecibelsModulatorView
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
            this.DM_AdvancedProgressBar = new ApplicationGUI.Controls.AdvancedProgressBar();
            this.DM_InfoLabel = new ApplicationGUI.Controls.ReadOnlyRichTextBox();
            this.DM_IncVolumeMaxRadioBtn = new System.Windows.Forms.RadioButton();
            this.DM_IncVolumeDbRadioBtn = new System.Windows.Forms.RadioButton();
            this.DM_IncVolumeSlider = new System.Windows.Forms.TrackBar();
            this.DM_IncVolumeLbl = new System.Windows.Forms.Label();
            this.DM_IncVolumeBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DM_WavBtn = new System.Windows.Forms.Button();
            this.DM_Mp3Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DM_IncVolumeSlider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DM_AdvancedProgressBar
            // 
            this.DM_AdvancedProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DM_AdvancedProgressBar.InsideMargin = 3;
            this.DM_AdvancedProgressBar.LabelWidth = 40;
            this.DM_AdvancedProgressBar.Location = new System.Drawing.Point(3, 168);
            this.DM_AdvancedProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DM_AdvancedProgressBar.Name = "DM_AdvancedProgressBar";
            this.DM_AdvancedProgressBar.Percent = 0;
            this.DM_AdvancedProgressBar.Size = new System.Drawing.Size(494, 30);
            this.DM_AdvancedProgressBar.TabIndex = 29;
            // 
            // DM_InfoLabel
            // 
            this.DM_InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DM_InfoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DM_InfoLabel.Location = new System.Drawing.Point(3, 81);
            this.DM_InfoLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DM_InfoLabel.Name = "DM_InfoLabel";
            this.DM_InfoLabel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.DM_InfoLabel.Size = new System.Drawing.Size(494, 83);
            this.DM_InfoLabel.TabIndex = 28;
            this.DM_InfoLabel.Text = "";
            // 
            // DM_IncVolumeMaxRadioBtn
            // 
            this.DM_IncVolumeMaxRadioBtn.AutoSize = true;
            this.DM_IncVolumeMaxRadioBtn.Checked = true;
            this.DM_IncVolumeMaxRadioBtn.Location = new System.Drawing.Point(3, 3);
            this.DM_IncVolumeMaxRadioBtn.Name = "DM_IncVolumeMaxRadioBtn";
            this.DM_IncVolumeMaxRadioBtn.Size = new System.Drawing.Size(137, 19);
            this.DM_IncVolumeMaxRadioBtn.TabIndex = 30;
            this.DM_IncVolumeMaxRadioBtn.TabStop = true;
            this.DM_IncVolumeMaxRadioBtn.Text = "Increase volume Max";
            this.DM_IncVolumeMaxRadioBtn.UseVisualStyleBackColor = true;
            // 
            // DM_IncVolumeDbRadioBtn
            // 
            this.DM_IncVolumeDbRadioBtn.AutoSize = true;
            this.DM_IncVolumeDbRadioBtn.Location = new System.Drawing.Point(3, 28);
            this.DM_IncVolumeDbRadioBtn.Name = "DM_IncVolumeDbRadioBtn";
            this.DM_IncVolumeDbRadioBtn.Size = new System.Drawing.Size(111, 19);
            this.DM_IncVolumeDbRadioBtn.TabIndex = 31;
            this.DM_IncVolumeDbRadioBtn.Text = "Increase volume";
            this.DM_IncVolumeDbRadioBtn.UseVisualStyleBackColor = true;
            // 
            // DM_IncVolumeSlider
            // 
            this.DM_IncVolumeSlider.BackColor = System.Drawing.Color.White;
            this.DM_IncVolumeSlider.Location = new System.Drawing.Point(120, 28);
            this.DM_IncVolumeSlider.Name = "DM_IncVolumeSlider";
            this.DM_IncVolumeSlider.Size = new System.Drawing.Size(104, 45);
            this.DM_IncVolumeSlider.TabIndex = 32;
            // 
            // DM_IncVolumeLbl
            // 
            this.DM_IncVolumeLbl.AutoSize = true;
            this.DM_IncVolumeLbl.Location = new System.Drawing.Point(230, 32);
            this.DM_IncVolumeLbl.Name = "DM_IncVolumeLbl";
            this.DM_IncVolumeLbl.Size = new System.Drawing.Size(38, 15);
            this.DM_IncVolumeLbl.TabIndex = 33;
            this.DM_IncVolumeLbl.Text = "label1";
            this.DM_IncVolumeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DM_IncVolumeBtn
            // 
            this.DM_IncVolumeBtn.Location = new System.Drawing.Point(3, 53);
            this.DM_IncVolumeBtn.Name = "DM_IncVolumeBtn";
            this.DM_IncVolumeBtn.Size = new System.Drawing.Size(75, 23);
            this.DM_IncVolumeBtn.TabIndex = 37;
            this.DM_IncVolumeBtn.Text = "Start";
            this.DM_IncVolumeBtn.UseVisualStyleBackColor = true;
            this.DM_IncVolumeBtn.Click += new System.EventHandler(this.DM_IncVolumeBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DM_WavBtn);
            this.groupBox1.Controls.Add(this.DM_Mp3Btn);
            this.groupBox1.Location = new System.Drawing.Point(301, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 67);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion";
            // 
            // DM_WavBtn
            // 
            this.DM_WavBtn.Location = new System.Drawing.Point(97, 26);
            this.DM_WavBtn.Name = "DM_WavBtn";
            this.DM_WavBtn.Size = new System.Drawing.Size(75, 23);
            this.DM_WavBtn.TabIndex = 1;
            this.DM_WavBtn.Text = "To wav";
            this.DM_WavBtn.UseVisualStyleBackColor = true;
            this.DM_WavBtn.Click += new System.EventHandler(this.DM_WavBtn_Click);
            // 
            // DM_Mp3Btn
            // 
            this.DM_Mp3Btn.Location = new System.Drawing.Point(16, 26);
            this.DM_Mp3Btn.Name = "DM_Mp3Btn";
            this.DM_Mp3Btn.Size = new System.Drawing.Size(75, 23);
            this.DM_Mp3Btn.TabIndex = 0;
            this.DM_Mp3Btn.Text = "To mp3";
            this.DM_Mp3Btn.UseVisualStyleBackColor = true;
            this.DM_Mp3Btn.Click += new System.EventHandler(this.DM_Mp3Btn_Click);
            // 
            // DecibelsModulatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DM_IncVolumeBtn);
            this.Controls.Add(this.DM_IncVolumeLbl);
            this.Controls.Add(this.DM_IncVolumeSlider);
            this.Controls.Add(this.DM_IncVolumeDbRadioBtn);
            this.Controls.Add(this.DM_IncVolumeMaxRadioBtn);
            this.Controls.Add(this.DM_AdvancedProgressBar);
            this.Controls.Add(this.DM_InfoLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DecibelsModulatorView";
            this.Size = new System.Drawing.Size(500, 200);
            ((System.ComponentModel.ISupportInitialize)(this.DM_IncVolumeSlider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton DM_IncVolumeMaxRadioBtn;
        private System.Windows.Forms.RadioButton DM_IncVolumeDbRadioBtn;
        private System.Windows.Forms.TrackBar DM_IncVolumeSlider;
        private System.Windows.Forms.Label DM_IncVolumeLbl;
        private System.Windows.Forms.Button DM_IncVolumeBtn;
        private ApplicationGUI.Controls.ReadOnlyRichTextBox DM_InfoLabel;
        private ApplicationGUI.Controls.AdvancedProgressBar DM_AdvancedProgressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DM_WavBtn;
        private System.Windows.Forms.Button DM_Mp3Btn;
    }
}
