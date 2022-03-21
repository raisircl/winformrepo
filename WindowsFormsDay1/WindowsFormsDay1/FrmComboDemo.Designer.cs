
namespace WindowsFormsDay1
{
    partial class FrmComboDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOrders = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPCode = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOfferPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "C",
            "C++",
            "VB",
            "Oracle",
            "Java"});
            this.comboBox1.Location = new System.Drawing.Point(60, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(60, 122);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(229, 24);
            this.cmbProducts.TabIndex = 2;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // cmbOrders
            // 
            this.cmbOrders.FormattingEnabled = true;
            this.cmbOrders.Location = new System.Drawing.Point(60, 276);
            this.cmbOrders.Name = "cmbOrders";
            this.cmbOrders.Size = new System.Drawing.Size(229, 24);
            this.cmbOrders.TabIndex = 7;
            this.cmbOrders.SelectedIndexChanged += new System.EventHandler(this.cmbOrders_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(583, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Product Code";
            // 
            // txtPCode
            // 
            this.txtPCode.Location = new System.Drawing.Point(683, 61);
            this.txtPCode.Name = "txtPCode";
            this.txtPCode.Size = new System.Drawing.Size(100, 22);
            this.txtPCode.TabIndex = 13;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(683, 99);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(187, 22);
            this.txtPName.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(583, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Product Name";
            // 
            // txtMRP
            // 
            this.txtMRP.Location = new System.Drawing.Point(683, 140);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(100, 22);
            this.txtMRP.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(583, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "MRP";
            // 
            // txtOfferPrice
            // 
            this.txtOfferPrice.Location = new System.Drawing.Point(683, 185);
            this.txtOfferPrice.Name = "txtOfferPrice";
            this.txtOfferPrice.Size = new System.Drawing.Size(100, 22);
            this.txtOfferPrice.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(583, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Offer Price";
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Location = new System.Drawing.Point(719, 229);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(97, 34);
            this.btnSaveProduct.TabIndex = 20;
            this.btnSaveProduct.Text = "Add Product";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsDay1.Properties.Resources.profile_;
            this.pictureBox1.Location = new System.Drawing.Point(393, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmComboDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 613);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.txtOfferPrice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMRP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPCode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbOrders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmComboDemo";
            this.Text = "FrmComboDemo";
            this.Load += new System.EventHandler(this.FrmComboDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOrders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPCode;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOfferPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}