
namespace Views.QuotationViews
{
    partial class FrmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbNew_Edit = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.btnSelectSaler = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoData = new System.Windows.Forms.Label();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbDiscount = new System.Windows.Forms.GroupBox();
            this.tcDiscount = new System.Windows.Forms.TabControl();
            this.tpTotal = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.tpUnit = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.btnRemoveDiscount = new System.Windows.Forms.Button();
            this.btnAplyDiscount = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalInLetters = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.rbPercentage = new System.Windows.Forms.RadioButton();
            this.rbAmount = new System.Windows.Forms.RadioButton();
            this.gbNew_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            this.gbDiscount.SuspendLayout();
            this.tcDiscount.SuspendLayout();
            this.tpTotal.SuspendLayout();
            this.tpUnit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNew_Edit
            // 
            this.gbNew_Edit.Controls.Add(this.label1);
            this.gbNew_Edit.Controls.Add(this.nudDays);
            this.gbNew_Edit.Controls.Add(this.btnSelectSaler);
            this.gbNew_Edit.Controls.Add(this.label12);
            this.gbNew_Edit.Controls.Add(this.txtClient);
            this.gbNew_Edit.Controls.Add(this.label13);
            this.gbNew_Edit.Controls.Add(this.dtpDate);
            this.gbNew_Edit.Controls.Add(this.label14);
            this.gbNew_Edit.Font = new System.Drawing.Font("Arial", 9F);
            this.gbNew_Edit.ForeColor = System.Drawing.Color.Gray;
            this.gbNew_Edit.Location = new System.Drawing.Point(12, 36);
            this.gbNew_Edit.Name = "gbNew_Edit";
            this.gbNew_Edit.Size = new System.Drawing.Size(589, 56);
            this.gbNew_Edit.TabIndex = 34;
            this.gbNew_Edit.TabStop = false;
            this.gbNew_Edit.Text = "Detalles de la cotización";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(283, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 70;
            this.label1.Text = "días";
            // 
            // nudDays
            // 
            this.nudDays.Location = new System.Drawing.Point(232, 22);
            this.nudDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(50, 21);
            this.nudDays.TabIndex = 69;
            this.nudDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSelectSaler
            // 
            this.btnSelectSaler.ForeColor = System.Drawing.Color.Black;
            this.btnSelectSaler.Location = new System.Drawing.Point(543, 21);
            this.btnSelectSaler.Name = "btnSelectSaler";
            this.btnSelectSaler.Size = new System.Drawing.Size(33, 23);
            this.btnSelectSaler.TabIndex = 68;
            this.btnSelectSaler.Text = "...";
            this.btnSelectSaler.UseVisualStyleBackColor = true;
            this.btnSelectSaler.Click += new System.EventHandler(this.btnSelectClient_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(325, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "Cliente:";
            // 
            // txtClient
            // 
            this.txtClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClient.Enabled = false;
            this.txtClient.Location = new System.Drawing.Point(380, 22);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(157, 21);
            this.txtClient.TabIndex = 33;
            this.txtClient.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(173, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 15);
            this.label13.TabIndex = 32;
            this.label13.Text = "Vigencia:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(56, 21);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(111, 21);
            this.dtpDate.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(6, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nueva cotización";
            // 
            // lblNoData
            // 
            this.lblNoData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Arial", 11F);
            this.lblNoData.ForeColor = System.Drawing.Color.Red;
            this.lblNoData.Location = new System.Drawing.Point(341, 236);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(114, 17);
            this.lblNoData.TabIndex = 36;
            this.lblNoData.Text = "No hay registros";
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.BackColor = System.Drawing.Color.Green;
            this.btnAddProducts.FlatAppearance.BorderSize = 0;
            this.btnAddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProducts.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAddProducts.ForeColor = System.Drawing.Color.White;
            this.btnAddProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProducts.Image")));
            this.btnAddProducts.Location = new System.Drawing.Point(12, 98);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(193, 31);
            this.btnAddProducts.TabIndex = 37;
            this.btnAddProducts.Text = "Añadir productos";
            this.btnAddProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Font = new System.Drawing.Font("Arial", 10F);
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(683, 106);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 23);
            this.btnRemove.TabIndex = 69;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "Quitar";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbDiscount
            // 
            this.gbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbDiscount.Controls.Add(this.tcDiscount);
            this.gbDiscount.Controls.Add(this.btnRemoveDiscount);
            this.gbDiscount.Controls.Add(this.btnAplyDiscount);
            this.gbDiscount.Font = new System.Drawing.Font("Arial", 8F);
            this.gbDiscount.ForeColor = System.Drawing.Color.DimGray;
            this.gbDiscount.Location = new System.Drawing.Point(12, 367);
            this.gbDiscount.Name = "gbDiscount";
            this.gbDiscount.Size = new System.Drawing.Size(290, 98);
            this.gbDiscount.TabIndex = 70;
            this.gbDiscount.TabStop = false;
            this.gbDiscount.Text = "Aplicar descuento";
            // 
            // tcDiscount
            // 
            this.tcDiscount.Controls.Add(this.tpTotal);
            this.tcDiscount.Controls.Add(this.tpUnit);
            this.tcDiscount.Location = new System.Drawing.Point(6, 15);
            this.tcDiscount.Name = "tcDiscount";
            this.tcDiscount.SelectedIndex = 0;
            this.tcDiscount.Size = new System.Drawing.Size(170, 77);
            this.tcDiscount.TabIndex = 40;
            // 
            // tpTotal
            // 
            this.tpTotal.BackColor = System.Drawing.Color.White;
            this.tpTotal.Controls.Add(this.rbPercentage);
            this.tpTotal.Controls.Add(this.rbAmount);
            this.tpTotal.Controls.Add(this.label3);
            this.tpTotal.Controls.Add(this.txtTotal);
            this.tpTotal.Location = new System.Drawing.Point(4, 23);
            this.tpTotal.Name = "tpTotal";
            this.tpTotal.Padding = new System.Windows.Forms.Padding(3);
            this.tpTotal.Size = new System.Drawing.Size(162, 50);
            this.tpTotal.TabIndex = 0;
            this.tpTotal.Text = "Total";
            this.tpTotal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(124, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "%";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(14, 8);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(108, 20);
            this.txtTotal.TabIndex = 39;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // tpUnit
            // 
            this.tpUnit.Controls.Add(this.label5);
            this.tpUnit.Controls.Add(this.txtUnit);
            this.tpUnit.Location = new System.Drawing.Point(4, 23);
            this.tpUnit.Name = "tpUnit";
            this.tpUnit.Padding = new System.Windows.Forms.Padding(3);
            this.tpUnit.Size = new System.Drawing.Size(162, 50);
            this.tpUnit.TabIndex = 1;
            this.tpUnit.Text = "Unitario";
            this.tpUnit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(126, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "%";
            // 
            // txtUnit
            // 
            this.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnit.Location = new System.Drawing.Point(16, 15);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(108, 20);
            this.txtUnit.TabIndex = 41;
            this.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnit_KeyPress);
            // 
            // btnRemoveDiscount
            // 
            this.btnRemoveDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveDiscount.FlatAppearance.BorderSize = 0;
            this.btnRemoveDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDiscount.Font = new System.Drawing.Font("Arial", 9F);
            this.btnRemoveDiscount.ForeColor = System.Drawing.Color.White;
            this.btnRemoveDiscount.Location = new System.Drawing.Point(182, 39);
            this.btnRemoveDiscount.Name = "btnRemoveDiscount";
            this.btnRemoveDiscount.Size = new System.Drawing.Size(102, 24);
            this.btnRemoveDiscount.TabIndex = 38;
            this.btnRemoveDiscount.Text = "Quitar";
            this.btnRemoveDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveDiscount.UseVisualStyleBackColor = false;
            // 
            // btnAplyDiscount
            // 
            this.btnAplyDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplyDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAplyDiscount.FlatAppearance.BorderSize = 0;
            this.btnAplyDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplyDiscount.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAplyDiscount.ForeColor = System.Drawing.Color.White;
            this.btnAplyDiscount.Location = new System.Drawing.Point(182, 10);
            this.btnAplyDiscount.Name = "btnAplyDiscount";
            this.btnAplyDiscount.Size = new System.Drawing.Size(102, 24);
            this.btnAplyDiscount.TabIndex = 37;
            this.btnAplyDiscount.Text = "Aplicar";
            this.btnAplyDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplyDiscount.UseVisualStyleBackColor = false;
            this.btnAplyDiscount.Click += new System.EventHandler(this.btnAplyDiscount_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Arial", 13F);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(630, 372);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(154, 22);
            this.lblTotal.TabIndex = 74;
            this.lblTotal.Text = "Q 99999.99";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(742, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 73;
            this.label6.Text = "Total:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(520, 503);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 28);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(659, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 28);
            this.btnSave.TabIndex = 71;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblTotalInLetters);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8F);
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(12, 471);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 60);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total en letras:";
            // 
            // lblTotalInLetters
            // 
            this.lblTotalInLetters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalInLetters.Font = new System.Drawing.Font("Arial", 9F);
            this.lblTotalInLetters.ForeColor = System.Drawing.Color.Black;
            this.lblTotalInLetters.Location = new System.Drawing.Point(6, 18);
            this.lblTotalInLetters.Name = "lblTotalInLetters";
            this.lblTotalInLetters.Size = new System.Drawing.Size(465, 32);
            this.lblTotalInLetters.TabIndex = 5;
            this.lblTotalInLetters.Text = "CERO QUETZALES CON 0/100 CENTAVOS";
            this.lblTotalInLetters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.Font = new System.Drawing.Font("Arial", 13F);
            this.lblDiscount.ForeColor = System.Drawing.Color.Black;
            this.lblDiscount.Location = new System.Drawing.Point(630, 412);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(154, 22);
            this.lblDiscount.TabIndex = 77;
            this.lblDiscount.Text = "Q 99999.99";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(704, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 76;
            this.label7.Text = "Descuento:";
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetTotal.Font = new System.Drawing.Font("Arial", 13F);
            this.lblNetTotal.ForeColor = System.Drawing.Color.Black;
            this.lblNetTotal.Location = new System.Drawing.Point(630, 452);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(154, 22);
            this.lblNetTotal.TabIndex = 79;
            this.lblNetTotal.Text = "Q 99999.99";
            this.lblNetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(710, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 78;
            this.label9.Text = "Total neto:";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.ColumnHeadersHeight = 35;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.Color.White;
            this.dgvData.Location = new System.Drawing.Point(12, 135);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.RowTemplate.Height = 30;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(772, 218);
            this.dgvData.TabIndex = 80;
            // 
            // rbPercentage
            // 
            this.rbPercentage.AutoSize = true;
            this.rbPercentage.Checked = true;
            this.rbPercentage.Location = new System.Drawing.Point(54, 29);
            this.rbPercentage.Name = "rbPercentage";
            this.rbPercentage.Size = new System.Drawing.Size(35, 18);
            this.rbPercentage.TabIndex = 49;
            this.rbPercentage.TabStop = true;
            this.rbPercentage.Text = "%";
            this.rbPercentage.UseVisualStyleBackColor = true;
            // 
            // rbAmount
            // 
            this.rbAmount.AutoSize = true;
            this.rbAmount.Location = new System.Drawing.Point(14, 29);
            this.rbAmount.Name = "rbAmount";
            this.rbAmount.Size = new System.Drawing.Size(33, 18);
            this.rbAmount.TabIndex = 48;
            this.rbAmount.Text = "Q";
            this.rbAmount.UseVisualStyleBackColor = true;
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(796, 543);
            this.Controls.Add(this.lblNetTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbDiscount);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.lblNoData);
            this.Controls.Add(this.gbNew_Edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvData);
            this.Font = new System.Drawing.Font("Arial", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAdd_KeyDown);
            this.gbNew_Edit.ResumeLayout(false);
            this.gbNew_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.gbDiscount.ResumeLayout(false);
            this.tcDiscount.ResumeLayout(false);
            this.tpTotal.ResumeLayout(false);
            this.tpTotal.PerformLayout();
            this.tpUnit.ResumeLayout(false);
            this.tpUnit.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNew_Edit;
        private System.Windows.Forms.Button btnSelectSaler;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbDiscount;
        private System.Windows.Forms.TabControl tcDiscount;
        private System.Windows.Forms.TabPage tpTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TabPage tpUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Button btnRemoveDiscount;
        private System.Windows.Forms.Button btnAplyDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalInLetters;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.RadioButton rbPercentage;
        private System.Windows.Forms.RadioButton rbAmount;
    }
}