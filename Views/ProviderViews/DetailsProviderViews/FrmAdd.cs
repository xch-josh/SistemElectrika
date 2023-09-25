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
using Models.ProviderModels.DetailProviderModels;

namespace Views.ProviderViews.DetailsProviderViews
{
    public partial class FrmAdd : Form
    {
        FrmDetail frmDetail;
        int id;
        public FrmAdd(FrmDetail frmDetail, int id)
        {
            InitializeComponent();
            this.id = id;
            this.frmDetail = frmDetail;
        }

        #region "Validations"
        private bool ValidateFields()
        {
            if (txtSaler.Text.Trim() != string.Empty && txtPhone.Text.Trim() != string.Empty && txtMail.Text.Trim() != string.Empty)
                return true;
            else
                return false;
        }

        private void ClearFields()
        {
            txtSaler.Clear();
            txtPhone.Clear();
            txtMail.Clear();
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    var detail = new DetailProviderController();
                    var vDetail = new DetailProviderAddModel();

                    vDetail.Saler = txtSaler.Text.Trim();
                    vDetail.Phone = int.Parse(txtPhone.Text.Trim());
                    vDetail.Mail = txtMail.Text.Trim();
                    vDetail.IdProvider = this.id;

                    detail.Insert(vDetail);
                    MessageBox.Show("Los datos han sido guardados satisfactoriamente :)", "Guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDetail.ShowData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Por favor llenar todos los campos", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
