using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ProductModels
{
    public class ProductGetModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Product { get; set; }
        public string Brand { get; set; }
        public int IdCategory { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal Gain { get; set; }
        public bool TypeGain { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Stock { get; set; }
        public int IdProvider { get; set; }
        public string Measure { get; set; }
    }
}
