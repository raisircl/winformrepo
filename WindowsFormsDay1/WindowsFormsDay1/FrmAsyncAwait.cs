using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDay1
{
    public partial class FrmAsyncAwait : Form
    {
        public FrmAsyncAwait()
        {
            InitializeComponent();
        }
        int CharactersCount()
        {
            int count = 0;
            using (StreamReader sr = new StreamReader(@"E:\code\log.txt"))
            {
                string content = sr.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
           return count;
        }
        private async void btnProcess_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CharactersCount);
            task.Start();

            lblContent.Text = "File is Processing Please wait...";

            int count = await task;
            lblContent.Text = $"File length after processing is {count}";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
