using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CurrencyExchange
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void AmendDatabase(string TxtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString);

            try
            {
                conn.Open();
                string query = TxtQuery;
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

            finally
            {
                conn.Close();
            }

        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
             int id = rand.Next();
        string accType = new string("");
            if (radioPersonal.Checked)
            {
                accType  = "Personal";
            }
            else
            {
                accType = "Business";
            }
            string addQuery = "INSERT INTO Users(UserID, UserName, Password, Forename, Surname, EmailAddress, AccountType, AccountStatus) VALUES ('" +id.ToString()+ "', '" +txtUsername.Text+"', '" +txtPassword.Text+ "', '" +forename.Text+ "', '" +txtSurname.Text+ "', '" +emailAdd.Text+ "', '" + accType.ToString() + "', 'Active')";

            AmendDatabase(addQuery);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
