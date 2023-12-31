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
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.Carrito = new HashSet<Carrito>();
            this.DetalleCompra = new HashSet<DetalleCompra>();
            this.DetalleCotizacion = new HashSet<DetalleCotizacion>();
            this.DetalleProforma = new HashSet<DetalleProforma>();
            this.DetalleVenta = new HashSet<DetalleVenta>();
        }
    
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Producto { get; set; }
        public string Marca { get; set; }
        public int IdCategoria { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal Ganancia { get; set; }
        public bool TipoGanancia { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Existencia { get; set; }
        public int IdProveedor { get; set; }
        public string UnidadMedida { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carrito> Carrito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCotizacion> DetalleCotizacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleProforma> DetalleProforma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
