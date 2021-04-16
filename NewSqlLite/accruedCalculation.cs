using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace NewSqlLite
{
    public partial class accruedCalculation : Form
    {
        public accruedCalculation()
        {
            InitializeComponent();
        }

        SQLiteConnection conn;
        SQLiteDataAdapter da_Customer;  // To retrieve data from a data source and populate tables within a DataSet.
        DataTable dt_Customer;       // The DataTable class  is a database table representing and provides a collection of columns                            and rows to store data in a grid for
        SQLiteCommand cmd;


        private void btnAccrued_Click(object sender, EventArgs e)
        {

           // ShowAccounts();

        }

        private void ExecuteQuery1(string txtQuery1)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = txtQuery1;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void ExecuteQuery2(string txtQuery2)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = txtQuery2;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void ExecuteQuery3(string txtQuery3)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = txtQuery3;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnAccruedCalc_Click(object sender, EventArgs e)
        {
            conn.Open(); // Open connection to the database
            string txtQuery1 = "UPDATE account SET accrued = accrued + ( balance * (SELECT intrate FROM product WHERE account.prodid = product.prodid)/365.0);";
            MessageBox.Show("Accrued interest updated", "Accrued interest updated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ExecuteQuery1(txtQuery1);

        }


    }
}
