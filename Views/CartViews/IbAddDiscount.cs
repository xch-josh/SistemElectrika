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

namespace Views.CartViews
{
    public partial class IbAddDiscount : Form
    {
        int idItemCart;
        public IbAddDiscount(int idItemCart)
        {
            InitializeComponent();

            this.idItemCart = idItemCart;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var cart = new CartController();

                cart.AplyOrModifyUnitDiscount(this.idItemCart, nudQuantity.Value, rbPercentage.Checked);

                MessageBox.Show("Descuento aplicado satisfactoriamente", "Descuentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
