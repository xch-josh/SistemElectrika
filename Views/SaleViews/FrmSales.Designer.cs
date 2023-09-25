
namespace Views.SaleViews
{
    partial class FrmSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNoData = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblHead = new System.Windows.Forms.ToolStripLabel();
            this.btnDeactive = new System.Windows.Forms.ToolStripButton();
            this.gbNew_Edit = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.chbEnableSearchByDate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTitleSum = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            this.gbNew_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoData
            // 
            this.lblNoData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Arial", 11F);
            this.lblNoData.ForeColor = System.Drawing.Color.Red;
            this.lblNoData.Location = new System.Drawing.Point(347, 312);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(114, 17);
            this.lblNoData.TabIndex = 24;
            this.lblNoData.Text = "No hay registros";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHead,
            this.btnDeactive});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(809, 33);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblHead
            // 
            this.lblHead.Font = new System.Drawing.Font("Arial", 15F);
            this.lblHead.ForeColor = System.Drawing.Color.White;
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(171, 30);
            this.lblHead.Text = "Historial de ventas";
            // 
            // btnDeactive
            // 
            this.btnDeactive.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDeactive.AutoSize = false;
            this.btnDeactive.BackColor = System.Drawing.Color.Gray;
            this.btnDeactive.ForeColor = System.Drawing.Color.White;
            this.btnDeactive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeactive.Name = "btnDeactive";
            this.btnDeactive.Size = new System.Drawing.Size(90, 30);
            this.btnDeactive.Text = "Retornar venta";
            this.btnDeactive.Click += new System.EventHandler(this.btnDeactive_Click);
            // 
            // gbNew_Edit
            // 
            this.gbNew_Edit.Controls.Add(this.label4);
            this.gbNew_Edit.Controls.Add(this.txtSearchClient);
            this.gbNew_Edit.Controls.Add(this.rbMonth);
            this.gbNew_Edit.Controls.Add(this.rbDay);
            this.gbNew_Edit.Controls.Add(this.label5);
            this.gbNew_Edit.Controls.Add(this.dtpDate);
            this.gbNew_Edit.Controls.Add(this.chbEnableSearchByDate);
            this.gbNew_Edit.Controls.Add(this.label2);
            this.gbNew_Edit.Controls.Add(this.label1);
            this.gbNew_Edit.Controls.Add(this.txtSearch);
            this.gbNew_Edit.Font = new System.Drawing.Font("Arial", 9F);
            this.gbNew_Edit.ForeColor = System.Drawing.Color.Gray;
            this.gbNew_Edit.Location = new System.Drawing.Point(12, 41);
            this.gbNew_Edit.Name = "gbNew_Edit";
            this.gbNew_Edit.Size = new System.Drawing.Size(555, 92);
            this.gbNew_Edit.TabIndex = 26;
            this.gbNew_Edit.TabStop = false;
            this.gbNew_Edit.Text = "Filtros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cliente:";
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchClient.Location = new System.Drawing.Point(61, 59);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(203, 21);
            this.txtSearchClient.TabIndex = 31;
            this.txtSearchClient.TextChanged += new System.EventHandler(this.txtSearchClient_TextChanged);
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.ForeColor = System.Drawing.Color.Black;
            this.rbMonth.Location = new System.Drawing.Point(499, 30);
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
            this.rbDay.Location = new System.Drawing.Point(499, 12);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(44, 19);
            this.rbDay.TabIndex = 29;
            this.rbDay.TabStop = true;
            this.rbDay.Text = "Día";
            this.rbDay.UseVisualStyleBackColor = true;
            this.rbDay.CheckedChanged += new System.EventHandler(this.rbDay_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(387, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mostrar ventas del";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(185, 20);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(107, 21);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDateSale_ValueChanged);
            // 
            // chbEnableSearchByDate
            // 
            this.chbEnableSearchByDate.AutoSize = true;
            this.chbEnableSearchByDate.Checked = true;
            this.chbEnableSearchByDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbEnableSearchByDate.ForeColor = System.Drawing.Color.Black;
            this.chbEnableSearchByDate.Location = new System.Drawing.Point(299, 15);
            this.chbEnableSearchByDate.Name = "chbEnableSearchByDate";
            this.chbEnableSearchByDate.Size = new System.Drawing.Size(82, 34);
            this.chbEnableSearchByDate.TabIndex = 3;
            this.chbEnableSearchByDate.Text = "busqueda\r\npor fecha";
            this.chbEnableSearchByDate.UseVisualStyleBackColor = true;
            this.chbEnableSearchByDate.CheckedChanged += new System.EventHandler(this.chbEnableSearchByDate_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(135, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(32, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(93, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblTitleSum
            // 
            this.lblTitleSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleSum.ForeColor = System.Drawing.Color.Black;
            this.lblTitleSum.Location = new System.Drawing.Point(701, 41);
            this.lblTitleSum.Name = "lblTitleSum";
            this.lblTitleSum.Size = new System.Drawing.Size(96, 15);
            this.lblTitleSum.TabIndex = 27;
            this.lblTitleSum.Text = "Total del día:";
            this.lblTitleSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Arial", 20F);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(573, 61);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(228, 45);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Q 9999999.99";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8F);
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
            this.dgvData.Location = new System.Drawing.Point(0, 139);
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
            this.dgvData.Size = new System.Drawing.Size(809, 403);
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
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 540);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTitleSum);
            this.Controls.Add(this.gbNew_Edit);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.dgvData);
            this.Font = new System.Drawing.Font("Arial", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSales_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbNew_Edit.ResumeLayout(false);
            this.gbNew_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblHead;
        private System.Windows.Forms.GroupBox gbNew_Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox chbEnableSearchByDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitleSum;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.ToolStripButton btnDeactive;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
    }
}