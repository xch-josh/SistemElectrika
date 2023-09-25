using Controllers;
using Components;
using Models.CategoryModels;
using Models.ProductModels;
using Models.ProviderModels;
using Models.QuotationModels.DetailQuotationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.ProductViews
{
    public partial class FrmAddToQuotation : Form
    {
        QuotationViews.FrmAdd frmAdd;
        public FrmAddToQuotation(QuotationViews.FrmAdd frmAdd)
        {
            InitializeComponent();
            this.frmAdd = frmAdd;
        }

        #region "Validations"
        private void ConfColumns()
        {
            if (dgvData.SelectedCells.Count > 0 && dgvData.Columns[0].Visible)
            {
                dgvData.Columns[0].Visible = false;
                dgvData.Columns[4].Visible = false;
                dgvData.Columns[7].Visible = false;

                dgvData.Columns[1].Width = 100;
                dgvData.Columns[2].Width = 250;
                dgvData.Columns[3].Width = 100;
                dgvData.Columns[5].Width = 100;

                dgvData.Columns[5].HeaderText = "Precio";
                dgvData.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void CalculateTotal()
        {
            if (decimal.TryParse(txtPrice.Text, out decimal price))
            {
                lblTotal.Text = "Q " + decimal.Round(price * nudQuantity.Value, 2).ToString();
            }
        }

        private void txtCodeProduct_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(".") && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar("."))
                if (txtPrice.Text.Contains("."))
                    e.Handled = true;
        }
        #endregion

        List<ProductViewModel> lst = new List<ProductViewModel>();
        private void FrmAddToQuotation_Load(object sender, EventArgs e)
        {
            GetCategories();
            GetProviders();
            ShowData();
            this.BringToFront();
        }

        public async void ShowData()
        {
            try
            {
                var product = new ProductController();
                lst = await product.GetData();
                Search();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search()
        {
            var search = new FiltersOfForms();

            var source = search.FilterProduct(lst, txtCodeProduct.Text.Trim(), txtBrand.Text.Trim(), cbProvider.Text.Trim(), cbCategory.Text.Trim());

            if (source.Count > 0)
            {
                dgvData.DataSource = source;
                lblNoData.Visible = false;
            }
            else
            {
                dgvData.DataSource = null;
                lblNoData.Visible = true;
            }
            ConfColumns();
        }

        

        private void GetProviders()
        {
            var providers = new ProviderController();
            var oProvider = new List<ProviderGetModel>();

            oProvider = providers.GetProviders();
            var all = new ProviderGetModel();
            all.Id = 0;
            all.Provider = "Todos";

            oProvider.Add(all);

            cbProvider.DataSource = oProvider;
            cbProvider.DisplayMember = "Provider";
            cbProvider.Text = "Todos";
        }

        private void GetCategories()
        {
            var categories = new CategoryController();
            var oCategories = new List<GetCategoriesModel>();

            oCategories = categories.GetCategories();
            var all = new GetCategoriesModel();
            all.Id = 0;
            all.Category = "Todas";

            oCategories.Add(all);

            cbCategory.DataSource = oCategories;
            cbCategory.DisplayMember = "Category";
            cbCategory.Text = "Todas";
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var getProduct = frmAdd.lst.Where(x => x.IdProduct == (int)dgvData.SelectedCells[0].Value).FirstOrDefault();

            if (getProduct != null)
            {
                getProduct.Cantidad += nudQuantity.Value;
                getProduct.SubTotal = getProduct.Cantidad * getProduct.Precio;
                getProduct.SubTotalNeto = getProduct.SubTotal - getProduct.Descuento;
            }
            else
            {
                var model = new DetailQuotationAddModel();

                model.Cantidad = nudQuantity.Value;
                model.IdProduct = (int)dgvData.SelectedCells[0].Value;
                model.Codigo = dgvData.SelectedCells[1].Value.ToString();
                model.Producto = dgvData.SelectedCells[2].Value.ToString();
                model.Precio = decimal.Parse(txtPrice.Text);
                model.SubTotal = model.Cantidad * model.Precio;
                model.Descuento = 0;
                model.SubTotalNeto = model.SubTotal;

                frmAdd.lst.Add(model);
            }
            frmAdd.ShowData();
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                txtProduct.Text = dgvData.SelectedCells[2].Value.ToString();
                txtPrice.Text = dgvData.SelectedCells[5].Value.ToString();
                CalculateTotal();
                txtCodeProduct.Focus();
            }
        }
    }
}
