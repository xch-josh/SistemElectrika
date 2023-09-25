using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Components;
using Models.DocumentsModels;
using Models.SaleModels.SaleDetailModels;
using Models.ShipmentModels;
using Views.ClientViews;

namespace Views.SaleViews.SaleDetailViews
{
    public partial class FrmSaleDetail : Form
    {
        FrmSales frmSales;
        FrmAcount frmAcunt;
        int id;
        decimal netTotal;
        bool toSales;
        public FrmSaleDetail(FrmSales frmSales, int id)
        {
            InitializeComponent();
            this.frmSales = frmSales;
            this.id = id;
            this.toSales = true;
        }

        public FrmSaleDetail(FrmAcount frmAcunt, int id)
        {
            InitializeComponent();
            this.frmAcunt = frmAcunt;
            this.id = id;
            this.toSales = false;
        }

        List<SaleDetailViewModel> lst = new List<SaleDetailViewModel>();
        private void FrmSaleDetail_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public void ShowData()
        {
            try
            {
                var detail = new SaleDetailController();
                lst = detail.GetData(id);

                if (lst.Count > 0)
                {
                    dgvData.DataSource = lst;
                    lblNoData.Visible = false;
                }
                else
                {
                    dgvData.DataSource = null;
                    lblNoData.Visible = true;
                }
                netTotal = lst.Select(x => x.SubTotalNeto).Sum();
                ConfColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfColumns()
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                dgvData.Columns[0].Visible = false;
                dgvData.Columns[1].Width = 90;
                dgvData.Columns[2].Width = 90;
                dgvData.Columns[3].Width = 250;
            }
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Se devolverá el producto seleccionado al inventario \n\n Desea continuar?",
                "Devolver venta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvData.RowCount == 1)
                    GiveBackSale();
                else if (dgvData.RowCount > 1)
                    GiveBackProduct();
            }
        }

        private void GiveBackSale()
        {
            try
            {
                var sale = new SaleController();
                sale.Devolution(id);

                if (toSales)
                    frmSales.ShowData();
                else
                    frmAcunt.ShowData();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GiveBackProduct()
        {
            try
            {
                var detail = new SaleDetailController();
                detail.Devolution((int)dgvData.SelectedCells[0].Value);
                ShowData();

                if (toSales)
                    frmSales.ShowData();
                else
                    frmAcunt.ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var voucherModel = new RptSaleVaucherParameterModel();
            voucherModel.IdSale = id;
            var document = new SetDocument().SaleVoucher(voucherModel, this.netTotal);
            System.Diagnostics.Process.Start(document);
        }

        private void btnNotEspecified_Click(object sender, EventArgs e)
        {
            txtReceives.Text = "<No especificado>";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDirection.Text.Trim() != string.Empty && txtReceives.Text.Trim() != string.Empty)
                {
                    var shipment = new ShipmentController();
                    var model = new ShipmentAddModel();

                    model.IdSale = this.id;
                    model.Direction = txtDirection.Text.Trim();
                    model.Items = lst.Count;
                    model.Recives = txtReceives.Text.Trim();
                    model.Delivery = dtpDelivery.Value;

                    shipment.Insert(model);

                    var result = MessageBox.Show("Envío creado correctamente :) \n ¿Desea imprimirlo?", "Hecho", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var shipmentParameterModel = new RptShipmentParameterModel();
                        var inLetters = new NumbersToLetters();
                        shipmentParameterModel.Id = this.id;
                        var shipmentDocument = new DocumentViews.FrmShowDocument(shipmentParameterModel, inLetters.NumeroALetras(netTotal));
                        shipmentDocument.Show();
                    }

                    gbCreateShipment.Visible = false;
                    txtDirection.Clear();
                    txtReceives.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateShipment_Click(object sender, EventArgs e)
        {
            gbCreateShipment.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbCreateShipment.Visible = false;
        }
    }
}
