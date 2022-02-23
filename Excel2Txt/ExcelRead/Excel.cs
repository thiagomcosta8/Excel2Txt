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
    }
}
