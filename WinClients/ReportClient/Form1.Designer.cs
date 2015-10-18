namespace ReportClient
{
    partial class Form1
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
            this.btnRun = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPerCall = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblPersession = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblSingle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(22, 13);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run Report";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(22, 42);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(197, 23);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download File";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Per Call";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPerCall
            // 
            this.lblPerCall.AutoSize = true;
            this.lblPerCall.Location = new System.Drawing.Point(104, 72);
            this.lblPerCall.Name = "lblPerCall";
            this.lblPerCall.Size = new System.Drawing.Size(35, 13);
            this.lblPerCall.TabIndex = 4;
            this.lblPerCall.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Per Session";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblPersession
            // 
            this.lblPersession.AutoSize = true;
            this.lblPersession.Location = new System.Drawing.Point(103, 101);
            this.lblPersession.Name = "lblPersession";
            this.lblPersession.Size = new System.Drawing.Size(35, 13);
            this.lblPersession.TabIndex = 6;
            this.lblPersession.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Single";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblSingle
            // 
            this.lblSingle.AutoSize = true;
            this.lblSingle.Location = new System.Drawing.Point(104, 126);
            this.lblSingle.Name = "lblSingle";
            this.lblSingle.Size = new System.Drawing.Size(35, 13);
            this.lblSingle.TabIndex = 8;
            this.lblSingle.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.lblSingle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblPersession);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblPerCall);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPerCall;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblPersession;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblSingle;
    }
}

