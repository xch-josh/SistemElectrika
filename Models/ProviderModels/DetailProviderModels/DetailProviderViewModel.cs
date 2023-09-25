using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ProviderModels.DetailProviderModels
{
    public class DetailProviderViewModel
    {
        public int Id { get; set; }
        public string Vendedor { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }
        public string Estado { get; set; }
    }
}
