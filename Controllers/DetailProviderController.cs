using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ProviderModels.DetailProviderModels;
using Models.DataBase;
using System.Data.Entity;

namespace Controllers
{
    public class DetailProviderController
    {
        public async Task<List<DetailProviderViewModel>> GetData(int id)
        {
            var lst = new List<DetailProviderViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = await (from x in db.DetalleProveedor
                       where x.IdProveedor == id orderby x.Estado descending
                       select new DetailProviderViewModel
                       {
                           Id = x.IdDetProveedor,
                           Vendedor = x.Vendedor,
                           Telefono = x.Telefono,
                           Mail = x.Mail,
                           Estado = x.Estado.ToString()
                       }).ToListAsync();
            }

            return lst;
        }

        public void Insert(DetailProviderAddModel model)
        {
            using (var db = new DbElectrikaEntities())
            {
                var detail = new DetalleProveedor();

                detail.Vendedor = model.Saler;
                detail.Telefono = model.Phone;
                detail.Mail = model.Mail;
                detail.Estado = true;
                detail.IdProveedor = model.IdProvider;

                db.DetalleProveedor.Add(detail);
                db.SaveChanges();
            }
        }

        public void Edit(DetailProviderEditModel model)
        {
            using (var db = new DbElectrikaEntities())
            {
                var detail = db.DetalleProveedor.Find(model.Id);

                detail.Vendedor = model.Saler;
                detail.Telefono = model.Phone;
                detail.Mail = model.Mail;

                db.Entry(detail).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public async void Delete(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var detail = db.DetalleProveedor.Find(id);

                db.Entry(detail).State = EntityState.Deleted;
                await db.SaveChangesAsync();
            }
        }

        public void Active(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var detail = db.DetalleProveedor.Find(id);
                detail.Estado = true;

                db.Entry(detail).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Deactive(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var detail = db.DetalleProveedor.Find(id);
                detail.Estado = false;

                db.Entry(detail).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}