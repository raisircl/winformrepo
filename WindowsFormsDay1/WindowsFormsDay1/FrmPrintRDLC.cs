using CrystalDecisions.Shared;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDay1
{
    public partial class FrmPrintRDLC : Form
    {
        public FrmPrintRDLC()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\code\\dotn-net\\winformrepo\\winformrepo\\WindowsFormsDay1\\WindowsFormsDay1\\sircltechdb.mdf;Integrated Security=True");
        SqlCommand comm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        
        private void FrmPrintRDLC_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
          
        }
        DataTable getinvoice()
        {
            DataTable ret = new DataTable();
            comm.CommandText = "sp_invoice3copy";
            comm.Parameters.AddWithValue("@id", 1);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ret);
            comm.Parameters.Clear();
            MessageBox.Show(ret.Rows.Count.ToString());
            return ret;
        }
        DataTable getinvoicedetails(int invoiceid)
        {
            DataTable ret = new DataTable();
            comm.CommandText = "sp_invoicedetails";
            comm.Parameters.AddWithValue("@id", invoiceid);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ret);
            MessageBox.Show(ret.Rows.Count.ToString());
            comm.Parameters.Clear();
            return ret;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = getinvoice();
            ReportDataSource rds1 = new ReportDataSource("dtInvoices", getinvoice());
            
            reportViewer1.LocalReport.DataSources.Clear();

            //reportViewer1.LocalReport.ReportPath = @"E:\code\dotn-net\winformrepo\winformrepo\WindowsFormsDay1\WindowsFormsDay1\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(rds1);
            // reportViewer1.LocalReport.DataSources.Add(rds2);
           reportViewer1.LocalReport.SubreportProcessing +=new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
            this.reportViewer1.RefreshReport();
        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            int invoiceid = 1;
            ReportDataSource rds2 = new ReportDataSource("Dataset1", getinvoicedetails(invoiceid));
            e.DataSources.Add(rds2);

        }
    }
}
