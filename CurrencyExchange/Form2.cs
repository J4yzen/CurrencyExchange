using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void LoadData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();
                string query = "SELECT CurrencyCode, CurrencyName, ExchangeRate FROM Currency";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        ExchangeRate.DataSource = dt;
                    }
                }
            } // ✅ Connection automatically closes here
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadBalance();
            UserSession.DisplayFlag(pictureBox1);
        }

        private void LoadBalance()
        {
            try
            {
                double balance = UserSession.ReadBalance(UserSession.AccountID);
                balanceTxt.Text = balance.ToString(); // Ensure balanceTxt is the correct control name
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading balance: " + ex.Message);
            }


        }
        private void balanceTxt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 topUp = new Form7();
            topUp.Show();
            this.Hide();
        }

        private void switchbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 currencyAccs = new Form4();
            currencyAccs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 exchangeCurrency = new Form8();
            exchangeCurrency.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 BankTransfer = new Form6();
            BankTransfer.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions();
            transactions.Show();
            this.Close();
        }
    }
}
