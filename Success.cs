using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QueuingSystem_1
{
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
        }
        /*
         *  Connect to database
         */
        MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; user=root; password=; database=queus_db"); 
        private void Success_Load(object sender, EventArgs e)
        {
            MySqlCommand mySqlCommand = connection.CreateCommand(); // mysql command
            mySqlCommand.CommandText = "SELECT * FROM queus_table_list"; // Cursor
            try
            {
                connection.Open();
                MySqlDataReader reader = mySqlCommand.ExecuteReader(); // Reads the database
                while (reader.Read()) 
                {
                    queuNumber.Text = reader["id"].ToString(); // to fetch the current ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            label3.Text = Main.NameQueu; // the data in the main form
        }

        private void queuNumber_Click(object sender, EventArgs e)
        {

        }

        /*
         * To close the form
         */
        private void closeOnDone_Click(object sender, EventArgs e)
        {
            Success success = this;
            success.Close();
        }
    }
}
