using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationGUI.Views
{
    public partial class SettingsDubbingCheckerView : UserControl
    {
        public SettingsDubbingCheckerView()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.dialogsPath.Width = this.Width;
            this.dubbingPath.Width = this.Width;
            this.itemsLookupPath.Width = this.Width;
            this.itemsPath.Width = this.Width;
            this.outputPath.Width = this.Width;
        }
    }
}
