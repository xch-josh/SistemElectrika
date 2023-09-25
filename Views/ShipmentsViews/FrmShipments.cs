using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.ShipmentModels;
using Components;
using Models.DocumentsModels;

namespace Views.ShipmentsViews
{
    public partial class FrmShipments : Form
    {
        public FrmShipments()
        {
            InitializeComponent();
        }

        List<ShipmentViewModel> lst = new List<ShipmentViewModel>();
        private void FrmShipments_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public void ShowData()
        {
            try
            {
                var shipment = new ShipmentController();
                lst = shipment.GetData();
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

            var source = search.FilterShipments(lst, txtSearch.Text.Trim(), txtIdSale.Text.Trim(), txtSearchClient.Text.Trim(), chbEnableSearchByDate.Checked,
                dtpDate.Value, rbDay.Checked, rbCreation.Checked);

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
                dgvData.Columns[1].Width = 70;
                dgvData.Columns[2].Width = 70;
                dgvData.Columns[3].Width = 200;
                dgvData.Columns[4].Width = 200;
                dgvData.Columns[5].Width = 60;
                dgvData.Columns[6].Width = 150;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        private void txtIdSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void chbEnableSearchByDate_CheckedChanged(object sender, EventArgs e)
        {
            Search();
            if (chbEnableSearchByDate.Checked)
            {
                dtpDate.Enabled = true;
                rbDay.Enabled = true;
                rbMonth.Enabled = true;
                
            }
            else
            {
                dtpDate.Enabled = false;
                rbDay.Enabled = false;
                rbMonth.Enabled = false;
            }
        }

        private void rbDay_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtIdSale_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                try
                {
                    var result = MessageBox.Show("Desea eliminar el elemento seleccionado? \n Eliminar este registro no afectrá al inventario de productos", "Eliminar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var purchase = new ShipmentController();
                        purchase.Delete((int)dgvData.SelectedCells[1].Value);
                        ShowData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvData.Columns["Details"].Index)
            {
                if (dgvData.SelectedCells.Count > 0)
                {
                    var detail = new ShipmentDetail.FrmDetail((int)dgvData.SelectedCells[2].Value);
                    detail.lblClient.Text = "Cliente: " + dgvData.SelectedCells[3].Value.ToString();
                    detail.lblDateDelivery.Text = "Fehca de entrega: " + dgvData.SelectedCells[7].Value.ToString();
                    detail.ShowDialog();
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

        private void rbCreation_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
