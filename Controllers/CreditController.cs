using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.CreditModels;
using Models.DataBase;

namespace Controllers
{
    public class CreditController
    {
        public async Task<List<CreditViewModel>> GetData(int idClient)
        {
            var lst = new List<CreditViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = await (from x in db.Creditos
                       join y in db.Ventas on x.idVenta equals y.IdVenta
                       join z in db.Clientes on y.IdCliente equals z.IdCliente
                       orderby x.Estado descending
                       where y.IdCliente == idClient
                       select new CreditViewModel
                       {
                           Id = x.idCredito,
                           IdVenta = x.idVenta,
                           Deuda = x.DeudaInicial,
                           Saldo = x.Saldo,
                           Fecha = x.Fecha,
                           Estado = x.Estado.ToString()
                       }).ToListAsync();
            }
            return lst;
        }

        public int Insert(CreditAddModel model)
        {
            using (var db = new DbElectrikaEntities())
            {
                var credit = new Creditos();

                credit.idVenta = model.idSale;
                credit.DeudaInicial = model.initialDebt;
                credit.Saldo = model.balance;
                credit.Fecha = model.date;
                credit.Estado = true;

                db.Creditos.Add(credit);
                db.SaveChanges();
                return credit.idCredito;
            }
        }

        public void Delete(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var credit = db.Creditos.Find(id);

                db.Entry(credit).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
