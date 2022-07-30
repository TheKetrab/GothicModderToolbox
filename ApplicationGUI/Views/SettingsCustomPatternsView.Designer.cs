
using System.Windows.Forms;

namespace ApplicationGUI.Views
{
    partial class SettingsCustomPatternsView
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
            this.customPatternsCheckBox = new System.Windows.Forms.CheckBox();
            this.patternsDataGridView = new System.Windows.Forms.DataGridView();
            this.resetPatternsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patternsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customPatternsCheckBox
            // 
            this.customPatternsCheckBox.AutoSize = true;
            this.customPatternsCheckBox.Location = new System.Drawing.Point(3, 5);
            this.customPatternsCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customPatternsCheckBox.Name = "customPatternsCheckBox";
            this.customPatternsCheckBox.Size = new System.Drawing.Size(165, 24);
            this.customPatternsCheckBox.TabIndex = 3;
            this.customPatternsCheckBox.Text = "Use custom patterns";
            this.customPatternsCheckBox.UseVisualStyleBackColor = true;
            // 
            // patternsDataGridView
            // 
            this.patternsDataGridView.AllowUserToAddRows = false;
            this.patternsDataGridView.AllowUserToDeleteRows = false;
            this.patternsDataGridView.AllowUserToResizeRows = false;
            this.patternsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patternsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patternsDataGridView.Location = new System.Drawing.Point(3, 41);
            this.patternsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patternsDataGridView.MultiSelect = false;
            this.patternsDataGridView.Name = "patternsDataGridView";
            this.patternsDataGridView.RowHeadersVisible = false;
            this.patternsDataGridView.RowHeadersWidth = 51;
            this.patternsDataGridView.RowTemplate.Height = 25;
            this.patternsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patternsDataGridView.Size = new System.Drawing.Size(557, 200);
            this.patternsDataGridView.EnabledChanged += pattensDataGridView_EnabledChanged;

            this.patternsDataGridView.TabIndex = 4;
            // 
            // resetPatternsBtn
            // 
            this.resetPatternsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetPatternsBtn.Location = new System.Drawing.Point(3, 248);
            this.resetPatternsBtn.Name = "resetPatternsBtn";
            this.resetPatternsBtn.Size = new System.Drawing.Size(126, 29);
            this.resetPatternsBtn.TabIndex = 5;
            this.resetPatternsBtn.Text = "Reset patterns";
            this.resetPatternsBtn.UseVisualStyleBackColor = true;
            this.resetPatternsBtn.Click += new System.EventHandler(this.resetPatternsBtn_Click);
            // 
            // SettingsCustomPatternsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resetPatternsBtn);
            this.Controls.Add(this.patternsDataGridView);
            this.Controls.Add(this.customPatternsCheckBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingsCustomPatternsView";
            this.Size = new System.Drawing.Size(563, 291);
            ((System.ComponentModel.ISupportInitialize)(this.patternsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox customPatternsCheckBox;
        private System.Windows.Forms.DataGridView patternsDataGridView;
        private Button resetPatternsBtn;
    }
}
