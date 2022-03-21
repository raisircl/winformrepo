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
    public partial class FrmComboDemo : Form
    {
        public FrmComboDemo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
        }
        List<Product> products = new List<Product>();
        List<Order> orders = new List<Order>();

        bool blnproducts = false;
        bool blnorders=false;
        private void FrmComboDemo_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = WindowsFormsDay1.Properties.Resources.sircl_logo;
            pictureBox1.Image = Image.FromFile(@"ganesha.jpg");

            pictureBox1.Image.Save("newganesha.jpg");
            
            products.Add(new Product() { Code = 1001, Name = "CD",MRP=300.55M, OfferPrice=275.80M });
            products.Add(new Product() { Code = 1002, Name = "DVD", MRP = 300.55M, OfferPrice = 275.80M });
            products.Add(new Product() { Code = 1003, Name = "Mother Board", MRP = 300.55M, OfferPrice = 275.80M });
            products.Add(new Product() { Code = 1004, Name = "Pen Drive", MRP = 600.55M, OfferPrice = 575.80M });
            products.Add(new Product() { Code = 1005, Name = "HDD", MRP = 2500.55M, OfferPrice = 2000.80M });
            products.Add(new Product() { Code = 1006, Name = "SSD",MRP = 3000.55M, OfferPrice = 2375.80M });
            cmbProducts.DataSource = products;
            cmbProducts.DisplayMember = "Name";
            cmbProducts.ValueMember = "Code";

            blnproducts = true;

            orders.Add(new Order() { OrderNo = 1, ProductCode = 1001, Price = 275.80M, Qty=10});
            orders.Add(new Order() { OrderNo = 1, ProductCode = 1005, Price = 2000.80M, Qty=5 });
            orders.Add(new Order() { OrderNo = 1, ProductCode = 1003, Price = 275.80M, Qty=17 });

            orders.Add(new Order() { OrderNo = 2, ProductCode = 1001, Price = 275.80M, Qty=12 });
            orders.Add(new Order() { OrderNo = 2, ProductCode = 1004, Price = 575.80M, Qty=9 });

            orders.Add(new Order() { OrderNo = 3, ProductCode = 1003, Price = 275.80M, Qty=7 });


            //loadProducts();
        }
        void loadProducts()
        {
            if (blnproducts)
            {
                //label2.Text = cmbProducts.SelectedValue.ToString();
                //label3.Text = cmbProducts.SelectedItem.ToString();
                Product product = (Product)cmbProducts.SelectedItem;
                label2.Text = product.Code.ToString();
                label3.Text = product.Name;
                label4.Text = product.MRP.ToString();
                label5.Text = product.OfferPrice.ToString();

                List<Order> productOrders = new List<Order>();
                blnorders = false;
                cmbOrders.Text = "";
                foreach (Order order in orders)
                {
                    if (product.Code == order.ProductCode)
                    {
                        productOrders.Add(order);
                    }
                }
                blnorders = true;
                if (blnorders)
                {
                    cmbOrders.DataSource = productOrders;
                    cmbOrders.DisplayMember = "OrderNo";
                    cmbOrders.ValueMember = "Total";
                }
            }
        }
        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            loadProducts();
        }

        private void cmbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(blnorders)
            {
                Order order = (Order)cmbOrders.SelectedItem;
                label9.Text = order.Price.ToString();
                label8.Text = order.Qty.ToString();
                
                order.Total = order.Price*order.Qty;

                label7.Text = order.Total.ToString();
                
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
           
            blnproducts = false;
            cmbProducts.DataSource = null;

            Product product = new Product();
            product.Code = Convert.ToInt32(txtPCode.Text);
            product.Name = txtPName.Text;
            product.MRP = Convert.ToDecimal(txtMRP.Text);
            product.OfferPrice = Convert.ToDecimal(txtOfferPrice.Text);
            
            products.Add(product);
            
            cmbProducts.DataSource = products;
            cmbProducts.DisplayMember = "Name";
            cmbProducts.ValueMember = "Code";
            
            MessageBox.Show("Product Added");
            blnproducts = true;
        }
    }
}
// state
