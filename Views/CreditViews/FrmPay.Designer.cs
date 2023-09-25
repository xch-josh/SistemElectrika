
namespace Views.CreditViews
{
    partial class FrmPay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPayAll = new System.Windows.Forms.Button();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abonar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(125, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Saldo";
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Arial", 13F);
            this.lblBalance.ForeColor = System.Drawing.Color.Black;
            this.lblBalance.Location = new System.Drawing.Point(12, 133);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(264, 21);
            this.lblBalance.TabIndex = 30;
            this.lblBalance.Text = "lblBalance";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCredit
            // 
            this.lblCredit.Font = new System.Drawing.Font("Arial", 18F);
            this.lblCredit.ForeColor = System.Drawing.Color.Black;
            this.lblCredit.Location = new System.Drawing.Point(12, 83);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(264, 27);
            this.lblCredit.TabIndex = 32;
            this.lblCredit.Text = "lblCredit";
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(100, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Deuda inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Abonar";
            // 
            // txtPay
            // 
            this.txtPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPay.Location = new System.Drawing.Point(15, 180);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(93, 20);
            this.txtPay.TabIndex = 34;
            this.txtPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPay_KeyPress);
            this.txtPay.Leave += new System.EventHandler(this.txtPay_Leave);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Arial", 13F);
            this.lblChange.ForeColor = System.Drawing.Color.Black;
            this.lblChange.Location = new System.Drawing.Point(13, 231);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(91, 21);
            this.lblChange.TabIndex = 36;
            this.lblChange.Text = "lblChange";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Cambio";
            // 
            // btnPayAll
            // 
            this.btnPayAll.Location = new System.Drawing.Point(114, 180);
            this.btnPayAll.Name = "btnPayAll";
            this.btnPayAll.Size = new System.Drawing.Size(57, 20);
            this.btnPayAll.TabIndex = 37;
            this.btnPayAll.Text = "Todo";
            this.btnPayAll.UseVisualStyleBackColor = true;
            this.btnPayAll.Click += new System.EventHandler(this.btnPayAll_Click);
            // 
            // txtCash
            // 
            this.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCash.Location = new System.Drawing.Point(180, 180);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(93, 20);
            this.txtCash.TabIndex = 39;
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            this.txtCash.Leave += new System.EventHandler(this.txtCash_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(177, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Efectivo";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(82, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 28);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnFinalize
            // 
            this.btnFinalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalize.BackColor = System.Drawing.Color.Green;
            this.btnFinalize.FlatAppearance.BorderSize = 0;
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.ForeColor = System.Drawing.Color.White;
            this.btnFinalize.Location = new System.Drawing.Point(82, 261);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(125, 28);
            this.btnFinalize.TabIndex = 43;
            this.btnFinalize.TabStop = false;
            this.btnFinalize.Text = "Finalizar";
            this.btnFinalize.UseVisualStyleBackColor = false;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(162, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "*Tecla Tab para calcular*";
            // 
            // FrmPay
            // 
            this.AcceptButton = this.btnFinalize;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(288, 335);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPayAll);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmPay";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPayments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPayAll;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblBalance;
        public System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Label label4;
    }
}