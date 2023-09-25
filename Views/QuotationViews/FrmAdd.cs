using Components;
using Controllers;
using Models.ClientModels;
using Models.DocumentsModels;
using Models.QuotationModels;
using Models.QuotationModels.DetailQuotationModels;
using Views.ClientViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.QuotationViews
{
    public partial class FrmAdd : Form
    {
        public List<DetailQuotationAddModel> lst = new List<DetailQuotationAddModel>();
        decimal SumDiscountOfUnit, NetTotal, Total, discountOfTotal, discount;
        int idClient;

        public FrmAdd()
        {
            InitializeComponent();
        }

        public void ShowData()
        {
            if (lst.Count > 0)
            {
                dgvData.DataSource = null;
                dgvData.DataSource = lst;
                lblNoData.Visible = false;
            }
            else
            {
                dgvData.DataSource = null;
                lblNoData.Visible = true;
            }
            ConfColumns();
            SetValueLabels();
        }

        private void ConfColumns()
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                dgvData.Columns[1].Visible = false;

                dgvData.Columns[0].Width = 80;
                dgvData.Columns[2].Width = 100;
                dgvData.Columns[3].Width = 190;

                dgvData.Columns[7].HeaderText = "SubTotal Neto";
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
                txtClient.Text = string.Format("{0} {1}", model.Names, model.Lastnames);
            }
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            var frmAddProduct = new ProductViews.FrmAddToQuotation(this);
            frmAddProduct.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                dgvData.Focus();
                lst.RemoveAt(dgvData.CurrentRow.Index);
                ShowData();
            }
        }

        private void FrmAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnAddProducts_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (txtTotal.Focused || txtUnit.Focused)
                    btnAplyDiscount_Click(sender, e);
                else
                    btnSave_Click(sender, e);
            }
        }

        private void btnAplyDiscount_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != string.Empty)
            {
                DiscountToTotal();
            }
            else if (txtUnit.Text != string.Empty)
            {
                DiscountToUnit();
            }
            else
            {
                MessageBox.Show("Ingrese un porcentaje de descuento");
            }
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lst.Count > 0 && txtClient.Text != string.Empty)
            {
                try
                {
                    var quotation = new QuotationController();
                    var model = new QuotationAddModel();

                    model.IdClient = this.idClient;
                    model.Total = Total;
                    model.Discount = discount;
                    model.NetTotal = NetTotal;
                    model.Creation = dtpDate.Value;
                    model.Expire = dtpDate.Value.AddDays((double)nudDays.Value);

                    int id = quotation.Insert(model, lst);
                    this.DialogResult = DialogResult.OK;
                    DialogResult result =  MessageBox.Show("Los datos han sido guardados :) \n ¿Desea imprimir el documento?", "Guadrar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        var quotationParameter = new RptQuotationParameterModel();
                        quotationParameter.IdQuotation = id;
                        var document = new DocumentViews.FrmShowDocument(quotationParameter, lblTotalInLetters.Text);
                        document.Show();
                        document.BringToFront();
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Debe llenar todos los campos");
        }

        #region "DiscountsFunctions"
        private void DiscountToTotal()
        {
            if (SumDiscountOfUnit == 0)
            {
                var operation = new MathOperations();

                discountOfTotal = operation.CalculateDiscount(Total, decimal.Parse(txtTotal.Text), rbPercentage.Checked);
                txtTotal.Text = string.Empty;
                SetValueLabels();
            }
            else
                MessageBox.Show("Ya se han aplicado descuentos a los productos en el carrito");
        }

        private void DiscountToUnit()
        {
            if (discountOfTotal == 0)
            {
                if ((decimal)dgvData.SelectedCells[6].Value == 0)
                {
                    dgvData.Focus();
                    var getItem = lst.ElementAt(dgvData.CurrentRow.Index);
                    var operation = new MathOperations();

                    getItem.Descuento = operation.CalculateDiscount(getItem.SubTotal, decimal.Parse(txtUnit.Text), rbPercentage.Checked);
                    getItem.SubTotalNeto -= getItem.Descuento;
                    txtUnit.Text = string.Empty;
                    ShowData();
                }
                else
                    MessageBox.Show("Ya se ha aplicado un descuento a este producto");
            }
            else
                MessageBox.Show("Ya se ha aplicado un descuento al total de la venta");
        }

        private void RemoveDiscountUnit()
        {
            dgvData.Focus();
            var getItem = lst.ElementAt(dgvData.CurrentRow.Index);

            getItem.SubTotalNeto += getItem.Descuento;
            getItem.Descuento = 0;
            ShowData();

        }

        private void RemoveDiscountOfTotal()
        {
            discountOfTotal = 0;
            NetTotal = Total;
            SetValueLabels();
        }
        #endregion

        #region "Validations"
        private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(".") && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar("."))
                if (txtUnit.Text.Contains("."))
                    e.Handled = true;

            if (txtTotal.Text.Trim() != string.Empty)
            {
                e.Handled = true;
                MessageBox.Show("el descuento al total ya tiene ingresado un valor");
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(".") && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar("."))
                if (txtTotal.Text.Contains("."))
                    e.Handled = true;

            if (txtUnit.Text.Trim() != string.Empty)
            {
                e.Handled = true;
                MessageBox.Show("el descuento unitario ya tiene ingresado un valor");
            }
        }

        private void SetValueLabels()
        {
            Total = decimal.Round(lst.Select(x => x.SubTotal).Sum(), 2);
            SumDiscountOfUnit = decimal.Round(lst.Select(x => x.Descuento).Sum(), 2);

            if (SumDiscountOfUnit > 0)
            {
                discount = SumDiscountOfUnit;
                NetTotal = decimal.Round(Total - SumDiscountOfUnit, 2);
            }
            else if (discountOfTotal > 0)
            {
                discount = discountOfTotal;
                NetTotal = decimal.Round(Total - discountOfTotal, 2);
            }
            else
            {
                discount = 0;
                NetTotal = Total;
            }

            lblTotal.Text = "Q " + Total.ToString();
            lblDiscount.Text = "Q " + discount.ToString();
            lblNetTotal.Text = "Q " + NetTotal.ToString();

            var totalInLetters = new NumbersToLetters();
            lblTotalInLetters.Text = totalInLetters.NumeroALetras(NetTotal);
        }
        #endregion
    }
}