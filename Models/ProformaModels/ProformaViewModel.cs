using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ProformaModels
{
    public class ProformaViewModel
    {
        public int Id { get; set; }
        public int Cliente { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Descuento { get; set; }
        public string Observaciones { get; set; }
    }
}
