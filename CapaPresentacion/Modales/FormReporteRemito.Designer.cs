
namespace CapaPresentacion.Modales
{
    partial class FormReporteRemito
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
            this.reporteRemitoView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reporteRemitoView
            // 
            this.reporteRemitoView.ActiveViewIndex = -1;
            this.reporteRemitoView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reporteRemitoView.Cursor = System.Windows.Forms.Cursors.Default;
            this.reporteRemitoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporteRemitoView.Location = new System.Drawing.Point(0, 0);
            this.reporteRemitoView.Name = "reporteRemitoView";
            this.reporteRemitoView.Size = new System.Drawing.Size(800, 450);
            this.reporteRemitoView.TabIndex = 0;
            // 
            // FormReporteRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reporteRemitoView);
            this.Name = "FormReporteRemito";
            this.Text = "FormReporteRemito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reporteRemitoView;
    }
}