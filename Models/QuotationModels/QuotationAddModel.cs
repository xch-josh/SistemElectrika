using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.QuotationModels
{
    public class QuotationAddModel
    {
        public int IdClient { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal NetTotal { get; set; }
        public DateTime Creation { get; set; }
        public DateTime Expire { get; set; }
    }
}
