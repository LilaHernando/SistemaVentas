using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void CP_Remito_Load(object sender, EventArgs e)         //Metodo LOAD, precarga los datos antes de mostrar el formulario.
        {
            //------------------ LISTA REMITOS ------------------

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

            //------------------ LISTA SUCURSAL ------------------

            List<CE_Sucursal> listarSucursal = new CN_Sucursal().ListarSucursal();

            foreach (CE_Sucursal cE_Sucursal in listarSucursal)               
            {
                string descripcion = cE_Sucursal.Descripcion;
                cbSucursal.Items.Add(new OpcionCombo { Texto = descripcion, Valor = descripcion });

            }
            cbSucursal.DisplayMember = "Texto";
            cbSucursal.ValueMember = "Valor";

            //------------------ LISTA ESTADO ------------------

            List<CE_Estado> listarEstado = new CN_Estado().ListarEstado();

            foreach (CE_Estado cE_Estado in listarEstado)
            {
                string descripcion = cE_Estado.descripcion;
                int iden = cE_Estado.iden;
                cbEstado.Items.Add(new OpcionCombo { Texto = descripcion, Valor = iden });
            }
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool resultadoOp = false;
            foreach (DataGridViewRow rows in tablaRemito.Rows)
            {
                if (rows.Cells["idOperacion"].Value.ToString() == txtIDOP.Text)
                {
                    MessageBox.Show("Se encontró un ID");
                    resultadoOp = true;
                    break;
                }


            }
            if (!resultadoOp)
            {
                MessageBox.Show("No se encontró un ID");
            }
        }
    }
}
