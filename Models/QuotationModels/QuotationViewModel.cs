using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.QuotationModels
{
    public class QuotationViewModel
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }
        public decimal Descuento { get; set; }
        public decimal TotalNeto { get; set; }
        public DateTime Creacion { get; set; }
        public DateTime Expiracion { get; set; }
        public string Estado { get; set; }
    }
}
