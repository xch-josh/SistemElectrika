using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports;
using Models.DocumentsModels;
using Controllers.Documents;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;

namespace Controllers.Untils
{
    public class SetDocument
    {
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

        public RptSaleVoucher SaleVoucher(RptSaleVaucherParameterModel model, string totalInLetters)
        {
            var report = new RptSaleVoucher();
            report.SetParameterValue("@Id", model.IdSale);

            TextObject inLetters;
            inLetters = (TextObject)report.ReportDefinition.ReportObjects["totalInLetters"];
            inLetters.Text = totalInLetters;

            return report;
        }

        public RptSaleVoucherWithCredit SaleVoucherWithCredit(RptSaleVaucherParameterModel model, string totalInLetters)
        {
            var report = new RptSaleVoucherWithCredit();
            report.SetParameterValue("@Id", model.IdSale);

            TextObject inLetters;
            inLetters = (TextObject)report.ReportDefinition.ReportObjects["totalInLetters"];
            inLetters.Text = totalInLetters;

            return report;
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
    }
}
