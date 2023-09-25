using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PurchasesModels.DetailPurchaseModel
{
    public class DetailPurchaseAddModel
    {
        public int IdProduct { get; set; }
        public decimal Quantity { get; set; }
        public string Code { get; set; }
        public string Product { get; set; }
        public string Brand { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal Gain { get; set; }
        public bool TypeGain { get; set; }
        public decimal SalePrice { get; set; }
        public string Measure { get; set; }
        public int IdProvider { get; set; }
        public int IdCategory { get; set; }
        public decimal SubTotal { get; set; }
    }
}
