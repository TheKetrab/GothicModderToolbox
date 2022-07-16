using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationGUI.Managers;
using GothicToolsLib.ContentAnalyzer;
using GothicToolsLib.Models;
using GothicToolsLib.Patterns;

namespace ApplicationGUI
{
    public class DubbingCheckerManager
    {
        private DialogParser dialogParser;
        private ItemParser itemParser;

        public async Task InvokeDialogParser(IProgress<ProgressModel> progress)
        {
            DubbingPatternsProvider patternsProvider =
                (SettingsManager.Instance.CP_Enabled)
                    ? new SettingsDubbingPatternsProvider()
                    : new DubbingPatternsProvider();


            dialogParser = new DialogParser(
                SettingsManager.Instance.DC_DialogsPath,
                SettingsManager.Instance.DC_DubbingPath,
                patternsProvider);

            await Task.Run(() => dialogParser.Parse(progress));
        }

        public async Task InvokeItemParser(IProgress<ProgressModel> progress)
        {
            ItemPatternsProvider patternsProvider =
                (SettingsManager.Instance.CP_Enabled)
                    ? new SettingsItemPatternsProvider()
                    : new ItemPatternsProvider();


            itemParser = new ItemParser(
                SettingsManager.Instance.DC_ItemsDirectory,
                SettingsManager.Instance.DC_ItemsLookupDirectory,
                patternsProvider);
            
            await Task.Run(() => itemParser.Parse(progress));
        }


        public void SaveData(bool hideCompleted = false, bool printMissing = false)
        {
            StatsPrinter printer = new StatsPrinter(
                SettingsManager.Instance.DC_OutputDirectory);

            if (dialogParser != null)
            {
                printer.PrintAlphabetical(dialogParser.AllDialogs);
                printer.PrintInfo(dialogParser.Npcs, hideCompleted, printMissing);

                printer.PrintMissingWavs(dialogParser.GetMissingWavs());
                printer.PrintUnnecessaryWavs(dialogParser.GetUnnecessaryWavs());

                printer.PrintMissingHero(dialogParser.Npcs);
                printer.PrintAllHero(dialogParser.Npcs);

                printer.PrintMissingNpcs(dialogParser.Npcs);
                printer.PrintAllNpcs(dialogParser.Npcs);
            }

            if (itemParser != null)
            {
                printer.PrintAllItems(itemParser.AllItems);
                printer.PrintUnusedItems(itemParser.AllItems);
            }

            Process.Start(new ProcessStartInfo()
            {
                FileName = SettingsManager.Instance.DC_OutputDirectory,
                UseShellExecute = true,
                Verb = "open"
            });


        }

        public void SaveExcelData()
        {
            if (dialogParser != null)
            {
                ExcelMaker.WriteDialogsExcel(SettingsManager.Instance.DC_OutputDirectory, dialogParser);
            }

            if (itemParser != null)
            {
                ExcelMaker.WriteItemsExcel(SettingsManager.Instance.DC_OutputDirectory, itemParser);
            }

            Process.Start(new ProcessStartInfo()
            {
                FileName = SettingsManager.Instance.DC_OutputDirectory,
                UseShellExecute = true,
                Verb = "open"
            });


        }



    }
}
