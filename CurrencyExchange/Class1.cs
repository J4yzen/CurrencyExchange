using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    public static class UserSession
    {

        public static double balance;
        public static int UserID { get; set; }

        public static int AccountID { get; set; }

        public static int AccountID2 { get; set; }

        public static int CurrencyID { get; set; }

        public static int CurrencyID2 { get; set; }

        public static string AccType { get; set; }

        public static string AccStatus { get; set; }    

        public static int TransferCap { get; set; }

        public static double ReadBalance(int AccID)
        {
            double balance = 0;

            using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();
                string query = "SELECT Balance FROM Currency_Acc WHERE AccountID = @AccountID";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountID", AccID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            balance = reader.GetDouble(0);
                        }
                    }
                }
            }

            return balance;
        }

        public static double ReadExchangeRate(int curID)
        {
            double exrate = 0;

            using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();
                string query = "SELECT ExchangeRate FROM Currency WHERE CurrencyID = @CurrencyID";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CurrencyID", curID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            exrate = reader.GetDouble(0);
                        }
                    }
                }
            }

            return exrate;
        }

        public static void DisplayFlag(PictureBox p)
        {

            string query = "SELECT CurrencyID FROM Currency_Acc WHERE AccountID = @AccountID";
            int currency = 0;

            SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString);
            SQLiteCommand cmd = null;
            SQLiteDataReader reader = null;
           

            try
            {
                conn.Open();
                cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountID", UserSession.AccountID);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    currency = reader.GetInt32(0);
                    switch (currency)
                    {
                        case 10: p.Image = Properties.Resources.america; break;
                        case 11: p.Image = Properties.Resources.euro; break;
                        case 12: p.Image = Properties.Resources.india; break;
                        case 13: p.Image = Properties.Resources.swiss; break;
                        case 14: p.Image = Properties.Resources.aus; break;
                        case 15: p.Image = Properties.Resources.cad; break;
                        case 16: p.Image = Properties.Resources.singa; break;
                        case 17: p.Image = Properties.Resources.malay; break;
                        case 18: p.Image = Properties.Resources.china; break;
                        case 19: p.Image = Properties.Resources.jpn; break;
                        case 38: p.Image = Properties.Resources.download; break;
                        default: p.Image = null; break;
                    }
                }

            }
            catch (Exception Ex) {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }


        }
    }

    public static class DatabaseConfig
    {
        public static string ConnectionString = @"Data Source=C:\Users\OWNER\Desktop\CurrencyExchange\CurrencyExchange\bin\Debug\CurrencyTransferDatabase.db";

        public static void EnableWALMode()
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("PRAGMA journal_mode=WAL;", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error enabling WAL mode: " + ex.Message);
                }
            }
        }
    }

    public class CurrencyAccount
    {
        public double Balance { get; set; }
        public int CurrencyID { get; set; }

        public int AccountID { get; set; }
    }

    public static class CurrencyAccList { 

        public static List<CurrencyAccount> accounts = new List<CurrencyAccount>();
    
    }
}
