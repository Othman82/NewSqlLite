namespace NewSqlLite
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
            this.dgv_customer = new System.Windows.Forms.DataGridView();
            this.btn_AddCust = new System.Windows.Forms.Button();
            this.btn_Update_Cust = new System.Windows.Forms.Button();
            this.btn_Del_Cust = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_customer
            // 
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customer.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_customer.Location = new System.Drawing.Point(0, 0);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.Size = new System.Drawing.Size(916, 497);
            this.dgv_customer.TabIndex = 0;
            // 
            // btn_AddCust
            // 
            this.btn_AddCust.Location = new System.Drawing.Point(1008, 41);
            this.btn_AddCust.Name = "btn_AddCust";
            this.btn_AddCust.Size = new System.Drawing.Size(96, 38);
            this.btn_AddCust.TabIndex = 1;
            this.btn_AddCust.Text = "Add Customer";
            this.btn_AddCust.UseVisualStyleBackColor = true;
            // 
            // btn_Update_Cust
            // 
            this.btn_Update_Cust.Location = new System.Drawing.Point(1008, 108);
            this.btn_Update_Cust.Name = "btn_Update_Cust";
            this.btn_Update_Cust.Size = new System.Drawing.Size(96, 38);
            this.btn_Update_Cust.TabIndex = 2;
            this.btn_Update_Cust.Text = "Update Customer";
            this.btn_Update_Cust.UseVisualStyleBackColor = true;
            // 
            // btn_Del_Cust
            // 
            this.btn_Del_Cust.Location = new System.Drawing.Point(1008, 187);
            this.btn_Del_Cust.Name = "btn_Del_Cust";
            this.btn_Del_Cust.Size = new System.Drawing.Size(96, 38);
            this.btn_Del_Cust.TabIndex = 3;
            this.btn_Del_Cust.Text = "Delete Customer";
            this.btn_Del_Cust.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 497);
            this.Controls.Add(this.btn_Del_Cust);
            this.Controls.Add(this.btn_Update_Cust);
            this.Controls.Add(this.btn_AddCust);
            this.Controls.Add(this.dgv_customer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.Button btn_AddCust;
        private System.Windows.Forms.Button btn_Update_Cust;
        private System.Windows.Forms.Button btn_Del_Cust;
    }
}

