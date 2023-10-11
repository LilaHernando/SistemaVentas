using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FormPreventa : Form
    {
        public FormPreventa()
        {
            InitializeComponent();
        }

        private void FormPreventa_Load(object sender, EventArgs e)
        {
            /*Listar Preventas*/
            List<CE_Preventa> listPreventas = new CN_Preventa().listar_Preventas();
           
            foreach (CE_Preventa p in listPreventas)
            {
                string estado = (p.Baja == 0) ? "Inactivo" : "Activo";
                string fechaFormateada = p.Fecha.ToString("yyyy/MM/dd");

                dgvDataPreventa.Rows.Add(new Object[]{
                    p.Numero,
                    fechaFormateada,
                    "$"+p.Monto,
                    p.CE_Cliente.nombre +" "+p.CE_Cliente.apellido,
                    p.CE_Surcusal.Descripcion,
                    p.IdOperacion,
                    estado
                });
            }
        }
        
    }
}
