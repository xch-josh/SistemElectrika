using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CartModels
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public string Codigo { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public decimal SubTotal { get; set; }
        public string Descuento { get; set; }
        public decimal SubTotalNeto { get; set; }
    }
}
