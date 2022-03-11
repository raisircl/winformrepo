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
    public partial class FrmEventDemo : Form
    {
        Button button;
        public FrmEventDemo()
        {
            InitializeComponent();

            button = new Button();
            button.Width = 100;
            button.Height = 50;
            button.Text = "Click Me";
            button.Top = 10;
            button.Left = 10;
            this.Controls.Add(button);
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello from click me");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void FrmEventDemo_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X + "," + e.Y;
        }
    }
}
