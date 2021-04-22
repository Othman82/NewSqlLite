namespace NewSqlLite
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.txtProdid = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdatesStatus = new System.Windows.Forms.Button();
            this.txtIntrate = new System.Windows.Forms.TextBox();
            this.btnUpdateInterestRate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_product
            // 
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_product.Location = new System.Drawing.Point(0, 0);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.Size = new System.Drawing.Size(621, 464);
            this.dgv_product.TabIndex = 0;
            this.dgv_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellContentClick);
            // 
            // txtProdid
            // 
            this.txtProdid.AcceptsReturn = true;
            this.txtProdid.BackColor = System.Drawing.SystemColors.Control;
            this.txtProdid.Location = new System.Drawing.Point(662, 41);
            this.txtProdid.Name = "txtProdid";
            this.txtProdid.ReadOnly = true;
            this.txtProdid.Size = new System.Drawing.Size(121, 20);
            this.txtProdid.TabIndex = 1;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.White;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.cbStatus.Location = new System.Drawing.Point(662, 124);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(658, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status";
            // 
            // btnUpdatesStatus
            // 
            this.btnUpdatesStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdatesStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatesStatus.ForeColor = System.Drawing.Color.SeaShell;
            this.btnUpdatesStatus.Location = new System.Drawing.Point(662, 167);
            this.btnUpdatesStatus.Name = "btnUpdatesStatus";
            this.btnUpdatesStatus.Size = new System.Drawing.Size(121, 38);
            this.btnUpdatesStatus.TabIndex = 4;
            this.btnUpdatesStatus.Text = "Update";
            this.btnUpdatesStatus.UseVisualStyleBackColor = false;
            this.btnUpdatesStatus.Click += new System.EventHandler(this.btnUpdatesStatus_Click);
            // 
            // txtIntrate
            // 
            this.txtIntrate.BackColor = System.Drawing.Color.White;
            this.txtIntrate.Location = new System.Drawing.Point(662, 316);
            this.txtIntrate.Name = "txtIntrate";
            this.txtIntrate.Size = new System.Drawing.Size(121, 20);
            this.txtIntrate.TabIndex = 5;
            // 
            // btnUpdateInterestRate
            // 
            this.btnUpdateInterestRate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInterestRate.ForeColor = System.Drawing.Color.SeaShell;
            this.btnUpdateInterestRate.Location = new System.Drawing.Point(662, 353);
            this.btnUpdateInterestRate.Name = "btnUpdateInterestRate";
            this.btnUpdateInterestRate.Size = new System.Drawing.Size(121, 38);
            this.btnUpdateInterestRate.TabIndex = 6;
            this.btnUpdateInterestRate.Text = "Update";
            this.btnUpdateInterestRate.UseVisualStyleBackColor = false;
            this.btnUpdateInterestRate.Click += new System.EventHandler(this.btnUpdateInterestRate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(658, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Interest Rate";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(840, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdateInterestRate);
            this.Controls.Add(this.txtIntrate);
            this.Controls.Add(this.btnUpdatesStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtProdid);
            this.Controls.Add(this.dgv_product);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.TextBox txtProdid;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdatesStatus;
        private System.Windows.Forms.TextBox txtIntrate;
        private System.Windows.Forms.Button btnUpdateInterestRate;
        private System.Windows.Forms.Label label2;
    }
}