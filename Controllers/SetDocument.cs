using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports;
using Models.DocumentsModels;
using Controllers.Documents;
using Components;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Controllers
{
    public class SetDocument
    {
        string mainPath = @"C:\Users\danny\Documents\DocumentosPOS\";

        public RptLowStock LowStockReport(RptLowStockFiltersModel model)
        {
            var repot = new RptLowStock();

            repot.SetParameterValue("@ProductoCodigo", model.ProductOrCode);
            repot.SetParameterValue("@Marca", model.Brand);

            if (model.Category != "Todas")
                repot.SetParameterValue("@Categoria", model.Category);
            else
                repot.SetParameterValue("@Categoria", string.Empty);

            if (model.Provider != "Todos")
                repot.SetParameterValue("@Proveedor", model.Provider);
            else
                repot.SetParameterValue("@Proveedor", string.Empty);

            return repot;
        }

        public RptInventory InventoryReport()
        {
            return new RptInventory();
        }

        public RptQuotation Quotation(RptQuotationParameterModel model, string totalInLetters)
        {
            var report = new RptQuotation();
            report.SetParameterValue("@Id", model.IdQuotation);

            TextObject inLetters;
            inLetters = (TextObject)report.ReportDefinition.ReportObjects["totalInLetters"];
            inLetters.Text = totalInLetters;

            return report;
        }

        public string SaleVoucher(RptSaleVaucherParameterModel model, decimal total)
        {
            var report = new RptSaleVoucher();
            var totalInLetters = new NumbersToLetters().NumeroALetras(total);
            string file = @"Notas de venta\";
            string name = "Nota de venta " + model.IdSale.ToString() + ".pdf";

            report.SetParameterValue("@Id", model.IdSale);

            TextObject inLetters;
            inLetters = (TextObject)report.ReportDefinition.ReportObjects["totalInLetters"];
            inLetters.Text = totalInLetters;

            if (Directory.Exists(mainPath + file + name))
                return mainPath + file + name;
            else
            {
                Export(report, file, name);
                return mainPath + file + name;
            }

        }

        public string SaleVoucherWithCredit(RptSaleVaucherParameterModel model, decimal total)
        {
            var report = new RptSaleVoucherWithCredit();
            var totalInLetters = new NumbersToLetters().NumeroALetras(total);
            string file = @"Notas de venta\";
            string name = "Nota de venta " + model.IdSale.ToString() + ".pdf";

            report.SetParameterValue("@Id", model.IdSale);

            TextObject inLetters;
            inLetters = (TextObject)report.ReportDefinition.ReportObjects["totalInLetters"];
            inLetters.Text = totalInLetters;

            if (Directory.Exists(mainPath + file + name))
                return mainPath + file + name;
            else
            {
                Export(report, file, name);
                return mainPath + file + name;
            }
        }

        public RptShipment Shipment(RptShipmentParameterModel model, string totalInLetters)
        {
            var report = new RptShipment();
            report.SetParameterValue("@Id", model.Id);

            TextObject inLetters;
            inLetters = (TextObject)report.ReportDefinition.ReportObjects["totalInLetters"];
            inLetters.Text = totalInLetters;

            return report;
        }

        public RptDualCredit Credit(RptCreditParametersModel model)
        {
            var report = new RptDualCredit();
            report.SetParameterValue("Id", model.id);

            return report;
        }

        private string Export(ReportDocument document, string file, string name)
        {
            string path = mainPath + file;
            var options = new ExportOptions();

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            options.ExportFormatType = ExportFormatType.PortableDocFormat;
            options.ExportDestinationType = ExportDestinationType.DiskFile;
            options.DestinationOptions = new DiskFileDestinationOptions { DiskFileName = path + name };

            document.Export(options);

            return path + name;
        }
    }
}
