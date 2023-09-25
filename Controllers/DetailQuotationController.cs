using Models.DataBase;
using Models.QuotationModels.DetailQuotationModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class DetailQuotationController
    {
        public async Task<List<DetailQuotationViewModel>> GetData(int id)
        {
            var lst = new List<DetailQuotationViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = await (from x in db.DetalleCotizacion
                       join y in db.Productos
                       on x.IdProducto equals y.IdProducto
                       where x.IdCotizacion == id
                       select new DetailQuotationViewModel
                       {
                           Id = x.IdDetCotizacion,
                           Cantidad = x.Cantidad,
                           Producto = y.Producto + " " + y.Marca + " (" + y.UnidadMedida + ")",
                           Precio = x.Precio,
                           SubTotal = x.SubTotal,
                           Descuento = x.Descuento,
                           SubTotalNeto = x.SubTotalNeto
                       }).ToListAsync();
            }

            return lst;
        }

        public void Insert(List<DetailQuotationAddModel> models, int idQuotation)
        {
            using (var db = new DbElectrikaEntities())
            {
                foreach (var item in models)
                {
                    var detail = new DetalleCotizacion();

                    detail.Cantidad = item.Cantidad;
                    detail.IdProducto = item.IdProduct;
                    detail.Precio = item.Precio;
                    detail.SubTotal = item.SubTotal;
                    detail.Descuento = item.Descuento;
                    detail.SubTotalNeto = item.SubTotalNeto;
                    detail.IdCotizacion = idQuotation;

                    db.DetalleCotizacion.Add(detail);
                    db.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var detail = db.DetalleCotizacion.Find(id);

                db.Entry(detail).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
