//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleProforma
    {
        public int IdDetProforma { get; set; }
        public decimal Cantidad { get; set; }
        public int IdProducto { get; set; }
        public decimal Precio { get; set; }
        public string Descuento { get; set; }
        public decimal SubTotal { get; set; }
        public int IdProforma { get; set; }
    
        public virtual Productos Productos { get; set; }
        public virtual Proformas Proformas { get; set; }
    }
}