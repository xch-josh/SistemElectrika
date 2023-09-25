using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CartModels
{
    public class CartInsertModel
    {
        public int idProduct { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string TypeDiscount { get; set; }
    }
}
