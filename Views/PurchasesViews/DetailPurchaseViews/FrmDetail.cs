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
using Models.PurchasesModels;
using Models.PurchasesModels.DetailPurchaseModel;

namespace Views.PurchasesViews.DetailPurchaseViews
{
    public partial class FrmDetail : Form
    {
        FrmPurchases frmPurchases;
        int id, idDetail;
        public FrmDetail(FrmPurchases frmPurchases, int id)
        {
            InitializeComponent();
            this.frmPurchases = frmPurchases;
            this.id = id;
        }

        List<DetailPurchaseViewModel> lst = new List<DetailPurchaseViewModel>();
        private void FrmDetail_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public async void ShowData()
        {
            try
            {
                var detail = new DetailPurchaseController();
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

                lblTotal.Text = "Q " + decimal.Round(lst.Select(x => x.SubTotal).Sum(), 2).ToString();

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

                dgvData.Columns[1].Width = 180;
                dgvData.Columns[2].Width = 270;
                dgvData.Columns[3].Width = 90;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(".") && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
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
                        var detail = new DetailPurchaseController();
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

        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(".") && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity.Text != string.Empty && txtPurchasePrice.Text != string.Empty)
                {
                    var purchase = new PurchaseController();
                    var model = new PurchaseEditModel();
                    var detailModel = new DetailPurchaseEditModel();

                    model.Id = this.id;
                    model.Bill = int.Parse(txtBill.Text);
                    detailModel.Id = this.idDetail;
                    detailModel.Quantity = decimal.Parse(txtQuantity.Text);
                    detailModel.PurchasePrice = decimal.Parse(txtPurchasePrice.Text);

                    purchase.Edit(model, detailModel);
                    MessageBox.Show("Los datos han sido editados satisfactoriamente :) \n Esta accion no afecta el inventario ni los datos del producto, solamente la compra", "Guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                    gbNew_Edit.Enabled = false;
                    gbProduct.Enabled = false;
                    dgvData_SelectionChanged(sender, e);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbNew_Edit.Enabled = false;
            gbProduct.Enabled = false;
            dgvData_SelectionChanged(sender, e);
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                if (!gbProduct.Enabled)
                {
                    txtQuantity.Text = dgvData.SelectedCells[1].Value.ToString();
                    txtProduct.Text = dgvData.SelectedCells[2].Value.ToString();
                    txtPurchasePrice.Text = dgvData.SelectedCells[3].Value.ToString();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gbNew_Edit.Enabled = true;
            gbProduct.Enabled = true;
            idDetail = (int)dgvData.SelectedCells[0].Value;
        }

    }
}
