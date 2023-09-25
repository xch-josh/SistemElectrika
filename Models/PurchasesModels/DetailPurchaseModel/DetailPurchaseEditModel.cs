using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PurchasesModels.DetailPurchaseModel
{
    public class DetailPurchaseEditModel
    {
        public int Id { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal Quantity { get; set; }

    }
}
