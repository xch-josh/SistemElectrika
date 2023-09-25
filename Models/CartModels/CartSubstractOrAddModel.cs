using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CartModels
{
    public class CartSubstractOrAddModel
    {
        public int Id { get; set; }
        public decimal Quantity { get; set; }
        public int IdProduct { get; set; }
    }
}
