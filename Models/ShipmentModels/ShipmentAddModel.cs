using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ShipmentModels
{
    public class ShipmentAddModel
    {
        public int IdSale { get; set; }
        public string Direction { get; set; }
        public int Items { get; set; }
        public string Recives { get; set; }
        public DateTime Delivery { get; set; }
    }
}
