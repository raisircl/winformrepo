using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDay1.Reports;
namespace WindowsFormsDay1
{
    public partial class FrmDeptReport : Form
    {
        public FrmDeptReport()
        {
            InitializeComponent();
        }
        CRDepartment cr = new CRDepartment();
        private void FrmDeptReport_Load(object sender, EventArgs e)
        {
            cr.SetDataSource(Common.dsprint.Tables["dept"]);
            crvDeprartment.ReportSource = cr;
        }
    }
}
//step 1 - dataset create
//step 2 - create crystal report from dataset 
// step 3 - create from and add crv
// step 4 - create common class - create static variable of dataset 
// step 5 - create print button
// on click of print set dataset of common class to ds
// load the report form 
// create object of crystal report
// set datasource of crstal report object to common dataset 
// set crv report source to crystal report object