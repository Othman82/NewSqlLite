namespace NewSqlLite
{
    partial class allAcounts
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
            this.dgvAllacounts = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllacounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllacounts
            // 
            this.dgvAllacounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllacounts.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dgvAllacounts.Location = new System.Drawing.Point(0, -2);
            this.dgvAllacounts.Name = "dgvAllacounts";
            this.dgvAllacounts.Size = new System.Drawing.Size(766, 420);
            this.dgvAllacounts.TabIndex = 0;
            this.dgvAllacounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllacounts_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.SeaShell;
            this.btnBack.Location = new System.Drawing.Point(321, 435);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 47);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // allAcounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 503);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvAllacounts);
            this.Name = "allAcounts";
            this.Text = "allAcounts";
            this.Load += new System.EventHandler(this.allAcounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllacounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllacounts;
        private System.Windows.Forms.Button btnBack;
    }
}