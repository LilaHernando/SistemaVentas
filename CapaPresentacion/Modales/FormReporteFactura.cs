using CapaEntidad;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace CapaPresentacion.Modales
{
    public partial class FormReporteFactura : Form
    {
        CE_Usuario usuario = CE_Usuario.Instance;

        public FormReporteFactura()
        {
            InitializeComponent();
        }

        public void SolicitarIdFactura(int id)
        {
            string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            ReportDocument report = new ReportDocument();

            report.Load(userProfilePath + "\\source\\repos\\SistemaVentas\\CapaPresentacion\\Modales\\ReporteFactura.rpt");

            ParameterField idFactura = (ParameterField)report.ParameterFields["@iden"];
            ParameterField user = (ParameterField)report.ParameterFields["user"];

            ParameterDiscreteValue parameterValueId = new ParameterDiscreteValue();
            ParameterDiscreteValue parameterValueUser = new ParameterDiscreteValue();

            parameterValueId.Value = id;
            parameterValueUser.Value = usuario.Nombre + " " + usuario.Apellido;

            idFactura.CurrentValues.Add(parameterValueId);
            user.CurrentValues.Add(parameterValueUser);

            //string nombreArchivo = "factura.pdf";
            //String exportPath = "C:\\Documentos\\";

            //DiskFileDestinationOptions DFDO = new DiskFileDestinationOptions();
            //DFDO.DiskFileName = exportPath + nombreArchivo;

            //ExportOptions wordExportOptions = new ExportOptions();
            //wordExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            //wordExportOptions.ExportDestinationOptions = DFDO;
            //wordExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            //wordExportOptions.ExportFormatOptions = null;
            //report.Export(wordExportOptions);

            reporteFacturaView.ReportSource = report;

            reporteFacturaView.AllowedExportFormats = (int)(ViewerExportFormats.PdfFormat);
        }        
    }
}