using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationGUI.Properties;

namespace ApplicationGUI.Controls
{
    public partial class AdvancedPathField : UserControl
    {
        public AdvancedPathField()
        {
            InitializeComponent();

            this.openBtn.Text = "";
            this.openBtn.Image = new Bitmap(Resources.btn_dir)
                .GetThumbnailImage(16,13,null,IntPtr.Zero);
        }

        const int margin = 3;
        const int btnWidth = 35;

        public string Label { get; set; } = "Label:";
        public int LabelWidth { get; set; } = 150;

        private string _path;
        public string Path
        {
            get => _path;
            set
            {
                _path = value;
                this.pathTextBox.Text = value;
            }
        }


        protected override void OnResize(EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.label.Text = Label;
            this.label.Left = margin;
            this.label.Width = LabelWidth;

            this.openBtn.Left = this.Width - btnWidth - margin;
            this.openBtn.Width = btnWidth;

            this.pathTextBox.Text = Path;
            this.pathTextBox.Left = margin + LabelWidth + margin;
            this.pathTextBox.Width = this.Width - LabelWidth - btnWidth - 4 * margin;

        }

        private void FillPathTextBox()
        {
            using var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                Path = fbd.SelectedPath;
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            FillPathTextBox();
        }
    }
}
