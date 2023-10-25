using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class FormFactura : Form
    {
        Random random = new Random();
        public List<CE_Factura> ListaFacturas;
        public List<CE_Preventa> ListaPreventas;
        public int idSucursal { get; set; }
        public string descripcionSucursal { get; set; }


        public FormFactura() { InitializeComponent(); }

        private bool VerificarCampos(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = (TextBox)c;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false;
                    }
                }

                else if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    if (comboBox.SelectedIndex == -1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void LimpiarCampos()
        {

            BoxNombreUsuario.Clear();
            BoxIdUsuario.Clear();
            BoxIdOperacion.SelectedItem = null;
            BoxTipoFactura.SelectedItem = null;
            BoxSucursal.Clear();
            BoxEstado.Clear();
            BoxNumeroFactura.Clear();
            BoxMonto.Clear();

            BoxIdOperacion.Text = "";
            BoxTipoFactura.Text = "";
            BoxSucursal.Text = "";
            BoxEstado.Text = "";
            BoxMonto.Text = "";
            BoxNumeroFactura.Text = "";

        }
        private void ListarFacturas(int idOperacion)
        {
            ListaFacturas = new CN_Factura().ListarFacturas(idOperacion);

            foreach (CE_Factura factura in ListaFacturas)
            {
                GridFacturas.Rows.Add(new object[] {

                    factura.CMP_Estado_iden == 1? "Pendiente" : (factura.CMP_Estado_iden == 2? "Anulado" : "Cofirmado"),
                    factura.FechaDeCarga,
                    factura.CE_Sucursal.Descripcion,
                    factura.IdOperacion,
                    factura.Letra,
                    factura.Numero,
                    factura.MontoTotal,
                });
            }
        }

        private void ListarPreventasPorDNI(int dni)
        {
            ListaPreventas = new CN_Factura().ObtenerPreventasPorDNI(dni);

            foreach (CE_Preventa preventa in ListaPreventas)
            {
                string IdOperacion = Convert.ToString(preventa.IdOperacion);

                BoxIdOperacion.Items.Add(new OpcionCombo { Texto = IdOperacion, Valor = IdOperacion });
            }
            BoxIdOperacion.DisplayMember = "Texto";
            BoxIdOperacion.ValueMember = "Valor";
        }

        private void CrearNumeroFactura()
        {
            int ultimoIndex = GridFacturas.Rows.Count - 1;
            if (ultimoIndex < 0) { BoxNumeroFactura.Text = "1"; }
            else
            {
            int ultimaFactura = Convert.ToInt32(GridFacturas.Rows[ultimoIndex].Cells["Numero"].Value);
            BoxNumeroFactura.Text = Convert.ToString(ultimaFactura + 1);
            }
        }
        private void CargarDatos(int IdOperacion, string entidad)
        {
            if (entidad == "preventa")
            {
                int indice = ListaPreventas.FindIndex(prev => prev.IdOperacion == Convert.ToInt32(IdOperacion));
                BoxSucursal.Text = ListaPreventas[indice].CE_Sucursal.Descripcion;
                BoxMonto.Text = Convert.ToString(ListaPreventas[indice].Monto);
                idSucursal = ListaPreventas[indice].CE_Sucursal.Id;
                descripcionSucursal = ListaPreventas[indice].CE_Sucursal.Descripcion;

            }
            else
            {
                BoxIdOperacion.Text = Convert.ToString(ListaFacturas[0].IdOperacion);
                BoxTipoFactura.Text = Convert.ToString(ListaFacturas[0].Letra);
                BoxSucursal.Text = ListaFacturas[0].CE_Sucursal.Descripcion;
                BoxEstado.Text = ListaFacturas[0].CMP_Estado_iden == 1 ? "Pendiente" : (ListaFacturas[0].CMP_Estado_iden == 2 ? "Anulado" : "Cofirmado");
                BoxNumeroFactura.Text = Convert.ToString(ListaFacturas[0].Numero);
                BoxMonto.Text = Convert.ToString(ListaFacturas[0].MontoTotal);
                BoxNombreUsuario.Text = $"{Convert.ToString(ListaFacturas[0].CE_Cliente.Nombre)}  {Convert.ToString(ListaFacturas[0].CE_Cliente.Apellido)}".ToUpper();
                BoxIdUsuario.Text = Convert.ToString(ListaFacturas[0].CE_Cliente.Dni);
            }
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
            
            //Listamos todas las facturas existentes en la DB
            ListarFacturas(0);
            CrearNumeroFactura();

            //Cargamos los tipos de Facturas
            BoxTipoFactura.Items.Add(new OpcionCombo { Texto = "A", Valor = "A" });
            BoxTipoFactura.Items.Add(new OpcionCombo { Texto = "B", Valor = "B" });
            BoxTipoFactura.DisplayMember = "Texto";
            BoxTipoFactura.ValueMember = "Valor";

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Cliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    AddBtn.Enabled = true;
                    BoxIdUsuario.Text = modal._Cliente.Dni;
                    BoxNombreUsuario.Text = $"{modal._Cliente.Nombre}  {modal._Cliente.Apellido}".ToUpper();
                    BoxEstado.Text = "Pendiente";

                }
            }
        }

        private void BoxIdUsuario_TextChanged(object sender, EventArgs e)
        {
            if (BoxIdUsuario.Text != "")
            {
                BoxIdOperacion.SelectedItem = null;
                BoxIdOperacion.Items.Clear();

                int boxDni = Convert.ToInt32(BoxIdUsuario.Text);

                ListarPreventasPorDNI(boxDni);
            }

        }

        private void BoxIdOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BoxIdOperacion.SelectedItem != null)
            {
                CargarDatos(Convert.ToInt32(BoxIdOperacion.Text), "preventa");
            }

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (VerificarCampos(GbRegistrar))
            {
                string mensaje = string.Empty;

                CE_Factura factura = new CE_Factura()
                {
                    Letra = Convert.ToChar(BoxTipoFactura.Text),
                    Numero = Convert.ToInt32(BoxNumeroFactura.Text),
                    MontoTotal = Convert.ToDecimal(BoxMonto.Text),
                    CMP_Estado_iden = 1,
                    IdOperacion = Convert.ToInt32(BoxIdOperacion.Text),
                    GN_Sucursal_iden = idSucursal,
                    FechaDeCarga = DateTime.Now,
                };

                new CN_Factura().CrearFactura(factura, out mensaje);

                if (mensaje != "") { MessageBox.Show(mensaje); }


                GridFacturas.Rows.Add(new object[] {

                    "Pendiente",
                    factura.FechaDeCarga,
                    descripcionSucursal,
                    factura.IdOperacion,
                    factura.Letra,
                    factura.Numero,
                    factura.MontoTotal,
                });

                GridFacturas.Refresh();
                LimpiarCampos();
                CrearNumeroFactura();

            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos para registrar una factura");

            }
        }

        private void GridFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            AddBtn.Enabled = false;
            LimpiarCampos();

            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;
            int IdOperacion = Convert.ToInt32(GridFacturas.Rows[iRow].Cells["IdOperacion"].Value.ToString());
            ListaFacturas = new CN_Factura().ListarFacturas(IdOperacion);

            CargarDatos(IdOperacion, "factura");
        }


    }
}
