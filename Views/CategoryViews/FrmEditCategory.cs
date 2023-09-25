using Controllers;
using Models.CategoryModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.CategoryViews
{
    public partial class FrmEditCategory : Form
    {
        int id;

        public FrmEditCategory(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new CategoryController();
                var vCategory = new CategoryEditModel();

                vCategory.Id = this.id;
                vCategory.Category = txtCategory.Text.Trim();

                category.Edit(vCategory);
                MessageBox.Show("Los datos han sido editados satisfactoriamente :)", "Editar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.Close();
        }
    }
}
