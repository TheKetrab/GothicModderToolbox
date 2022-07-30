using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GothicToolsLib.Patterns;

namespace ApplicationGUI.Views
{
    public partial class SettingsCustomPatternsView : UserControl
    {
        private BindingList<CustomPattern> customPatterns = new();

        public SettingsCustomPatternsView()
        {
            InitializeComponent();
            SetupDataGridView();
            InitializeBindings();
        }

        private void InitializeBindings()
        {
            patternsDataGridView.DataBindings.Add("Enabled", customPatternsCheckBox, "Checked");
            resetPatternsBtn.DataBindings.Add("Enabled", customPatternsCheckBox, "Checked");
        }

        private void SetupDataGridView()
        {
            patternsDataGridView.DataSource = customPatterns;
            if (patternsDataGridView.ColumnCount < 5)
                return;

            patternsDataGridView.Columns[0].HeaderText = "Pattern Id";
            patternsDataGridView.Columns[0].ReadOnly = true;

            patternsDataGridView.Columns[1].Visible = false; // Section

            patternsDataGridView.Columns[2].Visible = false; // Name

            patternsDataGridView.Columns[3].HeaderText = "Pattern";
            patternsDataGridView.Columns[3].ReadOnly = false;
            patternsDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            patternsDataGridView.Columns[4].HeaderText = "Group";
            patternsDataGridView.Columns[4].ReadOnly = false;
            patternsDataGridView.Columns[4].ToolTipText = "Number of group that contains text.";
            patternsDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Fill data
            LoadOptions();
        }

        private void ImportDefaultPatterns()
        {
            var textPatterns = new TextPatternsProvider().GetAsCustomPatterns();
            var dubbingPatterns = new DubbingPatternsProvider().GetAsCustomPatterns();
            var itemPatterns = new ItemPatternsProvider().GetAsCustomPatterns();

            var allPatterns = textPatterns.Concat(dubbingPatterns).Concat(itemPatterns);

            customPatterns.Clear();
            foreach (var p in allPatterns)
                customPatterns.Add(p);

        }

        private void resetPatternsBtn_Click(object sender, EventArgs e)
        {
            ImportDefaultPatterns();
        }

        public void LoadOptions()
        {
            foreach (var x in SettingsManager.Instance.CPManager.Patterns)
            {
                customPatterns.Add(x.Value);
            }
        }

        public void SaveOptions()
        {
            foreach (var x in customPatterns)
            {
                SettingsManager.Instance.CPManager.SetPattern(x.Id,x);
            }
        }

        private void pattensDataGridView_EnabledChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (!dgv.Enabled)
            {
                dgv.DefaultCellStyle.BackColor = SystemColors.Control;
                dgv.DefaultCellStyle.ForeColor = SystemColors.GrayText;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText;
                dgv.CurrentCell = null;
                dgv.ReadOnly = true;
                dgv.EnableHeadersVisualStyles = false;
            }
            else
            {
                dgv.DefaultCellStyle.BackColor = SystemColors.Window;
                dgv.DefaultCellStyle.ForeColor = SystemColors.ControlText;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Window;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
                dgv.ReadOnly = false;
                dgv.EnableHeadersVisualStyles = true;
            }
        }
    }
}
