using Controllers;
using Components; 
using Models.CategoryModels;
using Models.DocumentsModels;
using Models.ProductModels;
using Models.ProviderModels;
using Views.DocumentViews;
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
    public partial class FrmLowStock : Form
    {
        public FrmLowStock()
        {
            InitializeComponent();
        }

        List<ProductLowStockViewModel> lst = new List<ProductLowStockViewModel>();
        private void FrmLowStock_Load(object sender, EventArgs e)
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
                lst = await product.GetLowStock();
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
            if (dgvData.SelectedCells.Count > 0)
            {
                dgvData.Columns[0].Width = 100;
                dgvData.Columns[1].Width = 250;
                dgvData.Columns[2].Width = 120;
                dgvData.Columns[3].Width = 100;
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                var model = new RptLowStockFiltersModel();
                model.ProductOrCode = txtCodeProduct.Text.Trim();
                model.Brand = txtBrand.Text.Trim();
                model.Category = cbCategory.Text.Trim();
                model.Provider = cbProvider.Text.Trim();

                var frmDocument = new FrmShowDocument(model);
                frmDocument.Show();
            }
        }
    }
}
