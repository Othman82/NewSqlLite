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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        SQLiteConnection conn;   // Connecting to the data base source

        private void AddCustomer_Load(object sender, EventArgs e)  // Check connection & call the data base 
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

        private void btnAddCustomer_Click(object sender, EventArgs e) // This method will allow a customer to be added to the form 
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO customer (title," + "firstname," + "lastname," + "dob," + "nicode," + "email," + "password," + "allowance) VALUES (@setTitle, @setFirstname, @setLastname, @setDOB, @setNIcode, @setEmail, @setPassword, @setAllowance)";
                cmd.Parameters.AddWithValue("setTitle", cbTitle.Text);
                cmd.Parameters.AddWithValue("setFirstname", txtFirstname.Text);
                cmd.Parameters.AddWithValue("setLastname", txtLastname.Text);
                cmd.Parameters.AddWithValue("setDOB", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("setNIcode", txtNIcode.Text);
                cmd.Parameters.AddWithValue("setEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("setPassword", txtPasswd.Text);
                cmd.Parameters.AddWithValue("setAllowance", txtAllowance.Text);

                int recordsChanged = cmd.ExecuteNonQuery();
                MessageBox.Show(recordsChanged.ToString() + "Records Added");
                conn.Close();


                MainForm mainform = new MainForm();  // After adding the customer user will be back to the MainForm 
                mainform.Show();
                this.Hide();


            }
        }



        private void btnAddCancel_Click(object sender, EventArgs e)   // When clicked new customer will be closed and it will go back to MainForm
        {
            MainForm frm_main = new MainForm();
            frm_main.Show();
            this.Hide();
        }

      
    }
}