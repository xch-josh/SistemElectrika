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
using Models.ProductModels;
using Models.PurchasesModels;
using Models.PurchasesModels.DetailPurchaseModel;

namespace Views.PurchasesViews
{
    public partial class FrmAdd : Form
    {
        FrmPurchases frmPurchases;
        public FrmAdd(FrmPurchases frmPurchases)
        {
            InitializeComponent();
            this.frmPurchases = frmPurchases;
        }

        #region "Validations"
        private bool ValidateProduct()
        {
            if (cbCode.Text != string.Empty && txtProduct.Text != string.Empty && txtBrand.Text != string.Empty &&
                txtPurchasePrice.Text != string.Empty && txtGain.Text != string.Empty && txtSalePrice.Text != string.Empty && txtQuantity.Text != string.Empty &&
                decimal.TryParse(txtPurchasePrice.Text, out decimal pur) && decimal.TryParse(txtGain.Text, out decimal gain) && decimal.TryParse(txtSalePrice.Text, out decimal sale))
                return true;
            else
                return false;
        }

        private bool ValidatePurchase()
        {
            if (txtBill.Text != string.Empty && txtSaler.Text != string.Empty)
                return true;
            else
                return false;
        }

        private void txtBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(".") && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar("."))
                if (txtPurchasePrice.Text.Contains("."))
                    e.Handled = true;
        }

        private void txtPurchasePrice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(".") && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar("."))
                if (txtPurchasePrice.Text.Contains("."))
                    e.Handled = true;
        }

        private void txtGain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(".") && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar("."))
                if (txtGain.Text.Contains("."))
                    e.Handled = true;
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(".") && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar("."))
                if (txtSalePrice.Text.Contains("."))
                    e.Handled = true;
        }

        private void txtPurchasePrice_Leave_1(object sender, EventArgs e)
        {
            if (txtPurchasePrice.Text != string.Empty && txtGain.Text != string.Empty)
            {
                if (decimal.TryParse(txtPurchasePrice.Text, out decimal purchase) && decimal.TryParse(txtGain.Text, out decimal gain))
                {
                    var operation = new MathOperations();
                    txtSalePrice.Text = operation.CalculateGain(purchase, gain, rbPercentage.Checked).ToString();
                }
            }
        }

        private void txtGain_Leave(object sender, EventArgs e)
        {
            if (txtPurchasePrice.Text != string.Empty && txtGain.Text != string.Empty)
            {
                if (decimal.TryParse(txtPurchasePrice.Text, out decimal purchase) && decimal.TryParse(txtGain.Text, out decimal gain))
                {
                    var operation = new MathOperations();
                    txtSalePrice.Text = operation.CalculateGain(purchase, gain, rbPercentage.Checked).ToString();
                }
            }
        }

        private void rbPercentage_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPurchasePrice.Text != string.Empty && txtGain.Text != string.Empty)
            {
                if (decimal.TryParse(txtPurchasePrice.Text, out decimal purchase) && decimal.TryParse(txtGain.Text, out decimal gain))
                {
                    var operation = new MathOperations();
                    txtSalePrice.Text = operation.CalculateGain(purchase, gain, rbPercentage.Checked).ToString();
                }
            }
        }

        private void cbProvider_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbMeasure_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ConfColumns()
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                dgvData.Columns[0].Visible = false;
                dgvData.Columns[6].Visible = false;
                dgvData.Columns[7].Visible = false;
                dgvData.Columns[8].Visible = false;
                dgvData.Columns[10].Visible = false;
                dgvData.Columns[11].Visible = false;

                dgvData.Columns[1].Width = 80;
                dgvData.Columns[2].Width = 90;
                dgvData.Columns[3].Width = 250;
                dgvData.Columns[4].Width = 100;

                dgvData.Columns[1].HeaderText = "Cantidad";
                dgvData.Columns[2].HeaderText = "Codigo";
                dgvData.Columns[3].HeaderText = "Producto";
                dgvData.Columns[4].HeaderText = "Marca";
                dgvData.Columns[5].HeaderText = "Precio";
                dgvData.Columns[9].HeaderText = "Medida";
            }
        }

        private void ClearProductFields()
        {
            cbCode.Text = string.Empty;
            cbCode.SelectedItem = null;
            txtProduct.Clear();
            txtBrand.Clear();
            cbMeasure.Text = "UNIDAD";
            txtQuantity.Clear();
            txtPurchasePrice.Clear();
            txtGain.Clear();
            txtSalePrice.Clear();
            cbCategory.Text = "N/A";
            cbCode.Focus();
        }
        #endregion

        List<DetailPurchaseAddModel> detailModel = new List<DetailPurchaseAddModel>();
        private void FrmAdd_Load(object sender, EventArgs e)
        {
            GetCategories();
            GetProviders();
            ShowData();
            GetCodeProducts();
        }

        #region "GetData"
        private void GetCodeProducts()
        {
            if (cbProvider.SelectedItem != null)
            {
                if (int.TryParse(cbProvider.SelectedValue.ToString(), out int idProvider))
                {
                    try
                    {
                        var products = new ProductController();
                        cbCode.DataSource = products.GetCodes(idProvider);
                        cbCode.DisplayMember = "Code";
                        cbCode.ValueMember = "Id";

                        cbCode.AutoCompleteSource = AutoCompleteSource.ListItems;
                        cbCode.AutoCompleteMode = AutoCompleteMode.Suggest;

                        cbCode.SelectedItem = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error en el sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se han encontrado proveedores \n Por favor registrar proveedores");
                this.Close();
            }
        }

        private void GetCategories()
        {
            try
            {
                var getCategories = new CategoryController();

                cbCategory.DataSource = getCategories.GetCategories();
                cbCategory.DisplayMember = "Category";
                cbCategory.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en el sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void GetProviders()
        {
            try
            {
                var getProviders = new ProviderController();

                cbProvider.DataSource = getProviders.GetProvidersOnPurchases();
                cbProvider.DisplayMember = "Provider";
                cbProvider.ValueMember = "Id";
                cbProvider.Items.Remove("N/A");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en el sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateProduct())
            {
                var product = new DetailPurchaseAddModel();

                if (cbCode.SelectedValue != null)
                    product.IdProduct = (int)cbCode.SelectedValue;
                else
                    product.IdProduct = 0;

                product.Code = cbCode.Text.Trim();
                product.Product = txtProduct.Text.Trim();
                product.Brand = txtBrand.Text.Trim();
                product.PurchasePrice = decimal.Parse(txtPurchasePrice.Text.Trim());
                product.Gain = decimal.Parse(txtGain.Text.Trim());
                product.TypeGain = rbPercentage.Checked;
                product.SalePrice = decimal.Parse(txtSalePrice.Text.Trim());
                product.Quantity = decimal.Parse(txtQuantity.Text.Trim());
                product.Measure = cbMeasure.Text;
                product.IdProvider = (int)cbProvider.SelectedValue;
                product.IdCategory = (int)cbCategory.SelectedValue;
                product.SubTotal = decimal.Round(product.Quantity * product.PurchasePrice, 2);

                detailModel.Add(product);
                ClearProductFields();
                ShowData();
            }
            else
                MessageBox.Show("Debe llenar todos los campos del producto");
        }

        private void ShowData()
        {
            if (detailModel.Count > 0)
            {
                dgvData.DataSource = null;
                dgvData.DataSource = detailModel;
                lblNoData.Visible = false;
                cbProvider.Enabled = false;
            }
            else
            {
                dgvData.DataSource = null;
                lblNoData.Visible = true;
            }
            lblTotal.Text = "Q " + decimal.Round(detailModel.Select(x => x.SubTotal).Sum(), 2).ToString();
            ConfColumns();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                dgvData.Focus();
                detailModel.RemoveAt(dgvData.CurrentRow.Index);
                ShowData();
                cbCode.Focus();
            }
        }

        private void cbCode_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cbCode.SelectedValue != null)
                {
                    var product = new ProductController();
                    var model = product.GetProduct((int)cbCode.SelectedValue);

                    txtProduct.Text = model.Product;
                    txtBrand.Text = model.Brand;
                    cbMeasure.Text = model.Measure;
                    txtPurchasePrice.Text = model.PurchasePrice.ToString();
                    txtGain.Text = model.Gain.ToString();
                    txtSalePrice.Text = model.SalePrice.ToString();
                    cbCategory.SelectedValue = model.IdCategory;
                    cbProvider.SelectedValue = model.IdProvider;
                    rbPercentage.Checked = model.TypeGain;
                    rbAmount.Checked = !model.TypeGain;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectSaler_Click(object sender, EventArgs e)
        {
            var frmSelect = new ProviderViews.DetailsProviderViews.FrmSelect(this, (int)cbProvider.SelectedValue);
            frmSelect.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidatePurchase())
                if (dgvData.RowCount > 0)
                {
                    var purchase = new PurchaseController();
                    var model = new PurchseAddModel();

                    model.IdDetProvider = int.Parse(txtSaler.Tag.ToString());
                    model.BillNumber = int.Parse(txtBill.Text);
                    model.Total = decimal.Parse(lblTotal.Text.Replace("Q", string.Empty).Trim());
                    model.Date = dtpDate.Value;

                    purchase.Insert(model, this.detailModel);
                    MessageBox.Show("Los datos han sido guardados satisfactoriamente :)", "Guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPurchases.ShowData();
                    this.Close();
                }
                else
                    MessageBox.Show("La lista de compras está vacía");
            else
                MessageBox.Show("Debe llenar los datos de la compra");
        }

        private void cbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCodeProducts();
            txtSaler.Text = string.Empty;
            txtSaler.Tag = null;
        }
    }
}
