
namespace Views.CartViews
{
    partial class FrmCashOut
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCF = new System.Windows.Forms.Button();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.lblNit = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCashOut = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chbCreateShipment = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNotEspecified = new System.Windows.Forms.Button();
            this.dtpDelivery = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReceives = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.rbCounted = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCF);
            this.groupBox1.Controls.Add(this.btnSelectClient);
            this.groupBox1.Controls.Add(this.lblNit);
            this.groupBox1.Controls.Add(this.lblClient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // btnCF
            // 
            this.btnCF.ForeColor = System.Drawing.Color.Black;
            this.btnCF.Location = new System.Drawing.Point(316, 23);
            this.btnCF.Name = "btnCF";
            this.btnCF.Size = new System.Drawing.Size(48, 23);
            this.btnCF.TabIndex = 5;
            this.btnCF.TabStop = false;
            this.btnCF.Text = "C/F";
            this.btnCF.UseVisualStyleBackColor = true;
            this.btnCF.Click += new System.EventHandler(this.btnCF_Click);
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.ForeColor = System.Drawing.Color.Black;
            this.btnSelectClient.Location = new System.Drawing.Point(289, 62);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(75, 23);
            this.btnSelectClient.TabIndex = 4;
            this.btnSelectClient.TabStop = false;
            this.btnSelectClient.Text = "Seleccionar";
            this.btnSelectClient.UseVisualStyleBackColor = true;
            this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblNit.ForeColor = System.Drawing.Color.Black;
            this.lblNit.Location = new System.Drawing.Point(37, 52);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(24, 15);
            this.lblNit.TabIndex = 3;
            this.lblNit.Text = "C/F";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblClient.ForeColor = System.Drawing.Color.Black;
            this.lblClient.Location = new System.Drawing.Point(61, 26);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(121, 15);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "CONSUMIDOR FINAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 15F);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(17, 133);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 23);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Arial", 9F);
            this.lblPay.ForeColor = System.Drawing.Color.Black;
            this.lblPay.Location = new System.Drawing.Point(198, 118);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(52, 15);
            this.lblPay.TabIndex = 3;
            this.lblPay.Text = "Efectivo:";
            // 
            // txtMoney
            // 
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoney.Location = new System.Drawing.Point(201, 136);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(107, 20);
            this.txtMoney.TabIndex = 4;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Arial", 25F);
            this.lblChange.ForeColor = System.Drawing.Color.Black;
            this.lblChange.Location = new System.Drawing.Point(12, 183);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(118, 39);
            this.lblChange.TabIndex = 6;
            this.lblChange.Text = "Q 0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cambio:";
            // 
            // btnCashOut
            // 
            this.btnCashOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCashOut.BackColor = System.Drawing.Color.Green;
            this.btnCashOut.FlatAppearance.BorderSize = 0;
            this.btnCashOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashOut.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCashOut.ForeColor = System.Drawing.Color.White;
            this.btnCashOut.Location = new System.Drawing.Point(298, 181);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size(122, 36);
            this.btnCashOut.TabIndex = 7;
            this.btnCashOut.Text = "Cobrar";
            this.btnCashOut.UseVisualStyleBackColor = false;
            this.btnCashOut.Click += new System.EventHandler(this.btnCashOut_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(298, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 36);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(192, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "*Tecla Tab para calcular*";
            // 
            // chbCreateShipment
            // 
            this.chbCreateShipment.AutoSize = true;
            this.chbCreateShipment.Font = new System.Drawing.Font("Arial", 9F);
            this.chbCreateShipment.Location = new System.Drawing.Point(16, 233);
            this.chbCreateShipment.Name = "chbCreateShipment";
            this.chbCreateShipment.Size = new System.Drawing.Size(165, 19);
            this.chbCreateShipment.TabIndex = 10;
            this.chbCreateShipment.Text = "Crear envío de esta venta";
            this.chbCreateShipment.UseVisualStyleBackColor = true;
            this.chbCreateShipment.CheckedChanged += new System.EventHandler(this.chbCreateShipment_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnNotEspecified);
            this.groupBox2.Controls.Add(this.dtpDelivery);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtReceives);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDirection);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 0);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del envío";
            // 
            // btnNotEspecified
            // 
            this.btnNotEspecified.ForeColor = System.Drawing.Color.Black;
            this.btnNotEspecified.Location = new System.Drawing.Point(188, 73);
            this.btnNotEspecified.Name = "btnNotEspecified";
            this.btnNotEspecified.Size = new System.Drawing.Size(36, 23);
            this.btnNotEspecified.TabIndex = 13;
            this.btnNotEspecified.TabStop = false;
            this.btnNotEspecified.Text = "N/A";
            this.btnNotEspecified.UseVisualStyleBackColor = true;
            this.btnNotEspecified.Click += new System.EventHandler(this.btnNotEspecified_Click);
            // 
            // dtpDelivery
            // 
            this.dtpDelivery.Font = new System.Drawing.Font("Arial", 9F);
            this.dtpDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDelivery.Location = new System.Drawing.Point(9, 116);
            this.dtpDelivery.Name = "dtpDelivery";
            this.dtpDelivery.Size = new System.Drawing.Size(119, 21);
            this.dtpDelivery.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fecha de entrega:";
            // 
            // txtReceives
            // 
            this.txtReceives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceives.Location = new System.Drawing.Point(9, 75);
            this.txtReceives.Name = "txtReceives";
            this.txtReceives.Size = new System.Drawing.Size(173, 20);
            this.txtReceives.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Recibe:";
            // 
            // txtDirection
            // 
            this.txtDirection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirection.Location = new System.Drawing.Point(9, 34);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(215, 20);
            this.txtDirection.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbCredit);
            this.groupBox3.Controls.Add(this.rbCounted);
            this.groupBox3.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox3.Location = new System.Drawing.Point(324, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(96, 66);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de pago";
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.ForeColor = System.Drawing.Color.Black;
            this.rbCredit.Location = new System.Drawing.Point(12, 37);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(59, 18);
            this.rbCredit.TabIndex = 32;
            this.rbCredit.Text = "Credito";
            this.rbCredit.UseVisualStyleBackColor = true;
            // 
            // rbCounted
            // 
            this.rbCounted.AutoSize = true;
            this.rbCounted.Checked = true;
            this.rbCounted.ForeColor = System.Drawing.Color.Black;
            this.rbCounted.Location = new System.Drawing.Point(12, 19);
            this.rbCounted.Name = "rbCounted";
            this.rbCounted.Size = new System.Drawing.Size(65, 18);
            this.rbCounted.TabIndex = 31;
            this.rbCounted.TabStop = true;
            this.rbCounted.Text = "Contado";
            this.rbCounted.UseVisualStyleBackColor = true;
            this.rbCounted.CheckedChanged += new System.EventHandler(this.rbCounted_CheckedChanged);
            // 
            // FrmCashOut
            // 
            this.AcceptButton = this.btnCashOut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(432, 271);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chbCreateShipment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCashOut);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "FrmCashOut";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrar";
            this.Load += new System.EventHandler(this.FrmCachOut_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCashOut;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCF;
        public System.Windows.Forms.Label lblNit;
        public System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbCreateShipment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtReceives;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDelivery;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNotEspecified;
        public System.Windows.Forms.TextBox txtDirection;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.RadioButton rbCounted;
    }
}