using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.CartViews;
using Views.ProductViews;
using Views.SaleViews;
using Views.ClientViews;
using Views.ProviderViews;
using Views.PurchasesViews;
using Views.QuotationViews;
using Views.ShipmentsViews;

namespace Views
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void CloseAllForms()
        {
            List<Form> forms = new List<Form>();
            foreach (Form frm in Application.OpenForms)
            {
                forms.Add(frm);
            }

            forms.ForEach(x =>
            {
                if (x.Name != "FrmPrincipal")
                {
                    x.Close();
                }
            });
        }

        private void ShowForm(Form form)
        {
            CloseAllForms();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == form.Name)
                {
                    frm.BringToFront();
                    return;
                }
            }

            form.TopLevel = false;
            plContainer.Controls.Add(form);
            plContainer.Tag = form;
            form.Show();
            form.BringToFront();
        }

        private void ActiveButton(Button btn)
        {
            foreach(Control item in plHeader.Controls)
                if (item is Button)
                {
                    if (item == btn)
                        item.BackColor = Color.FromArgb(220, 220, 220);
                    else
                        item.BackColor = Color.WhiteSmoke;
                }
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmCart());
            ActiveButton(btnNewSale);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmProducts());
            ActiveButton(btnProducts);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmSales());
            ActiveButton(btnSales);
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmPurchases());
            ActiveButton(btnPurchases);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmClient());
            ActiveButton(btnClients);
        }

        private void btnProviders_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmProviders());
            ActiveButton(btnProviders);
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmQuotations());
            ActiveButton(btnDocuments);
        }

        private void btnShipment_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmShipments());
            ActiveButton(btnShipment);
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea cerrar el sistema?\n\nSus datos no se perderán", "Cerrar sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
