using Controllers;
using Components;
using Models.ProviderModels.DetailProviderModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.ProviderViews.DetailsProviderViews
{
    public partial class FrmSelect : Form
    {
        PurchasesViews.FrmAdd frmAdd;
        int id;
        public FrmSelect(PurchasesViews.FrmAdd frmAdd, int id)
        {
            InitializeComponent();
            this.frmAdd = frmAdd;
            this.id = id;
        }

        List<DetailProviderViewModel> lst = new List<DetailProviderViewModel>();
        private void FrmSelect_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public async void ShowData()
        {
            try
            {
                var detail = new DetailProviderController();
                lst = await detail.GetData(id);
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

            var source = search.FilterDetailProvider(lst, txtSearch.Text.Trim());

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
            if (dgvData.SelectedCells.Count > 0 && dgvData.Columns[1].Visible)
            {
                dgvData.Columns[0].Visible = false;
                dgvData.Columns[1].Width = 180;
                dgvData.Columns[2].Width = 90;
                dgvData.Columns[3].Width = 180;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.SelectedCells[4].Value.ToString() == "True")
            {
                frmAdd.txtSaler.Tag = dgvData.SelectedCells[0].Value.ToString();
                frmAdd.txtSaler.Text = dgvData.SelectedCells[1].Value.ToString();
                this.Close();
            }
            else
                MessageBox.Show("El vendedor está inactivo");
        }

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value.ToString() == "True")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.SelectionForeColor = Color.Green;
                    e.Value = "Activo";
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.SelectionForeColor = Color.Red;
                    e.Value = "Inactivo";
                }
            }
        }
    }
}
