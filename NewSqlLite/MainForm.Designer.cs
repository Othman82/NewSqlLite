namespace NewSqlLite
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgv_customer = new System.Windows.Forms.DataGridView();
            this.btn_AddCust = new System.Windows.Forms.Button();
            this.btn_Update_Cust = new System.Windows.Forms.Button();
            this.btn_Del_Cust = new System.Windows.Forms.Button();
            this.tssImage = new System.Windows.Forms.ToolStrip();
            this.txtCustid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_customer
            // 
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customer.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_customer.Location = new System.Drawing.Point(0, 0);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.Size = new System.Drawing.Size(833, 474);
            this.dgv_customer.TabIndex = 0;
            this.dgv_customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellClick);
            this.dgv_customer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellDoubleClick);
            // 
            // btn_AddCust
            // 
            this.btn_AddCust.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_AddCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCust.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_AddCust.Location = new System.Drawing.Point(867, 119);
            this.btn_AddCust.Name = "btn_AddCust";
            this.btn_AddCust.Size = new System.Drawing.Size(110, 51);
            this.btn_AddCust.TabIndex = 1;
            this.btn_AddCust.Text = "Add Customer";
            this.btn_AddCust.UseVisualStyleBackColor = false;
            this.btn_AddCust.Click += new System.EventHandler(this.btn_AddCust_Click);
            // 
            // btn_Update_Cust
            // 
            this.btn_Update_Cust.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Update_Cust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Cust.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Update_Cust.Location = new System.Drawing.Point(867, 200);
            this.btn_Update_Cust.Name = "btn_Update_Cust";
            this.btn_Update_Cust.Size = new System.Drawing.Size(110, 52);
            this.btn_Update_Cust.TabIndex = 2;
            this.btn_Update_Cust.Text = "Update Customer";
            this.btn_Update_Cust.UseVisualStyleBackColor = false;
            this.btn_Update_Cust.Click += new System.EventHandler(this.btn_Update_Cust_Click);
            // 
            // btn_Del_Cust
            // 
            this.btn_Del_Cust.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Del_Cust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del_Cust.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Del_Cust.Location = new System.Drawing.Point(867, 276);
            this.btn_Del_Cust.Name = "btn_Del_Cust";
            this.btn_Del_Cust.Size = new System.Drawing.Size(110, 57);
            this.btn_Del_Cust.TabIndex = 3;
            this.btn_Del_Cust.Text = "Delete Customer";
            this.btn_Del_Cust.UseVisualStyleBackColor = false;
            this.btn_Del_Cust.Click += new System.EventHandler(this.btn_Del_Cust_Click);
            // 
            // tssImage
            // 
            this.tssImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tssImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tssImage.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.tssImage.Location = new System.Drawing.Point(833, 449);
            this.tssImage.Name = "tssImage";
            this.tssImage.Size = new System.Drawing.Size(178, 25);
            this.tssImage.Stretch = true;
            this.tssImage.TabIndex = 4;
            this.tssImage.Text = "toolStrip1";
            // 
            // txtCustid
            // 
            this.txtCustid.Location = new System.Drawing.Point(867, 12);
            this.txtCustid.Name = "txtCustid";
            this.txtCustid.ReadOnly = true;
            this.txtCustid.Size = new System.Drawing.Size(100, 20);
            this.txtCustid.TabIndex = 5;
            this.txtCustid.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1011, 474);
            this.Controls.Add(this.txtCustid);
            this.Controls.Add(this.tssImage);
            this.Controls.Add(this.btn_Del_Cust);
            this.Controls.Add(this.btn_Update_Cust);
            this.Controls.Add(this.btn_AddCust);
            this.Controls.Add(this.dgv_customer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.Button btn_AddCust;
        private System.Windows.Forms.Button btn_Update_Cust;
        private System.Windows.Forms.Button btn_Del_Cust;
        private System.Windows.Forms.ToolStrip tssImage;
        private System.Windows.Forms.TextBox txtCustid;
    }
}

