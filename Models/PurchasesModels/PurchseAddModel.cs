using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PurchasesModels
{
    public class PurchseAddModel
    {
        public int IdDetProvider { get; set; }
        public int BillNumber { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
    }
}
