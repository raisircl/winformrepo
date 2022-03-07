using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDay1
{
    public partial class FrmControls : Form
    {
        public FrmControls()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(chkPlaying.Checked && chkStudying.Checked)
            {
                MessageBox.Show("Excelent");
            }
            else if(chkStudying.Checked)
            {
                MessageBox.Show("Very Good");
            }
            else if(chkPlaying.Checked)
            {
                MessageBox.Show("Good");
            }
            else
            {
                MessageBox.Show("Please select one option");
            }
        }

        private void btnGenderConfirmation_Click(object sender, EventArgs e)
        {

            if(rbMale.Checked)
            {
                MessageBox.Show($"Hello Mr. {txtName.Text}");
            }
            else if(rbFemale.Checked)
            {
                MessageBox.Show($"Hello Ms. {txtName.Text}");
            }
            else
            {
                MessageBox.Show("Please select Gender");
            }

        }

        private void chkAddressConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAddressConfirm.Checked)
            {
                txtPerAddress.Text = txtPermaAddress.Text;
                txtPerCity.Text = txtPermaCity.Text;
                txtPerState.Text = txtPermaState.Text;
            }
            else
            {
                //txtPerAddress.Text = "";
                //txtPerCity.Text = "";
                //txtPerState.Text = "";
                foreach(Control ctrl in gbPersentAddress.Controls)
                {
                    if(ctrl.GetType()==typeof(TextBox))
                    ctrl.Text = "";
                }
            }
        }
    }
}
