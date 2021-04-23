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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateAccruedIntetrestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.productToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllCustomersToolStripMenuItem,
            this.addCustomerToolStripMenuItem,
            this.updateCustomerToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // showAllCustomersToolStripMenuItem
            // 
            this.showAllCustomersToolStripMenuItem.Name = "showAllCustomersToolStripMenuItem";
            this.showAllCustomersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showAllCustomersToolStripMenuItem.Text = "Show All Customers";
            this.showAllCustomersToolStripMenuItem.Click += new System.EventHandler(this.showAllCustomersToolStripMenuItem_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllAccountsToolStripMenuItem,
            this.calculateAccruedIntetrestToolStripMenuItem,
            this.showBalanceToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // showAllAccountsToolStripMenuItem
            // 
            this.showAllAccountsToolStripMenuItem.Name = "showAllAccountsToolStripMenuItem";
            this.showAllAccountsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.showAllAccountsToolStripMenuItem.Text = "Show All Accounts";
            this.showAllAccountsToolStripMenuItem.Click += new System.EventHandler(this.showAllAccountsToolStripMenuItem_Click);
            // 
            // calculateAccruedIntetrestToolStripMenuItem
            // 
            this.calculateAccruedIntetrestToolStripMenuItem.Name = "calculateAccruedIntetrestToolStripMenuItem";
            this.calculateAccruedIntetrestToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.calculateAccruedIntetrestToolStripMenuItem.Text = "Calculate Accrued Intetrest";
            this.calculateAccruedIntetrestToolStripMenuItem.Click += new System.EventHandler(this.calculateAccruedIntetrestToolStripMenuItem_Click);
            // 
            // showBalanceToolStripMenuItem
            // 
            this.showBalanceToolStripMenuItem.Name = "showBalanceToolStripMenuItem";
            this.showBalanceToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.showBalanceToolStripMenuItem.Text = "Show Balance";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProductToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // updateProductToolStripMenuItem
            // 
            this.updateProductToolStripMenuItem.Name = "updateProductToolStripMenuItem";
            this.updateProductToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.updateProductToolStripMenuItem.Text = "Update Product";
            this.updateProductToolStripMenuItem.Click += new System.EventHandler(this.updateProductToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewSqlLite.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateAccruedIntetrestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductToolStripMenuItem;
    }
}