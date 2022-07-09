using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationGUI.Annotations;

namespace ApplicationGUI.Controls
{
    public partial class AdvancedProgressBar : UserControl
    {
        public AdvancedProgressBar()
        {
            InitializeComponent();
        }

        private int _percent;
        public int Percent
        {
            get => _percent;
            set
            {
                _percent = Math.Max(0, Math.Min(100, value));
                progressBar.Value = _percent;
                percentLabel.Text = $"{_percent}%";
                progressBar.Update();
                percentLabel.Update();
            }
        }

        public int LabelWidth { get; set; } = 40;

        protected override void OnResize(EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            percentLabel.Width = LabelWidth;
            percentLabel.Left = this.Width - LabelWidth;
            progressBar.Width = this.Width - LabelWidth;
        }

    }
}
