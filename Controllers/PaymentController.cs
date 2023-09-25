using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DataBase;
using Models.CreditModels.CreditPaymentModels;
using System.Data.Entity;

namespace Controllers
{
    public class PaymentController
    {
        public async Task<List<PaymentViewModel>> GetData(int idCredit)
        {
            var lst = new List<PaymentViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = await (from x in db.CreditosPagos
                       where x.idCredito == idCredit
                       select new PaymentViewModel
                       {
                           Id = x.idPago,
                           Monto = x.Monto,
                           Fecha = x.Fecha
                       }).ToListAsync();
            }
            return lst;
        }

        public void Insert(PaymentAddModel model)
        {
            using (var db = new DbElectrikaEntities())
            {
                var payment = new CreditosPagos();
                var getCredit = db.Creditos.Find(model.idCredit);

                if (model.amount >= getCredit.Saldo)
                {
                    payment.Monto = getCredit.Saldo;
                    getCredit.Saldo = 0;
                    getCredit.Estado = false;

                }
                else
                {
                    payment.Monto = model.amount;
                    getCredit.Saldo -= model.amount;
                }

                payment.idCredito = model.idCredit;
                payment.Fecha = model.date;

                db.CreditosPagos.Add(payment);
                db.Entry(getCredit).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Cancel(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var payment = db.CreditosPagos.Find(id);
                var credit = db.Creditos.Find(payment.idCredito);

                credit.Saldo += payment.Monto;
                credit.Estado = true;

                db.Entry(credit).State = EntityState.Modified;
                db.Entry(payment).State = EntityState.Deleted;

                db.SaveChanges();
            }
        }
    }
}
