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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accruedInterest));
            this.btnAccruedCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAccruedCalc
            // 
            this.btnAccruedCalc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAccruedCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccruedCalc.ForeColor = System.Drawing.Color.SeaShell;
            this.btnAccruedCalc.Location = new System.Drawing.Point(231, 116);
            this.btnAccruedCalc.Name = "btnAccruedCalc";
            this.btnAccruedCalc.Size = new System.Drawing.Size(253, 112);
            this.btnAccruedCalc.TabIndex = 0;
            this.btnAccruedCalc.Text = "Calculate";
            this.btnAccruedCalc.UseVisualStyleBackColor = false;
            this.btnAccruedCalc.Click += new System.EventHandler(this.btnAccruedCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Overnight Calculation of Accrued Interest";
            // 
            // accruedInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewSqlLite.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccruedCalc);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "accruedInterest";
            this.Text = "accruedInterest";
            this.Load += new System.EventHandler(this.accruedInterest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccruedCalc;
        private System.Windows.Forms.Label label1;
    }
}