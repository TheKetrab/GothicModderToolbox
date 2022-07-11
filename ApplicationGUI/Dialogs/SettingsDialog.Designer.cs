
namespace ApplicationGUI.Dialogs
{
    partial class SettingsDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingsApplyBtn = new System.Windows.Forms.Button();
            this.settingsResetBtn = new System.Windows.Forms.Button();
            this.settingsCancelBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.settingsDCtabPage = new System.Windows.Forms.TabPage();
            this.settingsATtabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsApplyBtn
            // 
            this.settingsApplyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsApplyBtn.Location = new System.Drawing.Point(415, 282);
            this.settingsApplyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsApplyBtn.Name = "settingsApplyBtn";
            this.settingsApplyBtn.Size = new System.Drawing.Size(82, 22);
            this.settingsApplyBtn.TabIndex = 0;
            this.settingsApplyBtn.Text = "Apply";
            this.settingsApplyBtn.UseVisualStyleBackColor = true;
            this.settingsApplyBtn.Click += new System.EventHandler(this.settingsApplyBtn_Click);
            // 
            // settingsResetBtn
            // 
            this.settingsResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsResetBtn.Location = new System.Drawing.Point(327, 282);
            this.settingsResetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsResetBtn.Name = "settingsResetBtn";
            this.settingsResetBtn.Size = new System.Drawing.Size(82, 22);
            this.settingsResetBtn.TabIndex = 1;
            this.settingsResetBtn.Text = "Reset";
            this.settingsResetBtn.UseVisualStyleBackColor = true;
            this.settingsResetBtn.Click += new System.EventHandler(this.settingsResetBtn_Click);
            // 
            // settingsCancelBtn
            // 
            this.settingsCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsCancelBtn.Location = new System.Drawing.Point(240, 282);
            this.settingsCancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsCancelBtn.Name = "settingsCancelBtn";
            this.settingsCancelBtn.Size = new System.Drawing.Size(82, 22);
            this.settingsCancelBtn.TabIndex = 2;
            this.settingsCancelBtn.Text = "Cancel";
            this.settingsCancelBtn.UseVisualStyleBackColor = true;
            this.settingsCancelBtn.Click += new System.EventHandler(this.settingsCancelBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.settingsDCtabPage);
            this.tabControl1.Controls.Add(this.settingsATtabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 278);
            this.tabControl1.TabIndex = 3;
            // 
            // settingsDCtabPage
            // 
            this.settingsDCtabPage.Location = new System.Drawing.Point(4, 24);
            this.settingsDCtabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsDCtabPage.Name = "settingsDCtabPage";
            this.settingsDCtabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsDCtabPage.Size = new System.Drawing.Size(500, 250);
            this.settingsDCtabPage.TabIndex = 0;
            this.settingsDCtabPage.Text = "Dubbing Checker";
            this.settingsDCtabPage.UseVisualStyleBackColor = true;
            // 
            // settingsATtabPage
            // 
            this.settingsATtabPage.Location = new System.Drawing.Point(4, 24);
            this.settingsATtabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsATtabPage.Name = "settingsATtabPage";
            this.settingsATtabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsATtabPage.Size = new System.Drawing.Size(500, 201);
            this.settingsATtabPage.TabIndex = 1;
            this.settingsATtabPage.Text = "Auto Translator";
            this.settingsATtabPage.UseVisualStyleBackColor = true;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 313);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.settingsCancelBtn);
            this.Controls.Add(this.settingsResetBtn);
            this.Controls.Add(this.settingsApplyBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(352, 235);
            this.Name = "SettingsDialog";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingsApplyBtn;
        private System.Windows.Forms.Button settingsResetBtn;
        private System.Windows.Forms.Button settingsCancelBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage settingsDCtabPage;
        private System.Windows.Forms.TabPage settingsATtabPage;
    }
}