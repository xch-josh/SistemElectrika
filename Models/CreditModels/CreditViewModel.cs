using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CreditModels
{
    public class CreditViewModel
    {
        public int Id { get; set; }
        public int IdVenta { get; set; }
        public decimal Deuda { get; set; }
        public decimal Saldo { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
    }
}
