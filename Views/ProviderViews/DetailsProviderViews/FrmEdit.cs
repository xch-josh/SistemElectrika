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
    public partial class FrmEdit : Form
    {
        FrmDetail frmDetail;
        int id;
        public FrmEdit(FrmDetail frmDetail, int id)
        {
            InitializeComponent();
            this.frmDetail = frmDetail;
            this.id = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region "Validations"
        private bool ValidateFields()
        {
            if (txtSaler.Text.Trim() != string.Empty && txtPhone.Text.Trim() != string.Empty && txtMail.Text.Trim() != string.Empty)
                return true;
            else
                return false;
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    var detail = new DetailProviderController();
                    var vDetail = new DetailProviderEditModel();

                    vDetail.Id = this.id;
                    vDetail.Saler = txtSaler.Text.Trim();
                    vDetail.Mail = txtMail.Text.Trim();
                    vDetail.Phone = int.Parse(txtPhone.Text.Trim());

                    detail.Edit(vDetail);
                    MessageBox.Show("Los datos han sido editados satisfactoriamente :)", "Guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDetail.ShowData();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
