
namespace Views.CartViews
{
    partial class IbInsertByCode
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rbAmount = new System.Windows.Forms.RadioButton();
            this.rbPercentage = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNetSubtotal = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAppliedDiscount = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(399, 37);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Agregar al carrito";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(125, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 31);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(125, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 31);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Cantidad:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQuantity.DecimalPlaces = 2;
            this.nudQuantity.Font = new System.Drawing.Font("Arial", 12F);
            this.nudQuantity.Location = new System.Drawing.Point(110, 99);
            this.nudQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 26);
            this.nudQuantity.TabIndex = 1;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Precio:";
            // 
            // nudPrice
            // 
            this.nudPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Font = new System.Drawing.Font("Arial", 12F);
            this.nudPrice.Location = new System.Drawing.Point(110, 137);
            this.nudPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 26);
            this.nudPrice.TabIndex = 2;
            this.nudPrice.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // nudDiscount
            // 
            this.nudDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDiscount.DecimalPlaces = 2;
            this.nudDiscount.Font = new System.Drawing.Font("Arial", 12F);
            this.nudDiscount.Location = new System.Drawing.Point(110, 213);
            this.nudDiscount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(120, 26);
            this.nudDiscount.TabIndex = 3;
            this.nudDiscount.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 30);
            this.label3.TabIndex = 44;
            this.label3.Text = "Descuento\r\n(unidad):";
            // 
            // rbAmount
            // 
            this.rbAmount.AutoSize = true;
            this.rbAmount.Location = new System.Drawing.Point(110, 245);
            this.rbAmount.Name = "rbAmount";
            this.rbAmount.Size = new System.Drawing.Size(34, 19);
            this.rbAmount.TabIndex = 4;
            this.rbAmount.Text = "Q";
            this.rbAmount.UseVisualStyleBackColor = true;
            // 
            // rbPercentage
            // 
            this.rbPercentage.AutoSize = true;
            this.rbPercentage.Checked = true;
            this.rbPercentage.Location = new System.Drawing.Point(150, 245);
            this.rbPercentage.Name = "rbPercentage";
            this.rbPercentage.Size = new System.Drawing.Size(36, 19);
            this.rbPercentage.TabIndex = 5;
            this.rbPercentage.TabStop = true;
            this.rbPercentage.Text = "%";
            this.rbPercentage.UseVisualStyleBackColor = true;
            this.rbPercentage.CheckedChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "Subtotal neto:";
            // 
            // lblNetSubtotal
            // 
            this.lblNetSubtotal.AutoSize = true;
            this.lblNetSubtotal.Font = new System.Drawing.Font("Arial", 20F);
            this.lblNetSubtotal.Location = new System.Drawing.Point(236, 172);
            this.lblNetSubtotal.Name = "lblNetSubtotal";
            this.lblNetSubtotal.Size = new System.Drawing.Size(97, 32);
            this.lblNetSubtotal.TabIndex = 49;
            this.lblNetSubtotal.Text = "Q 0.00";
            // 
            // lblProduct
            // 
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProduct.Font = new System.Drawing.Font("Arial", 11F);
            this.lblProduct.Location = new System.Drawing.Point(0, 37);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(399, 59);
            this.lblProduct.TabIndex = 50;
            this.lblProduct.Text = "Producto";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "Descuento total aplicado:";
            // 
            // lblAppliedDiscount
            // 
            this.lblAppliedDiscount.AutoSize = true;
            this.lblAppliedDiscount.Font = new System.Drawing.Font("Arial", 15F);
            this.lblAppliedDiscount.Location = new System.Drawing.Point(236, 114);
            this.lblAppliedDiscount.Name = "lblAppliedDiscount";
            this.lblAppliedDiscount.Size = new System.Drawing.Size(71, 23);
            this.lblAppliedDiscount.TabIndex = 52;
            this.lblAppliedDiscount.Text = "Q 0.00";
            // 
            // nudStock
            // 
            this.nudStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudStock.DecimalPlaces = 2;
            this.nudStock.Font = new System.Drawing.Font("Arial", 12F);
            this.nudStock.Location = new System.Drawing.Point(110, 175);
            this.nudStock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(120, 26);
            this.nudStock.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 54;
            this.label6.Text = "Existencias:";
            // 
            // IbInsertByCode
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(399, 358);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAppliedDiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblNetSubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbPercentage);
            this.Controls.Add(this.rbAmount);
            this.Controls.Add(this.nudDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IbInsertByCode";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.IbInsertByCode_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IbInsertByCode_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown nudPrice;
        public System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbAmount;
        private System.Windows.Forms.RadioButton rbPercentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNetSubtotal;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAppliedDiscount;
        public System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label label6;
    }
}