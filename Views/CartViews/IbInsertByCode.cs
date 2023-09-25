using System;
using Components.CustomExceptions;
using System.Windows.Forms;
using Controllers;
using Components;
using Models.CartModels;
using Views.ProductViews;

namespace Views.CartViews
{
    public partial class IbInsertByCode : Form
    {
        string code;
        int idProduct;

        public IbInsertByCode(string code)
        {
            InitializeComponent();
            this.code = code;
        }

        private bool GetProduct()
        {
            try
            {
                var product = new ProductController().GetProduct(code);

                if (product.Code != null)
                {
                    lblProduct.Text = string.Format("{0} {1} ({2}) - {3}", product.Product, product.Brand, product.Measure, product.Code);
                    nudPrice.Value = product.SalePrice;
                    idProduct = product.Id;
                    nudStock.Value = product.Stock;

                    return true;
                }
                else
                {
                    if (MessageBox.Show("No hay un producto que corresponda a este codigo\n\nDesea ingresar un nuevo producto?", "Codigo no registrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var frmAdd = new FrmAdd();
                        frmAdd.txtCode.Text = this.code;
                        frmAdd.txtCode.Enabled = false;
                        frmAdd.btnEditCode.Visible = true;
                        frmAdd.ShowDialog();

                        if (frmAdd.DialogResult == DialogResult.OK)
                        {
                            GetProduct();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void Insert()
        {
            if (nudQuantity.Value > 0)
            {
                try
                {
                    var cart = new CartController();
                    var model = new CartInsertModel();

                    model.idProduct = this.idProduct;
                    model.Quantity = nudQuantity.Value;
                    model.Price = nudPrice.Value;
                    model.Discount = nudDiscount.Value;
                    model.TypeDiscount = rbPercentage.Checked ? "%" : "Q";

                    cart.Insert(model);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (InsufficientStockException ex)
                {
                    if (MessageBox.Show(ex.Message + "\n\nDesea modificar el producto?", "Existencia insuficiente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var frmEditProduct = new FrmEdit(this.idProduct);
                        frmEditProduct.ShowDialog();

                        if (frmEditProduct.DialogResult == DialogResult.OK)
                            Insert();
                    }
                }
                catch (InvalidDiscountException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("La cantidad no puede ser 0");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            SetLabelValues();
        }

        private void SetLabelValues()
        {
            if ((rbPercentage.Checked && nudDiscount.Value <= 100) || (rbAmount.Checked && nudDiscount.Value < nudPrice.Value))
            {
                var math = new MathOperations();
                decimal unitDiscountInMoney, totalDiscount, subTotal, netSubtotal;

                unitDiscountInMoney = math.CalculateDiscount(nudPrice.Value, nudDiscount.Value, rbPercentage.Checked);
                totalDiscount = unitDiscountInMoney * nudQuantity.Value;
                subTotal = nudQuantity.Value * nudPrice.Value;
                netSubtotal = subTotal - totalDiscount;

                lblAppliedDiscount.Text = "Q " + totalDiscount.ToString("N2");
                lblNetSubtotal.Text = "Q " + netSubtotal.ToString("N2");
            }
        }

        private void IbInsertByCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
                nudQuantity.Value += 1;
            else if (e.KeyCode == Keys.Subtract)
                if (nudQuantity.Value > 0)
                    nudQuantity.Value -= 1;
        }

        private void IbInsertByCode_Load(object sender, EventArgs e)
        {
            if (GetProduct() == false)
                this.Close();
        }
    }
}
