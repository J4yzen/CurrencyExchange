using System;
using System.CodeDom;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (UserSession.AccType == "Business") {
                currency5.Visible = true;
				currency6.Visible = true;
                pictureBox6.Visible = true;
                pictureBox5.Visible = true; 
			}

            LoadAccounts();

        }

        protected void LoadAccounts()
        {
            List<Label> clist = new List<Label> { currency1, currency2, currency3, currency4, currency5, currency6 };
            List<PictureBox> pictureBoxes = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };

            CurrencyAccList.accounts.Clear(); // Prevent duplicate entries

            using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Balance, CurrencyID, AccountID FROM Currency_Acc WHERE UserID = @UserID";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", UserSession.UserID);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CurrencyAccList.accounts.Add(new CurrencyAccount
                                {
                                    Balance = reader.GetDouble(0),  // ✅ Use GetDouble instead of GetInt32 for balance
                                    CurrencyID = reader.GetInt32(1),
                                    AccountID = reader.GetInt32(2)
                                });
                            }
                        } // ✅ Reader automatically closes here
                    } // ✅ Command automatically disposes here
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading accounts: " + ex.Message);
                }
            } // ✅ Connection automatically closes here

            // Update UI after data retrieval
            for (int i = 0; i < CurrencyAccList.accounts.Count && i < clist.Count; i++)
            {
                clist[i].Text = CurrencyAccList.accounts[i].Balance.ToString("F2"); // ✅ Format for currency
            }

            for (int i = 0; i < CurrencyAccList.accounts.Count && i < pictureBoxes.Count; i++)
            {
                switch (CurrencyAccList.accounts[i].CurrencyID)
                {
                    case 10: pictureBoxes[i].Image = Properties.Resources.america; break;
                    case 11: pictureBoxes[i].Image = Properties.Resources.euro; break;
                    case 12: pictureBoxes[i].Image = Properties.Resources.india; break;
                    case 13: pictureBoxes[i].Image = Properties.Resources.swiss; break;
                    case 14: pictureBoxes[i].Image = Properties.Resources.aus; break;
                    case 15: pictureBoxes[i].Image = Properties.Resources.cad; break;
                    case 16: pictureBoxes[i].Image = Properties.Resources.singa; break;
                    case 17: pictureBoxes[i].Image = Properties.Resources.malay; break;
                    case 18: pictureBoxes[i].Image = Properties.Resources.china; break;
                    case 19: pictureBoxes[i].Image = Properties.Resources.jpn; break;
                    case 38: pictureBoxes[i].Image = Properties.Resources.download; break;
                    default: pictureBoxes[i].Image = null; break;
                }
            }
        }


        /* for (int i = 0; i < accounts.Count; i++ )
                        {
                            clist[i].Text = accounts[i].Balance.ToString();
                        }

                        int x = 0;
                        foreach (CurrencyAccount a in accounts)
                        {
                            switch (a.CurrencyID)
                            {
                                case 10:
                                    pictureBoxes[x].Image = Properties.Resources.america;
                                    x++;
                                    break;
                                case 11:
                                    pictureBoxes[x].Image = Properties.Resources.euro;
                                    x++;
                                    break;
                                case 12:
                                    pictureBoxes[x].Image = Properties.Resources.india;
                                    x++;
                                    break;
                                case 13:
                                    pictureBoxes[x].Image = Properties.Resources.swiss;
                                    x++;
                                    break;
                                case 14:
                                    pictureBoxes[x].Image = Properties.Resources.aus;
                                    x++;
                                    break;
                                case 15:
                                    pictureBoxes[x].Image = Properties.Resources.cad;
                                    x++;
                                    break;
                                case 16:
                                    pictureBoxes[x].Image = Properties.Resources.singa;
                                    x++;
                                    break;
                                case 17:
                                    pictureBoxes[x].Image = Properties.Resources.malay;
                                    x++;
                                    break;
                                case 18:
                                    pictureBoxes[x].Image = Properties.Resources.china;
                                    x++;
                                    break;
                                case 19:
                                    pictureBoxes[x].Image = Properties.Resources.jpn;
                                    break;
                                case 38:
                                    pictureBoxes[x].Image = Properties.Resources.download;
                                    x++;
                                    break;
                                default:
                                    x++;
                                    break;


                            }

                        } */
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void currency1_Click(object sender, EventArgs e)
        {
            if (CurrencyAccList.accounts[0] != null)
            {
                UserSession.AccountID = CurrencyAccList.accounts[0].AccountID;
                UserSession.CurrencyID = CurrencyAccList.accounts[0].CurrencyID;
            }

            Form2 home = new Form2();
            home.Show();
            this.Hide();
            /* string query = "SELECT AccountID FROM Currency_Acc WHERE UserID = @UserID";
   
            try
            {
                SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\OWNER\Desktop\CurrencyTransferGUI (2)\CurrencyTransferGUI\bin\Debug\CurrencyTransferDatabase.db");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) { 
                
                    UserSession.AccountID = reader.GetInt32(0);
                }

           

            }
            catch (Exception ex)
            {

            }
            finally 
            {

            }

            */

        }

        private void currency2_Click(object sender, EventArgs e)
        {
            if (CurrencyAccList.accounts[1] != null)
            {
                UserSession.AccountID = CurrencyAccList.accounts[1].AccountID;
                UserSession.CurrencyID = CurrencyAccList.accounts[1].CurrencyID;
            }
            Form2 home = new Form2();
            home.Show();
            this.Hide();
        }

        private void currency3_Click(object sender, EventArgs e)
        {
            if (CurrencyAccList.accounts[2] != null)
            {
                UserSession.AccountID = CurrencyAccList.accounts[2].AccountID;
                UserSession.CurrencyID = CurrencyAccList.accounts[2].CurrencyID;
            }

            Form2 home = new Form2();
            home.Show();
            this.Hide();
        }

        private void currency4_Click(object sender, EventArgs e)
        {
            if (CurrencyAccList.accounts[3] != null)
            {
                UserSession.AccountID = CurrencyAccList.accounts[3].AccountID;
                UserSession.CurrencyID = CurrencyAccList.accounts[3].CurrencyID;

            }
            Form2 home = new Form2();
            home.Show();
            this.Hide();
        }

        private void currency5_Click(object sender, EventArgs e)
        {

        }

        private void currency6_Click(object sender, EventArgs e)
        {

        }
    }
}
