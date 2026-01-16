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
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace CurrencyExchange
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();
                string query = "SELECT \r\n    t.TransactionID,\r\n    sender_user.Forename || ' ' || sender_user.Surname AS Sender,\r\n    sender_currency.CurrencyCode AS SenderCurrency,\r\n    CASE \r\n        WHEN t.TransactionType = 'Internal' \r\n        THEN receiver_user.Forename || ' ' || receiver_user.Surname\r\n        ELSE b.Forename || ' ' || b.Surname\r\n    END AS Recipient,\r\n    CASE \r\n        WHEN t.TransactionType = 'Internal' \r\n        THEN receiver_currency.CurrencyCode\r\n        ELSE NULL\r\n    END AS RecipientCurrency,\r\n    t.Date,\r\n    t.Amount,\r\n    t.TransactionFee,\r\n    t.TransactionType\r\nFROM \r\n    \"Transaction\" t\r\nLEFT JOIN \r\n    \"Currency_Acc\" sender_acc ON t.SenderID = sender_acc.AccountID\r\nLEFT JOIN \r\n    \"Users\" sender_user ON sender_acc.UserID = sender_user.UserID\r\nLEFT JOIN \r\n    \"Currency\" sender_currency ON sender_acc.CurrencyID = sender_currency.CurrencyID\r\nLEFT JOIN \r\n    \"Currency_Acc\" receiver_acc ON t.ReceiverID = receiver_acc.AccountID\r\nLEFT JOIN \r\n    \"Users\" receiver_user ON receiver_acc.UserID = receiver_user.UserID\r\nLEFT JOIN \r\n    \"Currency\" receiver_currency ON receiver_acc.CurrencyID = receiver_currency.CurrencyID\r\nLEFT JOIN \r\n    \"Beneficiary\" b ON t.BeneficiaryID = b.BeneficiaryID\r\nORDER BY \r\n    t.Date DESC, t.TransactionID DESC";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id1", UserSession.AccountID);
                    cmd.Parameters.AddWithValue("@id2", UserSession.AccountID2);
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        transactionDGV.DataSource = dt;
                    }
                }
            } // ✅ Connection automatically closes here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();

        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            // 1. Get selected transaction ID (adjust based on your UI)
            int transactionId = Convert.ToInt32(transactionDGV.CurrentRow.Cells["TransactionID"].Value);

            // 2. Fetch transaction data
            TransactionDetail transaction = null;
            

            using (SQLiteConnection conn = new SQLiteConnection(DatabaseConfig.ConnectionString))
            {
                conn.Open();
                string sql = @"
        SELECT 
            t.TransactionID,
            sender_user.Forename || ' ' || sender_user.Surname AS Sender,
            sender_currency.CurrencyCode AS SenderCurrency,
            CASE 
                WHEN t.TransactionType = 'Internal' 
                THEN receiver_user.Forename || ' ' || receiver_user.Surname
                ELSE b.Forename || ' ' || b.Surname
            END AS Recipient,
            CASE 
                WHEN t.TransactionType = 'Internal' 
                THEN receiver_currency.CurrencyCode
                ELSE NULL
            END AS RecipientCurrency,
            t.Date,
            t.Amount,
            t.TransactionFee,
            t.TransactionType
        FROM 
            ""Transaction"" t
        LEFT JOIN 
            ""Currency_Acc"" sender_acc ON t.SenderID = sender_acc.AccountID
        LEFT JOIN 
            ""Users"" sender_user ON sender_acc.UserID = sender_user.UserID
        LEFT JOIN 
            ""Currency"" sender_currency ON sender_acc.CurrencyID = sender_currency.CurrencyID
        LEFT JOIN 
            ""Currency_Acc"" receiver_acc ON t.ReceiverID = receiver_acc.AccountID
        LEFT JOIN 
            ""Users"" receiver_user ON receiver_acc.UserID = receiver_user.UserID
        LEFT JOIN 
            ""Currency"" receiver_currency ON receiver_acc.CurrencyID = receiver_currency.CurrencyID
        LEFT JOIN 
            ""Beneficiary"" b ON t.BeneficiaryID = b.BeneficiaryID
        WHERE t.TransactionID = @id";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", transactionId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            transaction = new TransactionDetail
                            {
                                TransactionID = reader.GetInt32(0),
                                Sender = reader.GetString(1),
                                SenderCurrency = reader.GetString(2),
                                Recipient = reader.IsDBNull(3) ? null : reader.GetString(3),
                                RecipientCurrency = reader.IsDBNull(4) ? null : reader.GetString(4),
                                Date = reader.GetDateTime(5),
                                Amount = reader.GetDecimal(6),
                                TransactionFee = reader.GetDecimal(7),
                                TransactionType = reader.GetString(8)
                            };
                        }
                    }
                }
            }

            if (transaction == null)
            {
                MessageBox.Show("Transaction not found!");
                return;
            }

            // 3. Let user choose where to save the PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = $"Invoice_{transaction.TransactionID}.pdf"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            // 4. Generate PDF invoice
            GenerateInvoicePDF(transaction, saveFileDialog.FileName);
            MessageBox.Show($"Invoice saved to:\n{saveFileDialog.FileName}");
        }



        private void GenerateInvoicePDF(TransactionDetail transaction, string filePath)
        {
            Document document = new Document();
            try
            {
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Add title
                document.Add(new Paragraph("CURRENCY EXCHANGE INVOICE",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18)));

                // Add transaction details
                document.Add(new Paragraph($"Invoice #: {transaction.TransactionID}"));
                document.Add(new Paragraph($"Date: {transaction.Date.ToString("yyyy-MM-dd HH:mm")}"));
                document.Add(new Paragraph($"Transaction Type: {transaction.TransactionType}"));

                // Add sender/recipient info
                document.Add(new Paragraph("\nSender:"));
                document.Add(new Paragraph($"{transaction.Sender} ({transaction.SenderCurrency})"));

                document.Add(new Paragraph("\nRecipient:"));
                document.Add(new Paragraph($"{transaction.Recipient}" +
                    (transaction.RecipientCurrency != null ? $" ({transaction.RecipientCurrency})" : "")));

                // Add amount and fees
                document.Add(new Paragraph("\nTransaction Details:"));
                document.Add(new Paragraph($"Amount: {transaction.Amount} {transaction.SenderCurrency}"));
                document.Add(new Paragraph($"Fee: {transaction.TransactionFee} {transaction.SenderCurrency}"));

                // Calculate total
                decimal total = transaction.Amount + transaction.TransactionFee;
                document.Add(new Paragraph($"\nTOTAL: {total} {transaction.SenderCurrency}",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));

                // Add footer
                document.Add(new Paragraph("\nThank you for you using our service!",
                    FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10)));
            }
            finally
            {
                document.Close();
            }
        }
    }
}
