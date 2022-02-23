using ClosedXML.Excel;
using System.Collections.Generic;

namespace Excel2Txt
{
    public class ExcelSheets
    {
        public string Name { get; set; }
        public int RowsCount { get; set; }
        public List<ExcelColumn> Columns { get; set; }

        public ExcelSheets(IXLWorksheet worksheet)
        {
            this.Name = worksheet.Name;
            this.RowsCount = worksheet.RowCount();
            foreach (IXLColumn column in worksheet.Columns())
            {
                this.Columns.Add(new ExcelColumn(column, this.RowsCount));
            }

        }

        public ExcelColumn getColumn(string columnName)
        {
            ExcelColumn Column = this.Columns.Find(col => col.Title == columnName);
            return Column;
        }

    }
}
