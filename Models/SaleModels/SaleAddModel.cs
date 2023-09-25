using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SaleModels
{
    public class SaleAddModel
    {
        public int IdClient { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal NetTotal { get; set; }
        public DateTime Date { get; set; }
    }
}
