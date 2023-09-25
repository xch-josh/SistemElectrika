using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Models.ProviderModels;
using Models.DataBase;
using Models.ProviderModels.DetailProviderModels;

namespace Controllers
{
    public class ProviderController
    {
        public async Task<List<ProviderViewModel>> GetData(bool state)
        {
            var lst = new List<ProviderViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = await (from x in db.Proveedores
                       where x.Proveedor != "N/A" && x.Estado == state
                       select new ProviderViewModel
                       {
                           Id = x.IdProveedor,
                           Codigo = x.Codigo,
                           Proveedor = x.Proveedor,
                           Telefono = x.Telefono,
                           Mail = x.Mail
                       }).ToListAsync();
            }

            return lst;
        }

        public void Insert(ProviderAddModel model, DetailProviderAddModel model2)
        {
            if (ExistsCode(model.Code, null))
                throw new Exception($"Un proveedor ya utiliza el codigo: {model.Code} \n Por favor intentar con otro");
            else
            {
                using (var db = new DbElectrikaEntities())
                {
                    var provider = new Proveedores();

                    provider.Codigo = model.Code;
                    provider.Proveedor = model.Provider;
                    provider.Telefono = model.Phone;
                    provider.Mail = model.Mail;
                    provider.Estado = true;

                    db.Proveedores.Add(provider);
                    db.SaveChanges();

                    model2.IdProvider = provider.IdProveedor;
                    var detail = new DetailProviderController();
                    detail.Insert(model2);
                }
            }
        }

        public void Edit(ProviderEditModel model)
        {
            if (ExistsCode(model.Code, model.Id))
                throw new Exception($"Otro proveedor ya utiliza el codigo: {model.Code} \n Por favor intentar con otro");
            else
            {
                using (var db = new DbElectrikaEntities())
                {
                    var provider = db.Proveedores.Find(model.Id);

                    provider.Codigo = model.Code;
                    provider.Proveedor = model.Provider;
                    provider.Telefono = model.Phone;
                    provider.Mail = model.Mail;

                    db.Entry(provider).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var provider = db.Proveedores.Find(id);
                var detail = db.DetalleProveedor.Where(x => x.IdProveedor == id).ToList();

                detail.ForEach(x => db.Entry(x).State = EntityState.Deleted);
                db.SaveChanges();
                db.Entry(provider).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        private bool ExistsCode(string code, int? id)
        {
            using (var db = new DbElectrikaEntities())
            {
                string providers;

                if (id == null)
                    providers = db.Proveedores.Where(x => x.Codigo == code).Select(y => y.Codigo).FirstOrDefault();
                else
                    providers = db.Proveedores.Where(x => x.Codigo == code && x.IdProveedor != id).Select(y => y.Codigo).FirstOrDefault();

                if (providers != null)
                    return true;
                else
                    return false;
            }
        }

        public void Active(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var provider = db.Proveedores.Find(id);
                provider.Estado = true;

                db.Entry(provider).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Deactive(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var provider = db.Proveedores.Find(id);
                provider.Estado = false;

                db.Entry(provider).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<ProviderGetModel> GetProviders()
        {
            var lst = new List<ProviderGetModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = (from x in db.Proveedores
                       where x.Estado == true
                       orderby x.Proveedor ascending
                       select new ProviderGetModel
                       {
                           Id = x.IdProveedor,
                           Provider = x.Proveedor,
                       }).ToList();
            }
            
            return lst;
        }

        public List<ProviderGetModel> GetProvidersOnPurchases()
        {
            var lst = new List<ProviderGetModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = (from x in db.Proveedores
                       where x.Estado == true && x.Proveedor != "N/A"
                       orderby x.Proveedor descending
                       select new ProviderGetModel
                       {
                           Id = x.IdProveedor,
                           Provider = x.Proveedor,
                       }).ToList();
            }

            return lst;
        }
    }
}
