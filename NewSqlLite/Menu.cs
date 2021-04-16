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

        private void btnCustomerTools_Click(object sender, EventArgs e)
        {
            accruedCalculation accrued = new accruedCalculation();
            accrued.Show();
        }
    }
    
}
