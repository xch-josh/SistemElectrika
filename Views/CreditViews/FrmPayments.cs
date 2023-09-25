using Controllers;
using Models.CreditModels.CreditPaymentModels;
using Models.DocumentsModels;
using Views.ClientViews;
using Views.DocumentViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.CreditViews
{
    public partial class FrmPayments : Form
    {
        FrmAcount frmAcount;
        int id, idSale;
        List<PaymentViewModel> lst = new List<PaymentViewModel>();
        decimal credit, balance, totalPays;
        public FrmPayments(FrmAcount frmAcount, int id, decimal credit, int idSale)
        {
            InitializeComponent();
            this.frmAcount = frmAcount;
            this.id = id;
            this.credit = credit;
            this.idSale = idSale;
        }

        private void FrmPayments_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public async void ShowData()
        {
            try
            {
                var payment = new PaymentController();
                lst = await payment.GetData(id);

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

                totalPays = decimal.Round(lst.Select(x => x.Monto).Sum(), 2);
                balance = credit - totalPays;
                setTextLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setTextLabels()
        {
            lblCredit.Text = "Q " + credit.ToString();
            lblBalance.Text = "Q " + balance.ToString();
            lblPays.Text = "Q " + totalPays.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var model = new RptCreditParametersModel();
            model.id = this.idSale;
            var document = new FrmShowDocument(model);
            document.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea anular el pago seleccionado?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var payment = new PaymentController();

                    payment.Cancel((int)dgvData.SelectedCells[0].Value);
                    ShowData();
                    frmAcount.ShowData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (balance > 0)
            {
                var frmPay = new FrmPay(this, frmAcount, id, credit, balance);
                frmPay.ShowDialog();
            }
        }
    }
}
