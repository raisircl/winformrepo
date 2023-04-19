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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=sircltechdb;Integrated Security=True;");
        SqlCommand comm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        DataSet dsStates = new DataSet();
        bool blnstates = false;

        DataSet dsDistrict = new DataSet();
        bool blnDistrict = false;

        DataSet dsCities = new DataSet();
        bool blnCities = false;

        DataSet dsDept = new DataSet();
        bool blnDept = false;
        private void FrmEmployee_Load(object sender, EventArgs e)
        {

            LoadStates();
            LoadDept();

        }
        void LoadEmploees()
        {

        }
        void LoadDept()
        {
            cmbDepartment.Text = "";
            dsDept.Tables.Clear();
            comm.CommandText = "select * from tblDept";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(dsDept, "dept");
            cmbDepartment.DataSource = dsDept.Tables["dept"];
            cmbDepartment.DisplayMember = "DName";
            cmbDepartment.ValueMember = "DNo";
        }
        void  LoadStates()
        {
            cmbStates.Text = "";
            dsStates.Tables.Clear();
            comm.CommandText = "select * from tblstates";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(dsStates,"States");
            cmbStates.DataSource = dsStates.Tables["States"];
            cmbStates.DisplayMember = "StateName";
            cmbStates.ValueMember = "StateId";
            if(dsStates.Tables["States"].Rows.Count>0)
            {
                blnstates = true;
            }
            if(blnstates)
            {
                int sid = Convert.ToInt32(dsStates.Tables["States"].Rows[0]["StateId"]);
                LoadDistrict(sid);
            }

        }
       void LoadDistrict(int stateid)
        {
            cmbDistrict.Text = "";
            dsDistrict.Tables.Clear();
            comm.CommandText = "select * from tblDistricts where StateId=@sid";
            comm.Parameters.AddWithValue("@sid", stateid);
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(dsDistrict,"district");
            comm.Parameters.Clear();
            cmbDistrict.DataSource = dsDistrict.Tables["district"];
            cmbDistrict.DisplayMember = "DistrictName";
            cmbDistrict.ValueMember = "DistrictId";
            if (dsDistrict.Tables["district"].Rows.Count > 0)
                blnDistrict = true;
            if(blnDistrict)
            {
                int did = Convert.ToInt32(dsDistrict.Tables["district"].Rows[0]["DistrictId"]);
                LoadCities(did);
            }

        }
        void LoadCities(int districtd)
        {
            cmbCities.Text = "";
            dsCities.Tables.Clear();
            comm.CommandText = "select * from tblCities where DistrictId=@did";
            comm.Parameters.AddWithValue("@did", districtd);
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(dsCities,"cities");
            comm.Parameters.Clear();
            cmbCities.DataSource = dsCities.Tables["cities"];
            cmbCities.DisplayMember = "CityName";
            cmbCities.ValueMember = "CityId";
            if(dsCities.Tables["cities"].Rows.Count>0)
            blnCities = true;
           
        }

        private void cmbStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(blnstates)
            {
                LoadDistrict(Convert.ToInt32(cmbStates.SelectedValue.ToString()));
            }
        }

        private void cmbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(blnDistrict)
            {
                LoadCities(Convert.ToInt32(cmbDistrict.SelectedValue.ToString()));
            }
        }
    }
}
