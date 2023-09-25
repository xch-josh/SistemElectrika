using Controllers;
using Components;
using Models.ClientModels;
using Models.CreditModels;
using Models.SaleModels;
using Views.CreditViews;
using Views.SaleViews.SaleDetailViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.ClientViews
{
    public partial class FrmAcount : Form
    {
        int idClient;
        List<CreditViewModel> lstCredit = new List<CreditViewModel>();
        List<GetByClientModel> lstSales = new List<GetByClientModel>();
        public FrmAcount(int idClient)
        {
            InitializeComponent();
            this.idClient = idClient;
        }

        private void FrmAcount_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public async void ShowData()
        {
            try
            {
                var credit = new CreditController();
                var getCredit = await credit.GetData(this.idClient);
                var sales = new SaleController();
                var getSale = await sales.GetByClient(this.idClient);
                var getClientData = new ClientController();
                var client = getClientData.GetClient(idClient);

                lstCredit = getCredit;
                lstSales = getSale;

                lblClient.Text = client.Names + " " + client.Lastnames;
                lblNit.Text = "Nit: " + client.Nit;
                lblDirection.Text = "Dirección: " + client.Direction;

                if (lstCredit.Count > 0)
                {
                    dgvCredits.DataSource = lstCredit;
                    lblNoCredits.Visible = false;
                }
                else
                {
                    dgvCredits.DataSource = null;
                    lblNoCredits.Visible = true;
                }
                Search();

                lblTotalCredit.Text = "Q " + decimal.Round(lstCredit.Select(x => x.Saldo).Sum(), 2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search()
        {
            var search = new FiltersOfForms();

            var source = search.FilterSales(lstSales, txtSearch.Text.Trim());

            if (source.Count > 0)
            {
                dgvSales.DataSource = source;
                lblNoSales.Visible = false;
            }
            else
            {
                dgvSales.DataSource = null;
                lblNoSales.Visible = true;
            }
        }

        private void dgvCredits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCredits.Columns["Payments"].Index)
            {
                if (dgvCredits.SelectedCells.Count > 0)
                {
                    var frmPay = new FrmPayments(this, (int)dgvCredits.SelectedCells[1].Value, (decimal)dgvCredits.SelectedCells[3].Value, (int)dgvCredits.SelectedCells[2].Value);
                    frmPay.ShowDialog();
                }
            }
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSales.Columns["DetSales"].Index)
            {
                if (dgvSales.SelectedCells.Count > 0)
                {
                    if (e.ColumnIndex == dgvSales.Columns["DetSales"].Index)
                    {
                        if (dgvSales.SelectedCells.Count > 0)
                        {
                            int id = (int)dgvSales.SelectedCells[1].Value;
                            var detail = new FrmSaleDetail(this, id);
                            detail.lblHead.Text = "Detalles de la venta " + id.ToString();
                            detail.lblClient.Text = "Cliente: " + lblClient.Text;
                            detail.lblDate.Text = "Fecha: " + Convert.ToDateTime(dgvSales.SelectedCells[5].Value).ToShortDateString();
                            detail.ShowDialog();
                        }
                    }
                }
            }
        }

        private void dgvCredits_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var font = new Font("Arial", 10);

            if (e.ColumnIndex == 0 && dgvCredits.Columns[e.ColumnIndex].Name == "Payments" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawString("Ver abonos", font, Brushes.Black, e.CellBounds.Left + 7, e.CellBounds.Top + 10);

                dgvCredits.Rows[e.RowIndex].Height = 35;
                dgvCredits.Columns[e.ColumnIndex].Width = 90;

                e.Handled = true;
            }
        }

        private void dgvSales_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var font = new Font("Arial", 10);

            if (e.ColumnIndex == 0 && dgvSales.Columns[e.ColumnIndex].Name == "DetSales" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawString("Ver detalles", font, Brushes.Black, e.CellBounds.Left + 7, e.CellBounds.Top + 10);

                dgvSales.Rows[e.RowIndex].Height = 35;
                dgvSales.Columns[e.ColumnIndex].Width = 90;

                e.Handled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
