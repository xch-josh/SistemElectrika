using Controllers;
using Components;
using Models.DocumentsModels;
using Models.QuotationModels.DetailQuotationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.QuotationViews.DetailQuotationViews
{
    public partial class FrmDetail : Form
    {
        FrmQuotations frmQuotations;
        int id;
        public FrmDetail(FrmQuotations frmQuotations, int id)
        {
            InitializeComponent();
            this.frmQuotations = frmQuotations;
            this.id = id;
        }

        List<DetailQuotationViewModel> lst = new List<DetailQuotationViewModel>();
        private void FrmDetail_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public async void ShowData()
        {
            try
            {
                var detail = new DetailQuotationController();
                lst = await detail.GetData(id);

                if (lst.Count > 0)
                {
                    dgvData.DataSource = lst;
                    lblNoData.Visible = false;
                }
                else
                {
                    dgvData.DataSource = null;
                    lblNoData.Visible = true;
                }

                lblTotal.Text = "Q " + decimal.Round(lst.Select(x => x.SubTotalNeto).Sum(), 2).ToString();

                ConfColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ConfColumns()
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                dgvData.Columns[0].Visible = false;

                dgvData.Columns[1].Width = 100;
                dgvData.Columns[2].Width = 270;
            }
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
                        var detail = new DetailQuotationController();
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

        private void lblState_TextChanged(object sender, EventArgs e)
        {
            if (lblState.Text == "Activo")
                lblState.ForeColor = Color.Green;
            else
                lblState.ForeColor = Color.Red;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var quotationParameter = new RptQuotationParameterModel();
            var inLetters = new NumbersToLetters();
            quotationParameter.IdQuotation = id;
            var document = new DocumentViews.FrmShowDocument(quotationParameter, inLetters.NumeroALetras(decimal.Parse(lblTotal.Text.Replace("Q", string.Empty).Trim())));
            document.Show();
            document.BringToFront();
        }
    }
}
