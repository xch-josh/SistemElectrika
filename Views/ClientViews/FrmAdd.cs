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
using Models.DataBase;
using Models.ClientModels;

namespace Views.ClientViews
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        #region "Validations"
        private bool ValidateFields()
        {
            if (txtNit.Text != string.Empty && txtNames.Text != string.Empty && txtLastnames.Text != string.Empty && txtDirection.Text != string.Empty &&
                txtPhone.Text != string.Empty && txtMail.Text != string.Empty)
                return true;
            else
                return false;
        }

        private void ClearFields()
        {
            txtNit.Clear();
            txtNames.Clear();
            txtLastnames.Clear();
            txtDirection.Clear();
            txtPhone.Clear();
            txtMail.Clear();
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {
                    var client = new ClientController();
                    var model = new ClientAddModel();

                    model.Nit = txtNit.Text.Trim();
                    model.Names = txtNames.Text.Trim();
                    model.Lastnames = txtLastnames.Text.Trim();
                    model.Direction = txtDirection.Text.Trim();
                    model.Phone = int.Parse(txtPhone.Text.Trim());
                    model.Mail = txtMail.Text.Trim();

                    client.Insert(model);

                    MessageBox.Show("Los datos han sido guardados satisfactoriamente :)", "Guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Por favor llena todos los campos", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        private void btnCF_Click(object sender, EventArgs e)
        {
            txtNit.Text = "C/F";
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }
    }
}
