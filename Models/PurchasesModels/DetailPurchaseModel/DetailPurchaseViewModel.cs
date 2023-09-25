using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PurchasesModels.DetailPurchaseModel
{
    public class DetailPurchaseViewModel
    {
        public int Id { get; set; }
        public decimal Cantidad { get; set; }
        public string Producto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal SubTotal { get; set; }
    }
}
