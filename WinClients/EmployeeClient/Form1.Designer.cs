namespace EmployeeClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtDob = new System.Windows.Forms.DateTimePicker();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOneway = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOnewayEx = new System.Windows.Forms.Button();
            this.btnReqReply = new System.Windows.Forms.Button();
            this.btnDuplex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(111, 10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(63, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // dtDob
            // 
            this.dtDob.Location = new System.Drawing.Point(111, 83);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(200, 20);
            this.dtDob.TabIndex = 6;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "PermanantEmployee",
            "ContractEmployye"});
            this.cmbType.Location = new System.Drawing.Point(111, 144);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(111, 111);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 9;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(111, 181);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(40, 23);
            this.btnGet.TabIndex = 10;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(158, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOneway
            // 
            this.btnOneway.Location = new System.Drawing.Point(15, 311);
            this.btnOneway.Name = "btnOneway";
            this.btnOneway.Size = new System.Drawing.Size(307, 23);
            this.btnOneway.TabIndex = 12;
            this.btnOneway.Text = "Oneway Operation";
            this.btnOneway.UseVisualStyleBackColor = true;
            this.btnOneway.Click += new System.EventHandler(this.btnOneway_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 210);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(307, 69);
            this.listBox1.TabIndex = 13;
            // 
            // btnOnewayEx
            // 
            this.btnOnewayEx.Location = new System.Drawing.Point(15, 286);
            this.btnOnewayEx.Name = "btnOnewayEx";
            this.btnOnewayEx.Size = new System.Drawing.Size(307, 23);
            this.btnOnewayEx.TabIndex = 14;
            this.btnOnewayEx.Text = "Oneway Exception";
            this.btnOnewayEx.UseVisualStyleBackColor = true;
            this.btnOnewayEx.Click += new System.EventHandler(this.btnOnewayEx_Click);
            // 
            // btnReqReply
            // 
            this.btnReqReply.Location = new System.Drawing.Point(15, 341);
            this.btnReqReply.Name = "btnReqReply";
            this.btnReqReply.Size = new System.Drawing.Size(307, 23);
            this.btnReqReply.TabIndex = 15;
            this.btnReqReply.Text = "Request Reply";
            this.btnReqReply.UseVisualStyleBackColor = true;
            this.btnReqReply.Click += new System.EventHandler(this.btnReqReply_Click);
            // 
            // btnDuplex
            // 
            this.btnDuplex.Location = new System.Drawing.Point(15, 371);
            this.btnDuplex.Name = "btnDuplex";
            this.btnDuplex.Size = new System.Drawing.Size(307, 23);
            this.btnDuplex.TabIndex = 16;
            this.btnDuplex.Text = "Duplex";
            this.btnDuplex.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 420);
            this.Controls.Add(this.btnDuplex);
            this.Controls.Add(this.btnReqReply);
            this.Controls.Add(this.btnOnewayEx);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOneway);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.dtDob);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtDob;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOneway;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOnewayEx;
        private System.Windows.Forms.Button btnReqReply;
        private System.Windows.Forms.Button btnDuplex;
    }
}

