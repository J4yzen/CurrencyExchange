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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExchangeCurrency();
        }

        private void Form5_Load_1(object sender, EventArgs e)
        {

        }

        private void ExchangeCurrency()
        {
            if (!double.TryParse(textBox1.Text, out double amount) || amount <= 0)
            {
                MessageBox.Show("Invalid amount entered.");
                return;
            }

            // Get exchange rates first to calculate GBP equivalent
            double ex1 = UserSession.ReadExchangeRate(UserSession.CurrencyID);
            double ex2 = UserSession.ReadExchangeRate(UserSession.CurrencyID2);

            if (ex1 == 0 || ex2 == 0)
            {
                MessageBox.Show("Error: Invalid exchange rates.");
                return;
            }

            // Calculate amount in GBP (assuming GBP is currency ID 38)
            double amountInGBP = amount;
            if (UserSession.CurrencyID != 38) // If not already GBP
            {
                double gbpRate = UserSession.ReadExchangeRate(38); // Get GBP exchange rate
                amountInGBP = amount * (gbpRate / ex1);
            }

            // Check transfer cap (50,000 GBP or equivalent)
            const double transferCapGBP = 5000;
            if (amountInGBP > transferCapGBP)
            {
                MessageBox.Show($"Error: Transfer amount exceeds £5,000 limit.\n" +
                               $"Attempted: £{amountInGBP:N2}\n" +
                               $"Limit: £{transferCapGBP:N0}");
                return;
            }

            double balance1 = UserSession.ReadBalance(UserSession.AccountID);
            double balance2 = UserSession.ReadBalance(UserSession.AccountID2);

            if (amount > balance1)
            {
                MessageBox.Show("Error: Insufficient funds.");
                return;
            }

            double fee = 0.01 * amount;
            feeTxt.Text = fee.ToString("F2");

            double convertedAmount = amount * (ex2 / ex1);
            textBox2.Text = convertedAmount.ToString("F2");

            double newBalance1 = balance1 - amount - fee;
            double newBalance2 = balance2 + convertedAmount;

            string updateQuery = "UPDATE Currency_Acc SET Balance = @Balance WHERE AccountID = @AccountID";
            string insertQuery = @"INSERT INTO ""Transaction"" 
              (TransactionID, SenderID, ReceiverID, Date, Amount, TransactionFee, TransactionType) 
              VALUES (@TranID, @SendID, @RecID, @Date, @Amount, @TranFee, @TranType)";

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    using (SQLiteTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Update balance for AccountID (balance1)
                            using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Balance", newBalance1);
                                cmd.Parameters.AddWithValue("@AccountID", UserSession.AccountID);
                                cmd.ExecuteNonQuery();
                            }

                            // Update balance for AccountID2 (balance2)
                            using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Balance", newBalance2);
                                cmd.Parameters.AddWithValue("@AccountID", UserSession.AccountID2);
                                cmd.ExecuteNonQuery();
                            }

                            // Record the transaction
                            using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn, transaction))
                            {
                                int id = new Random().Next(1, int.MaxValue);
                                cmd.Parameters.AddWithValue("@TranID", id);
                                cmd.Parameters.AddWithValue("@SendID", UserSession.AccountID);
                                cmd.Parameters.AddWithValue("@RecID", UserSession.AccountID2);
                                cmd.Parameters.AddWithValue("@Date", DateTime.Today.ToString("yyyy-MM-dd"));
                                cmd.Parameters.AddWithValue("@Amount", amount);
                                cmd.Parameters.AddWithValue("@TranFee", fee);
                                cmd.Parameters.AddWithValue("@TranType", "Internal");
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show($"Currency exchange successful!\n" +
                                            $"Amount: {amount:N2} → {convertedAmount:N2}\n" +
                                            $"Fee: {fee:N2}\n" +
                                            $"GBP Equivalent: {amountInGBP:N2}");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error during currency exchange: " + ex.Message);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }

            Form2 home = new Form2();
            home.Show();
            this.Hide();
        }
        /*private void ExchangeCurrency()
        {
            if (!double.TryParse(textBox1.Text, out double amount) || amount <= 0)
            {
                MessageBox.Show("Invalid amount entered.");
                return;
            }

            double balance1 = UserSession.ReadBalance(UserSession.AccountID);
            double balance2 = UserSession.ReadBalance(UserSession.AccountID2);
            if (amount > balance1)
            {
                MessageBox.Show("Error: Insufficient funds.");
                return;
            }

            double fee = 0.01 * amount;
            feeTxt.Text = fee.ToString();

            double ex1 = UserSession.ReadExchangeRate(UserSession.CurrencyID);
            double ex2 = UserSession.ReadExchangeRate(UserSession.CurrencyID2);

            if (ex1 == 0 || ex2 == 0)
            {
                MessageBox.Show("Error: Invalid exchange rates.");
                return;
            }

            double convertedAmount = amount * (ex2 / ex1);
            textBox2.Text = convertedAmount.ToString("F2");

            double newBalance1 = balance1 - amount - fee;
            double newBalance2 = balance2 + convertedAmount;

            string query = "UPDATE Currency_Acc SET Balance = @Balance WHERE AccountID = @AccountID";

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();

                    // Update balance for AccountID (balance1)
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Balance", newBalance1);
                        cmd.Parameters.AddWithValue("@AccountID", UserSession.AccountID);
                        cmd.ExecuteNonQuery();
                    }

                    // Update balance for AccountID2 (balance2)
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Balance", newBalance2);
                        cmd.Parameters.AddWithValue("@AccountID", UserSession.AccountID2);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Currency exchange successful!");
                Random rand = new Random();
                int id = rand.Next();
                DateTime date = DateTime.Today;
                string query2 = "INSERT INTO [Transaction] (TransactionID, SenderID, ReceiverID, Date, Amount, TransactionFee, TransactionType) VALUES (@TranID, @SendID, @RecID, @Date, @Amount, @TranFee, @TranType)";

                using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query2, conn))
                    {
                        cmd.Parameters.AddWithValue("@TranID", id.ToString());
                        cmd.Parameters.AddWithValue("@SenID", UserSession.AccountID);
                        cmd.Parameters.AddWithValue("@RecID", UserSession.AccountID2);
                        cmd.Parameters.AddWithValue("@Date", date.ToString());
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@TranFee", fee);
                        cmd.Parameters.AddWithValue("@TranType", "Internal");
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            Form2 home = new Form2();
            home.Show();
            this.Hide();
        }*/
        /* using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
         {
             conn.Open();
             using (SQLiteTransaction transaction = conn.BeginTransaction()) // Start transaction
             {
                 try
                 {
                     string query = "UPDATE Currency_Acc SET Balance = @Balance WHERE AccountID = @AccountID";

                     using (SQLiteCommand cmd1 = new SQLiteCommand(query, conn, transaction))
                     {
                         cmd1.Parameters.AddWithValue("@Balance", newBalance1);
                         cmd1.Parameters.AddWithValue("@AccountID", UserSession.AccountID);
                         cmd1.ExecuteNonQuery();
                     }

                     using (SQLiteCommand cmd2 = new SQLiteCommand(query, conn, transaction))
                     {
                         cmd2.Parameters.AddWithValue("@Balance", newBalance2);
                         cmd2.Parameters.AddWithValue("@AccountID", UserSession.AccountID2);
                         cmd2.ExecuteNonQuery();
                     }

                     transaction.Commit(); // Commit transaction if successful
                 }
                 catch (Exception ex)
                 {
                     transaction.Rollback(); // Rollback on failure
                     MessageBox.Show("Error during currency exchange: " + ex.Message);
                 }


             }
         } */



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void feeTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
