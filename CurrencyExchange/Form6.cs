using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate amount
            if (!double.TryParse(textBox4.Text, out double amount) || amount <= 0)
            {
                MessageBox.Show("Invalid amount entered.");
                return;
            }

            // Check balance
            double balance = UserSession.ReadBalance(UserSession.AccountID);
            if (amount > balance)
            {
                MessageBox.Show("Error: Insufficient funds.");
                return;
            }

            // Calculate fee
            double fee = 0.01 * amount;
            feeTxt.Text = fee.ToString("F2");

            // Get currency ID
            string currency = listBox1.GetItemText(listBox1.SelectedItem);
            int currencyID = 0;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    using (SQLiteTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Get currency ID
                            string query = "SELECT CurrencyID FROM Currency WHERE CurrencyName = @Currency";
                            using (SQLiteCommand cmd = new SQLiteCommand(query, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Currency", currency);
                                object result = cmd.ExecuteScalar();
                                if (result != null)
                                {
                                    currencyID = Convert.ToInt32(result);
                                }
                                else
                                {
                                    throw new Exception("Currency not found");
                                }
                            }

                            // Calculate exchange
                            double ex1 = UserSession.ReadExchangeRate(UserSession.CurrencyID);
                            double ex2 = UserSession.ReadExchangeRate(currencyID);
                            double convertedAmount = amount * (ex2 / ex1);
                            textBox5.Text = convertedAmount.ToString("F2");

                            // Update balance
                            double newbalance = balance - amount - fee;
                            string query2 = "UPDATE Currency_Acc SET Balance = @Balance WHERE AccountID = @AccountID";
                            using (SQLiteCommand cmd = new SQLiteCommand(query2, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Balance", newbalance);
                                cmd.Parameters.AddWithValue("@AccountID", UserSession.AccountID);
                                cmd.ExecuteNonQuery();
                            }

                            // Generate random BeneficiaryID (6-digit number)
                            Random rand = new Random();
                            int beneficiaryID = rand.Next(100000, 999999);

                            // Create transaction record
                            string query3 = @"INSERT INTO [Transaction] 
                                    (SenderID, BeneficiaryID, Date, Amount, TransactionFee, TransactionType) 
                                    VALUES (@SendID, @BenID, @Date, @Amount, @TranFee, @TranType)";

                            using (SQLiteCommand cmd = new SQLiteCommand(query3, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@SendID", UserSession.AccountID);
                                cmd.Parameters.AddWithValue("@BenID", beneficiaryID);
                                cmd.Parameters.AddWithValue("@Date", DateTime.Today.ToString("yyyy-MM-dd"));
                                cmd.Parameters.AddWithValue("@Amount", amount);
                                cmd.Parameters.AddWithValue("@TranFee", fee);
                                cmd.Parameters.AddWithValue("@TranType", "External");
                                cmd.ExecuteNonQuery();
                            }

                            // Insert into Beneficiary table 
                            string query4 = @"INSERT INTO [Beneficiary] 
                                    (BeneficiaryID, Forename, Surname, AccountNo, SortCode) 
                                    VALUES (@BenID, @Forename, @Surname, @AccountNo, @SortCode)";

                            using (SQLiteCommand cmd = new SQLiteCommand(query4, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@BenID", beneficiaryID);
                                cmd.Parameters.AddWithValue("@Forename", forename.Text); // Placeholder values
                                cmd.Parameters.AddWithValue("@Surname", surename.Text);
                                cmd.Parameters.AddWithValue("@AccountNo", accNo.Text);
                                cmd.Parameters.AddWithValue("@SortCode", sortCode.Text);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show($"Currency exchange successful!\nBeneficiary ID: {beneficiaryID}");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error during exchange: {ex.Message}");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
        }
        /*private void ExchangeCurrency(object sender, EventArgs e)
        {

            if (!double.TryParse(textBox4.Text, out double amount) || amount <= 0)
            {
                MessageBox.Show("Invalid amount entered.");
                return;
            }

            double balance = UserSession.ReadBalance(UserSession.AccountID);
            if (amount > balance)
            {
                MessageBox.Show("Error: Insufficient funds.");
                return;
            }
            double fee = 0.01 * amount;
            feeTxt.Text = fee.ToString();

            string currency = listBox1.GetItemText(listBox1.SelectedItem);
            string query = "SELECT CurrencyID FROM Currency WHERE CurrencyName = @Currency";

            int currencyID = 0;

            using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Currency", currency);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currencyID = reader.GetInt32(0);
                        }
                
                    }

                }
            }
            MessageBox.Show("CurrencyID = " + currencyID.ToString());
            
            double ex1 = UserSession.ReadExchangeRate(UserSession.CurrencyID);
            double ex2 = UserSession.ReadExchangeRate(currencyID);

            double convertedAmount = amount * (ex2 / ex1);
            textBox5.Text = convertedAmount.ToString();
            double newbalance = balance - amount - fee;


            string query2 = "UPDATE Currency_Acc SET Balance = @Balance WHERE AccountID = @AccountID";
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query2, conn))
                    {
                        cmd.Parameters.AddWithValue("@Balance", newbalance);
                        cmd.Parameters.AddWithValue("@AccountID", UserSession.AccountID);
                        cmd.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("Currency exchange successful!");
                Random rand = new Random();
                int id = rand.Next();
                int id2 = rand.Next();
                DateTime date = DateTime.Today;
                string query3 = "INSERT INTO [Transaction] (TransactionID, SenderID, BeneficiaryID, Date, Amount, TransactionFee, TransactionType) VALUES (@TranID, @SendID, @BenID, @Date, @Amount, @TranFee, @TranType)";

                using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query3, conn))
                    {
                        cmd.Parameters.AddWithValue("@TranID", id);
                        cmd.Parameters.AddWithValue("@SenID", UserSession.AccountID);
                        cmd.Parameters.AddWithValue("@BenID", id2);
                        cmd.Parameters.AddWithValue("@Date", date.ToString());
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@TranFee", fee);
                        cmd.Parameters.AddWithValue("@TranType", "External");
                        cmd.ExecuteNonQuery();
                    }
                }

                string query4 = "INSERT INTO [Beneficiary] (BeneficiaryID, Forename, Surname, AccountNo, SortCode) VALUES (@BenID, @fore, @sur, @accNo, @sortCo)";

                using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query3, conn))
                    {
                        cmd.Parameters.AddWithValue("@TranID", id.ToString());
                        cmd.Parameters.AddWithValue("@SenID", UserSession.AccountID);
                        cmd.Parameters.AddWithValue("@BenID", id2.ToString());
                        cmd.Parameters.AddWithValue("@Date", date.ToString());
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@TranFee", fee);
                        cmd.Parameters.AddWithValue("@TranType", "External");
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error: "+ ex.Message);
            }
           
        }*/

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
        