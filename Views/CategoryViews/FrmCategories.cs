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
using Models.CategoryModels;

namespace Views.CategoryViews
{
    public partial class FrmCategories : Form
    {
        List<CategoryViewModel> lst = new List<CategoryViewModel>();
        bool change = false;

        public FrmCategories()
        {
            InitializeComponent();
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public async void ShowData()
        {
            try
            {
                var category = new CategoryController();
                lst = await category.GetData();

                if (lst.Count > 0)
                {
                    dgvData.DataSource = lst;
                    lblNoData.Visible = false;
                    dgvData.Columns[0].Visible = false;
                }
                else
                {
                    dgvData.DataSource = null;
                    lblNoData.Visible = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var frmAdd = new FrmAddCategory();
            frmAdd.ShowDialog();

            if (frmAdd.DialogResult == DialogResult.OK)
            {
                ShowData();
                change = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                var frmEdit = new FrmEditCategory((int)dgvData.SelectedCells[0].Value);
                frmEdit.ShowDialog();

                if (frmEdit.DialogResult == DialogResult.OK)
                {
                    ShowData();
                    change = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Desea eliminar el elemento seleccionado?", "Eliminar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(result == DialogResult.Yes)
                {
                    var category = new CategoryController();
                    category.Delete((int)dgvData.SelectedCells[0].Value);
                    ShowData();
                    change = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCategories_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (change)
                this.DialogResult = DialogResult.OK;
        }
    }
}
