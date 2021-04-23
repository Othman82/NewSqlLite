namespace NewSqlLite
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNIcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTitle
            // 
            this.cbTitle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Items.AddRange(new object[] {
            "Mr",
            "Miss",
            "Mrs",
            "Professor",
            "Colonel",
            "Rev"});
            this.cbTitle.Location = new System.Drawing.Point(47, 104);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(121, 21);
            this.cbTitle.TabIndex = 0;
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtLastname.Location = new System.Drawing.Point(315, 105);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(135, 20);
            this.txtLastname.TabIndex = 2;
            // 
            // txtPasswd
            // 
            this.txtPasswd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtPasswd.Location = new System.Drawing.Point(188, 258);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(135, 20);
            this.txtPasswd.TabIndex = 3;
            // 
            // txtAllowance
            // 
            this.txtAllowance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtAllowance.Location = new System.Drawing.Point(47, 330);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(135, 20);
            this.txtAllowance.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtEmail.Location = new System.Drawing.Point(47, 258);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(135, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtNIcode
            // 
            this.txtNIcode.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtNIcode.Location = new System.Drawing.Point(47, 186);
            this.txtNIcode.Name = "txtNIcode";
            this.txtNIcode.Size = new System.Drawing.Size(135, 20);
            this.txtNIcode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.ForeColor = System.Drawing.Color.SeaShell;
            this.btnAddCancel.Location = new System.Drawing.Point(404, 327);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(77, 39);
            this.btnAddCancel.TabIndex = 14;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.SeaShell;
            this.btnAddCustomer.Location = new System.Drawing.Point(300, 327);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(79, 39);
            this.btnAddCustomer.TabIndex = 15;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(196, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Firstname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lastname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "NI Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Allowance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password";
            // 
            // txtFirstname
            // 
            this.txtFirstname.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtFirstname.Location = new System.Drawing.Point(174, 105);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(135, 20);
            this.txtFirstname.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.PaleTurquoise;
            this.dateTimePicker1.Location = new System.Drawing.Point(315, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "DoB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "New Customer";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::NewSqlLite.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 391);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnAddCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNIcode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAllowance);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.cbTitle);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtAllowance;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNIcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
    }
}