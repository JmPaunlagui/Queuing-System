using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
//MySQLConnector
using MySql.Data.MySqlClient;

namespace QueuingSystem_1
{
    public partial class Main : Form
    {
        public static string NameQueu;
        public static string LastName;
        public Main()
        {
            InitializeComponent();
        }

        public string getNameValue
        {
            get { return txtLastname.Text;  }
            
        }
        MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; user=root; password=; database=queus_db");
        /*
         Tabel name queus_table_list 11columns
         */
        //REGISTER
        private void btnRegister_Click(object sender, EventArgs e)
        {
            /* 
             * validate method, to ensure that there is data inputed
             */
            validate();

            /*
             * To get the value from the radiobuttons
             */
            string genderVal = "";

            if (rbMale.Checked == true)
            {
                genderVal = rbMale.Text;
            }
            else if (rbFemale.Checked == true)
            {
                genderVal = rbFemale.Text;
            }
            /*
             * SQL Command, to insert the data into the database Don't Change anything hahahha
             */
            string insertQuery = "INSERT INTO queus_table_list(lastName,firstName,middleName,birthMonth,birthDay,birthYear,gender, address, email,phoneNumber)" +
                " VALUES('" + txtLastname.Text + "','" + txtFirstname.Text + "','" + txtMiddlename.Text + "','" + cbMonth.Text + "'," + cbDate.Text + "," + cbYear.Text +
                ",'" + genderVal + "', '" + txtAddress.Text + "', '" + txtEmail.Text + "', '" + txtPhonenumber.Text + "')";

            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            try
            {
                /*
                 * Opens the database
                 */
                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    /*
                     * Success
                     */
                    //MessageBox.Show("Data Inserted");
                    NameQueu = txtLastname.Text + " " + txtFirstname.Text + " " + txtMiddlename.Text; // To pass the data to the success form
                    LastName = txtLastname.Text; // To pass the data to the success form
                    Success success = new Success();
                    success.Show();  // To show the success form
                    clearFields(); // Clearing the fields when done
                }
                else
                {
                    MessageBox.Show("Something went wrong! 🙁");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "🙁"); //Error
            }
            /*
             * Closes the database
             */
            connection.Close();

        }
        /*
         * validate method, to ensure that there is data inputed
         */
        private void validate()
        {
            
            RadioButton[] genders = new RadioButton[] { rbMale, rbFemale };
            /* validation */
            if (txtLastname.TextLength == 0)
                MessageBox.Show("Last name required");
            if (txtFirstname.TextLength == 0)
                MessageBox.Show("First name required");
            if (txtMiddlename.TextLength == 0)
                MessageBox.Show("Middle name required");
            if (cbMonth.SelectedIndex == -1)
                MessageBox.Show("Birth month required");
            if (cbDate.SelectedIndex == -1)
                MessageBox.Show("Birth date required");
            if (cbYear.SelectedIndex == -1)
                MessageBox.Show("Birth year required");
            /*
             * No radio buttons are checked
             */
            if (!genders.Any(rb => rb.Checked))
                MessageBox.Show("Gender required");
            if (txtAddress.TextLength == 0)
                MessageBox.Show("Address required");
            if (txtEmail.TextLength == 0)
                MessageBox.Show("Email required");
            if (txtPhonenumber.TextLength == 0)
                MessageBox.Show("Phone number required");
        }

        /*
         * To clear all the fields
         */
        private void clearFields()
        {
            txtLastname.Clear();
            txtFirstname.Clear();
            txtMiddlename.Clear();
            cbMonth.SelectedIndex = -1;
            cbDate.SelectedIndex = -1;
            cbYear.SelectedIndex = -1;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhonenumber.Clear();
        }  
    }
}
