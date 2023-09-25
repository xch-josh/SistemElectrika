using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PurchasesModels
{
    public class PurchaseViewModel
    {
        public int Id { get; set; }
        public string Proveedor { get; set; }
        public int Factura { get; set; }
        public decimal Total { get; set; }
        public string Vendedor { get; set; }
        public DateTime Fecha { get; set; }
    }
}
