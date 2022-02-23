using ClosedXML.Excel;
using System.Collections.Generic;

namespace Excel2Txt
{
    public class ExcelColumn
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public List<string> ColumnData { get; set; }

        public ExcelColumn(IXLColumn column, int totalRows)
        {
            this.Number = column.ColumnNumber();
            this.Title = column.Cell(1).Value.ToString();
            for (int row = 1; row <= totalRows; row++)
            {
                ColumnData.Add(column.Cell(row).Value.ToString());
            }
        }

        public override string ToString()
        {
            return this.Title + " (" + this.Number + ")";
        }
    }
}
