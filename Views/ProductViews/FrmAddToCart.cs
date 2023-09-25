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
using Models.CategoryModels;
using Models.ProviderModels;
using Models.CartModels;
using Views.CartViews;

namespace Views.ProductViews
{
    public partial class FrmAddToCart : Form
    {
        FrmCart frmCart;
        List<ProductViewModel> lst = new List<ProductViewModel>();

        public FrmAddToCart(FrmCart frmCart)
        {
            InitializeComponent();
            this.frmCart = frmCart;
        }

        private void FrmSelectProduct_Load(object sender, EventArgs e)
        {
            GetCategories();
            GetProviders();
            ShowData();
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

        private void Field_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void NumberField_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            var math = new MathOperations();
            decimal priceWithDiscount = nudPrice.Value - math.CalculateDiscount(nudPrice.Value, nudDiscount.Value, rbPercentage.Checked);
            decimal subtotal = priceWithDiscount * nudQuantity.Value;
            lblTotal.Text = "Q " + subtotal.ToString("N2");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nudQuantity.Value > 0)
            {
                try
                {
                    var cart = new CartController();
                    var model = new CartInsertModel();

                    model.idProduct = (int)dgvData.SelectedCells[0].Value;
                    model.Quantity = nudQuantity.Value;
                    model.Price = decimal.Parse(nudPrice.Text);
                    model.Discount = nudDiscount.Value;
                    model.TypeDiscount = rbPercentage.Checked ? "%" : "Q";

                    cart.Insert(model);
                    ShowData();
                    frmCart.ShowData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("La cantidad no puede ser 0");
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                txtProduct.Text = dgvData.SelectedCells[2].Value.ToString();
                nudPrice.Value = (decimal)dgvData.SelectedCells[5].Value;
                CalculateTotal();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var frmAdd = new FrmAdd();
            frmAdd.ShowDialog();

            if (frmAdd.DialogResult == DialogResult.OK)
            {
                ShowData();
                GetCategories();
                GetProviders();
            }

            txtCodeProduct.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var frmEdit = new FrmEdit((int)dgvData.SelectedCells[0].Value);
            frmEdit.ShowDialog();

            if (frmEdit.DialogResult == DialogResult.OK)
            {
                ShowData();
                GetCategories();
                GetProviders();
            }

            txtCodeProduct.Focus();
        }

        private void FrmAddToCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
                nudQuantity.Value += 1;
            else if (e.KeyCode == Keys.Subtract)
                if (nudQuantity.Value > 0)
                    nudQuantity.Value -= 1;
        }

        private void txtCodeProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("+"))
                e.Handled = true;
            else if (e.KeyChar == Convert.ToChar("-"))
                e.Handled = true;
        }
    }
}
