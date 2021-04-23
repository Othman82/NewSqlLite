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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        SQLiteConnection conn;
        SQLiteDataAdapter da_Account;  // To retrieve data from a data source and populate tables within a DataSet.
        DataTable dt_Account;         // The DataTable class  is a database table representing and provides a collection of column                                and rows to store data in a grid for
      

        private void Account_Load(object sender, EventArgs e)
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

            ShowAccount();  // if there no errors show all customers 
        }

        private void ShowAccount() 
        {
            try
            {

                conn = new SQLiteConnection(dbConnections.source); // reading the database from the source (connection)
                string sqlcommand = @"SELECT * FROM account WHERE custid ='" + Global.selectedCust + "';";  // getting the content from the database

                da_Account = new SQLiteDataAdapter(sqlcommand, conn); //  create new data adpater to stor the data base temperorely (using sqlcommand)
                dt_Account = new DataTable(); // create new data  tables
                da_Account.Fill(dt_Account); // use the data adpater 
                dgv_account.DataSource = dt_Account;    // populate data grid view with the data from the data table 
            }

            catch (Exception ex) // incase of error exception message will be showen
            {
                MessageBox.Show(ex.Message);

            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm frm_main = new MainForm();
            frm_main.Show();
            this.Hide();
        }
    }
}
