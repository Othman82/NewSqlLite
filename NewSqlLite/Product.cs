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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        SQLiteConnection conn;   // Connecting to the data base source
        SQLiteDataAdapter da_Products;  // To retrieve data from a data source and populate tables within a DataSet.
        DataTable dt_Products;       // The DataTable class  is a database table representing and provides a collection of columns                            and rows to store data in a grid for
        SQLiteCommand cmd;     // SQlite command to tell it to do somthing

        private void Product_Load(object sender, EventArgs e)
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

          ShowProduct();  // if there no errors show all products

        }




        private void ShowProduct()
        {
            try
            {
                conn = new SQLiteConnection(dbConnections.source); // reading the database from the source (connection)
                string sqlcommand = @"SELECT * FROM product WHERE prodid";  // getting the content from the database

                da_Products = new SQLiteDataAdapter(sqlcommand, conn); //  create new data adpater to stor the data base temperorely (using sqlcommand) 
                dt_Products = new DataTable(); // create new data  tables
                da_Products.Fill(dt_Products); // use the data adpater 
                dgv_product.DataSource = dt_Products;    // populate data grid view with the data from the data table 
            }

            catch (Exception ex) // incase of error exception message will be showen
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ExcuteQuery(string txtQuery) //Custome function - saves time when openning and closing queries-
        {
            cmd = conn.CreateCommand();     //Prepare connection for command
            cmd.CommandText = txtQuery;     //Prepare command
            cmd.ExecuteNonQuery();         // Excute command
            conn.Close();                  // Close connection
        }

        private void btnUpdatesStatus_Click(object sender, EventArgs e)
        {
            conn.Open();
            string txtQuery = "UPDATE product SET status ='" + this.cbStatus.Text + "' WHERE prodid ='" + this.txtProdid.Text + "';";
            MessageBox.Show("Status Updated", "Status Updated!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ExcuteQuery(txtQuery);
            ShowProduct();
            Global.selectedStatus = cbStatus.Text;
        }

        private void btnUpdateInterestRate_Click(object sender, EventArgs e)
        {
            conn.Open();
            string txtQuery = "UPDATE product SET intrate ='" + this.txtIntrate.Text + "' WHERE prodid ='" + this.txtProdid.Text + "';";
            MessageBox.Show("Interest Rate Updated", "Interest Rate Updated!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ExcuteQuery(txtQuery);
            ShowProduct();
            Global.selectedIntrate = txtIntrate.Text;
        }

        private void dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgv_product.Rows[e.RowIndex];
                Global.selectedProd = dgvRow.Cells[0].Value.ToString();
                Global.selectedISAName = dgvRow.Cells[1].Value.ToString();
                Global.selectedStatus = dgvRow.Cells[2].Value.ToString();
                Global.selectedTransin = dgvRow.Cells[3].Value.ToString();
                Global.selectedIntrate = dgvRow.Cells[4].Value.ToString();
            }

            txtProdid.Text = Global.selectedProd;
        }


    }
}
