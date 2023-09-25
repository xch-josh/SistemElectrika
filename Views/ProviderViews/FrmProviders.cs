using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ProviderModels;
using Controllers;
using Components;
using System.Windows.Forms;

namespace Views.ProviderViews
{
    public partial class FrmProviders : Form
    {
        public FrmProviders()
        {
            InitializeComponent();
        }

        List<ProviderViewModel> lst = new List<ProviderViewModel>();
        private void FrmProviders_Load(object sender, EventArgs e)
        {
            ShowData(true);
        }

        public async void ShowData(bool state)
        {
            try
            {
                var provider = new ProviderController();
                lst = await provider.GetData(state);
                Search();

                if (state)
                {
                    lnkEnabledDisabled.Text = "Ver inactivos >>";
                    btnDeactive.Text = "Desactivar";
                }
                else
                {
                    lnkEnabledDisabled.Text = "<< Ver activos";
                    btnDeactive.Text = "Activar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search()
        {
            var search = new FiltersOfForms();

            var source = search.FilterProviders(lst, txtSearch.Text.Trim());

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
                dgvData.Columns[1].Visible = false;
                dgvData.Columns[2].Width = 70;
                dgvData.Columns[2].Width = 90;
                dgvData.Columns[3].Width = 160;
                dgvData.Columns[4].Width = 90;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
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
                        var provider = new ProviderController();
                        provider.Delete((int)dgvData.SelectedCells[1].Value);
                        if (btnDeactive.Text == "Desactivar")
                            ShowData(true);
                        else
                            ShowData(false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var frmAdd = new FrmAddProvider();
            frmAdd.ShowDialog();

            if (frmAdd.DialogResult == DialogResult.OK)
            {
                ShowData(true);
            }
        }

        private void FrmProviders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                var frmEdit = new FrmEdit(this, (int)dgvData.SelectedCells[1].Value);
                frmEdit.txtCode.Text = dgvData.SelectedCells[2].Value.ToString();
                frmEdit.txtProvider.Text = dgvData.SelectedCells[3].Value.ToString();
                frmEdit.txtPhone.Text = dgvData.SelectedCells[4].Value.ToString();
                frmEdit.txtMail.Text = dgvData.SelectedCells[5].Value.ToString();

                frmEdit.ShowDialog();
            }
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                try
                {
                    var provider = new ProviderController();

                    if (btnDeactive.Text == "Desactivar")
                    { 
                        var result = MessageBox.Show("Desea desactivar el elemento seleccionado?", "Desactivar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            provider.Deactive((int)dgvData.SelectedCells[1].Value);
                            ShowData(true);
                        }
                    }
                    else
                    {
                        provider.Active((int)dgvData.SelectedCells[1].Value);
                        ShowData(false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
        }

        private void lnkEnabledDisabled_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnkEnabledDisabled.Text == "Ver inactivos >>")
                ShowData(false);
            else
                ShowData(true);
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvData.Columns["Details"].Index)
            {
                if (dgvData.SelectedCells.Count > 0)
                {
                    var frmDetail = new DetailsProviderViews.FrmDetail((int)dgvData.SelectedCells[1].Value);
                    frmDetail.lblHead.Text = $"Detalles de {dgvData.SelectedCells[3].Value.ToString()}";
                    frmDetail.ShowDialog();
                }
            }
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var font = new Font("Arial", 10);

            if (e.ColumnIndex == 0 && dgvData.Columns[e.ColumnIndex].Name == "Details" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawString("Ver detalles", font, Brushes.Black, e.CellBounds.Left + 7, e.CellBounds.Top + 10);

                dgvData.Rows[e.RowIndex].Height = 35;
                dgvData.Columns[e.ColumnIndex].Width = 90;

                e.Handled = true;
            }
        }
    }
}
