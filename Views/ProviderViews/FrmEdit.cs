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


namespace Views.ProviderViews
{
    public partial class FrmEdit : Form
    {
        FrmProviders providers;
        int id;
        public FrmEdit(FrmProviders providers, int id)
        {
            InitializeComponent();
            this.providers = providers;
            this.id = id;
        }

        #region "Validations"
        private bool ValidareFields()
        {
            if (txtCode.Text != string.Empty && txtProvider.Text != string.Empty && txtPhone.Text != string.Empty && txtMail.Text != string.Empty)
                return true;
            else
                return false;
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidareFields())
                {
                    var provider = new ProviderController();
                    var model = new ProviderEditModel();

                    model.Id = this.id;
                    model.Code = txtCode.Text.Trim();
                    model.Provider = txtProvider.Text.Trim();
                    model.Phone = int.Parse(txtPhone.Text.Trim());
                    model.Mail = txtMail.Text.Trim();

                    provider.Edit(model);
                    MessageBox.Show("Los datos han sido editados satisfactoriamente :)", "Guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.providers.ShowData(true);
                    this.providers.lnkEnabledDisabled.Text = "Ver inactivos >>";
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

        private void lnkEditDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var details = new DetailsProviderViews.FrmDetail(this.id);
            details.lblHead.Text = $"Detalles de {txtProvider.Text.Trim()}";
            details.ShowDialog();
        }
    }
}
