using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            try
            {
                List<PictureBox> pictureBoxes = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
                List<Label> clist = new List<Label> { currency1, currency2, currency3, currency4 };
                for (int i = 0; i < CurrencyAccList.accounts.Count && i < clist.Count; i++)
                {
                    clist[i].Text = CurrencyAccList.accounts[i].Balance.ToString();
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

            catch (Exception Ex)
            {
                MessageBox.Show("Error:" + Ex.Message);
            }

            finally
            {
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void currency2_Click(object sender, EventArgs e)
        {
            Form5 transfer = new Form5();
            UserSession.AccountID2 = CurrencyAccList.accounts[1].AccountID;
            UserSession.CurrencyID2 = CurrencyAccList.accounts[1].CurrencyID;
            transfer.Show();
            this.Hide();
        }

        private void currency3_Click(object sender, EventArgs e)
        {
            Form5 transfer = new Form5();
            UserSession.AccountID2 = CurrencyAccList.accounts[2].AccountID;
            UserSession.CurrencyID2 = CurrencyAccList.accounts[2].CurrencyID;
            transfer.Show();
            this.Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void currency1_Click(object sender, EventArgs e)
        {
            Form5 transfer = new Form5();
            UserSession.AccountID2 = CurrencyAccList.accounts[0].AccountID;
            UserSession.CurrencyID2 = CurrencyAccList.accounts[0].CurrencyID;
            transfer.Show();
            this.Hide();

        }

        private void currency4_Click(object sender, EventArgs e)
        {
            Form5 transfer = new Form5();
            UserSession.AccountID2 = CurrencyAccList.accounts[3].AccountID;
            UserSession.CurrencyID2= CurrencyAccList.accounts[3].CurrencyID;
            transfer.Show();
            this.Hide();
        }
    }
}
