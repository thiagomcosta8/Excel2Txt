using ClosedXML.Excel;
using System.Collections.Generic;

namespace Excel2Txt
{
    public class Excel
    {
        public List<ExcelSheets> Sheets = new List<ExcelSheets>();

        public Excel(string ExcelFileName)
        {
            using (XLWorkbook ExcelOpened = new XLWorkbook(ExcelFileName))
            {
                foreach (IXLWorksheet worksheet in ExcelOpened.Worksheets)
                {
                    this.Sheets.Add(new ExcelSheets(worksheet));
                }
            }
        }

        public List<string> SheetsList()
        {
            List<string> SheetsNameList = new List<string>();
            foreach (ExcelSheets sheet in this.Sheets)
            {
                SheetsNameList.Add(sheet.Name);
            }
            return SheetsNameList;
        }

        public ExcelSheets getSheet(string SheetName)
        {
            foreach (ExcelSheets sheet in this.Sheets)
            {
                if (sheet.Name == SheetName)
                {
                    return sheet;
                }
            }
            return null;
        }
    }
}
