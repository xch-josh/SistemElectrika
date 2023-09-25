using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SaleModels
{
    public class SaleViewModel
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Nit { get; set; }
        public decimal Total { get; set; }
        public decimal Descuento { get; set; }
        public decimal TotalNeto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
