using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsDay1
{
    public partial class FrmDept : Form
    {
        public FrmDept()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        private void FrmDept_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=sircltechdb;Integrated Security=True;";
            loaddgvDept();
        }
        void loaddgvDept()
        {
            ds.Tables.Clear(); // collection of tables
            comm.CommandText = "select * from tbldept";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ds, "dept");
            dgvDept.DataSource = ds.Tables["dept"];
            dgvDept.Columns["Addon"].Visible = false;
            dgvDept.Columns[4].Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            comm.CommandText = "insert into tbldept(dname,loc,addon,status) values(@dname, @loc,@addon,@status)";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@dname", txtdname.Text);
            comm.Parameters.AddWithValue("@loc", txtloc.Text);
            comm.Parameters.AddWithValue("@addon", DateTime.Now);
            comm.Parameters.AddWithValue("@status", 'A');
            conn.Open();
            int response= comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();
            if (response > 0)
            {
                MessageBox.Show("Record Inserted Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddgvDept();
                reset();
            }
        }

        private void dgvDept_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvDept_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtdno.Text = dgvDept.Rows[e.RowIndex].Cells["Dno"].Value.ToString();
                txtdname.Text = dgvDept.Rows[e.RowIndex].Cells["DName"].Value.ToString();
                txtloc.Text = dgvDept.Rows[e.RowIndex].Cells["Loc"].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            comm.CommandText = "update tbldept set DName=@dname, Loc=@loc, UpdateOn=@updateon where DNo=@dno";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@dno", txtdno.Text);
            comm.Parameters.AddWithValue("@dname", txtdname.Text);
            comm.Parameters.AddWithValue("@loc", txtloc.Text);
            comm.Parameters.AddWithValue("@updateon", DateTime.Now);
            
            conn.Open();
            int response = comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();
            if (response > 0)
            {
                MessageBox.Show("Record Updated Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddgvDept();
                reset();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        void reset()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                    ctrl.Text = "";
            }
            txtdname.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            comm.CommandText = "delete from tbldept where DNo=@dno";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@dno", txtdno.Text);
          

            conn.Open();
            int response = comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();
            if (response > 0)
            {
                MessageBox.Show("Record deleted Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddgvDept();
                reset();
            }
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            comm.CommandText = "update tbldept set Status=@status where DNo=@dno";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@status", txtdno.Text);
           

            conn.Open();
            int response = comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();
            if (response > 0)
            {
                MessageBox.Show("Record Updated Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddgvDept();
                reset();
            }
        }
    }
}
