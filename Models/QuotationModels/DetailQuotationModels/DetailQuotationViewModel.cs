using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.QuotationModels.DetailQuotationModels
{
    public class DetailQuotationViewModel
    {
        public int Id { get; set; }
        public decimal Cantidad { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal SubTotalNeto { get; set; }
    }
}
