using System;
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
    public partial class ColumnNameInput : Form
    {
        private ExcelColumn _column { get; set; }
        public ColumnNameInput(ExcelColumn column)
        {
            InitializeComponent();
            _column = column;
            OriginalColumn.Text = column.Title;
            columnTitle.Text = "SAIDA" + column.Title;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            this.Close();
        }
    }
}
