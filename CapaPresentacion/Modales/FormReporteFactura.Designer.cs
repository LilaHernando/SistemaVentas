
namespace CapaPresentacion.Modales
{
    partial class FormReporteFactura
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
            this.reporteFacturaView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reporteFacturaView
            // 
            this.reporteFacturaView.ActiveViewIndex = -1;
            this.reporteFacturaView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reporteFacturaView.Cursor = System.Windows.Forms.Cursors.Default;
            this.reporteFacturaView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporteFacturaView.Location = new System.Drawing.Point(0, 0);
            this.reporteFacturaView.Name = "reporteFacturaView";
            this.reporteFacturaView.Size = new System.Drawing.Size(800, 450);
            this.reporteFacturaView.TabIndex = 0;
            // 
            // FormReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reporteFacturaView);
            this.Name = "FormReporteFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporteFactura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reporteFacturaView;
    }
}