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
    public partial class accruedInterest : Form
    {
        public accruedInterest()
        {
            InitializeComponent();
        }

        SQLiteConnection conn;
        SQLiteCommand cmd;


        private void accruedInterest_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SQLiteConnection();
                conn.ConnectionString = dbConnections.source;
                conn.Open();

            }
            catch (Exception ex)
            {

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void ExecuteQuery1(string txtQuery1)
        {
            //conn.Open();
            cmd = conn.CreateCommand();                 //Prepare connection for command
            cmd.CommandText = txtQuery1;                //Prepare command
            cmd.ExecuteNonQuery();                      // Excute command
            conn.Close();                              //Close connection
        }

        private void ExecuteQuery2(string txtQuery2)
        {
            //conn.Open();
            cmd = conn.CreateCommand();
                cmd.CommandText = txtQuery2;
                cmd.ExecuteNonQuery();
                conn.Close();
        }


        private void ExecuteQuery3(string txtQuery3)
        {
            //conn.Open();
            cmd = conn.CreateCommand();        //Prepare connection for command
            cmd.CommandText = txtQuery3;      //Prepare command
            cmd.ExecuteNonQuery();           // Excute command
            conn.Close();                   //Close connection
        }


        private void btnAccruedCalc_Click(object sender, EventArgs e)
        {
            //conn.Open(); // Open connection to the database
            string txtQuery1 = "UPDATE account SET accrued = accrued + ( balance * (SELECT intrate FROM product WHERE account.prodid = product.prodid)/365.0);";
            MessageBox.Show("Accrued interest updated", "Accrued interest updated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ExecuteQuery1(txtQuery1);

            allAcounts frm_allAccounts = new allAcounts(); // To show the all accounts form with new accrued figures after the calculation 
            frm_allAccounts.Show();
            this.Hide();
               
            

        }




    }  

  
}

