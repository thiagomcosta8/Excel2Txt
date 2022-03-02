using System;
using System.Collections.Generic;
using System.Linq;

namespace Excel2Txt
{
    class ExcelResultColumns
    {
        public Dictionary<int, string> ColumnsTitles = new Dictionary<int, string>();

        public void Add(ExcelColumn column, string Title)
        {
            if(SearchTitle(Title) > 0)
            {
                throw new Exception("Valor já existe em ExcelResultColumns");
            }
            if (this.ColumnsTitles.ContainsKey(column.Number)) 
            {
                this.ColumnsTitles[column.Number] = Title;
                return;
            }
            this.ColumnsTitles.Add(column.Number, Title);
        }

        public int SearchTitle(string Title)
        {
            KeyValuePair<int, string> ResultColumn = this.ColumnsTitles.Where(item => item.Value == Title).FirstOrDefault();
            if(ResultColumn.Value == null)
            {
                return 0;
            }
            return ResultColumn.Key;
        }

        public void Remove(ExcelColumn column)
        {
            this.ColumnsTitles.Remove(column.Number);
        }

        public void Remove(string Title)
        {
            KeyValuePair<int, string> ResultColumn = this.ColumnsTitles.Where(item => item.Value == Title).FirstOrDefault();
            if (ResultColumn.Value != null)
            {
                this.ColumnsTitles.Remove(ResultColumn.Key);
            }
        }

        public List<string> TitleList()
        {
            return this.ColumnsTitles.Values.Select(item => item).ToList();
        }

    }
}
