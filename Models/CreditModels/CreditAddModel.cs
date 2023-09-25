using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CreditModels
{
    public class CreditAddModel
    {
        public int idSale { get; set; }
        public decimal initialDebt { get; set; }
        public decimal balance { get; set; }
        public DateTime date { get; set; }
    }
}
