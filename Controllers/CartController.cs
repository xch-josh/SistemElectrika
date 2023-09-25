using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Components;
using Models.CartModels;
using Models.DataBase;
using Components.CustomExceptions;

namespace Controllers
{
    public class CartController
    {
        public async Task<List<CartViewModel>> GetData()
        {
            var lst = new List<CartViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = await (from x in db.Carrito
                       join y in db.Productos on x.IdProducto equals y.IdProducto
                       select new CartViewModel
                       {
                           Id = x.IdCarrito,
                           IdProducto = x.IdProducto,
                           Codigo = y.Codigo,
                           Cantidad = x.Cantidad,
                           Producto = y.Producto + " " + y.Marca + " (" + y.UnidadMedida + ")",
                           Precio = x.Precio,
                           Descuento = x.TipoDescuento == "%" ? "-" + x.Descuento.ToString() + "%" : "-Q" + x.Descuento.ToString(),
                           SubTotal = x.SubTotal,
                           SubTotalNeto = x.SubTotalNeto
                       }).ToListAsync();
            }
            return lst;
        }

        public void Insert(CartInsertModel model)
        {
            using (var db = new DbElectrikaEntities())
            {
                var math = new MathOperations();
                var productFromCart = db.Carrito.Where(x => x.IdProducto == model.idProduct).FirstOrDefault();
                var product = db.Productos.Find(model.idProduct);
                bool isPercentage;

                if (product.Existencia >= model.Quantity)
                {
                    if (productFromCart != null)
                    {
                        var cart = db.Carrito.Find(productFromCart.IdCarrito);

                        isPercentage = cart.TipoDescuento.Trim() == "%" ? true : false;

                        var discount = math.CalculateDiscount(cart.Precio, cart.Descuento, isPercentage);

                        cart.Cantidad += model.Quantity;
                        cart.SubTotal = cart.Cantidad * cart.Precio;
                        cart.SubTotalNeto = cart.Cantidad * (cart.Precio - discount);
                        cart.TipoDescuento = model.TypeDiscount;

                        db.Entry(cart).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        var cart = new Carrito();

                        isPercentage = model.TypeDiscount.Trim() == "%" ? true : false;
                        cart.Cantidad = model.Quantity;
                        cart.IdProducto = model.idProduct;
                        cart.Precio = model.Price;
                        cart.Descuento = model.Discount;
                        cart.SubTotal = cart.Cantidad * cart.Precio;
                        cart.SubTotalNeto = cart.Cantidad * (cart.Precio - math.CalculateDiscount(cart.Precio, cart.Descuento, isPercentage));
                        cart.TipoDescuento = model.TypeDiscount;

                        db.Carrito.Add(cart);
                        db.SaveChanges();
                    }
                    product.Existencia -= model.Quantity;
                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                    throw new InsufficientStockException("No hay suficientes existencias");
            }
        }

        public void Subtract(CartSubstractOrAddModel model)
        {
            using (var db = new DbElectrikaEntities())
            {
                var cart = db.Carrito.Find(model.Id);
                var math = new MathOperations();

                if (cart.Cantidad > model.Quantity)
                {
                    bool isPercentage = cart.TipoDescuento == "%" ? true : false;
                    var discount = math.CalculateDiscount(cart.Precio, cart.Descuento, isPercentage);

                    cart.Cantidad -= model.Quantity;
                    cart.SubTotal = cart.Cantidad * cart.Precio;
                    cart.SubTotalNeto = cart.Cantidad * (cart.Precio - discount);
                    db.Entry(cart).State = EntityState.Modified;
                    db.SaveChanges();

                    var product = db.Productos.Find(model.IdProduct);
                    product.Existencia += model.Quantity;
                    db.SaveChanges();
                }
                else if (cart.Cantidad == model.Quantity)
                {
                    db.Entry(cart).State = EntityState.Deleted;
                    db.SaveChanges();

                    var product = db.Productos.Find(model.IdProduct);
                    product.Existencia += model.Quantity;
                    db.SaveChanges();
                }
                else
                    throw new Exception("No puedes retirar una cantidad mayor a la del carrito");
            }
        }

        public void Add(CartSubstractOrAddModel model)
        {
            using (var db = new DbElectrikaEntities())
            {
                var product = db.Productos.Find(model.IdProduct);
                var math = new MathOperations();

                if (product.Existencia >= model.Quantity)
                {
                    var cart = db.Carrito.Find(model.Id);
                    bool isPercentage = cart.TipoDescuento == "%" ? true : false;
                    var discount = math.CalculateDiscount(cart.Precio, cart.Descuento, isPercentage);

                    product.Existencia -= model.Quantity;
                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();

                    cart.Cantidad += model.Quantity;
                    cart.SubTotal = cart.Cantidad * cart.Precio;
                    cart.SubTotalNeto = cart.Cantidad * (cart.Precio - discount);

                    db.Entry(cart).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                    throw new Exception("No hay suficientes existencias");
            }
        }

        public void Remove(CartSubstractOrAddModel model)
        {
            using (var db = new DbElectrikaEntities())
            {
                var cart = db.Carrito.Find(model.Id);
                var product = db.Productos.Find(model.IdProduct);

                product.Existencia += model.Quantity;
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();

                db.Entry(cart).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Clear()
        {
            using (var db = new DbElectrikaEntities())
            {
                db.LimpiarCarrito();
            }
        }

        public void AplyOrModifyUnitDiscount(int id, decimal discount, bool isPercentage)
        {
            using (var db = new DbElectrikaEntities())
            {
                var cart = db.Carrito.Find(id);
                var math = new MathOperations();
                decimal priceWithDiscount = 0;
                var apliedDiscount = math.CalculateDiscount(cart.Precio, discount, isPercentage);

                priceWithDiscount = cart.Precio - apliedDiscount;
                cart.SubTotalNeto = cart.Cantidad * priceWithDiscount;
                cart.Descuento = discount;

                db.Entry(cart).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void RemoveUnitDiscount(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var cart = db.Carrito.Find(id);

                cart.SubTotalNeto = cart.Precio * cart.Cantidad;
                cart.Descuento = 0;
                cart.TipoDescuento = "%";

                db.Entry(cart).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
