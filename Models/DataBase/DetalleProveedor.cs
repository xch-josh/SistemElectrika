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
    
    public partial class DetalleProveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetalleProveedor()
        {
            this.Compras = new HashSet<Compras>();
        }
    
        public int IdDetProveedor { get; set; }
        public string Vendedor { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }
        public bool Estado { get; set; }
        public int IdProveedor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compras> Compras { get; set; }
        public virtual Proveedores Proveedores { get; set; }
    }
}
