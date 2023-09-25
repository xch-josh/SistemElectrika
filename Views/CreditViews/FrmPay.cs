using Controllers;
using Models.CreditModels.CreditPaymentModels;
using Views.ClientViews;
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
    public partial class FrmPay : Form
    {
        FrmPayments frmPayments;
        FrmAcount frmAcount;
        int id;
        decimal credit, balance;
        public FrmPay(FrmPayments frmPayments, FrmAcount frmAcount, int id, decimal credit, decimal balance)
        {
            InitializeComponent();
            this.id = id;
            this.frmAcount = frmAcount;
            this.credit = credit;
            this.balance = balance;
            this.frmPayments = frmPayments;
        }

        private void FrmPayments_Load(object sender, EventArgs e)
        {
            lblBalance.Text = balance.ToString();
            lblCredit.Text = credit.ToString();
            lblChange.Text = "Q 0.00";
        }

        private void txtPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(".") && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar("."))
                if (txtPay.Text.Contains("."))
                    e.Handled = true;
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(".") && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar("."))
                if (txtCash.Text.Contains("."))
                    e.Handled = true;
        }

        private void txtPay_Leave(object sender, EventArgs e)
        {
            if (txtPay.Text != string.Empty)
                if (decimal.TryParse(txtPay.Text, out decimal pay))
                    if (pay > balance)
                    {
                        MessageBox.Show("El abono no puede ser mayor al saldo de la cuenta");
                        txtPay.Clear();
                        txtPay.Focus();
                    }

            if (txtPay.Text != string.Empty && txtCash.Text != string.Empty)
                if (decimal.TryParse(txtPay.Text, out decimal pay) && decimal.TryParse(txtCash.Text, out decimal cash))
                    lblChange.Text = "Q " + (cash - pay).ToString();
                else
                {
                    MessageBox.Show("Por favor revise que el formato numerico de los campos sean correctos");
                    txtPay.Clear();
                    txtPay.Focus();
                }
        }

        private void txtCash_Leave(object sender, EventArgs e)
        {
            if (txtPay.Text != string.Empty && txtCash.Text != string.Empty)
                if (decimal.TryParse(txtPay.Text, out decimal pay) && decimal.TryParse(txtCash.Text, out decimal cash))
                    lblChange.Text = "Q " + (cash - pay).ToString();
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            try
            {
                var payment = new PaymentController();
                var model = new PaymentAddModel();

                model.idCredit = id;
                model.amount = decimal.Parse(txtPay.Text.Trim());
                model.date = DateTime.Today;

                payment.Insert(model);
                frmAcount.ShowData();
                frmPayments.ShowData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPayAll_Click(object sender, EventArgs e)
        {
            txtPay.Text = balance.ToString();
        }
    }
}
