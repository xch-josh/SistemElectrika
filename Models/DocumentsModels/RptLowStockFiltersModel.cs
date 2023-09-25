using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DocumentsModels
{
    public class RptLowStockFiltersModel
    {
        public string ProductOrCode { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Provider { get; set; }
    }
}
