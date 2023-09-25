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
using Models.CartModels;

namespace Views.CartViews
{
    public partial class IbAddOrSubstract : Form
    {
        int id, idProduct;
        string behavior;

        public IbAddOrSubstract(int id, int idProduct, string behavior)
        {
            InitializeComponent();

            nudQuantity.Focus();

            this.id = id;
            this.idProduct = idProduct;
            this.behavior = behavior;

            if (behavior == "add")
            {
                lblHeader.Text = "Agregar";
                btnAdd.Text = "Agregar";
            }
            else
            {
                lblHeader.Text = "Restar";
                btnAdd.Text = "Restar";
            }
        }

        private void Add(CartSubstractOrAddModel model)
        {
            try
            {
                var cart = new CartController();

                cart.Add(model);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Subtract(CartSubstractOrAddModel model)
        {
            try
            {
                var cart = new CartController();

                cart.Subtract(model);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            var model = new CartSubstractOrAddModel();

            model.Quantity = nudQuantity.Value;
            model.Id = this.id;
            model.IdProduct = this.idProduct;

            if (behavior == "add")
            {
                Add(model);
            }
            else
            {
                Subtract(model);
            }
        }
    }
}