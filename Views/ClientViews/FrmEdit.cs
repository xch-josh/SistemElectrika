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
using Models.ClientModels;

namespace Views.ClientViews
{
    public partial class FrmEdit : Form
    {
        int id;
        public FrmEdit(int id)
        {
            InitializeComponent();
            this.id = id;

            GetClient();
        }

        private void GetClient()
        {
            try
            {
                var client = new ClientController().GetClient(this.id);

                txtNit.Text = client.Nit.ToString();
                txtNames.Text = client.Names;
                txtLastnames.Text = client.Lastnames;
                txtDirection.Text = client.Direction;
                txtPhone.Text = client.Phone;
                txtMail.Text = client.Mail;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateFields()
        {
            if (txtNit.Text != string.Empty && txtNames.Text != string.Empty && txtLastnames.Text != string.Empty && txtDirection.Text != string.Empty &&
                txtPhone.Text != string.Empty && txtMail.Text != string.Empty)
                return true;
            else
                return false;
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {
                    var client = new ClientController();
                    var model = new ClientEditModel();

                    model.Id = this.id;
                    model.Nit = txtNit.Text.Trim();
                    model.Names = txtNames.Text.Trim();
                    model.Lastnames = txtLastnames.Text.Trim();
                    model.Direction = txtDirection.Text.Trim();
                    model.Phone = int.Parse(txtPhone.Text.Trim());
                    model.Mail = txtMail.Text.Trim();

                    client.Edit(model);

                    MessageBox.Show("Los datos han sido editados satisfactoriamente :)", "Guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("Por favor llena todos los campos", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
