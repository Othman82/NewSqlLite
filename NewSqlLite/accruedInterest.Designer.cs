namespace NewSqlLite
{
    partial class accruedInterest
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
            this.btnAccruedCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccruedCalc
            // 
            this.btnAccruedCalc.Location = new System.Drawing.Point(278, 169);
            this.btnAccruedCalc.Name = "btnAccruedCalc";
            this.btnAccruedCalc.Size = new System.Drawing.Size(233, 87);
            this.btnAccruedCalc.TabIndex = 0;
            this.btnAccruedCalc.Text = "Overnight Calculation of Accrued Interest";
            this.btnAccruedCalc.UseVisualStyleBackColor = true;
            this.btnAccruedCalc.Click += new System.EventHandler(this.btnAccruedCalc_Click);
            // 
            // accruedInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAccruedCalc);
            this.Name = "accruedInterest";
            this.Text = "accruedInterest";
            this.Load += new System.EventHandler(this.accruedInterest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccruedCalc;
    }
}