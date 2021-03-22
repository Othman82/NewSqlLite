using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; //SQLlite data base library

namespace NewSqlLite
{
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        SQLiteConnection conn; // Connecting to the data base source
        SQLiteCommand cmd;     // SQlite command to tell it to do somthing

        private void UpdateCustomer_Load(object sender, EventArgs e)    // When the form is loaded check connection & there is no errors 
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

            ShowCustomer();  // if there no errors show all customers 
        }

        private void ShowCustomer()    // To populate the update customer constantly
        {
            try // To ensure that if there is any error the program doesn't fall over 
            {
                txtCustid.Text = Global.selectedCust;
                cbTitle.Text = Global.selectedTitle;
                txtFirstname.Text = Global.selectedFirstname;
                txtLastname.Text = Global.selectedLastname;
                dateTimePicker1.Text = Global.selectedDOB;              // All information going from Global Vars to these text boxes 
                txtNIcode.Text = Global.selectedNI;
                txtEmail.Text = Global.selectedEmail;
                txtPasswd.Text = Global.selectedPassword;
                txtAllowance.Text = Global.selectedAllowance;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

        private void ExcuteQuery(string txtQuery) //Custome function - saves time when openning and closing queries-
        {
            cmd = conn.CreateCommand();     //Prepare connection for command
            cmd.CommandText = txtQuery;     //Prepare command
            cmd.ExecuteNonQuery();         // Excute command
            conn.Close();                  // Close connection
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string txtQuery = "UPDATE Customer SET title ='" + this.cbTitle.Text + "', firstname='" + this.txtFirstname.Text + "', lastname='" + this.txtLastname.Text + "', dob='" + this.dateTimePicker1.Text + "', nicode='" + this.txtNIcode.Text + "', email='" + this.txtEmail.Text + "', password='" + this.txtPasswd.Text + "', allowance='" + this.txtAllowance.Text + "' WHERE custid='" + this.txtCustid.Text + "';";

            MessageBox.Show("Information Updated", "Information Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ExcuteQuery(txtQuery);

            MainForm frm_main = new MainForm();
            frm_main.Show();
            this.Hide();
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {

            MainForm frm_main = new MainForm();
            frm_main.Show();
            this.Hide();
        }
    }
}
