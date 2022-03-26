
namespace WindowsFormsDay1
{
    partial class FrmAsyncAwait
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
            this.lblContent = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContent
            // 
            this.lblContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContent.Location = new System.Drawing.Point(49, 196);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(567, 47);
            this.lblContent.TabIndex = 0;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(164, 70);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(269, 72);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process File";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "Process File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAsyncAwait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lblContent);
            this.Name = "FrmAsyncAwait";
            this.Text = "FrmAsyncAwait";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button button1;
    }
}