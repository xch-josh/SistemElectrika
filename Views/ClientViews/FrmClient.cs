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
using Models.ClientModels;

namespace Views.ClientViews
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        List<ClientViewModel> lst = new List<ClientViewModel>();
        private void FrmClient_Load(object sender, EventArgs e)
        {
            ShowData(true);
        }

        public async void ShowData(bool state)
        {
            try
            {
                var client = new ClientController();
                lst = await client.GetData(state);
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

            var source = search.FilterClient(lst, txtNit.Text.Trim(), txtNames.Text.Trim(), txtLastnames.Text.Trim());

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

                dgvData.Columns[2].Width = 100;
                dgvData.Columns[3].Width = 160;
                dgvData.Columns[4].Width = 160;
                dgvData.Columns[5].Width = 180;
                dgvData.Columns[6].Width = 90;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvData.Columns["ViewAcount"].Index)
            {
                if (dgvData.RowCount > 0)
                {
                    var frmAcount = new FrmAcount((int)dgvData.SelectedCells[1].Value);
                    frmAcount.ShowDialog();
                }
            }
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var font = new Font("Arial", 10);

            if (e.ColumnIndex == 0 && dgvData.Columns[e.ColumnIndex].Name == "ViewAcount" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawString("Ver cuenta", font, Brushes.Black, e.CellBounds.Left + 10, e.CellBounds.Top + 10);

                dgvData.Rows[e.RowIndex].Height = 35;
                dgvData.Columns[e.ColumnIndex].Width = 90;

                e.Handled = true;
            }
        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtNames_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtLastnames_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                try
                {
                    var result = MessageBox.Show("Desea eliminar el cliente seleccionado? \n\n Se borrarán todos los datos relacionados a este", "Eliminar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var client = new ClientController();
                        client.Delete((int)dgvData.SelectedCells[1].Value);
                        if (btnDeactive.Text == "Desactivar") ShowData(true);
                        else ShowData(false);
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
                    var client = new ClientController();

                    if (btnDeactive.Text == "Desactivar")
                    {
                        var result = MessageBox.Show("Desea desactivar el elemento seleccionado?", "Desactivar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            client.Deactive((int)dgvData.SelectedCells[1].Value);
                            ShowData(true);
                        }
                    }
                    else
                    {
                        client.Active((int)dgvData.SelectedCells[1].Value);
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            var frmAdd = new FrmAdd();
            frmAdd.ShowDialog();

            if (frmAdd.DialogResult == DialogResult.OK)
                ShowData(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                var frmEdit = new FrmEdit((int)dgvData.SelectedCells[1].Value);

                frmEdit.ShowDialog();

                if (frmEdit.DialogResult == DialogResult.OK)
                    ShowData(true);
            }
        }

        private void administrarCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
