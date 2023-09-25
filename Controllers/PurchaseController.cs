using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.PurchasesModels;
using Models.DataBase;
using System.Data.Entity;
using Models.PurchasesModels.DetailPurchaseModel;

namespace Controllers
{
    public class PurchaseController
    {
        public async Task<List<PurchaseViewModel>> GetData()
        {
            var lst = new List<PurchaseViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = await (from x in db.Compras
                       join y in db.DetalleProveedor
                       on x.IdDetProveedor equals y.IdDetProveedor
                       join z in db.Proveedores
                       on y.IdProveedor equals z.IdProveedor
                       select new PurchaseViewModel
                       {
                           Id = x.IdCompra,
                           Proveedor = z.Proveedor,
                           Factura = x.NumeroFactura,
                           Total = x.Total,
                           Vendedor = y.Vendedor,
                           Fecha = x.Fecha
                       }).ToListAsync();
            }
            return lst;
        }

        public void Insert(PurchseAddModel model, List<DetailPurchaseAddModel> detailModels)
        {
            using (var db = new DbElectrikaEntities())
            {
                var purchase = new Compras();

                purchase.IdDetProveedor = model.IdDetProvider;
                purchase.NumeroFactura = model.BillNumber;
                purchase.Total = model.Total;
                purchase.Fecha = model.Date;

                db.Compras.Add(purchase);
                db.SaveChanges();

                var detail = new DetailPurchaseController();
                detail.Insert(detailModels, purchase.IdCompra);
            }
        }

        public void Edit(PurchaseEditModel model, DetailPurchaseEditModel model2)
        {
            using (var db = new DbElectrikaEntities())
            {
                var purchase = db.Compras.Find(model.Id);

                purchase.NumeroFactura = model.Bill;

                db.Entry(purchase).State = EntityState.Modified;
                db.SaveChanges();

                var detail = new DetailPurchaseController();
                detail.Edit(model2);

            }
        }

        public void Delete(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var purchase = db.Compras.Find(id);

                db.Entry(purchase).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
