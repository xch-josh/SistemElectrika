using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CreditModels.CreditPaymentModels
{
    public class PaymentAddModel
    {
        public int idCredit { get; set; }
        public decimal amount { get; set; }
        public DateTime date { get; set; }
    }
}
