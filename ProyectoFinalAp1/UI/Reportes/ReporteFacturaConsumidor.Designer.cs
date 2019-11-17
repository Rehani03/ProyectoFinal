namespace ProyectoFinalAp1.UI.Reportes
{
    partial class ReporteFacturaConsumidor
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
            this.ReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReportViewer
            // 
            this.ReportViewer.ActiveViewIndex = -1;
            this.ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.Size = new System.Drawing.Size(714, 422);
            this.ReportViewer.TabIndex = 0;
            this.ReportViewer.Load += new System.EventHandler(this.CrystalReportViewer1_Load);
            // 
            // ReporteFacturaConsumidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 422);
            this.Controls.Add(this.ReportViewer);
            this.Name = "ReporteFacturaConsumidor";
            this.Text = "Factura a Consumidor-ButterSoft";
            this.Load += new System.EventHandler(this.ReporteFacturaConsumidor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewer;
    }
}