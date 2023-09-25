using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ShipmentModels
{
    public class ShipmentViewModel
    {
        public int Id { get; set; }
        public int IdVenta { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public int Items { get; set; }
        public string Recibe { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
