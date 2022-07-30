
namespace ApplicationGUI.Views
{
    partial class SettingsDubbingCheckerView
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
            this.itemsLookupPath = new ApplicationGUI.Controls.AdvancedPathField();
            this.itemsPath = new ApplicationGUI.Controls.AdvancedPathField();
            this.dubbingPath = new ApplicationGUI.Controls.AdvancedPathField();
            this.dialogsPath = new ApplicationGUI.Controls.AdvancedPathField();
            this.outputPath = new ApplicationGUI.Controls.AdvancedPathField();
            this.SuspendLayout();
            // 
            // itemsLookupPath
            // 
            this.itemsLookupPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsLookupPath.Label = "Items lookup:";
            this.itemsLookupPath.LabelWidth = 120;
            this.itemsLookupPath.Location = new System.Drawing.Point(3, 167);
            this.itemsLookupPath.Name = "itemsLookupPath";
            this.itemsLookupPath.Path = null;
            this.itemsLookupPath.Size = new System.Drawing.Size(565, 35);
            this.itemsLookupPath.TabIndex = 64;
            // 
            // itemsPath
            // 
            this.itemsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsPath.Label = "Items path:";
            this.itemsPath.LabelWidth = 120;
            this.itemsPath.Location = new System.Drawing.Point(3, 125);
            this.itemsPath.Name = "itemsPath";
            this.itemsPath.Path = null;
            this.itemsPath.Size = new System.Drawing.Size(565, 35);
            this.itemsPath.TabIndex = 63;
            // 
            // dubbingPath
            // 
            this.dubbingPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dubbingPath.Label = "Dubbing path:";
            this.dubbingPath.LabelWidth = 120;
            this.dubbingPath.Location = new System.Drawing.Point(3, 85);
            this.dubbingPath.Name = "dubbingPath";
            this.dubbingPath.Path = null;
            this.dubbingPath.Size = new System.Drawing.Size(565, 35);
            this.dubbingPath.TabIndex = 62;
            // 
            // dialogsPath
            // 
            this.dialogsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogsPath.Label = "Dialogs path:";
            this.dialogsPath.LabelWidth = 120;
            this.dialogsPath.Location = new System.Drawing.Point(3, 44);
            this.dialogsPath.Name = "dialogsPath";
            this.dialogsPath.Path = null;
            this.dialogsPath.Size = new System.Drawing.Size(565, 35);
            this.dialogsPath.TabIndex = 61;
            // 
            // outputPath
            // 
            this.outputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputPath.Label = "Output:";
            this.outputPath.LabelWidth = 120;
            this.outputPath.Location = new System.Drawing.Point(3, 3);
            this.outputPath.Name = "outputPath";
            this.outputPath.Path = null;
            this.outputPath.Size = new System.Drawing.Size(565, 35);
            this.outputPath.TabIndex = 60;
            // 
            // SettingsDubbingCheckerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemsLookupPath);
            this.Controls.Add(this.itemsPath);
            this.Controls.Add(this.dubbingPath);
            this.Controls.Add(this.dialogsPath);
            this.Controls.Add(this.outputPath);
            this.Name = "SettingsDubbingCheckerView";
            this.Size = new System.Drawing.Size(571, 333);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.AdvancedPathField itemsLookupPath;
        private Controls.AdvancedPathField itemsPath;
        private Controls.AdvancedPathField dubbingPath;
        private Controls.AdvancedPathField dialogsPath;
        private Controls.AdvancedPathField outputPath;
    }
}
