﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.QuotationModels.DetailQuotationModels
{
    public class DetailQuotationAddModel
    {
        public decimal Cantidad { get; set; }
        public int IdProduct { get; set; }
        public string Codigo { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal SubTotalNeto { get; set; }
    }
}
