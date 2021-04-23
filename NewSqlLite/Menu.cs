using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSqlLite
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void showAllCustomersToolStripMenuItem_Click(object sender, EventArgs e) // To call MainForm 
        {
            MainForm frm_main = new MainForm();
            frm_main.Show();
            //this.Hide();
        }

        private void showAllAccountsToolStripMenuItem_Click(object sender, EventArgs e) // To Call Product form 
        {
            Account frm_account = new Account();
            frm_account.Show();
        }

        private void calculateAccruedIntetrestToolStripMenuItem_Click(object sender, EventArgs e) // To call Acrrued Interest calculation form
        {
            accruedInterest frm_accrued = new accruedInterest();
            frm_accrued.Show();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e) // To Call Update product Form 
        {
            Product frm_products = new Product();
            frm_products.Show();
            // this.Hide();
        }
    }
}
