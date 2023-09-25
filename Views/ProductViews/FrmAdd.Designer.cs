
namespace Views.ProductViews
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProvider = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGain = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.rbPercentage = new System.Windows.Forms.RadioButton();
            this.rbAmount = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMeasure = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnEditCode = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnAddProvider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código:";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCode.Location = new System.Drawing.Point(87, 54);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(203, 23);
            this.txtCode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nuevo producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Producto:";
            // 
            // txtProduct
            // 
            this.txtProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduct.Font = new System.Drawing.Font("Arial", 10F);
            this.txtProduct.Location = new System.Drawing.Point(87, 93);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(527, 23);
            this.txtProduct.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Marca:";
            // 
            // txtBrand
            // 
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrand.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBrand.Location = new System.Drawing.Point(87, 132);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(173, 23);
            this.txtBrand.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Categoría:";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Arial", 10F);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(97, 210);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(163, 24);
            this.cbCategory.TabIndex = 10;
            this.cbCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LockedField);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(309, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Proveedor:";
            // 
            // cbProvider
            // 
            this.cbProvider.Font = new System.Drawing.Font("Arial", 10F);
            this.cbProvider.FormattingEnabled = true;
            this.cbProvider.Location = new System.Drawing.Point(393, 210);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(163, 24);
            this.cbProvider.TabIndex = 11;
            this.cbProvider.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LockedField);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Precio de compra:";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurchasePrice.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPurchasePrice.Location = new System.Drawing.Point(141, 171);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(68, 23);
            this.txtPurchasePrice.TabIndex = 7;
            this.txtPurchasePrice.Leave += new System.EventHandler(this.CalculateGain_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(219, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Ganancia:";
            // 
            // txtGain
            // 
            this.txtGain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGain.Font = new System.Drawing.Font("Arial", 10F);
            this.txtGain.Location = new System.Drawing.Point(296, 171);
            this.txtGain.Name = "txtGain";
            this.txtGain.Size = new System.Drawing.Size(68, 23);
            this.txtGain.TabIndex = 8;
            this.txtGain.Leave += new System.EventHandler(this.CalculateGain_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(414, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Precio de venta:";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalePrice.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSalePrice.Location = new System.Drawing.Point(531, 171);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(68, 23);
            this.txtSalePrice.TabIndex = 9;
            // 
            // rbPercentage
            // 
            this.rbPercentage.AutoSize = true;
            this.rbPercentage.Checked = true;
            this.rbPercentage.Font = new System.Drawing.Font("Arial", 10F);
            this.rbPercentage.Location = new System.Drawing.Point(370, 162);
            this.rbPercentage.Name = "rbPercentage";
            this.rbPercentage.Size = new System.Drawing.Size(38, 20);
            this.rbPercentage.TabIndex = 37;
            this.rbPercentage.TabStop = true;
            this.rbPercentage.Text = "%";
            this.rbPercentage.UseVisualStyleBackColor = true;
            this.rbPercentage.CheckedChanged += new System.EventHandler(this.CalculateGain_Leave);
            // 
            // rbAmount
            // 
            this.rbAmount.AutoSize = true;
            this.rbAmount.Font = new System.Drawing.Font("Arial", 10F);
            this.rbAmount.Location = new System.Drawing.Point(371, 181);
            this.rbAmount.Name = "rbAmount";
            this.rbAmount.Size = new System.Drawing.Size(37, 20);
            this.rbAmount.TabIndex = 38;
            this.rbAmount.Text = "Q";
            this.rbAmount.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(419, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Medida:";
            // 
            // cbMeasure
            // 
            this.cbMeasure.Font = new System.Drawing.Font("Arial", 10F);
            this.cbMeasure.FormattingEnabled = true;
            this.cbMeasure.Items.AddRange(new object[] {
            "UNIDAD",
            "DOCENA",
            "CENTENA",
            "ONZA",
            "LIBRA",
            "MILIGRAMO",
            "GRAMO",
            "KILOGRAMO",
            "MILIMETRO",
            "PULGADA",
            "CENTIMETRO",
            "METRO",
            "YARDA",
            "PIE"});
            this.cbMeasure.Location = new System.Drawing.Point(489, 131);
            this.cbMeasure.Name = "cbMeasure";
            this.cbMeasure.Size = new System.Drawing.Size(125, 24);
            this.cbMeasure.TabIndex = 6;
            this.cbMeasure.Text = "UNIDAD";
            this.cbMeasure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LockedField);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(350, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 28);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(489, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 28);
            this.btnSave.TabIndex = 41;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(266, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Existencia:";
            // 
            // txtStock
            // 
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Font = new System.Drawing.Font("Arial", 10F);
            this.txtStock.Location = new System.Drawing.Point(345, 132);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(68, 23);
            this.txtStock.TabIndex = 5;
            // 
            // btnEditCode
            // 
            this.btnEditCode.AutoSize = true;
            this.btnEditCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditCode.FlatAppearance.BorderSize = 0;
            this.btnEditCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCode.ForeColor = System.Drawing.Color.White;
            this.btnEditCode.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCode.Image")));
            this.btnEditCode.Location = new System.Drawing.Point(296, 53);
            this.btnEditCode.Name = "btnEditCode";
            this.btnEditCode.Size = new System.Drawing.Size(68, 24);
            this.btnEditCode.TabIndex = 45;
            this.btnEditCode.Text = "Editar";
            this.btnEditCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditCode.UseVisualStyleBackColor = false;
            this.btnEditCode.Visible = false;
            this.btnEditCode.Click += new System.EventHandler(this.btnEditCode_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.Location = new System.Drawing.Point(266, 210);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(26, 24);
            this.btnAddCategory.TabIndex = 46;
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnAddProvider
            // 
            this.btnAddProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddProvider.FlatAppearance.BorderSize = 0;
            this.btnAddProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProvider.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAddProvider.ForeColor = System.Drawing.Color.White;
            this.btnAddProvider.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProvider.Image")));
            this.btnAddProvider.Location = new System.Drawing.Point(562, 210);
            this.btnAddProvider.Name = "btnAddProvider";
            this.btnAddProvider.Size = new System.Drawing.Size(26, 24);
            this.btnAddProvider.TabIndex = 47;
            this.btnAddProvider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProvider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProvider.UseVisualStyleBackColor = false;
            this.btnAddProvider.Click += new System.EventHandler(this.btnAddProvider_Click);
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(626, 301);
            this.Controls.Add(this.btnAddProvider);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnEditCode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbMeasure);
            this.Controls.Add(this.rbAmount);
            this.Controls.Add(this.rbPercentage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbProvider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAdd_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbProvider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.RadioButton rbPercentage;
        private System.Windows.Forms.RadioButton rbAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMeasure;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStock;
        public System.Windows.Forms.TextBox txtCode;
        public System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnAddProvider;
        public System.Windows.Forms.Button btnEditCode;
    }
}