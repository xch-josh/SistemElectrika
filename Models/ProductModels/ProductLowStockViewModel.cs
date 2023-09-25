using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ProductModels
{
    public class ProductLowStockViewModel
    {
        public string Codigo { get; set; }
        public string Producto { get; set; }
        public string Marca { get; set; }
        public decimal Existencias { get; set; }
        public string Categoria { get; set; }
        public string Proveedor { get; set; }
    }
}
