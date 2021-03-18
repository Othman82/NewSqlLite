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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        SQLiteConnection conn;
        SQLiteDataAdapter da_Customer; //to retrieve data from a data source and populate tables within a DataSet.
        DataTable dt_Customer; //The DataTable class  is a database table representing and provides a collection of columns and rows to store data in a grid for

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SQLiteConnection();
                conn.ConnectionString = dbConnections.source;
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                
                    tssImage.BackgroundImage = Properties.Resources.grn;
                    tssImage.Text = "- Connected - ";
                

            }
            catch (Exception ex)
            {

                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Close();
                
                    tssImage.BackgroundImage = Properties.Resources.red;
                    tssImage.Text = "- Not Connected - ";
                MessageBox.Show(ex.Message);

            }

            showAllcustomer();

        }

        private void showAllcustomer()
        {
            try
            {
                conn = new SQLiteConnection(dbConnections.source); // reading the database from the source (connection)
                string sqlcommand = @"SELECT * FROM customer";  // getting the content from the database

                da_Customer = new SQLiteDataAdapter(sqlcommand, conn); //  create new data adpater to stor the data base temperorely (using sqlcommand) 
                dt_Customer = new DataTable(); // create new data  tables
                da_Customer.Fill(dt_Customer); // use the data adpater 
                dgv_customer.DataSource = dt_Customer;    // populate data grid view with the data from the data table 
            }

            catch (Exception ex) // incase of error exception message will be showen
            {
                MessageBox.Show(ex.Message); 
               
            }
        }

        private void btn_AddCust_Click(object sender, EventArgs e)
        {
            AddCustomer newCust = new AddCustomer();
            newCust.Show();
            this.Hide();
        }

        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgv_customer.Rows[e.RowIndex];
                Global.selectedCust = dgvRow.Cells[0].Value.ToString();
                Global.selectedTitle = dgvRow.Cells[1].Value.ToString();
                Global.selectedFirstname = dgvRow.Cells[2].Value.ToString();
                Global.selectedLastname = dgvRow.Cells[3].Value.ToString();
                Global.selectedDOB= dgvRow.Cells[4].Value.ToString();
                Global.selectedNI = dgvRow.Cells[5].Value.ToString();
                Global.selectedEmail = dgvRow.Cells[6].Value.ToString();
                Global.selectedPassword= dgvRow.Cells[7].Value.ToString();
                Global.selectedAllowance = dgvRow.Cells[0].Value.ToString();

            }

            txtCustid.Text = Global.selectedCust;
        }
    }
}
