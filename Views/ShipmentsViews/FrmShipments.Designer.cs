
namespace Views.ShipmentsViews
{
    partial class FrmShipments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShipments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbNew_Edit = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdSale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.chbEnableSearchByDate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblHead = new System.Windows.Forms.ToolStripLabel();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.lblNoData = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.rbDelivery = new System.Windows.Forms.RadioButton();
            this.rbCreation = new System.Windows.Forms.RadioButton();
            this.gbShowBy = new System.Windows.Forms.GroupBox();
            this.gbNew_Edit.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gbDate.SuspendLayout();
            this.gbShowBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNew_Edit
            // 
            this.gbNew_Edit.Controls.Add(this.gbShowBy);
            this.gbNew_Edit.Controls.Add(this.gbDate);
            this.gbNew_Edit.Controls.Add(this.label3);
            this.gbNew_Edit.Controls.Add(this.txtIdSale);
            this.gbNew_Edit.Controls.Add(this.label4);
            this.gbNew_Edit.Controls.Add(this.txtSearchClient);
            this.gbNew_Edit.Controls.Add(this.chbEnableSearchByDate);
            this.gbNew_Edit.Controls.Add(this.label1);
            this.gbNew_Edit.Controls.Add(this.txtSearch);
            this.gbNew_Edit.Font = new System.Drawing.Font("Arial", 9F);
            this.gbNew_Edit.ForeColor = System.Drawing.Color.Gray;
            this.gbNew_Edit.Location = new System.Drawing.Point(12, 36);
            this.gbNew_Edit.Name = "gbNew_Edit";
            this.gbNew_Edit.Size = new System.Drawing.Size(567, 119);
            this.gbNew_Edit.TabIndex = 27;
            this.gbNew_Edit.TabStop = false;
            this.gbNew_Edit.Text = "Filtros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Id Venta:";
            // 
            // txtIdSale
            // 
            this.txtIdSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdSale.Location = new System.Drawing.Point(65, 86);
            this.txtIdSale.Name = "txtIdSale";
            this.txtIdSale.Size = new System.Drawing.Size(93, 21);
            this.txtIdSale.TabIndex = 33;
            this.txtIdSale.TextChanged += new System.EventHandler(this.txtIdSale_TextChanged);
            this.txtIdSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdSale_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(164, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cliente:";
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchClient.Location = new System.Drawing.Point(219, 86);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(203, 21);
            this.txtSearchClient.TabIndex = 31;
            this.txtSearchClient.TextChanged += new System.EventHandler(this.txtSearchClient_TextChanged);
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.ForeColor = System.Drawing.Color.Black;
            this.rbMonth.Location = new System.Drawing.Point(6, 34);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(48, 19);
            this.rbMonth.TabIndex = 30;
            this.rbMonth.Text = "Mes";
            this.rbMonth.UseVisualStyleBackColor = true;
            // 
            // rbDay
            // 
            this.rbDay.AutoSize = true;
            this.rbDay.Checked = true;
            this.rbDay.ForeColor = System.Drawing.Color.Black;
            this.rbDay.Location = new System.Drawing.Point(6, 16);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(44, 19);
            this.rbDay.TabIndex = 29;
            this.rbDay.TabStop = true;
            this.rbDay.Text = "Día";
            this.rbDay.UseVisualStyleBackColor = true;
            this.rbDay.CheckedChanged += new System.EventHandler(this.rbDay_CheckedChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(81, 23);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(113, 21);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // chbEnableSearchByDate
            // 
            this.chbEnableSearchByDate.AutoSize = true;
            this.chbEnableSearchByDate.Checked = true;
            this.chbEnableSearchByDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbEnableSearchByDate.ForeColor = System.Drawing.Color.Black;
            this.chbEnableSearchByDate.Location = new System.Drawing.Point(140, 27);
            this.chbEnableSearchByDate.Name = "chbEnableSearchByDate";
            this.chbEnableSearchByDate.Size = new System.Drawing.Size(82, 34);
            this.chbEnableSearchByDate.TabIndex = 3;
            this.chbEnableSearchByDate.Text = "busqueda\r\npor fecha";
            this.chbEnableSearchByDate.UseVisualStyleBackColor = true;
            this.chbEnableSearchByDate.CheckedChanged += new System.EventHandler(this.chbEnableSearchByDate_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(32, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(93, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHead,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(778, 33);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblHead
            // 
            this.lblHead.Font = new System.Drawing.Font("Arial", 15F);
            this.lblHead.ForeColor = System.Drawing.Color.White;
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(69, 30);
            this.lblHead.Text = "Envíos";
            // 
            // btnDelete
            // 
            this.btnDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDelete.AutoSize = false;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblNoData
            // 
            this.lblNoData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Arial", 11F);
            this.lblNoData.ForeColor = System.Drawing.Color.Red;
            this.lblNoData.Location = new System.Drawing.Point(347, 348);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(114, 17);
            this.lblNoData.TabIndex = 30;
            this.lblNoData.Text = "No hay registros";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeight = 35;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Details});
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.Color.White;
            this.dgvData.Location = new System.Drawing.Point(0, 161);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowTemplate.Height = 30;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(778, 392);
            this.dgvData.TabIndex = 44;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // Details
            // 
            this.Details.HeaderText = "";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.rbDelivery);
            this.gbDate.Controls.Add(this.rbCreation);
            this.gbDate.Controls.Add(this.dtpDate);
            this.gbDate.Location = new System.Drawing.Point(227, 12);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(200, 57);
            this.gbDate.TabIndex = 45;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Fecha de";
            // 
            // rbDelivery
            // 
            this.rbDelivery.AutoSize = true;
            this.rbDelivery.ForeColor = System.Drawing.Color.Black;
            this.rbDelivery.Location = new System.Drawing.Point(6, 34);
            this.rbDelivery.Name = "rbDelivery";
            this.rbDelivery.Size = new System.Drawing.Size(68, 19);
            this.rbDelivery.TabIndex = 38;
            this.rbDelivery.Text = "Entrega";
            this.rbDelivery.UseVisualStyleBackColor = true;
            // 
            // rbCreation
            // 
            this.rbCreation.AutoSize = true;
            this.rbCreation.Checked = true;
            this.rbCreation.ForeColor = System.Drawing.Color.Black;
            this.rbCreation.Location = new System.Drawing.Point(6, 16);
            this.rbCreation.Name = "rbCreation";
            this.rbCreation.Size = new System.Drawing.Size(75, 19);
            this.rbCreation.TabIndex = 37;
            this.rbCreation.TabStop = true;
            this.rbCreation.Text = "Creación";
            this.rbCreation.UseVisualStyleBackColor = true;
            this.rbCreation.CheckedChanged += new System.EventHandler(this.rbCreation_CheckedChanged);
            // 
            // gbShowBy
            // 
            this.gbShowBy.Controls.Add(this.rbDay);
            this.gbShowBy.Controls.Add(this.rbMonth);
            this.gbShowBy.Location = new System.Drawing.Point(433, 12);
            this.gbShowBy.Name = "gbShowBy";
            this.gbShowBy.Size = new System.Drawing.Size(122, 57);
            this.gbShowBy.TabIndex = 45;
            this.gbShowBy.TabStop = false;
            this.gbShowBy.Text = "Mostrar envíos del";
            // 
            // FrmShipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 553);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbNew_Edit);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmShipments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmShipments_Load);
            this.gbNew_Edit.ResumeLayout(false);
            this.gbNew_Edit.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            this.gbShowBy.ResumeLayout(false);
            this.gbShowBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNew_Edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox chbEnableSearchByDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdSale;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblHead;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.RadioButton rbDelivery;
        private System.Windows.Forms.RadioButton rbCreation;
        private System.Windows.Forms.GroupBox gbShowBy;
    }
}