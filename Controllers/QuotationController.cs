using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.QuotationModels;
using Models.DataBase;
using Models.QuotationModels.DetailQuotationModels;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace Controllers
{
    public class QuotationController
    {
        public List<QuotationViewModel> GetData()
        {
            var lst = new List<QuotationViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = (from x in db.Cotizaciones
                       join y in db.Clientes
                       on x.IdClietne equals y.IdCliente
                       orderby x.Estado descending
                       select new QuotationViewModel
                       {
                           Id = x.IdCotizacion,
                           Cliente = y.Nombres + " " + y.Apellidos,
                           Total = x.Total,
                           Descuento = x.Descuento,
                           TotalNeto = x.TotalNeto,
                           Creacion = x.FehcaCreacion,
                           Expiracion = x.FechaExpiracion,
                           Estado = x.Estado.ToString()
                       }).ToList();
            }

            return lst;
        }

        public int Insert(QuotationAddModel model, List<DetailQuotationAddModel> detailModel)
        {
            using (var db = new DbElectrikaEntities())
            {
                var quotation = new Cotizaciones();

                quotation.IdClietne = model.IdClient;
                quotation.Total = model.Total;
                quotation.Descuento = model.Discount;
                quotation.TotalNeto = model.NetTotal;
                quotation.FehcaCreacion = model.Creation;
                quotation.FechaExpiracion = model.Expire;
                quotation.Estado = true;

                db.Cotizaciones.Add(quotation);
                db.SaveChanges();

                var detail = new DetailQuotationController();
                detail.Insert(detailModel, quotation.IdCotizacion);

                return quotation.IdCotizacion;
            }
        }

        public void Delete(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var quotation = db.Cotizaciones.Find(id);

                db.Entry(quotation).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Expire()
        {
            using (var db = new DbElectrikaEntities())
            {
                db.Cotizacion_caducada();
            }
        }
    }
}
