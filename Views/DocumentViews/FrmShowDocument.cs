using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Components;
using Models.DocumentsModels;
using Controllers;
using CrystalDecisions.Windows.Forms;
using Controllers.Documents;

namespace Views.DocumentViews
{
    public partial class FrmShowDocument : Form
    {
        public FrmShowDocument()
        {
            InitializeComponent();

            SetInventory();
        }

        public FrmShowDocument(RptLowStockFiltersModel model)
        {
            InitializeComponent();
            var report = new SetDocument();
            crvDocument.ReportSource = report.LowStockReport(model);
        }

        //EL COSTRUCTOR RECIBE EL MODELO PARA LOS PARAMETROS DEL REPORTE Y UN TOTAL EN LETRAS
        public FrmShowDocument(RptQuotationParameterModel model, string totalInLetters)
        {
            InitializeComponent();
            var report = new SetDocument();
            crvDocument.ReportSource = report.Quotation(model, totalInLetters);
            this.BringToFront();
        }

        public FrmShowDocument(RptSaleVaucherParameterModel model, string totalInLetters, bool creditExtend)
        {
            InitializeComponent();
           
        }

        public FrmShowDocument(RptShipmentParameterModel model, string totalInLetters)
        {
            InitializeComponent();
            var report = new SetDocument();
            crvDocument.ReportSource = report.Shipment(model, totalInLetters);
            this.BringToFront();
        }

        public FrmShowDocument(RptCreditParametersModel model)
        {
            InitializeComponent();
            var report = new SetDocument();
            crvDocument.ReportSource = report.Credit(model);
            this.BringToFront();
        }

        private async void SetInventory()
        {
            var report = new SetDocument();

            Task<RptInventory> task = new Task<RptInventory>(report.InventoryReport);
            task.Start();
            crvDocument.ReportSource = await task;
            crvDocument.RefreshReport();
        }
    }
}
