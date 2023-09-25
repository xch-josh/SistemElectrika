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
using Models.DocumentsModels;
using Models.SaleModels;

namespace Views.SaleViews
{
    public partial class FrmSales : Form
    {
        public FrmSales()
        {
            InitializeComponent();
        }

        List<SaleViewModel> lst = new List<SaleViewModel>();
        private void FrmSales_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public async void ShowData()
        {
            try
            {
                var sale = new SaleController();
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

            var source = search.FilterSales(lst, txtSearch.Text.Trim(), txtSearchClient.Text.Trim(), chbEnableSearchByDate.Checked,
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

            if (chbEnableSearchByDate.Checked)
                lblTotal.Text = "Q " + decimal.Round(source.Select(x => x.TotalNeto).Sum(), 2).ToString();
            else
                lblTotal.Text = "No disponible";

            ConfColumns();
        }

        private void ConfColumns()
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                dgvData.Columns[1].Width = 70;
                dgvData.Columns[2].Width = 200;
                dgvData.Columns[3].Width = 100;
                dgvData.Columns[4].Width = 90;
                dgvData.Columns[5].Width = 90;
                dgvData.Columns[6].Width = 90;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            Search();
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
            if (rbDay.Checked)
                lblTitleSum.Text = "Total del día:";
            else
                lblTitleSum.Text = "Total del mes:";
            Search();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Se devolverán todas los productos de esta venta al inventario \n\n Desea continuar?",
                "Devolver venta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var sale = new SaleController();
                    sale.Devolution((int)dgvData.SelectedCells[1].Value);
                    ShowData();
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
                    int id = (int)dgvData.SelectedCells[1].Value;
                    var detail = new SaleDetailViews.FrmSaleDetail(this, id);
                    detail.lblHead.Text = "Detalles de la venta " + id.ToString();
                    detail.lblClient.Text = "Cliente: " + dgvData.SelectedCells[2].Value.ToString();
                    detail.lblDate.Text = "Fecha: " + Convert.ToDateTime(dgvData.SelectedCells[7].Value).ToShortDateString();
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
