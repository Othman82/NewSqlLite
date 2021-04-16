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

           showProducts();  // if there no errors show all products
        }

        private void showProducts()
        {
            try
            {
                conn = new SQLiteConnection(dbConnections.source); // reading the database from the source (connection)
                string sqlcommand = @"SELECT * FROM product WHERE prodid";  // getting the content from the database

                da_Products = new SQLiteDataAdapter(sqlcommand, conn); //  create new data adpater to stor the data base temperorely (using sqlcommand) 
                dt_Products  = new DataTable(); // create new data  tables
                da_Products.Fill(dt_Products); // use the data adpater 
                dgv_product.DataSource = dt_Products;    // populate data grid view with the data from the data table 
            }

            catch (Exception ex) // incase of error exception message will be showen
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
