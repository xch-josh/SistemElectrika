using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;
using Models.ClientModels;
using Models.DataBase;

namespace Controllers
{
    public class ClientController
    {
        public async Task<List<ClientViewModel>> GetData(bool state)
        {
            var lst = new List<ClientViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = await (from x in db.Clientes
                       where x.Estado == state && x.Nombres != "CONSUMIDOR"
                       select new ClientViewModel
                       {
                           Id = x.IdCliente,
                           Nit = x.Nit,
                           Nombres = x.Nombres,
                           Apellidos = x.Apellidos,
                           Direccion = x.Direccion,
                           Telefono = x.Telefono,
                           Mail = x.Mail
                       }).ToListAsync();
            }
            return lst;
        }

        public void Insert(ClientAddModel model)
        {
            using (var db = new DbElectrikaEntities())
            {
                var clients = new Clientes();

                clients.Nit = model.Nit;
                clients.Nombres = model.Names;
                clients.Apellidos = model.Lastnames;
                clients.Direccion = model.Direction;
                clients.Telefono = model.Phone;
                clients.Mail = model.Mail.ToLower();
                clients.Estado = true;

                db.Clientes.Add(clients);
                db.SaveChanges();
            }
        }

        public void Edit(ClientEditModel model)
        {
            using (var db = new DbElectrikaEntities())
            {
                var clients = db.Clientes.Find(model.Id);

                clients.Nit = model.Nit;
                clients.Nombres = model.Names;
                clients.Apellidos = model.Lastnames;
                clients.Direccion = model.Direction;
                clients.Telefono = model.Phone;
                clients.Mail = model.Mail;

                db.Entry(clients).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var clients = db.Clientes.Find(id);

                db.Entry(clients).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Active(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var client = db.Clientes.Find(id);
                client.Estado = true;

                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Deactive(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var client = db.Clientes.Find(id);
                client.Estado = false;

                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public async Task<List<ClientGetModel>> GetClients()
        {
            var lst = new List<ClientGetModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = await (from x in db.Clientes
                       where x.Estado == true && x.Nombres != "CONSUMIDOR"
                       select new ClientGetModel
                       {
                           Id = x.IdCliente,
                           Nit = x.Nit,
                           Names = x.Nombres,
                           Lastnames = x.Apellidos,
                           Direction = x.Direccion
                       }).ToListAsync();
            }
            return lst;
        }

        public async Task<ClientGetModel> GetCF()
        {
            var client = new ClientGetModel();
            using (var db = new DbElectrikaEntities())
            {
                client = await(from y in db.Clientes
                          where y.Nombres == "CONSUMIDOR" && y.Apellidos == "FINAL"
                          select new ClientGetModel
                          {
                              Id = y.IdCliente,
                              Nit = y.Nit,
                              Names = y.Nombres,
                              Lastnames = y.Apellidos
                          }).FirstAsync();
            }
            return client;
        }

        public ClientGetModel GetClient(int id)
        {
            var client = new ClientGetModel();
            using (var db = new DbElectrikaEntities())
            {
                client =(from y in db.Clientes
                                where y.IdCliente == id
                                select new ClientGetModel
                                {
                                    Id = y.IdCliente,
                                    Nit = y.Nit,
                                    Names = y.Nombres,
                                    Lastnames = y.Apellidos,
                                    Direction = y.Direccion,
                                    Phone = y.Telefono.ToString(),
                                    Mail = y.Mail
                                }).FirstOrDefault();
            }
            return client;
        }
    }
}
