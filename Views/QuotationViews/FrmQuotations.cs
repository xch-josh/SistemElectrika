using Controllers;
using Components;
using Models.QuotationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.QuotationViews
{
    public partial class FrmQuotations : Form
    {
        public FrmQuotations()
        {
            InitializeComponent();
        }

        List<QuotationViewModel> lst = new List<QuotationViewModel>();
        private void FrmQuotations_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public void ShowData()
        {
            try
            {
                var quotation = new QuotationController();
                quotation.Expire();
                lst = quotation.GetData();
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

            var source = search.FilterQuotations(lst, txtSearch.Text.Trim(), chbEnableSearchByDate.Checked,
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

                dgvData.Columns[2].Width = 210;
            }
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
                    var result = MessageBox.Show("Desea eliminar el elemento seleccionado? \n Eliminar este registro no afectrá al inventario de productos", "Eliminar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var purchase = new QuotationController();
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
            var frmAdd = new FrmAdd();
            frmAdd.ShowDialog();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvData.Columns["Details"].Index)
            {
                if (dgvData.SelectedCells.Count > 0)
                {
                    Func<string> state = () =>
                    {
                        if (dgvData.SelectedCells[8].Value.ToString() == "True")
                            return "Activo";
                        else
                            return "Caducado";
                    };

                    var frmDetail = new DetailQuotationViews.FrmDetail(this, (int)dgvData.SelectedCells[1].Value);
                    frmDetail.txtClient.Text = dgvData.SelectedCells[2].Value.ToString();
                    frmDetail.lblState.Text = state();
                    frmDetail.ShowDialog();
                }
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
                    e.Value = "Caducado";
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
