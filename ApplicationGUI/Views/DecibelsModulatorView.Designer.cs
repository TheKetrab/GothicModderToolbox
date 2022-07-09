
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DM_FFmpegPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DM_RunBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DM_FFmpegPath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DM_RunBtn);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 119);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decibels Modulator";
            // 
            // DM_FFmpegPath
            // 
            this.DM_FFmpegPath.Location = new System.Drawing.Point(119, 23);
            this.DM_FFmpegPath.Name = "DM_FFmpegPath";
            this.DM_FFmpegPath.Size = new System.Drawing.Size(125, 27);
            this.DM_FFmpegPath.TabIndex = 2;
            this.DM_FFmpegPath.Text = "ffmpeg.exe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "FFmpeg path:";
            // 
            // DM_RunBtn
            // 
            this.DM_RunBtn.Location = new System.Drawing.Point(74, 67);
            this.DM_RunBtn.Name = "DM_RunBtn";
            this.DM_RunBtn.Size = new System.Drawing.Size(94, 29);
            this.DM_RunBtn.TabIndex = 0;
            this.DM_RunBtn.Text = "Run";
            this.DM_RunBtn.UseVisualStyleBackColor = true;
            // 
            // DecibelsModulatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "DecibelsModulatorView";
            this.Size = new System.Drawing.Size(421, 226);
            this.Load += new System.EventHandler(this.DecibelsModulatorView_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DM_FFmpegPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DM_RunBtn;
    }
}
