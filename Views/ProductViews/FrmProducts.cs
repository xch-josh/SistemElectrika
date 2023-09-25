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
using Models.CategoryModels;
using Models.ProductModels;
using Models.ProviderModels;

namespace Views.ProductViews
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        List<ProductViewModel> lst = new List<ProductViewModel>();
        private void FrmProducts_Load(object sender, EventArgs e)
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

                dgvData.Columns[1].Width = 100;
                dgvData.Columns[2].Width = 250;
                dgvData.Columns[3].Width = 100;
                dgvData.Columns[5].Width = 100;
                dgvData.Columns[6].Width = 100;

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

        public void GetCategories()
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                try
                {
                    var result = MessageBox.Show("Desea eliminar el elemento seleccionado? \n\n Se borrarán todos los datos relacionados a este", "Eliminar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var product = new ProductController();
                        product.Delete((int)dgvData.SelectedCells[0].Value);
                        ShowData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void administrarCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var categories = new CategoryViews.FrmCategories();
            categories.ShowDialog();

            if (categories.DialogResult == DialogResult.OK)
                GetCategories();
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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                var frmEdit = new FrmEdit((int)dgvData.SelectedCells[0].Value);
                frmEdit.ShowDialog();

                if (frmEdit.DialogResult == DialogResult.OK)
                {
                    ShowData();
                    GetCategories();
                    GetProviders();
                }
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

        private void imprimírInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmShowDocument = new DocumentViews.FrmShowDocument();
            frmShowDocument.Show();
        }

        private void verExistenciasBajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLowStock = new FrmLowStock();
            frmLowStock.ShowDialog();
        }
    }
}
