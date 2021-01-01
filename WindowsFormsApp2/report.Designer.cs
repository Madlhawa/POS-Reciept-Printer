
namespace WindowsFormsApp2
{
    partial class report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPrint2 = new System.Windows.Forms.Button();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.crvHelloworld = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crv2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrint2
            // 
            this.btnPrint2.Location = new System.Drawing.Point(1203, 3);
            this.btnPrint2.Name = "btnPrint2";
            this.btnPrint2.Size = new System.Drawing.Size(75, 23);
            this.btnPrint2.TabIndex = 2;
            this.btnPrint2.Text = "Pritnt2";
            this.btnPrint2.UseVisualStyleBackColor = true;
            this.btnPrint2.Click += new System.EventHandler(this.btnPrint2_Click);
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvItem.Location = new System.Drawing.Point(472, 32);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(344, 437);
            this.dgvItem.TabIndex = 4;
            // 
            // crvHelloworld
            // 
            this.crvHelloworld.ActiveViewIndex = -1;
            this.crvHelloworld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvHelloworld.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvHelloworld.Location = new System.Drawing.Point(2, 32);
            this.crvHelloworld.Name = "crvHelloworld";
            this.crvHelloworld.Size = new System.Drawing.Size(464, 437);
            this.crvHelloworld.TabIndex = 5;
            // 
            // crv2
            // 
            this.crv2.ActiveViewIndex = -1;
            this.crv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv2.Location = new System.Drawing.Point(822, 32);
            this.crv2.Name = "crv2";
            this.crv2.Size = new System.Drawing.Size(464, 437);
            this.crv2.TabIndex = 6;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(599, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn1.HeaderText = "name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemAvailableQuantity";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ItemSellingPrice";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 470);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.crv2);
            this.Controls.Add(this.crvHelloworld);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.btnPrint2);
            this.Controls.Add(this.btnPrint);
            this.Name = "report";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPrint2;
        private System.Windows.Forms.DataGridView dgvItem;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvHelloworld;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

