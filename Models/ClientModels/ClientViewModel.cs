using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ClientModels
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string Nit { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }
    }
}
