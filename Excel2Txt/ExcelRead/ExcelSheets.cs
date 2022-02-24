﻿using ClosedXML.Excel;
using System;
using System.Collections.Generic;

namespace Excel2Txt
{
    public class ExcelSheets
    {
        public string Name { get; set; }
        public int RowsCount { get; set; }
        public int ColumnsCount { get; set; }
        public List<ExcelColumn> Columns { get; set; }

        public ExcelSheets(IXLWorksheet worksheet)
        {
            this.Name = worksheet.Name;
            this.Columns = new List<ExcelColumn>();

            setSheetSize(worksheet);

            return;
            foreach (IXLColumn column in worksheet.Columns())
            {
                this.Columns.Add(new ExcelColumn(column, this.RowsCount));
            }
        }

        private void setSheetSize(IXLWorksheet worksheet)
        {
            //Se encontrar 5 células seguidas em branco considera linha/coluna vazia
            string CelValue;
            int TotalRow = 0;
            int TotalColumn = 0;
            int ActiveRow = 0;
            int ActiveColumn = 0;
            int EmptyRow = 0;
            int EmptyColumn = 0;
            while (EmptyColumn <= 5)
            {
                ActiveColumn++;
                EmptyRow = 0;
                ActiveRow = 0;
                while (EmptyRow <= 5)
                {
                    ActiveRow++;
                    CelValue = worksheet.Cell(ActiveRow, ActiveColumn).Value.ToString();
                    if (String.IsNullOrEmpty(CelValue))
                    {
                        EmptyRow++;
                        continue;
                    }
                    TotalRow = Math.Max(ActiveRow, TotalRow);
                    EmptyRow = 0;
                }
                if (ActiveRow == 6) //Se coluna vazia
                {
                    EmptyColumn++;
                    continue;
                }
                TotalColumn = Math.Max(ActiveColumn, TotalColumn);
                EmptyColumn = 0;
            }
        }

        public ExcelColumn getColumn(string columnName)
        {
            ExcelColumn Column = this.Columns.Find(col => col.Title == columnName);
            return Column;
        }

    }
}
