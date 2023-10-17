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
        private static IconMenuItem MenuActivo = null; //Atributo de tipo Static que va a almacenar el Menu seleccionado por el Usuario
        private static Form FormActivo = null; //Atributo de tipo Static que va a almacenar el Formulario seleccionado por el Usuario respecto del Menu

        public FormPreventa()
        {
            InitializeComponent();
        }

        private void FormPreventa_Load(object sender, EventArgs e)
        {
            /*Listar Preventas*/
            List<CE_Preventa> listPreventas = new CN_Preventa().listar_Preventas();

            listarEstado(cbbEstado);

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

                cbbSucursal.Items.Add(new OpcionCombo() { Valor = p.CE_Surcusal.Id, Texto = p.CE_Surcusal.Descripcion });
                cbbSucursal.DisplayMember = "Texto";
                cbbSucursal.ValueMember = "Valor";
                cbbSucursal.SelectedIndex = 0;
            }
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

    }
}
