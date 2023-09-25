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
using Models.PurchasesModels;

namespace Views.PurchasesViews
{
    public partial class FrmPurchases : Form
    {
        public FrmPurchases()
        {
            InitializeComponent();
        }

        List<PurchaseViewModel> lst = new List<PurchaseViewModel>();
        private void FrmPurchases_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public async void ShowData()
        {
            try
            {
                var sale = new PurchaseController();
                lst = await sale.GetData();
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

            var source = search.FilterPurchases(lst, txtSearch.Text.Trim(), txtSearchProvider.Text.Trim(), chbEnableSearchByDate.Checked,
                dtpDate.Value, rbDay.Checked);

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
                dgvData.Columns[1].Visible = false;

                dgvData.Columns[2].Width = 180;
                dgvData.Columns[3].Width = 100;
                dgvData.Columns[4].Width = 90;
                dgvData.Columns[5].Width = 250;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        private void dtpDateSale_ValueChanged(object sender, EventArgs e)
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearchProvider_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                try
                {
                    var result = MessageBox.Show("Desea eliminar el elemento seleccionado? \n\n Se borrarán todos los datos relacionados a este \n Eliminar este registro no afectrá al inventario de productos", "Eliminar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var purchase = new PurchaseController();
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            var frmAdd = new FrmAdd(this);
            frmAdd.ShowDialog();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvData.Columns["Details"].Index)
            {
                if (dgvData.SelectedCells.Count > 0)
                {
                    var detail = new DetailPurchaseViews.FrmDetail(this, (int)dgvData.SelectedCells[1].Value);

                    detail.txtProvider.Text = dgvData.SelectedCells[2].Value.ToString();
                    detail.txtBill.Text = dgvData.SelectedCells[3].Value.ToString();
                    detail.txtSaler.Text = dgvData.SelectedCells[5].Value.ToString();
                    detail.dtpDate.Value = Convert.ToDateTime(dgvData.SelectedCells[6].Value);

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
    }
}
