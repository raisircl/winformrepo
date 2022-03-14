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
    public partial class FrmListControls : Form
    {
        public FrmListControls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!listBox1.Items.Contains(textBox1.Text))
            listBox1.Items.Add(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = listBox1.Items.Count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = listBox1.Items.Count;
            label3.Text = "";
            for(int i=0;i<x;i++)
            {
                label3.Text +=  listBox1.Items[i].ToString() + "\n";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex>-1)
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            int x = listBox1.Items.Count;
            for(int i=0;i<x;i++)
            {
                listBox1.Items.RemoveAt(0);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = listBox1.SelectedIndex.ToString();
        }
    }
}
