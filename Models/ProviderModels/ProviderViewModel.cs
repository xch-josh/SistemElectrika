using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ProviderModels
{
    public class ProviderViewModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Proveedor { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }
    }
}
