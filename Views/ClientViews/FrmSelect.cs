using Controllers;
using Components;
using Models.ClientModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.ClientViews
{
    public partial class FrmSelect : Form
    {
        ClientGetModel clientGetModel;
        public FrmSelect(ref ClientGetModel clientGetModel)
        {
            InitializeComponent();

            this.clientGetModel = clientGetModel;
        }

        List<ClientGetModel> lst = new List<ClientGetModel>();
        private void FrmSelectClient_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public async void ShowData()
        {
            try
            {
                var client = new ClientController();
                lst = await client.GetClients();
                Search();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search()
        {
            var search = new FiltersOfForms();

            var source = search.FilterClient(lst, txtNit.Text.Trim(), txtNames.Text.Trim(), txtLastnames.Text.Trim());

            if (source.Count > 0)
            {
                dgvData.DataSource = source;
                lblNoData.Visible = false;
            }
            else
            {
                dgvData.DataSource = null;
                lblNoData.Visible = true;
            }
            ConfColumns();
        }

        private void ConfColumns()
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                dgvData.Columns[0].Visible = false;
                dgvData.Columns[4].Visible = false;
            }
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var frmAdd = new FrmAdd();
            frmAdd.ShowDialog();

            if (frmAdd.DialogResult == DialogResult.OK)
                ShowData();
        }

        private void SetValues()
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                this.clientGetModel.Id = (int)dgvData.SelectedCells[0].Value;
                this.clientGetModel.Nit = dgvData.SelectedCells[1].Value.ToString();
                this.clientGetModel.Names = dgvData.SelectedCells[2].Value.ToString();
                this.clientGetModel.Lastnames = dgvData.SelectedCells[3].Value.ToString();
                this.clientGetModel.Direction = dgvData.SelectedCells[4].Value.ToString();

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SetValues();
        }

        private void FrmSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SetValues();
            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedCells.Count > 0)
            {
                var frmEdit = new FrmEdit((int)dgvData.SelectedCells[0].Value);
                frmEdit.ShowDialog();

                if (frmEdit.DialogResult == DialogResult.OK)
                    ShowData();
            }
        }
    }
}
