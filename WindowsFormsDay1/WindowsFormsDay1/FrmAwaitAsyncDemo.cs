using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDay1
{
    public partial class FrmAwaitAsyncDemo : Form
    {
        public FrmAwaitAsyncDemo()
        {
            InitializeComponent();
        }

        int sum()
        {
            int s = 0;
            for(int i=1;i<=10;i++)
            {
                s = s + i;
            }
            Thread.Sleep(5000);
            return s;
        }
        private async void btnProcess_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(sum);
            task.Start();

            lblProcessing.Text = "data is loading please wait...";
            int s = await task; //sum();
            lblProcessing.Text = $"data loaded successfully. Your result is {s}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblsum.Text = textBox1.Text + textBox2.Text;
        }
    }
}
