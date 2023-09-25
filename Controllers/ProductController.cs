using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ProductModels;
using Models.DataBase;
using System.Data.Entity;

namespace Controllers
{
    public class ProductController
    {
        public async Task<List<ProductViewModel>> GetData()
        {
            var lst = new List<ProductViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst =await (from x in db.Productos
                       join y in db.Proveedores on x.IdProveedor equals y.IdProveedor
                       join z in db.Categorias on x.IdCategoria equals z.IdCategoria
                       select new ProductViewModel
                       {
                           Id = x.IdProducto,
                           Codigo = x.Codigo,
                           Producto = x.Producto + " (" + x.UnidadMedida +")",
                           Marca = x.Marca,
                           Categoria = z.Categoria,
                           PrecioVenta = x.PrecioVenta,
                           Existencia = x.Existencia,
                           Proveedor = y.Proveedor
                       }).ToListAsync();
            }
            return lst;
        }

        public int Insert(ProductAddModel model)
        {
            if (ExistsCode(model.Code, null))
            {
                throw new Exception($"Un producto ya utiliza el codigo: {model.Code} \n Por favor intentar con otro");
            }
            else
            {
                using (var db = new DbElectrikaEntities())
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
                    product.Existencia = model.Stock;
                    product.IdProveedor = model.IdProvider;
                    product.UnidadMedida = model.Measure.ToUpper();

                    db.Productos.Add(product);
                    db.SaveChanges();

                    return product.IdProducto;
                }
            }
        }

        public void Edit(ProductEditModel model)
        {
            if (ExistsCode(model.Code, model.Id))
            {
                throw new Exception($"Otro producto ya utiliza el codigo: {model.Code} \n Por favor intentar con otro");
            }
            else
            {
                using (var db = new DbElectrikaEntities())
                {
                    var product = db.Productos.Find(model.Id);

                    product.Codigo = model.Code.ToUpper();
                    product.Producto = model.Product.ToUpper();
                    product.Marca = model.Brand.ToUpper();
                    product.IdCategoria = model.IdCategory;
                    product.PrecioCompra = model.PurchasePrice;
                    product.Ganancia = model.Gain;
                    product.TipoGanancia = model.TypeGain;
                    product.PrecioVenta = model.SalePrice;
                    product.Existencia = model.Stock;
                    product.IdProveedor = model.IdProvider;
                    product.UnidadMedida = model.Measure.ToUpper();

                    db.Entry(product).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (var db = new DbElectrikaEntities())
            {
                var product = db.Productos.Find(id);

                db.Entry(product).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public ProductGetModel GetProduct(int id)
        {
            var model = new ProductGetModel();

            using (var db = new DbElectrikaEntities())
            {
                var product = db.Productos.Find(id);

                model.Code = product.Codigo;
                model.Product = product.Producto;
                model.Brand = product.Marca;
                model.IdCategory = product.IdCategoria;
                model.PurchasePrice = product.PrecioCompra;
                model.Gain = product.Ganancia;
                model.TypeGain = product.TipoGanancia;
                model.SalePrice = product.PrecioVenta;
                model.Stock = product.Existencia;
                model.IdProvider = product.IdProveedor;
                model.Measure = product.UnidadMedida;
            }
            return model;
        }

        public ProductGetModel GetProduct(string code)
        {
            var model = new ProductGetModel();

            using (var db = new DbElectrikaEntities())
            {
                var product = db.Productos.Where(x => x.Codigo == code).FirstOrDefault();

                if (product != null)
                {
                    model.Id = product.IdProducto;
                    model.Code = product.Codigo;
                    model.Product = product.Producto;
                    model.Brand = product.Marca;
                    model.IdCategory = product.IdCategoria;
                    model.PurchasePrice = product.PrecioCompra;
                    model.Gain = product.Ganancia;
                    model.TypeGain = product.TipoGanancia;
                    model.SalePrice = product.PrecioVenta;
                    model.Stock = product.Existencia;
                    model.IdProvider = product.IdProveedor;
                    model.Measure = product.UnidadMedida;
                }
            }
            return model;
        }

        private bool ExistsCode(string code, int? id)
        {
            using (var db = new DbElectrikaEntities())
            {
                string products;

                if (id == null)
                    products = db.Productos.Where(x => x.Codigo == code).Select(y => y.Codigo).FirstOrDefault();
                else
                    products = db.Productos.Where(x => x.Codigo == code && x.IdProducto != id).Select(y => y.Codigo).FirstOrDefault();

                if (products != null)
                    return true;
                else
                    return false;
            }
        }

        public List<ProductGetCodesModel> GetCodes(int idProvider)
        {
            var lst = new List<ProductGetCodesModel>();

            using (var db = new DbElectrikaEntities())
            {
                lst = (from x in db.Productos
                       where x.IdProveedor == idProvider
                       select new ProductGetCodesModel
                       {
                           Id = x.IdProducto,
                           Code = x.Codigo
                       }).ToList();
            }
            return lst;
        }

        public async Task<List<ProductLowStockViewModel>> GetLowStock()
        {
            var lst = new List<ProductLowStockViewModel>();

            using (var db = new DbElectrikaEntities())
            {
                var minStock = db.Configuraciones.First();
                lst = await (from x in db.Productos
                       join y in db.Proveedores on x.IdProveedor equals y.IdProveedor
                       join z in db.Categorias on x.IdCategoria equals z.IdCategoria
                       where x.Existencia <= minStock.AlertaStockBajo
                       select new ProductLowStockViewModel
                       {
                           Codigo = x.Codigo,
                           Producto = x.Producto + " (" + x.UnidadMedida + ")",
                           Marca = x.Marca,
                           Existencias = x.Existencia,
                           Categoria = z.Categoria,
                           Proveedor = y.Proveedor
                       }).ToListAsync();
            }
            return lst;
        }
    }
}
