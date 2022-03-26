
namespace WindowsFormsDay1
{
    partial class FrmAwaitAsyncDemo
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
            this.lblProcessing = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblsum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProcessing
            // 
            this.lblProcessing.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProcessing.Location = new System.Drawing.Point(46, 101);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(401, 52);
            this.lblProcessing.TabIndex = 0;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(524, 103);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(191, 61);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "5";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 335);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblsum
            // 
            this.lblsum.AutoSize = true;
            this.lblsum.Location = new System.Drawing.Point(190, 444);
            this.lblsum.Name = "lblsum";
            this.lblsum.Size = new System.Drawing.Size(46, 17);
            this.lblsum.TabIndex = 5;
            this.lblsum.Text = "label1";
            // 
            // FrmAwaitAsyncDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 559);
            this.Controls.Add(this.lblsum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lblProcessing);
            this.Name = "FrmAwaitAsyncDemo";
            this.Text = "FrmAwaitAsyncDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblsum;
    }
}