using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            CrystalReports.crptHelloWorld crpt = new CrystalReports.crptHelloWorld();
            crvHelloworld.ReportSource = null;
            crvHelloworld.ReportSource = crpt;

            dgvItem.AutoGenerateColumns = false;
            using (HarithmaSalesEntities db = new HarithmaSalesEntities())
            {
                dgvItem.DataSource =  db.Items.ToList();
            }

            /*
            CrystalReports.crptItem crptItem = new CrystalReports.crptItem();
            crv2.ReportSource = null;
            crv2.ReportSource = crptItem;
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReports.crptHelloWorld crpt = new CrystalReports.crptHelloWorld();

            crpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            crpt.PrintToPrinter(1, false, 0, 0);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Creating DataTable.
            DataTable dt = new DataTable();

            //Adding the Columns.
            foreach (DataGridViewColumn column in dgvItem.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows.
            foreach (DataGridViewRow row in dgvItem.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            //ds.WriteXmlSchema("item2.xml");
            
            CrystalReports.crptItem cptItm = new CrystalReports.crptItem();
            cptItm.SetDataSource(ds);
            cptItm.SetParameterValue("totalAmount", 11075);
            cptItm.SetParameterValue("recievedAmount", 12000);
            crv2.ReportSource = cptItm;
            crv2.Refresh();
        }

        private void btnPrint2_Click(object sender, EventArgs e)
        {
            //Creating DataTable.
            DataTable dt = new DataTable();

            //Adding the Columns.
            foreach (DataGridViewColumn column in dgvItem.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows.
            foreach (DataGridViewRow row in dgvItem.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            //ds.WriteXmlSchema("item2.xml");

            CrystalReports.crptItem cptItm = new CrystalReports.crptItem();
            cptItm.SetDataSource(ds);
            cptItm.SetParameterValue("totalAmount", 11075);
            cptItm.SetParameterValue("recievedAmount", 12000);

            cptItm.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            cptItm.PrintToPrinter(1, false, 0, 0);
        }
    }
}
