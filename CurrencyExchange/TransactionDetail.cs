using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange
{
  
        public class TransactionDetail
        {
            public int TransactionID { get; set; }
            public string Sender { get; set; }
            public string SenderCurrency { get; set; }
            public string Recipient { get; set; }
            public string RecipientCurrency { get; set; }
            public DateTime Date { get; set; }
            public decimal Amount { get; set; }
            public decimal TransactionFee { get; set; }
            public string TransactionType { get; set; }
        }
   
}
