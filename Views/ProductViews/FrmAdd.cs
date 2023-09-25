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
using Views.CategoryViews;
using Views.ProviderViews;

namespace Views.ProductViews
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();

            var validate = new ValidateFields();

            txtPurchasePrice.KeyPress += validate.OnlyNumbersField;
            txtSalePrice.KeyPress += validate.OnlyNumbersField;
            txtGain.KeyPress += validate.OnlyNumbersField;
            txtStock.KeyPress += validate.OnlyNumbersField;

            GetCategories();
            GetProviders();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateField())
            {
                try
                {
                    var product = new ProductController();
                    var model = new ProductAddModel();

                    model.Code = txtCode.Text.Trim();
                    model.Product = txtProduct.Text.Trim();
                    model.Brand = txtBrand.Text.Trim();
                    model.IdCategory = (int)cbCategory.SelectedValue;
                    model.PurchasePrice = decimal.Parse(txtPurchasePrice.Text.Trim());
                    model.Gain = decimal.Parse(txtGain.Text.Trim());
                    model.TypeGain = rbPercentage.Checked;
                    model.SalePrice = decimal.Parse(txtSalePrice.Text.Trim());
                    model.Stock = decimal.Parse(txtStock.Text.Trim());
                    model.IdProvider = (int)cbProvider.SelectedValue;
                    model.Measure = cbMeasure.Text;

                    product.Insert(model);
                    MessageBox.Show("Los datos han sido guardados satisfactoriamente :)", "Guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    ClearFields();
                    txtCode.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Por favor llenar todos los campos y verificar que los campos tengan el formato correcto", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region "Validations"
        private void FrmAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCode.Focused == false)
            {
                btnSave_Click(sender, e);
            }
        }

        private void LockedField(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private bool ValidateField()
        {
            if (txtCode.Text != string.Empty && txtProduct.Text != string.Empty && txtBrand.Text != string.Empty &&
                txtPurchasePrice.Text != string.Empty && txtGain.Text != string.Empty && txtSalePrice.Text != string.Empty && txtStock.Text != string.Empty &&
                decimal.TryParse(txtPurchasePrice.Text, out decimal pur) && decimal.TryParse(txtGain.Text, out decimal gain) && decimal.TryParse(txtSalePrice.Text, out decimal sale))
                return true;
            else
                return false;
        }
            
        private void CalculateGain_Leave(object sender, EventArgs e)
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

        private void ClearFields()
        {
            txtCode.Clear();
            txtProduct.Clear();
            txtBrand.Clear();
            txtStock.Clear();
            txtPurchasePrice.Clear();
            txtGain.Clear();
            txtSalePrice.Clear();
            cbMeasure.Text = "UNIDAD";
            cbCategory.Text = "N/A";
            cbProvider.Text = "N/A";
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var frmAddCategory = new FrmAddCategory();
            frmAddCategory.ShowDialog();

            if (frmAddCategory.DialogResult == DialogResult.OK)
                GetCategories();
        }

        private void btnEditCode_Click(object sender, EventArgs e)
        {
            txtCode.Enabled = true;
        }

        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            var frmAdd = new FrmAddProvider();
            frmAdd.ShowDialog();

            if (frmAdd.DialogResult == DialogResult.OK)
                GetProviders();
        }

        #endregion

        #region "GetData"
        private void GetCategories()
        {
            try
            {
                var getCategories = new CategoryController();

                cbCategory.DataSource = getCategories.GetCategories();
                cbCategory.DisplayMember = "Category";
                cbCategory.ValueMember = "Id";
                cbCategory.Text = "N/A";
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

                cbProvider.DataSource = getProviders.GetProviders();
                cbProvider.DisplayMember = "Provider";
                cbProvider.ValueMember = "Id";
                cbProvider.Text = "N/A";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en el sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

    }
}
