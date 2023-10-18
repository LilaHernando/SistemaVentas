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
using FontAwesome.Sharp;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class FormPreventa : Form
    {
        private bool addingDollarSign = true;
        private static IconMenuItem MenuActivo = null;
        private static Form FormActivo = null;
        private int DniCliente = 0; /* Atributo usado en el método btnBuscarCliente_Click()
                                     * para obtener idCliente en el metodo de agregar*/
        public FormPreventa()
        {
            InitializeComponent();
        }

        private void FormPreventa_Load(object sender, EventArgs e)
        {
            listarPreventas();
            listarSucursal(cbbSucursal);
            listarEstado(cbbEstado);
        }

        public void listarPreventas()
        {
            List<CE_Preventa> listPreventas = new CN_Preventa().listar_Preventas();
            foreach (CE_Preventa p in listPreventas)
            {
                string estado = (p.Baja == 0) ? "Inactivo" : "Activo";
                string fechaFormateada = p.Fecha.ToString("yyyy/MM/dd");

                dgvDataPreventa.Rows.Add(new Object[]{
                    p.Numero,
                    fechaFormateada,
                    "$"+p.Monto,
                    p.CE_Cliente.Nombre +" "+p.CE_Cliente.Apellido,
                    p.CE_Surcusal.Descripcion,
                    p.IdOperacion,
                    estado
                });
            }
        }
        
        public void listarSucursal(ComboBox cbbSucursal)
        {
            List<CE_Sucursal> listSucursales = new CN_Preventa().Listar_Sucursales();
            cbbSucursal.DataSource = listSucursales;
            cbbSucursal.DisplayMember = "Descripcion";
            cbbSucursal.ValueMember = "Id";
            cbbSucursal.SelectedIndex = -1;

        }

        public void listarEstado(ComboBox cbb)
        {
            cbb.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activa" });
            cbb.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactiva" });
            cbb.DisplayMember = "Texto";
            cbb.ValueMember = "Valor";
            cbb.SelectedIndex = 0;
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Cliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    DniCliente = Convert.ToInt32( modal._Cliente.Dni);
                    txtCliente.Text = modal._Cliente.Nombre+" "+modal._Cliente.Apellido;
                }
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '-' && ((TextBox)sender).SelectionStart == 0)
            {
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OK;
            CN_Preventa cN_preventa = new CN_Preventa();
            if (VerificarVacio(txtMonto.Text,txtDate.Text,txtCliente.Text))
            {
                CE_Preventa PreventaCreada = crearPreventa();
                cN_preventa.InsertarPreventa(PreventaCreada);
                dgvDataPreventa.Rows.Clear();
                listarPreventas();
                cbbSucursal.Items.Clear();
                LimpiarCampos();
                MessageBox.Show("Preventa registrada correctamente", "Estado de registro", botones, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un elemento en el ComboBox antes de registrar.", "Campos Incompletos",botones ,MessageBoxIcon.Error);
            }

        }

        public CE_Preventa crearPreventa()
        {
            Random RandomOperacion = new Random();
            CN_Preventa cN_preventa = new CN_Preventa();
            CE_Sucursal selectedSucursal = (CE_Sucursal)cbbSucursal.SelectedItem;
            CE_Preventa Preventa = new CE_Preventa()

            {
                
                //Id_Sucursal = Convert.ToInt32(((OpcionCombo)cbbSucursal.SelectedItem).Valor),
                
                Id_Sucursal = selectedSucursal.Id,
                Id_Cliente = cN_preventa.ObtenerIdCliente(DniCliente),
                Fecha = Convert.ToDateTime(txtDate.Text),
                Numero = RandomOperacion.Next(7, 10000),
                Baja = Convert.ToInt32(((OpcionCombo)cbbEstado.SelectedItem).Valor),
                Monto = Convert.ToDecimal(txtMonto.Text),
                IdOperacion = RandomOperacion.Next(6, 10000)
            };
            
            return Preventa;
        }

        public void LimpiarCampos()
        {
            txtMonto.Text = "";
            txtCliente.Text = "";
            cbbEstado.Items.Clear();
            listarSucursal(cbbSucursal);
            listarEstado(cbbEstado);
        }

        public Boolean VerificarVacio(String txtMonto, String txtDate, String txtCliente)
        {
            if( string.IsNullOrEmpty(txtMonto)|| string.IsNullOrEmpty(txtDate) ||
                string.IsNullOrEmpty(txtCliente) || cbbSucursal.SelectedIndex == -1 || cbbEstado.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }

    
}
