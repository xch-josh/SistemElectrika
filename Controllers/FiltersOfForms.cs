using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ProviderModels;
using Models.ProviderModels.DetailProviderModels;
using Models.ProductModels;
using Models.ClientModels;
using Models.SaleModels;
using Models.PurchasesModels;
using Models.QuotationModels;
using Models.ShipmentModels;

namespace Controllers
{
    public class FiltersOfForms
    {
        public List<ProviderViewModel> FilterProviders(List<ProviderViewModel> lst, string codeProv)
        {
            var result = lst.AsQueryable();

            if (codeProv != string.Empty)
                result = result.Where(x => x.Codigo.ToUpper().Contains(codeProv.ToUpper()) || x.Proveedor.ToUpper().Contains(codeProv.ToUpper()));

            return result.ToList();
        }

        public List<DetailProviderViewModel> FilterDetailProvider(List<DetailProviderViewModel> lst, string saler)
        {
            var result = lst.AsQueryable();

            if (saler != string.Empty)
                result = result.Where(x => x.Vendedor.ToUpper().Contains(saler.ToUpper()));

            return result.ToList();
        }

        public List<ProductViewModel> FilterProduct(List<ProductViewModel> lst, string codeProd, string brand, string provider, string category)
        {
            var result = lst.AsQueryable();

            if (codeProd != string.Empty)
                result = result.Where(x => x.Producto.ToUpper().Contains(codeProd.ToUpper()) || x.Codigo.ToUpper().Contains(codeProd.ToUpper()));

            if (brand != string.Empty)
                result = result.Where(x => x.Marca.ToUpper().Contains(brand.ToUpper()));

            if (provider != "Todos" && provider != string.Empty)
                result = result.Where(x => x.Proveedor.ToUpper().Contains(provider.ToUpper()));

            if (category != "Todas" && category != string.Empty)
                result = result.Where(x => x.Categoria.ToUpper().Contains(category.ToUpper()));

            return result.ToList();
        }

        public List<ProductLowStockViewModel> FilterProduct(List<ProductLowStockViewModel> lst, string codeProd, string brand, string provider, string category)
        {
            var result = lst.AsQueryable();

            if (codeProd != string.Empty)
                result = result.Where(x => x.Producto.ToUpper().Contains(codeProd.ToUpper()) || x.Codigo.ToUpper().Contains(codeProd.ToUpper()));

            if (brand != string.Empty)
                result = result.Where(x => x.Marca.ToUpper().Contains(brand.ToUpper()));

            if (provider != "Todos" && provider != string.Empty)
                result = result.Where(x => x.Proveedor.ToUpper().Contains(provider.ToUpper()));

            if (category != "Todas" && category != string.Empty)
                result = result.Where(x => x.Categoria.ToUpper().Contains(category.ToUpper()));

            return result.ToList();
        }

        public List<ClientViewModel> FilterClient(List<ClientViewModel> lst, string nit, string names, string lastnames)
        {
            var result = lst.AsQueryable();

            if (nit != string.Empty)
                result = result.Where(x => x.Nit.ToString().ToUpper().Contains(nit.ToUpper()));

            if (names != string.Empty)
                result = result.Where(x => x.Nombres.ToUpper().Contains(names.ToUpper()));

            if (lastnames != string.Empty)
                result = result.Where(x => x.Apellidos.ToUpper().Contains(lastnames.ToUpper()));

            return result.ToList();
        }

        public List<ClientGetModel> FilterClient(List<ClientGetModel> lst, string nit, string names, string lastnames)
        {
            var result = lst.AsQueryable();

            if (nit != string.Empty)
                result = result.Where(x => x.Nit.ToString().ToUpper().Contains(nit.ToUpper()));

            if (names != string.Empty)
                result = result.Where(x => x.Names.ToUpper().Contains(names.ToUpper()));

            if (lastnames != string.Empty)
                result = result.Where(x => x.Lastnames.ToUpper().Contains(lastnames.ToUpper()));

            return result.ToList();
        }

        public List<SaleViewModel> FilterSales(List<SaleViewModel> lst, string id, string client, bool enableDate, DateTime date, bool showByDay)
        {
            var result = lst.AsQueryable();

            if (enableDate)
            {
                if (showByDay)
                    result = result.Where(x => x.Fecha.ToShortDateString() == date.ToShortDateString());
                else
                {
                    result = result.Where(x => x.Fecha.ToString("dd/MM/yyyy").Contains(date.ToString("MM/yyyy")));
                }
            }

            if (id != string.Empty)
                result = result.Where(x => x.Id.ToString().Contains(id));

            if (client != string.Empty)
                result = result.Where(x => x.Cliente.ToUpper().Contains(client.ToUpper()));

            return result.ToList();
        }

        public List<PurchaseViewModel> FilterPurchases(List<PurchaseViewModel> lst, string bill, string provider, bool enableDate, DateTime date, bool showByDay)
        {
            var result = lst.AsQueryable();

            if (enableDate)
            {
                if (showByDay)
                    result = result.Where(x => x.Fecha.ToShortDateString() == date.ToShortDateString());
                else
                {
                    result = result.Where(x => x.Fecha.ToString("dd/MM/yyyy").Contains(date.ToString("MM/yyyy")));
                }
            }

            if (bill != string.Empty)
                result = result.Where(x => x.Factura.ToString().Contains(bill));

            if (provider != string.Empty)
                result = result.Where(x => x.Proveedor.ToUpper().Contains(provider.ToUpper()));

            return result.ToList();
        }

        public List<QuotationViewModel> FilterQuotations(List<QuotationViewModel> lst, string client, bool enableDate, DateTime date, bool showByDay)
        {
            var result = lst.AsQueryable();

            if (enableDate)
            {
                if (showByDay)
                    result = result.Where(x => x.Creacion.ToShortDateString() == date.ToShortDateString());
                else
                {
                    result = result.Where(x => x.Creacion.ToString("dd/MM/yyyy").Contains(date.ToString("MM/yyyy")));
                }
            }

            if (client != string.Empty)
                result = result.Where(x => x.Cliente.ToString().Contains(client));

            return result.ToList();
        }

        public List<ShipmentViewModel> FilterShipments(List<ShipmentViewModel> lst, string id, string idSale, string client, bool enableDate, DateTime date, bool showByDay, bool showByCreationDate)
        {
            var result = lst.AsQueryable();

            if (enableDate)
            {
                if (showByCreationDate)
                    if (showByDay)
                        result = result.Where(x => x.FechaCreacion.ToShortDateString() == date.ToShortDateString());
                    else
                        result = result.Where(x => x.FechaCreacion.ToString("dd/MM/yyyy").Contains(date.ToString("MM/yyyy")));
                else
                    if (showByDay)
                    result = result.Where(x => x.FechaEntrega.ToShortDateString() == date.ToShortDateString());
                else
                    result = result.Where(x => x.FechaEntrega.ToString("dd/MM/yyyy").Contains(date.ToString("MM/yyyy")));
            }

            if (id != string.Empty)
                result = result.Where(x => x.Id.ToString().Contains(id));

            if (idSale != string.Empty)
                result = result.Where(x => x.IdVenta.ToString().Contains(idSale));

            if (client != string.Empty)
                result = result.Where(x => x.Cliente.ToUpper().Contains(client.ToUpper()));

            return result.ToList();
        }

        public List<GetByClientModel> FilterSales(List<GetByClientModel> lst, string id)
        {
            var result = lst.AsQueryable();

            if (id != string.Empty)
                result = result.Where(x => x.Id.ToString().Contains(id));

            return result.ToList();
        }
    }
}
