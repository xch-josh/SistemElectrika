using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.SaleModels;
using Models.DataBase;
using System.Data.Entity;

namespace Controllers
{
    public class SaleController
    {
        public async Task<List<SaleViewModel>> GetData()
        {
            var lst = new List<SaleViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = await(from x in db.Ventas join y in db.Clientes
                       on x.IdCliente equals y.IdCliente
                       select new SaleViewModel
                       {
                           Id = x.IdVenta,
                           Cliente = y.Nombres + " " + y.Apellidos,
                           Nit = y.Nit,
                           Total = x.Total,
                           Descuento = x.Descuento,
                           TotalNeto = x.TotalNeto,
                           Fecha = x.Fecha
                       }
                    ).ToListAsync();
            }

            return lst;
        }

        public int Insert(SaleAddModel model)
        {
            using (var db = new DbElectrikaEntities())
            {
                var sale = new Ventas();

                sale.IdCliente = model.IdClient;
                sale.Total = model.Total;
                sale.Descuento = model.Discount;
                sale.TotalNeto = model.NetTotal;
                sale.Fecha = model.Date;

                db.Ventas.Add(sale);
                db.SaveChanges();

                var detail = new SaleDetailController();
                detail.Insert(sale.IdVenta);

                return sale.IdVenta;
            }
        }

        public void Devolution(int id)
        {
            using (var db = new DbElectrikaEntities())
                db.DevolverVenta(id);
        }

        public async Task<List<GetByClientModel>> GetByClient(int idClient)
        {
            var lst = new List<GetByClientModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = await (from x in db.Ventas
                       join y in db.Clientes
                       on x.IdCliente equals y.IdCliente
                       where x.IdCliente == idClient
                       select new GetByClientModel
                       {
                           Id = x.IdVenta,
                           Total = x.Total,
                           Descuento = x.Descuento,
                           TotalNeto = x.TotalNeto,
                           Fecha = x.Fecha
                       }
                    ).ToListAsync();
            }

            return lst;
        }

    }
}
