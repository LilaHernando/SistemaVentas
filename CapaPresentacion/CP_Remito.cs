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
        //------------------ PRECARGA --------------------
        private void CP_Remito_Load(object sender, EventArgs e)         //Metodo LOAD, precarga los datos antes de mostrar el formulario.
        {
            LimpiarCampos();    //Limpia los campos
            Listar();       //Lista los remitos
            CrearNumeroRemito(); //Actualiza el numero de remito para el siguiente remito a generar.
            btnLimpiar.Enabled = false;


            //------------------ LISTA SUCURSAL ------------------
            List<CE_Sucursal> listarSucursal = new CN_Sucursal().ListarSucursal();

            foreach (CE_Sucursal cE_Sucursal in listarSucursal)               
            {
              
                cbSucursal.Items.Add(new OpcionCombo { Texto = cE_Sucursal.Descripcion, Valor = cE_Sucursal.iden });

            }
            cbSucursal.DisplayMember = "Texto";
            cbSucursal.ValueMember = "Valor";


            //------------------ LISTA ESTADO --------------------
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

        //------------------ LISTA TABLA --------------------
        private void Listar()
        {
            List<CE_Remito> listaRemitos = new CN_Remito().Listar();    //Instancio una lista de objetos denominada listaremitos, que proviene del metodo Listar que ya contiene enlistado a los objetos en la capa NEGOCIO.

            foreach (CE_Remito cE_Remito in listaRemitos)               //Ciclo foreach que me permite traer varios objetos de varios tipos de datos.
            {
                tablaRemito.Rows.Add(new object[]{                      //[nombretabla].[objeto].[funcion](new Object).
                    
                    cE_Remito.iden,
                    cE_Remito.Sucursal.Descripcion,
                    cE_Remito.estadoRemito.descripcion,
                    cE_Remito.idOperacion,
                    cE_Remito.numero,
                    cE_Remito.letra,
                    cE_Remito.tipoRemito,
                    cE_Remito.fechaRemito
                });
            }
        }


        //------------------ METODOS Y EVENTOOS --------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            var idOpRemitos =                                                       //Declaro una variable
                (from DataGridViewRow rows in tablaRemito.Rows                      //Indico de donde proviene la collecion de datos para la variable local rows.
                 where rows.Cells["idOperacion"].Value.ToString() == txtIDOP.Text   //Donde evalua cada celda de mi colección rows, con el valor ingresado en el campo txtIDOP del fomulario.
                 select rows).FirstOrDefault();                                     //Selecciona en rows la primera coincidencia y la almacena en idOpRemitos.
            if (idOpRemitos != null)                                                //Si encontró un valor, idOpRemitos viene distinto de NULL, caso contrario no encontró coincidencia y pasamos al ELSE.
            {
                MessageBox.Show("Ya existe un remito con el ID de Operación");
            }
            else
            {
                bool resultado = new CN_Remito().VerFactura(Convert.ToInt32(txtIDOP.Text), out message);    //resultado va a ser igual a un entero, de valor 1 o 0, hacia el SP.
                if (resultado)
                {
                    MessageBox.Show("Existe una factura pendiente de remito");
                    btnGuardar.Enabled = true;
                    btnLimpiar.Enabled = true;
                    cbSucursal.Enabled = true;
                    NumRemito.Enabled = true;
                    cbEstado.Enabled = true;
                    NumRemito.Enabled = true;
                    tipoRem.Enabled = true;
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
                //basura
            //bool resultadoOp = false;
            //foreach (DataGridViewRow rows in tablaRemito.Rows)
            //{
            //    if (rows.Cells["idOperacion"].Value.ToString() == txtIDOP.Text)   ¡¡METODO SIN USAR LINQ1!!
            //    {
            //        MessageBox.Show("Se encontró un ID");
            //        resultadoOp = true;
            //        break;
            //    }


            //}
            //if (!resultadoOp)
            //{
            //    MessageBox.Show("No se encontró un ID");
            //}
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Remito Remito = new CE_Remito()
            {
                Sucursal = new CE_Sucursal()
                {
                    iden = Convert.ToInt32(((OpcionCombo)cbSucursal.SelectedItem).Valor)
                },
                estadoRemito = new CE_Estado()
                {

                    iden = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).Valor)
                },
                idOperacion = Convert.ToInt32(txtIDOP.Text),
                numero = Convert.ToInt32(NumRemito.Text),
                letra = Convert.ToChar(letraRem.Text),
                tipoRemito = Convert.ToString(tipoRem.Text),
                fechaRemito = Convert.ToDateTime(fechaRem.Text),
            };

            new CN_Remito().CrearRemito(Remito, out mensaje);
            if (mensaje == string.Empty)
            {
                tablaRemito.Rows.Clear();
                Listar();
                MessageBox.Show("Remito cargado con éxito");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtIDOP.Clear();
            btnGuardar.Enabled = false;
            cbSucursal.Enabled = false;
            NumRemito.Enabled = false;
            cbEstado.Enabled = false;
            NumRemito.Enabled = false;
            tipoRem.Enabled = false;
            fechaRem.Enabled = false;
            letraRem.Enabled = false;
            cbEstado.SelectedItem = null;
            cbSucursal.SelectedItem = null;
        }

        private void CrearNumeroRemito()
        {
            int UltimoIndex = tablaRemito.Rows.Count - 1;
            if (UltimoIndex < 0)
            { NumRemito.Text = "1"; }
            else
            {
                int UltimoRemito = Convert.ToInt32(tablaRemito.Rows[UltimoIndex].Cells["NumeroRemito"].Value);
                NumRemito.Text = Convert.ToString(UltimoRemito + 1);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void TxtIDOP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
