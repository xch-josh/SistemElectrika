using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.SaleModels.SaleDetailModels;
using Models.DataBase;
using System.Data.Entity;

namespace Controllers
{
    public class SaleDetailController
    {
        public List<SaleDetailViewModel> GetData(int id)
        {
            var lst = new List<SaleDetailViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = (from x in db.DetalleVenta
                       join y in db.Productos
                       on x.IdProducto equals y.IdProducto
                       where x.IdVenta == id
                       select new SaleDetailViewModel
                       {
                           Id = x.IdDetVenta,
                           Cantidad = x.Cantidad,
                           Codigo = y.Codigo,
                           Producto = y.Producto + " " + y.Marca + " (" + y.UnidadMedida + ")",
                           Precio = x.Precio,
                           SubTotal = x.SubTotal,
                           Descuento = x.Descuento,
                           SubTotalNeto = x.SubTotalNeto
                       }).ToList();
            }

            return lst;
        }

        public void Insert(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                db.CobrarVenta(id);
            }
        }

        public void Devolution(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var detail = db.DetalleVenta.Find(id);
                var product = db.Productos.Find(detail.IdProducto);
                var sale = db.Ventas.Find(detail.IdVenta);

                product.Existencia += detail.Cantidad;
                db.Entry(product).State = EntityState.Modified;

                db.Entry(detail).State = EntityState.Deleted;
                db.SaveChanges();

                sale.Total = db.DetalleVenta.Where(x => x.IdVenta == detail.IdVenta).Sum(y => y.SubTotal);
                sale.TotalNeto = db.DetalleVenta.Where(x => x.IdVenta == detail.IdVenta).Sum(y => y.SubTotalNeto);

                db.Entry(sale).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
