using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.ProductViews;
using Controllers;
using Components;
using Models.CartModels;

namespace Views.CartViews
{
    public partial class FrmCart : Form
    {
        List<CartViewModel> lst = new List<CartViewModel>();
        public decimal total, discount, netTotal;

        public FrmCart()
        {
            InitializeComponent();
            ShowData();
        }

        public async void ShowData()
        {
            try
            {
                var cart = new CartController();
                lst = await cart.GetData();

                if (lst.Count > 0)
                {
                    dgvData.DataSource = lst;
                    pbNoData.Visible = false;
                }
                else
                {
                    dgvData.DataSource = null;
                    pbNoData.Visible = true;
                }

                SetValueLabels();

                ConfColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            var frmSelect = new FrmAddToCart(this);
            frmSelect.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Desea limpiar el carrito?", "Limpiar carrito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var cart = new CartController();
                        cart.Clear();
                        ShowData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                var frmAdd = new IbAddOrSubstract((int)dgvData.SelectedCells[0].Value, (int)dgvData.SelectedCells[1].Value, "add");

                frmAdd.ShowDialog();
                if (frmAdd.DialogResult == DialogResult.OK)
                {
                    ShowData();
                }
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                var frmSubstract = new IbAddOrSubstract((int)dgvData.SelectedCells[0].Value, (int)dgvData.SelectedCells[1].Value, "substract");

                frmSubstract.ShowDialog();
                if (frmSubstract.DialogResult == DialogResult.OK)
                {
                    ShowData();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Desea quitar el producto seleccionado?", "Quitar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var cart = new CartController();
                        var model = new CartSubstractOrAddModel();

                        model.Id = (int)dgvData.SelectedCells[0].Value;
                        model.Quantity = (decimal)dgvData.SelectedCells[2].Value;
                        model.IdProduct = (int)dgvData.SelectedCells[1].Value;

                        cart.Remove(model);
                        ShowData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                var frmCashOut = new FrmCashOut(this);
                frmCashOut.total = total;
                frmCashOut.discount = decimal.Parse(lblDiscount.Text.Replace("-Q ", string.Empty).Trim());
                frmCashOut.netTotal = netTotal;
                frmCashOut.itemsCount = dgvData.RowCount;
                frmCashOut.ShowDialog();
            }
        }

        #region DiscountFunctions
        
        #endregion

        #region Validations
        private void ConfColumns()
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                dgvData.Columns[0].Visible = false;
                dgvData.Columns[1].Visible = false;

                dgvData.Columns[2].Width = 80;
                dgvData.Columns[3].Width = 100;
                dgvData.Columns[4].Width = 500;

                dgvData.Columns[8].HeaderText = "Subtotal neto";
                dgvData.Columns[7].HeaderText = "Descuento (c/u)";
            }
        }

        private void FrmCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                btnAddProducts_Click(sender, e);
            else if (e.KeyCode == Keys.F12)
                btnCashOut_Click(sender, e);
            else if (e.KeyCode == Keys.Add)
                btnAdd_Click(sender, e);
            else if (e.KeyCode == Keys.Subtract)
                btnSubtract_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.Q)
                btnRemove_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.L)
                btnClear_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.D)
                AddDiscount_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.F)
                RemoveDiscount_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.G)
                ModifyDiscount_Click(sender, e);
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("+") || e.KeyChar == Convert.ToChar("-"))
                e.Handled = true;
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCode.Text.Trim() != string.Empty)
                {
                    var ibInsert = new IbInsertByCode(txtCode.Text.Trim());
                    ibInsert.ShowDialog();

                    if (ibInsert.DialogResult == DialogResult.OK)
                        ShowData();

                    txtCode.Clear();
                    txtCode.Focus();
                }
            }
        }

        private void AddDiscount_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                decimal.TryParse(dgvData.SelectedCells[7].Value.ToString(), out decimal discount);
                if (discount == 0)
                {
                    var frmAply = new IbAddDiscount((int)dgvData.SelectedCells[0].Value);
                    frmAply.ShowDialog();

                    if (frmAply.DialogResult == DialogResult.OK)
                        ShowData();
                }
                else
                {
                    if (MessageBox.Show("Ya se ha aplicado un descuento\n\nDesea modificarlo?", "Descuentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        ModifyDiscount_Click(sender, e);

                }
            }
        }

        private void RemoveDiscount_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                var match = Regex.Match(dgvData.SelectedCells[7].Value.ToString(), @"\d+");
                if (match.Success)
                    if (Convert.ToDecimal(match.Value) > 0)
                        if (MessageBox.Show("Desea retirar el descuento aplicado a este producto?", "Descuentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            try
                            {
                                var cart = new CartController();

                                cart.RemoveUnitDiscount((int)dgvData.SelectedCells[0].Value);
                                ShowData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
            }
        }

        private void ModifyDiscount_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                var match = Regex.Match(dgvData.SelectedCells[7].Value.ToString(), @"\d+");
                if (match.Success)
                {
                    decimal.TryParse(match.Value, out decimal discount);
                    if (discount > 0)
                    {
                        var frmAply = new IbAddDiscount((int)dgvData.SelectedCells[0].Value);

                        frmAply.lblHeader.Text = "Modificar descuento";
                        frmAply.btnAdd.Text = "Modificar";
                        frmAply.nudQuantity.Value = discount;

                        frmAply.ShowDialog();

                        if (frmAply.DialogResult == DialogResult.OK)
                            ShowData();
                    }
                }
            }
        }

        private void TxtCode_LostFocus(object sender, EventArgs e)
        {
            txtCode.Focus();
        }

        private void SetValueLabels()
        {
            decimal netDiscount = 0;
            total = lst.Select(x => x.SubTotal).Sum();
            discount = total - lst.Select(x => x.SubTotalNeto).Sum();

            if (discount > 0)
                netDiscount = discount;
            else
                netDiscount = 0;

            netTotal = total - netDiscount;

            lblTotal.Text = "Q " + total.ToString("N2");
            lblDiscount.Text = "-Q " + netDiscount.ToString("N2");
            lblNetTotal.Text = "Q " + netTotal.ToString("N2");

            var totalInLetters = new NumbersToLetters();
            lblTotalInLetters.Text = totalInLetters.NumeroALetras(netTotal);
        }
        #endregion
    }
}
