﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf;

namespace ApplicationGUI.Views
{
    public partial class SettingsDubbingCheckerView : UserControl
    {
        public SettingsDubbingCheckerView()
        {
            InitializeComponent();
        }

        public void LoadOptions()
        {
            this.dialogsPath.Path = SettingsManager.Instance.DC_DialogsPath;
            this.dubbingPath.Path = SettingsManager.Instance.DC_DubbingPath;
            this.itemsLookupPath.Path = SettingsManager.Instance.DC_ItemsLookupDirectory;
            this.itemsPath.Path = SettingsManager.Instance.DC_ItemsDirectory;
            this.outputPath.Path = SettingsManager.Instance.DC_OutputDirectory;
        }
        public void SaveOptions()
        {
            SettingsManager.Instance.DC_DialogsPath = this.dialogsPath.Path;
            SettingsManager.Instance.DC_DubbingPath = this.dubbingPath.Path;
            SettingsManager.Instance.DC_ItemsLookupDirectory = this.itemsLookupPath.Path;
            SettingsManager.Instance.DC_ItemsDirectory = this.itemsPath.Path;
            SettingsManager.Instance.DC_OutputDirectory = this.outputPath.Path;
        }
    }
}
