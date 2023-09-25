using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.PurchasesModels.DetailPurchaseModel;
using Models.DataBase;
using System.Data.Entity;
using Models.ProductModels;

namespace Controllers
{
    public class DetailPurchaseController
    {
        public async Task<List<DetailPurchaseViewModel>> GetData(int id)
        {
            var lst = new List<DetailPurchaseViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = await (from x in db.DetalleCompra join y in db.Productos
                       on x.IdProducto equals y.IdProducto
                       where x.IdCompra == id
                       select new DetailPurchaseViewModel
                       {
                           Id = x.IdDetCompra,
                           Cantidad = x.Cantidad,
                           Producto = y.Producto + " " + y.Marca + " (" + y.UnidadMedida + ")",
                           PrecioCompra = x.Precio,
                           SubTotal = x.SubTotal
                       }).ToListAsync();
            }

            return lst;
        }

        public void Insert(List<DetailPurchaseAddModel> models, int idPurchase)
        {
            using (var db = new DbElectrikaEntities())
            {
                foreach (var item in models)
                {
                    if (item.IdProduct != 0)
                    {
                        var product = db.Productos.Find(item.IdProduct);

                        product.Existencia += item.Quantity;
                        product.PrecioCompra = item.PurchasePrice;
                        product.Ganancia = item.Gain;
                        product.PrecioVenta = item.SalePrice;

                        db.Entry(product).State = EntityState.Modified;
                        db.SaveChanges();

                        var detail = new DetalleCompra();

                        detail.IdCompra = idPurchase;
                        detail.Cantidad = item.Quantity;
                        detail.IdProducto = item.IdProduct;
                        detail.Precio = item.PurchasePrice;
                        detail.SubTotal = decimal.Round(item.Quantity * item.PurchasePrice, 2);

                        db.DetalleCompra.Add(detail);
                        db.SaveChanges();
                    }
                    else
                    {
                        var product = new Productos();

                        product.Codigo = item.Code.ToUpper();
                        product.Producto = item.Product.ToUpper();
                        product.Marca = item.Brand.ToUpper();
                        product.IdCategoria = item.IdCategory;
                        product.PrecioCompra = item.PurchasePrice;
                        product.Ganancia = item.Gain;
                        product.TipoGanancia = item.TypeGain;
                        product.PrecioVenta = item.SalePrice;
                        product.Existencia += item.Quantity;
                        product.IdProveedor = item.IdProvider;
                        product.UnidadMedida = item.Measure.ToUpper();
                        db.Productos.Add(product);
                        db.SaveChanges();

                        var detail = new DetalleCompra();

                        detail.IdCompra = idPurchase;
                        detail.Cantidad = item.Quantity;
                        detail.IdProducto = product.IdProducto ;
                        detail.Precio = item.PurchasePrice;
                        detail.SubTotal = decimal.Round(item.Quantity * item.PurchasePrice, 2);

                        db.DetalleCompra.Add(detail);
                        db.SaveChanges();
                    }
                }
            }
        }

        public void Insert(DetailPurchaseAddModel model, int idPurchase)
        {
            using (var db = new DbElectrikaEntities())
            {
                if (model.IdProduct != 0)
                {
                    var product = db.Productos.Find(model.IdProduct);

                    product.Existencia += model.Quantity;
                    product.PrecioCompra = model.PurchasePrice;
                    product.Ganancia = model.Gain;
                    product.PrecioVenta = model.SalePrice;

                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();

                    var detail = new DetalleCompra();

                    detail.IdCompra = idPurchase;
                    detail.Cantidad = model.Quantity;
                    detail.IdProducto = model.IdProduct;
                    detail.Precio = model.PurchasePrice;
                    detail.SubTotal = decimal.Round(model.Quantity * model.PurchasePrice, 2);

                    db.DetalleCompra.Add(detail);
                    db.SaveChanges();
                }
                else
                {
                    var product = new Productos();

                    product.Codigo = model.Code.ToUpper();
                    product.Producto = model.Product.ToUpper();
                    product.Marca = model.Brand.ToUpper();
                    product.IdCategoria = model.IdCategory;
                    product.PrecioCompra = model.PurchasePrice;
                    product.Ganancia = model.Gain;
                    product.TipoGanancia = model.TypeGain;
                    product.PrecioVenta = model.SalePrice;
                    product.Existencia += model.Quantity;
                    product.IdProveedor = model.IdProvider;
                    product.UnidadMedida = model.Measure.ToUpper();
                    db.Productos.Add(product);
                    db.SaveChanges();

                    var detail = new DetalleCompra();

                    detail.IdCompra = idPurchase;
                    detail.Cantidad = model.Quantity;
                    detail.IdProducto = product.IdProducto;
                    detail.Precio = model.PurchasePrice;
                    detail.SubTotal = decimal.Round(model.Quantity * model.PurchasePrice, 2);

                    db.DetalleCompra.Add(detail);
                    db.SaveChanges();
                }
            }
        }

        public void Edit(DetailPurchaseEditModel model)
        {
            using (var db = new DbElectrikaEntities())
            {
                var detail = db.DetalleCompra.Find(model.Id);

                detail.Cantidad = model.Quantity;
                detail.Precio = model.PurchasePrice;
                detail.SubTotal = detail.Cantidad * detail.Precio;

                db.Entry(detail).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var detail = db.DetalleCompra.Find(id);

                db.Entry(detail).State = EntityState.Deleted;
                db.SaveChanges();

                var purchase = db.Compras.Find(detail.IdCompra);
                var sumDetail = decimal.Round(db.DetalleCompra.Where(x => x.IdCompra == detail.IdCompra).Select(y => y.SubTotal).Sum(), 2);
                purchase.Total = sumDetail;
                db.Entry(purchase).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
