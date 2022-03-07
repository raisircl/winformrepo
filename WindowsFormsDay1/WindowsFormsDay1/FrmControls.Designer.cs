
namespace WindowsFormsDay1
{
    partial class FrmControls
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
            this.chkPlaying = new System.Windows.Forms.CheckBox();
            this.chkStudying = new System.Windows.Forms.CheckBox();
            this.gbHobbies = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.btnFeeConfirmation = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.lblFee = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPermaAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPermaState = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPermaCity = new System.Windows.Forms.TextBox();
            this.gbPersentAddress = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPerCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPerState = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPerAddress = new System.Windows.Forms.TextBox();
            this.chkAddressConfirm = new System.Windows.Forms.CheckBox();
            this.gbHobbies.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbPersentAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkPlaying
            // 
            this.chkPlaying.AutoSize = true;
            this.chkPlaying.Location = new System.Drawing.Point(34, 40);
            this.chkPlaying.Name = "chkPlaying";
            this.chkPlaying.Size = new System.Drawing.Size(76, 21);
            this.chkPlaying.TabIndex = 0;
            this.chkPlaying.Text = "Playing";
            this.chkPlaying.UseVisualStyleBackColor = true;
            // 
            // chkStudying
            // 
            this.chkStudying.AutoSize = true;
            this.chkStudying.Location = new System.Drawing.Point(34, 78);
            this.chkStudying.Name = "chkStudying";
            this.chkStudying.Size = new System.Drawing.Size(66, 21);
            this.chkStudying.TabIndex = 1;
            this.chkStudying.Text = "Study";
            this.chkStudying.UseVisualStyleBackColor = true;
            // 
            // gbHobbies
            // 
            this.gbHobbies.Controls.Add(this.btnSubmit);
            this.gbHobbies.Controls.Add(this.chkStudying);
            this.gbHobbies.Controls.Add(this.chkPlaying);
            this.gbHobbies.Location = new System.Drawing.Point(29, 37);
            this.gbHobbies.Name = "gbHobbies";
            this.gbHobbies.Size = new System.Drawing.Size(330, 220);
            this.gbHobbies.TabIndex = 2;
            this.gbHobbies.TabStop = false;
            this.gbHobbies.Text = "Select Your Hobbies";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(34, 118);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(124, 46);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(21, 18);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(66, 21);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "MALE";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(93, 18);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(83, 21);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "FEMALE";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // btnFeeConfirmation
            // 
            this.btnFeeConfirmation.Location = new System.Drawing.Point(442, 188);
            this.btnFeeConfirmation.Name = "btnFeeConfirmation";
            this.btnFeeConfirmation.Size = new System.Drawing.Size(132, 56);
            this.btnFeeConfirmation.TabIndex = 6;
            this.btnFeeConfirmation.Text = "Fee Confirmation";
            this.btnFeeConfirmation.UseVisualStyleBackColor = true;
            this.btnFeeConfirmation.Click += new System.EventHandler(this.btnGenderConfirmation_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(442, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 22);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(439, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 17);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Enter your Name:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(94, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "OBC";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 21);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Gen";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(211, 30);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 21);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ST";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(158, 30);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 21);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "SC";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(439, 250);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(46, 17);
            this.lblFee.TabIndex = 12;
            this.lblFee.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Location = new System.Drawing.Point(442, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 53);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Location = new System.Drawing.Point(442, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 72);
            this.panel2.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPermaCity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPermaState);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPermaAddress);
            this.groupBox1.Location = new System.Drawing.Point(816, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 200);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parmanent Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Address";
            // 
            // txtPermaAddress
            // 
            this.txtPermaAddress.Location = new System.Drawing.Point(18, 50);
            this.txtPermaAddress.Name = "txtPermaAddress";
            this.txtPermaAddress.Size = new System.Drawing.Size(209, 22);
            this.txtPermaAddress.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "State";
            // 
            // txtPermaState
            // 
            this.txtPermaState.Location = new System.Drawing.Point(18, 97);
            this.txtPermaState.Name = "txtPermaState";
            this.txtPermaState.Size = new System.Drawing.Size(209, 22);
            this.txtPermaState.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "City";
            // 
            // txtPermaCity
            // 
            this.txtPermaCity.Location = new System.Drawing.Point(18, 149);
            this.txtPermaCity.Name = "txtPermaCity";
            this.txtPermaCity.Size = new System.Drawing.Size(209, 22);
            this.txtPermaCity.TabIndex = 12;
            // 
            // gbPersentAddress
            // 
            this.gbPersentAddress.Controls.Add(this.label4);
            this.gbPersentAddress.Controls.Add(this.txtPerCity);
            this.gbPersentAddress.Controls.Add(this.label5);
            this.gbPersentAddress.Controls.Add(this.txtPerState);
            this.gbPersentAddress.Controls.Add(this.label6);
            this.gbPersentAddress.Controls.Add(this.txtPerAddress);
            this.gbPersentAddress.Location = new System.Drawing.Point(816, 260);
            this.gbPersentAddress.Name = "gbPersentAddress";
            this.gbPersentAddress.Size = new System.Drawing.Size(465, 200);
            this.gbPersentAddress.TabIndex = 16;
            this.gbPersentAddress.TabStop = false;
            this.gbPersentAddress.Text = "Present Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "City";
            // 
            // txtPerCity
            // 
            this.txtPerCity.Location = new System.Drawing.Point(18, 149);
            this.txtPerCity.Name = "txtPerCity";
            this.txtPerCity.Size = new System.Drawing.Size(209, 22);
            this.txtPerCity.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "State";
            // 
            // txtPerState
            // 
            this.txtPerState.Location = new System.Drawing.Point(18, 97);
            this.txtPerState.Name = "txtPerState";
            this.txtPerState.Size = new System.Drawing.Size(209, 22);
            this.txtPerState.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address";
            // 
            // txtPerAddress
            // 
            this.txtPerAddress.Location = new System.Drawing.Point(18, 50);
            this.txtPerAddress.Name = "txtPerAddress";
            this.txtPerAddress.Size = new System.Drawing.Size(209, 22);
            this.txtPerAddress.TabIndex = 8;
            // 
            // chkAddressConfirm
            // 
            this.chkAddressConfirm.AutoSize = true;
            this.chkAddressConfirm.Location = new System.Drawing.Point(816, 223);
            this.chkAddressConfirm.Name = "chkAddressConfirm";
            this.chkAddressConfirm.Size = new System.Drawing.Size(351, 21);
            this.chkAddressConfirm.TabIndex = 17;
            this.chkAddressConfirm.Text = "Is Present Address is Same as Parmanent Address";
            this.chkAddressConfirm.UseVisualStyleBackColor = true;
            this.chkAddressConfirm.CheckedChanged += new System.EventHandler(this.chkAddressConfirm_CheckedChanged);
            // 
            // FrmControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 653);
            this.Controls.Add(this.chkAddressConfirm);
            this.Controls.Add(this.gbPersentAddress);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnFeeConfirmation);
            this.Controls.Add(this.gbHobbies);
            this.Name = "FrmControls";
            this.Text = "FrmControls";
            this.gbHobbies.ResumeLayout(false);
            this.gbHobbies.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPersentAddress.ResumeLayout(false);
            this.gbPersentAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPlaying;
        private System.Windows.Forms.CheckBox chkStudying;
        private System.Windows.Forms.GroupBox gbHobbies;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Button btnFeeConfirmation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPermaCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPermaState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPermaAddress;
        private System.Windows.Forms.GroupBox gbPersentAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPerCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPerState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPerAddress;
        private System.Windows.Forms.CheckBox chkAddressConfirm;
    }
}