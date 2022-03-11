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
    public partial class FrmCalc : Form
    {
        double n1, n2, r;
        double temp;
        string op;
        public FrmCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = button1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = button3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = button2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = button5.Text;
        }

        private void commonbtn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = btn.Text;
        }
    }
}
