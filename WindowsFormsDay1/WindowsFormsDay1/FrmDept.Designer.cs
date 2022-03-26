
namespace WindowsFormsDay1
{
    partial class FrmDept
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtdno = new System.Windows.Forms.TextBox();
            this.txtdname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInactive = new System.Windows.Forms.Button();
            this.dgvDept = new System.Windows.Forms.DataGridView();
            this.txtloc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDept)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department No";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtdno
            // 
            this.txtdno.BackColor = System.Drawing.SystemColors.Info;
            this.txtdno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdno.Location = new System.Drawing.Point(220, 29);
            this.txtdno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdno.Name = "txtdno";
            this.txtdno.ReadOnly = true;
            this.txtdno.Size = new System.Drawing.Size(118, 32);
            this.txtdno.TabIndex = 1;
            this.txtdno.TabStop = false;
            // 
            // txtdname
            // 
            this.txtdname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdname.Location = new System.Drawing.Point(220, 73);
            this.txtdname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdname.Name = "txtdname";
            this.txtdname.Size = new System.Drawing.Size(262, 32);
            this.txtdname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(32, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 49);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(183, 183);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 49);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(337, 183);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 49);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(488, 183);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 49);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnInactive
            // 
            this.btnInactive.Location = new System.Drawing.Point(649, 183);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(145, 49);
            this.btnInactive.TabIndex = 10;
            this.btnInactive.Text = "Inactive";
            this.btnInactive.UseVisualStyleBackColor = true;
            this.btnInactive.Click += new System.EventHandler(this.btnInactive_Click);
            // 
            // dgvDept
            // 
            this.dgvDept.AllowUserToAddRows = false;
            this.dgvDept.AllowUserToDeleteRows = false;
            this.dgvDept.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDept.Location = new System.Drawing.Point(32, 292);
            this.dgvDept.Name = "dgvDept";
            this.dgvDept.ReadOnly = true;
            this.dgvDept.RowHeadersWidth = 51;
            this.dgvDept.RowTemplate.Height = 24;
            this.dgvDept.Size = new System.Drawing.Size(762, 194);
            this.dgvDept.TabIndex = 11;
            this.dgvDept.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDept_CellClick);
            this.dgvDept.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDept_CellEnter);
            // 
            // txtloc
            // 
            this.txtloc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtloc.Location = new System.Drawing.Point(220, 115);
            this.txtloc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtloc.Name = "txtloc";
            this.txtloc.Size = new System.Drawing.Size(262, 32);
            this.txtloc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Location = new System.Drawing.Point(40, 263);
            this.lblNotification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(0, 26);
            this.lblNotification.TabIndex = 12;
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 498);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.txtloc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDept);
            this.Controls.Add(this.btnInactive);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtdname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDept";
            this.Text = "FrmDept";
            this.Load += new System.EventHandler(this.FrmDept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdno;
        private System.Windows.Forms.TextBox txtdname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInactive;
        private System.Windows.Forms.DataGridView dgvDept;
        private System.Windows.Forms.TextBox txtloc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNotification;
    }
}