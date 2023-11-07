using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class FormReporteRemito : Form
    {
        public FormReporteRemito()
        {
            InitializeComponent();
        }

        public void SolicitarIdRemito(int id)
        {
            string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            ReportDocument report = new ReportDocument();

            report.Load(userProfilePath + "\\source\\repos\\SistemaVentas\\CapaPresentacion\\Modales\\ReporteRemito.rpt");

            ParameterField idRemito = (ParameterField)report.ParameterFields["@iden"];

            ParameterDiscreteValue parameterValueId = new ParameterDiscreteValue();

            parameterValueId.Value = id;

            idRemito.CurrentValues.Add(parameterValueId);

            reporteRemitoView.ReportSource = report;

            reporteRemitoView.AllowedExportFormats = (int)(ViewerExportFormats.PdfFormat);
        }
    }
}
