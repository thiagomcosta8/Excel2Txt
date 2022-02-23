namespace Excel2Txt
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btExcel = new System.Windows.Forms.Button();
            this.ExcelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxSheets = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxColumns = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxReturn = new System.Windows.Forms.ListBox();
            this.brAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btExcel
            // 
            this.btExcel.Location = new System.Drawing.Point(29, 14);
            this.btExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(144, 31);
            this.btExcel.TabIndex = 0;
            this.btExcel.Text = "Excel";
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // ExcelName
            // 
            this.ExcelName.Location = new System.Drawing.Point(29, 55);
            this.ExcelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExcelName.Name = "ExcelName";
            this.ExcelName.Size = new System.Drawing.Size(959, 26);
            this.ExcelName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Planilhas";
            // 
            // boxSheets
            // 
            this.boxSheets.FormattingEnabled = true;
            this.boxSheets.ItemHeight = 20;
            this.boxSheets.Location = new System.Drawing.Point(29, 117);
            this.boxSheets.Name = "boxSheets";
            this.boxSheets.Size = new System.Drawing.Size(223, 324);
            this.boxSheets.TabIndex = 3;
            this.boxSheets.SelectedIndexChanged += new System.EventHandler(this.boxSheets_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Colunas";
            // 
            // boxColumns
            // 
            this.boxColumns.FormattingEnabled = true;
            this.boxColumns.ItemHeight = 20;
            this.boxColumns.Location = new System.Drawing.Point(296, 119);
            this.boxColumns.Name = "boxColumns";
            this.boxColumns.Size = new System.Drawing.Size(236, 324);
            this.boxColumns.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(714, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saída";
            // 
            // boxReturn
            // 
            this.boxReturn.FormattingEnabled = true;
            this.boxReturn.ItemHeight = 20;
            this.boxReturn.Location = new System.Drawing.Point(712, 124);
            this.boxReturn.Name = "boxReturn";
            this.boxReturn.Size = new System.Drawing.Size(275, 324);
            this.boxReturn.TabIndex = 7;
            // 
            // brAdd
            // 
            this.brAdd.Location = new System.Drawing.Point(564, 182);
            this.brAdd.Name = "brAdd";
            this.brAdd.Size = new System.Drawing.Size(119, 37);
            this.brAdd.TabIndex = 8;
            this.brAdd.Text = ">>>";
            this.brAdd.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(564, 284);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(118, 37);
            this.btRemove.TabIndex = 9;
            this.btRemove.Text = "<<<";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.brAdd);
            this.Controls.Add(this.boxReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxColumns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxSheets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExcelName);
            this.Controls.Add(this.btExcel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Principal";
            this.ShowIcon = false;
            this.Text = "Conversão de arquivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.TextBox ExcelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox boxSheets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox boxColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox boxReturn;
        private System.Windows.Forms.Button brAdd;
        private System.Windows.Forms.Button btRemove;
    }
}

