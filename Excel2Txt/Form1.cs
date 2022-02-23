using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel2Txt
{
    public partial class Principal : Form
    {
        
        public string RootFolderName { get; set; }
        public Excel ExcelFileSelected { get; set; }

        public Principal()
        {
            InitializeComponent();
        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            string ExcelFileName = @"C:\Users\Thiago\Application Data\Desktop\Wow Marcelo\tabela.xlsm";
            this.RootFolderName = Path.GetDirectoryName(ExcelFileName);
            ExcelName.Text = ExcelFileName;
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    this.ExcelFileName = openFileDialog1.FileName;
            //    this.RootFolderName = Path.GetDirectoryName(this.ExcelFileName);
            //    ExcelName.Text = this.ExcelFileName;
            //}
            this.ExcelFileSelected = new Excel(ExcelFileName);
            boxSheets.DataSource = this.ExcelFileSelected.SheetsName;
            boxSheets.SelectedIndex = 0;
            //SelectSheet();
        }

        private void AddColumnToTxt()
        {
            //Adicionar coluna selecionada
        }

        private void RemoveColumnFromTxt()
        {
            //Remover coluna selecionada
        }

        private string SetNameTxtColumn()
        {
            //Definir novo nome da coluna
            return "";
        }

        private void SelectSheet()
        {
            boxColumns.DataSource = null;
            this.ExcelFileSelected.ActiveSheet(boxSheets.SelectedItem.ToString());
            boxColumns.DataSource = this.ExcelFileSelected.ColumnsNames;
        }

        private void boxSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectSheet();
        }
    }
}
