using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void AmendDatabase(string TxtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString);
            string query = TxtQuery;
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

            finally
            {
                conn.Close();
            }

        }
        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the current balance
                double balance = UserSession.ReadBalance(UserSession.AccountID);

                // Parse the amount entered by the user
                double amount = Double.Parse(txtAmount.Text);

                // Calculate the new balance
                double newBalance = balance + amount;

                // Define the SQL query with parameters
                string addQuery = "UPDATE Currency_Acc SET Balance = @Balance WHERE AccountID = @AccountID";

                // Open a connection to the database
                using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();

                    // Create a command with the query and connection
                    using (SQLiteCommand cmd = new SQLiteCommand(addQuery, conn))
                    {
                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@Balance", newBalance);
                        cmd.Parameters.AddWithValue("@AccountID", UserSession.AccountID);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }
                }

                // Navigate back to Form2
                Form2 home = new Form2();
                home.Show();
                this.Hide();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for the amount.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating balance: " + ex.Message);
            }
        }


    }
}
