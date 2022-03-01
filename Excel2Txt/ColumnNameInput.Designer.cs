namespace Excel2Txt
{
    partial class ColumnNameInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OriginalColumn = new System.Windows.Forms.TextBox();
            this.columnTitle = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coluna da planilha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título no arquivo de texto:";
            // 
            // OriginalColumn
            // 
            this.OriginalColumn.Enabled = false;
            this.OriginalColumn.Location = new System.Drawing.Point(34, 45);
            this.OriginalColumn.Name = "OriginalColumn";
            this.OriginalColumn.Size = new System.Drawing.Size(691, 26);
            this.OriginalColumn.TabIndex = 2;
            // 
            // columnTitle
            // 
            this.columnTitle.Location = new System.Drawing.Point(34, 136);
            this.columnTitle.Name = "columnTitle";
            this.columnTitle.Size = new System.Drawing.Size(691, 26);
            this.columnTitle.TabIndex = 3;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(599, 180);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(126, 41);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(467, 180);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(126, 41);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // ColumnNameInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(762, 263);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.columnTitle);
            this.Controls.Add(this.OriginalColumn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColumnNameInput";
            this.ShowIcon = false;
            this.Text = "Nome da Coluna";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OriginalColumn;
        private System.Windows.Forms.TextBox columnTitle;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
    }
}