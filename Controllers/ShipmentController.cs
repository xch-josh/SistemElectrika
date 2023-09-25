using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DataBase;
using Models.ShipmentModels;

namespace Controllers
{
    public class ShipmentController
    {
        public List<ShipmentViewModel> GetData()
        {
            var lst = new List<ShipmentViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = (from x in db.Envios
                       join y in db.Ventas
                       on x.IdVenta equals y.IdVenta
                       join z in db.Clientes
                       on y.IdCliente equals z.IdCliente
                       select new ShipmentViewModel
                       {
                           Id = x.IdEnvio,
                           IdVenta = y.IdVenta,
                           Cliente = z.Nombres + " " + z.Apellidos,
                           Direccion = x.Direccion,
                           Items = x.Items,
                           Recibe = x.Recibio,
                           FechaEntrega = x.FechaEntrega,
                           FechaCreacion = x.FechaCreación
                       }).ToList();
            }

            return lst;
        }

        public void Insert(ShipmentAddModel model)
        {
            using (var db = new DbElectrikaEntities())
            {
                var getShipment = db.Envios.Where(x => x.IdVenta == model.IdSale).ToList();

                if (getShipment.Count == 0)
                {
                    var shipment = new Envios();

                    shipment.IdVenta = model.IdSale;
                    shipment.Direccion = model.Direction;
                    shipment.Items = model.Items;
                    shipment.Recibio = model.Recives;
                    shipment.FechaEntrega = model.Delivery;
                    shipment.FechaCreación = DateTime.Today;

                    db.Envios.Add(shipment);
                    db.SaveChanges();
                }
                else
                    throw new Exception("Esta venta ya tiene un envío.");
            }
        }

        public void Delete(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var shipment = db.Envios.Find(id);

                db.Entry(shipment).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
