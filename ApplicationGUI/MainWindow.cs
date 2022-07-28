using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ApplicationGUI.Dialogs;
using IniParser;
using IniParser.Model;

namespace ApplicationGUI
{
    public partial class MainWindow : Form
    {

        private DubbingCheckerView dubbingCheckerView = new DubbingCheckerView();
        private DecibelsModulatorView decibelsModulatorView = new DecibelsModulatorView();
        private AutoTranslatorView autoTranslatorView = new AutoTranslatorView();

        public MainWindow()
        {
            InitializeComponent();

            decibelsModulatorView.Parent = this.tabPage1;
            dubbingCheckerView.Parent = this.tabPage2;
            autoTranslatorView.Parent = this.tabPage3;

            this.tabPage1.SizeChanged += (s, a) => AlignSize(decibelsModulatorView, tabPage1);
            this.tabPage2.SizeChanged += (s, a) => AlignSize(dubbingCheckerView, tabPage2);
            this.tabPage3.SizeChanged += (s, a) => AlignSize(autoTranslatorView, tabPage3);

            AlignSize(decibelsModulatorView,tabPage1);
            AlignSize(dubbingCheckerView,tabPage2);
            AlignSize(autoTranslatorView,tabPage3);

        }

        private void AlignSize(Control child, Panel parent)
        {
            child.Width = parent.Width;
            child.Height = parent.Height;
            child.Invalidate();
        }

        private void toolStripSettingsBtn_Click(object sender, EventArgs e)
        {
            var dialog = new SettingsDialog();
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ShowDialog(this);
        }

    }
}
