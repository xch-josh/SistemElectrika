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
using Models.ProviderModels;
using Models.ProviderModels.DetailProviderModels;

namespace Views.ProviderViews
{
    public partial class FrmAddProvider : Form
    {
        public FrmAddProvider()
        {
            InitializeComponent();
        }

        #region "Validations"
        private bool ValidateFields()
        {
            if (txtCode.Text.Trim() != string.Empty && txtProvider.Text.Trim() != string.Empty && txtPhone.Text.Trim() != string.Empty && txtMail.Text.Trim() != string.Empty
                && txtNameSaler.Text.Trim() != string.Empty && txtPhoneSaler.Text.Trim() != string.Empty && txtMailSaler.Text.Trim() != string.Empty)
                return true;
            else
                return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {
                    var provider = new ProviderController();
                    var model = new ProviderAddModel();
                    var detail = new DetailProviderAddModel();

                    model.Code = txtCode.Text.Trim();
                    model.Provider = txtProvider.Text.Trim();
                    model.Phone = int.Parse(txtPhone.Text.Trim());
                    model.Mail = txtMail.Text.Trim();

                    detail.Saler = txtNameSaler.Text.Trim();
                    detail.Phone = int.Parse(txtPhoneSaler.Text.Trim());
                    detail.Mail = txtMailSaler.Text.Trim();

                    provider.Insert(model, detail);

                    MessageBox.Show("Los datos han sido guardados satisfactoriamente :)", "Guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    ClearFields();
                }
                else
                    MessageBox.Show("Por favor llena todos los campos", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearFields()
        {
            txtCode.Clear();
            txtProvider.Clear();
            txtPhone.Clear();
            txtMail.Clear();
            txtNameSaler.Clear();
            txtPhoneSaler.Clear();
            txtMailSaler.Clear();
            txtCode.Focus();
        }
    }
}
