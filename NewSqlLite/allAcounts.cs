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
    public partial class allAcounts : Form
    {
        public allAcounts()
        {
            InitializeComponent();
        }

        SQLiteConnection conn;
        SQLiteDataAdapter da_allAccounts;  // To retrieve data from a data source and populate tables within a DataSet.
        DataTable dt_allAccounts;         // The DataTable class  is a database table representing and provides a collection of column                                and rows to store data in a grid for

        private void allAcounts_Load(object sender, EventArgs e)
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

            ShowallAccounts();  // if there no errors show all customers 

        }

        private void ShowallAccounts()
        {
            try
            {
                conn = new SQLiteConnection(dbConnections.source); // reading the database from the source (connection)
                string sqlcommand = @"SELECT * FROM account";

                da_allAccounts = new SQLiteDataAdapter(sqlcommand, conn); //  create new data adpater to stor the data base temperorely (using sqlcommand)
                dt_allAccounts = new DataTable(); // create new data  tables
                da_allAccounts.Fill(dt_allAccounts); // use the data adpater 
                dgvAllacounts.DataSource = dt_allAccounts;    // populate data grid view with the data from the data table 
            }

            catch (Exception ex) // incase of error exception message will be showen
            {
                MessageBox.Show(ex.Message);

            }
        }



        private void dgvAllacounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)        // What cell is actually on (when I select somthing I want to do somthing)
            {
                DataGridViewRow dgvRow = dgvAllacounts.Rows[e.RowIndex];
                Global.selectedAccid = dgvRow.Cells[0].Value.ToString();
                Global.selectedCustid = dgvRow.Cells[1].Value.ToString();
                Global.selectedProdid = dgvRow.Cells[2].Value.ToString();
                Global.selectedBalance = dgvRow.Cells[3].Value.ToString();
                Global.selectedAccrued = dgvRow.Cells[4].Value.ToString();
                Global.selectedActive = dgvRow.Cells[5].Value.ToString();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu frm_menu = new Menu();
            frm_menu.Show();
            this.Hide();
        }
    }
}
