namespace NewSqlLite
{
    partial class Menu
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
            this.btnCustomerTools = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccountTools = new System.Windows.Forms.Button();
            this.btnProdTools = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomerTools
            // 
            this.btnCustomerTools.Location = new System.Drawing.Point(21, 100);
            this.btnCustomerTools.Name = "btnCustomerTools";
            this.btnCustomerTools.Size = new System.Drawing.Size(179, 37);
            this.btnCustomerTools.TabIndex = 0;
            this.btnCustomerTools.Text = "Customer Tools";
            this.btnCustomerTools.UseVisualStyleBackColor = true;
            this.btnCustomerTools.Click += new System.EventHandler(this.btnCustomerTools_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers ";
            // 
            // btnAccountTools
            // 
            this.btnAccountTools.Location = new System.Drawing.Point(229, 100);
            this.btnAccountTools.Name = "btnAccountTools";
            this.btnAccountTools.Size = new System.Drawing.Size(179, 37);
            this.btnAccountTools.TabIndex = 2;
            this.btnAccountTools.Text = "Account Tools";
            this.btnAccountTools.UseVisualStyleBackColor = true;
            // 
            // btnProdTools
            // 
            this.btnProdTools.Location = new System.Drawing.Point(452, 100);
            this.btnProdTools.Name = "btnProdTools";
            this.btnProdTools.Size = new System.Drawing.Size(179, 37);
            this.btnProdTools.TabIndex = 3;
            this.btnProdTools.Text = "Product Tools";
            this.btnProdTools.UseVisualStyleBackColor = true;
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(682, 100);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(179, 37);
            this.btnTransaction.TabIndex = 4;
            this.btnTransaction.Text = "Transactions";
            this.btnTransaction.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 260);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnProdTools);
            this.Controls.Add(this.btnAccountTools);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomerTools);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerTools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccountTools;
        private System.Windows.Forms.Button btnProdTools;
        private System.Windows.Forms.Button btnTransaction;
    }
}