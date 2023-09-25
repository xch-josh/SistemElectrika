using Controllers;
using Components;
using Models.DocumentsModels;
using Models.SaleModels.SaleDetailModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.ShipmentsViews.ShipmentDetail
{
    public partial class FrmDetail : Form
    {
        int id;
        public FrmDetail(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        List<SaleDetailViewModel> lst = new List<SaleDetailViewModel>();
        private void FrmDetail_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public void ShowData()
        {
            try
            {
                var detail = new SaleDetailController();
                lst = detail.GetData(id);

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
                dgvData.Columns[1].Width = 90;
                dgvData.Columns[2].Width = 90;
                dgvData.Columns[3].Width = 250;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var parameter = new RptShipmentParameterModel();
            var inLetters = new NumbersToLetters();
            decimal total = decimal.Round(lst.Select(x => x.SubTotalNeto).Sum(), 2);
            parameter.Id = id;
            var document = new DocumentViews.FrmShowDocument(parameter, inLetters.NumeroALetras(total));
            document.Show();
            document.BringToFront();
        }
    }
}
