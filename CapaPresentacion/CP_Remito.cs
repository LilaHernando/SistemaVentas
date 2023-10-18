using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agrego las capas a utilizar
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Properties;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class CP_Remito : Form
    {
        public CP_Remito()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CP_Remito_Load(object sender, EventArgs e)         //Metodo LOAD, precarga los datos antes de mostrar el formulario.
        {
            List<CE_Remito> listaRemitos = new CN_Remito().Listar();    //Instancio una lista de objetos denominada listaremitos, que proviene del metodo Listar que ya contiene enlistado a los objetos en la capa NEGOCIO.

            foreach (CE_Remito cE_Remito in listaRemitos)               //Ciclo foreach que me permite traer varios objetos de varios tipos de datos.
            {
                tablaRemito.Rows.Add(new object[]{                      //[nombretabla].[objeto].[funcion](new Object).
                    
                    cE_Remito.iden,
                    cE_Remito.nombreSucursal,
                    cE_Remito.estadoRemito,
                    cE_Remito.idOperacion,
                    cE_Remito.numero,
                    cE_Remito.letra,
                    cE_Remito.tipoRemito,
                    cE_Remito.fechaRemito

                    });

            }
        }

        private void TablaRemitos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Titulo1_Click(object sender, EventArgs e)
        {

        }
    }
}
