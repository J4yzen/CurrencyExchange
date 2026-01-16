using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            DatabaseConfig.EnableWALMode();

        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void label1_Click_1(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();

                    string username = txt_username.Text;
                    string password = txt_password.Text;

                    
                    string query = "SELECT UserID, AccountType, AccountStatus FROM Users WHERE UserName = @username AND Password = @password";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // If user exists
                            {
                                UserSession.UserID = reader.GetInt32(0); // Store UserID in the public variable
                                UserSession.AccType = reader.GetString(1);
                                UserSession.AccStatus = reader.GetString(2);

                                MessageBox.Show($"Login successful! UserID: {UserSession.UserID}");

                                if (UserSession.AccType == "Admin")
                                {
                                    Transactions2 transactions2 = new Transactions2();
                                    transactions2.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    Form4 accs = new Form4();
                                    accs.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Details.");
                                txt_username.Clear();
                                txt_password.Clear();
                                txt_username.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 createNewAcc = new Form3();
            createNewAcc.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}