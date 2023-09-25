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
using Models.ProviderModels.DetailProviderModels;
using Components;

namespace Views.ProviderViews.DetailsProviderViews
{
    public partial class FrmDetail : Form
    {
        int id;
        public FrmDetail(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        List<DetailProviderViewModel> lst = new List<DetailProviderViewModel>();
        private void FrmDetail_Load(object sender, EventArgs e)
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var frmAdd = new FrmAdd(this, this.id);
            frmAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                var frmEdit = new FrmEdit(this, (int)dgvData.SelectedCells[0].Value);
                frmEdit.txtSaler.Text = dgvData.SelectedCells[1].Value.ToString();
                frmEdit.txtPhone.Text = dgvData.SelectedCells[2].Value.ToString();
                frmEdit.txtMail.Text = dgvData.SelectedCells[3].Value.ToString();

                frmEdit.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                try
                {
                    var result = MessageBox.Show("Desea eliminar el elemento seleccionado?", "Eliminar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var detail = new DetailProviderController();
                        detail.Delete((int)dgvData.SelectedCells[0].Value);
                        ShowData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                try
                {
                    var detail = new DetailProviderController();

                    if (btnDeactive.Text == "Desactivar")
                    {
                        var result = MessageBox.Show("Desea desactivar el elemento seleccionado?", "Desactivar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            detail.Deactive((int)dgvData.SelectedCells[0].Value);
                            ShowData();
                        }
                    }
                    else
                    {
                        detail.Active((int)dgvData.SelectedCells[0].Value);
                        ShowData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                if (dgvData.SelectedCells[4].Value.ToString() == "True")
                    btnDeactive.Text = "Desactivar";
                else
                    btnDeactive.Text = "Activar";
            }
        }
    }
}
