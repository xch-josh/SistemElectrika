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
using Models.ClientModels;
using Models.CreditModels;
using Models.CreditModels.CreditPaymentModels;
using Models.DocumentsModels;
using Models.SaleModels;
using Models.ShipmentModels;
using Views.ClientViews;

namespace Views.CartViews
{
    public partial class FrmCashOut : Form
    {
        FrmCart frmCart;
        public int idClient, itemsCount;
        public decimal netTotal, total, discount;
        public FrmCashOut(FrmCart frmCart)
        {
            InitializeComponent();
            this.frmCart = frmCart;
        }

        #region "Validations"
        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(".") && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar("."))
                if (txtMoney.Text.Contains("."))
                    e.Handled = true;

        }

        private void CalculateChange()
        {
            if (txtMoney.Text != string.Empty)
            {
                decimal money = decimal.Parse(txtMoney.Text);
                if (money >= netTotal)
                {
                    lblChange.Text = "Q " + decimal.Round(money - netTotal, 2).ToString();
                    lblChange.ForeColor = Color.Black;
                }
                else
                {
                    lblChange.Text = "<Efectivo insuficiente>";
                    lblChange.ForeColor = Color.DarkRed;
                }
            }
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            var model = new ClientGetModel();
            var frmSelectClient = new FrmSelect(ref model);
            frmSelectClient.ShowDialog();

            if (frmSelectClient.DialogResult == DialogResult.OK)
            {
                this.idClient = model.Id;
                lblNit.Text = model.Nit;
                lblClient.Text = string.Format("{0} {1}", model.Names, model.Lastnames);
            }
        }

        private void btnCF_Click(object sender, EventArgs e)
        {
            txtDirection.Clear();
            txtReceives.Clear();
            GetFinalConsumer();
        }

        private void chbCreateShipment_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCreateShipment.Checked)
                this.Size = new Size(this.Size.Width, 460);
            else
                this.Size = new Size(this.Size.Width, 310);
        }

        private void rbCounted_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCounted.Checked)
                lblPay.Text = "Efectivo";
            else
                lblPay.Text = "Abono";
        }

        private void btnNotEspecified_Click(object sender, EventArgs e)
        {
            txtReceives.Text = "<No especificado>";
        }
        #endregion

        private void FrmCachOut_Load(object sender, EventArgs e)
        {
            GetFinalConsumer();
            lblTotal.Text = netTotal.ToString("N2");
        }

        private async void GetFinalConsumer()
        {
            try
            {
                var client = new ClientController();
                var model = await client.GetCF();

                lblClient.Text = model.Names + " " + model.Lastnames;
                lblNit.Text = model.Nit;
                idClient = model.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            try
            {
                //VALIDE IF CLIENT SELECTED ISN'T FINAL CONSUMER
                if (rbCredit.Checked && lblClient.Text == "CONSUMIDOR FINAL")
                {
                    MessageBox.Show("Debe seleccionar un cliente para poder extender un credito");
                    return;
                }

                //VALIDE IF CREATE A SHIPMENT
                if (chbCreateShipment.Checked)
                    if (txtDirection.Text.Trim() == string.Empty && txtReceives.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Debe llenar los campos del envío");
                        return;
                    }

                var sale = new SaleController();
                var model = new SaleAddModel();

                model.IdClient = idClient;
                model.Total = total;
                model.Discount = discount;
                model.NetTotal = netTotal;
                model.Date = DateTime.Parse(DateTime.Today.ToShortDateString());

                var idSale = sale.Insert(model);

                CreateShipment(idSale);
                CreditExtend(idSale);
                QuestionPrint(idSale);

                frmCart.discount = 0;
                frmCart.total = 0;
                frmCart.netTotal = 0;

                frmCart.ShowData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QuestionPrint(int id)
        {
            var result = MessageBox.Show("Venta realizada correctamente :) \n ¿Desea imprimir un comprobante?", "Hecho", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var voucherModel = new RptSaleVaucherParameterModel();
                var document = new SetDocument();

                voucherModel.IdSale = id;
                
                if (rbCredit.Checked)
                    System.Diagnostics.Process.Start(document.SaleVoucherWithCredit(voucherModel, this.netTotal));
                else
                    System.Diagnostics.Process.Start(document.SaleVoucher(voucherModel, this.netTotal));
            }
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            if (txtMoney.Text != string.Empty)
            {
                if (decimal.TryParse(txtMoney.Text, out decimal money))
                {
                    if (money >= netTotal)
                    {
                        lblChange.Text = "Q " + decimal.Round(money - netTotal, 2).ToString("N2");
                        lblChange.ForeColor = Color.Black;
                    }
                    else
                    {
                        lblChange.Text = "<Efectivo insuficiente>";
                        lblChange.ForeColor = Color.DarkRed;
                    }
                }
                else
                    lblChange.Text = "Q 0.00";
            }
        }

        private void CreateShipment(int idSale)
        {
            if (chbCreateShipment.Checked)
            {
                try
                {
                    var shipment = new ShipmentController();
                    var model = new ShipmentAddModel();

                    model.IdSale = idSale;
                    model.Direction = txtDirection.Text.Trim();
                    model.Items = itemsCount;
                    model.Recives = txtReceives.Text.Trim();
                    model.Delivery = dtpDelivery.Value;

                    shipment.Insert(model);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CreditExtend(int idSale)
        {
            if (rbCredit.Checked)
            {
                try
                {
                    var credit = new CreditController();
                    var model = new CreditAddModel();

                    model.idSale = idSale;
                    model.initialDebt = netTotal;
                    model.balance = netTotal;
                    model.date = DateTime.Today;

                    int idCredit = credit.Insert(model);

                    if (txtMoney.Text.Trim() != string.Empty)
                        AddPay(idCredit);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddPay(int idCredit)
        {
            try
            {
                var payment = new PaymentController();
                var model = new PaymentAddModel();

                model.idCredit = idCredit;
                model.amount = decimal.Parse(txtMoney.Text.Trim());
                model.date = DateTime.Today;

                payment.Insert(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
