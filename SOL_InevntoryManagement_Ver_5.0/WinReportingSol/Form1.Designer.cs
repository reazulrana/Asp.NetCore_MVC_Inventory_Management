
namespace WinReportingSol
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lstc = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.lstarray = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstc
            // 
            this.lstc.FormattingEnabled = true;
            this.lstc.ItemHeight = 20;
            this.lstc.Location = new System.Drawing.Point(12, 66);
            this.lstc.Name = "lstc";
            this.lstc.Size = new System.Drawing.Size(188, 104);
            this.lstc.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 26);
            this.textBox1.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 176);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(188, 26);
            this.txtResult.TabIndex = 3;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(234, 34);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(207, 26);
            this.txtsl.TabIndex = 4;
            // 
            // lstarray
            // 
            this.lstarray.FormattingEnabled = true;
            this.lstarray.ItemHeight = 20;
            this.lstarray.Location = new System.Drawing.Point(234, 67);
            this.lstarray.Name = "lstarray";
            this.lstarray.Size = new System.Drawing.Size(207, 104);
            this.lstarray.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(234, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(460, 116);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(135, 35);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(13, 224);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(171, 39);
            this.btnLoadData.TabIndex = 9;
            this.btnLoadData.Text = "Load";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dgvGrid
            // 
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGrid.Location = new System.Drawing.Point(0, 299);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowHeadersWidth = 62;
            this.dgvGrid.RowTemplate.Height = 28;
            this.dgvGrid.Size = new System.Drawing.Size(778, 245);
            this.dgvGrid.TabIndex = 10;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(210, 230);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(188, 26);
            this.txtSearchProduct.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.dgvGrid);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstarray);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstc);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.ListBox lstarray;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.TextBox txtSearchProduct;
    }
}

