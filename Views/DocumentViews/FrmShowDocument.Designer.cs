
namespace Views.DocumentViews
{
    partial class FrmShowDocument
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
            this.crvDocument = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvDocument
            // 
            this.crvDocument.ActiveViewIndex = -1;
            this.crvDocument.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDocument.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDocument.DisplayBackgroundEdge = false;
            this.crvDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDocument.Location = new System.Drawing.Point(0, 0);
            this.crvDocument.Name = "crvDocument";
            this.crvDocument.ShowCloseButton = false;
            this.crvDocument.ShowGroupTreeButton = false;
            this.crvDocument.ShowLogo = false;
            this.crvDocument.ShowParameterPanelButton = false;
            this.crvDocument.ShowRefreshButton = false;
            this.crvDocument.Size = new System.Drawing.Size(947, 691);
            this.crvDocument.TabIndex = 0;
            this.crvDocument.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmShowDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 691);
            this.Controls.Add(this.crvDocument);
            this.Name = "FrmShowDocument";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDocument;
    }
}