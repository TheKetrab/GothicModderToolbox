using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GothicToolsLib.Models;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace GothicToolsLib.ContentAnalyzer
{
    public class ExcelMaker
    {
        private static void Dialogs_CreateHeader(XSSFSheet sheet)
        {
            var headerRow = sheet.CreateRow(0);
            var names = new string[5]
            {
                "Id", "Npc", "Instance", "File", "Text"
            };
            for (int i = 0; i < 5; i++)
            {
                var cell = headerRow.CreateCell(i);
                cell.SetCellValue(names[i]);
            }
        }

        private static void Items_FillData(XSSFSheet sheet, Dictionary<string,int> itemsData)
        {
            int currentRow = 1;
            int id = 1;
            foreach (var itm in itemsData)
            {
                var row = sheet.CreateRow(currentRow++);
                row.CreateCell(0).SetCellValue(id++);
                row.CreateCell(1).SetCellValue(itm.Key);
                row.CreateCell(2).SetCellValue(itm.Value);
            }
            
            for (int i = 0; i < 3; i++)
                sheet.AutoSizeColumn(i);

        }


        private static void Dialogs_FillData(XSSFSheet sheet, NpcDictionary npcs)
        {
            int currentRow = 1;
            int id = 1;
            foreach (NpcModel npc in npcs)
            {
                foreach (AIOutputModel aio in npc.Dialogs)
                {
                    var row = sheet.CreateRow(currentRow++);
                    row.CreateCell(0).SetCellValue(id++);
                    row.CreateCell(1).SetCellValue($"{npc.Id}_{npc.Name}");
                    row.CreateCell(2).SetCellValue(aio.Instance);
                    row.CreateCell(3).SetCellValue(new FileInfo(aio.FileName).Name);
                    row.CreateCell(4).SetCellValue(aio.Text);
                }
            }

            for (int i=0; i<5; i++)
                sheet.AutoSizeColumn(i);
        }

        private static void FillStringData(XSSFSheet sheet, List<string> data)
        {
            int currentRow = 0;
            foreach (string s in data)
                sheet.CreateRow(currentRow++).CreateCell(0).SetCellValue(s);

            sheet.AutoSizeColumn(0);
        }

        public static void WriteDialogsExcel(string outputDirectory, DialogParser parser)
        {
            if (!parser.Parsed)
            {
                throw new Exception("Parser not initialized. Use parser.Parse()!");
            }

            IWorkbook workbook = new XSSFWorkbook();
            var sheet1 = (XSSFSheet)workbook.CreateSheet("Dialogs");
            var sheet2 = (XSSFSheet)workbook.CreateSheet("Missing wavs");
            var sheet3 = (XSSFSheet)workbook.CreateSheet("Unnecessary wavs");

            Dialogs_CreateHeader(sheet1);
            Dialogs_FillData(sheet1,parser.Npcs);
            
            FillStringData(sheet2,parser.GetMissingWavs());
            FillStringData(sheet3, parser.GetUnnecessaryWavs());

            using (FileStream sw = File.Create($"{outputDirectory}/AllInfos.xlsx"))
            {
                workbook.Write(sw);
            }

        }

        public static void WriteItemsExcel(string outputDirectory, ItemParser parser)
        {
            if (!parser.Parsed)
            {
                throw new Exception("Parser not initialized. Use parser.Parse()!");
            }

            IWorkbook workbook = new XSSFWorkbook();
            var sheet = (XSSFSheet)workbook.CreateSheet("Items");
            Items_FillData(sheet,parser.AllItems);

            using (FileStream sw = File.Create($"{outputDirectory}/AllItems.xlsx"))
            {
                workbook.Write(sw);
            }

        }





    }
}
