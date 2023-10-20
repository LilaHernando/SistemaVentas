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
        private int NumeroPreventa;
        private int IdOperacion;
        private int IdPreventa;
        private int IdCliente;
        public FormPreventa()
        {
            InitializeComponent();
        }

        private void FormPreventa_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            txtCliente.Enabled = false;
            listarPreventas();
            listarSucursal(cbbSucursal);
            listarEstado(cbbEstado);
            iniciarCbbBuscar();
        }

        public void iniciarCbbBuscar()
        {
            cbbBusqueda.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Numero" });
            cbbBusqueda.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Cliente" });
            cbbBusqueda.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Sucursal" });
            cbbBusqueda.DisplayMember = "Texto";
            cbbBusqueda.ValueMember = "Valor";
            cbbBusqueda.SelectedIndex = -1;
        }

        public void listarPreventas()
        {
            List<CE_Preventa> listPreventas = new CN_Preventa().listar_Preventas();
            foreach (CE_Preventa p in listPreventas)
            {
                string estado = (p.Baja == 1) ? "Inactivo" : "Activo";
                string fechaFormateada = p.Fecha.ToString("yyyy/MM/dd");

                dgvDataPreventa.Rows.Add(new Object[]{
                    p.Numero,
                    fechaFormateada,
                    "$"+p.Monto,
                    p.CE_Cliente.Nombre +" "+p.CE_Cliente.Apellido,
                    p.CE_Surcusal.Descripcion,
                    p.IdOperacion,
                    estado,
                    "",
                    p.CE_Cliente.Id,
                    p.CE_Surcusal.Id,
                    p.IdPreventa
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
            cbb.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Activa" });
            cbb.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Inactiva" });
            cbb.DisplayMember = "Texto";
            cbb.ValueMember = "Valor";
            cbb.SelectedIndex = -1;
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
                    IdCliente = modal._Cliente.Id;
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
                //CE_Preventa PreventaCreada = crearPreventa();
                //cN_preventa.InsertarPreventa(PreventaCreada);
                dgvDataPreventa.Rows.Clear();
                listarPreventas();
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
                Id_Sucursal = selectedSucursal.Id,
                Id_Cliente = IdCliente,
                Fecha = Convert.ToDateTime(txtDate.Text),
                Numero = RandomOperacion.Next(7, 10000),
                Baja = Convert.ToInt32(((OpcionCombo)cbbEstado.SelectedItem).Valor),
                Monto = Convert.ToDecimal(txtMonto.Text),
                IdOperacion = RandomOperacion.Next(6, 10000)
            };
            
            return Preventa;
        }

        public Boolean VerificarVacio(String txtMonto, String txtDate, String txtCliente)
        {
           
                if (string.IsNullOrEmpty(txtMonto) || string.IsNullOrEmpty(txtDate) ||
                string.IsNullOrEmpty(txtCliente) || cbbEstado.SelectedIndex == -1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
        }

        
        public void SetearCamposPreventa(String fecha, String monto, String cliente, String estado, String sucursal )
        {
            txtDate.Value = DateTime.Parse(fecha);
            txtMonto.Text = monto;
            txtCliente.Text = cliente;
            cbbEstado.Text = estado;
            cbbSucursal.Text = sucursal;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OK;
            CN_Preventa cN_preventa = new CN_Preventa();
            try
            {
                if (VerificarVacio(txtMonto.Text, txtDate.Text, txtCliente.Text))
                {
                    CE_Preventa PreventaEdit = new CE_Preventa();
                    PreventaEdit.Numero = NumeroPreventa;
                    PreventaEdit.Monto = Convert.ToDecimal(txtMonto.Text);
                    PreventaEdit.Fecha = Convert.ToDateTime(txtDate.Value);
                    PreventaEdit.IdOperacion = IdOperacion;
                    PreventaEdit.Id_Cliente = IdCliente;
                    PreventaEdit.IdPreventa = IdPreventa;
                    PreventaEdit.Baja = ((OpcionCombo)cbbEstado.SelectedItem).Texto == "Activa" ? 0 : 1;
                    cN_preventa.InsertarPreventa(PreventaEdit);
                    dgvDataPreventa.Rows.Clear();
                    listarPreventas();
                    LimpiarCampos();
                    btnBuscarCliente.Enabled = true;
                    cbbSucursal.Enabled = true;
                    btnEditar.Enabled = false;
                    MessageBox.Show("Preventa actualizada correctamente", "Estado de actualización", botones, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos y seleccione un elemento en el ComboBox antes de registrar.", "Campos Incompletos", botones, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", botones, MessageBoxIcon.Error);

            }

        }

        private void dgvDataPreventa_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.click.Width;
                var h = Properties.Resources.click.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.click, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvDataPreventa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataPreventa.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                btnEditar.Enabled = true;
                btnBuscarCliente.Enabled = false;
                cbbSucursal.Enabled = false;
                txtDate.Select();
                int indice = e.RowIndex; //Almacenamos el Indice de la Fila captada por el Evento
                if (indice >= 0) //Si el indice es mayor o igual a 0...
                {
                    try
                    {
                        string fecha = dgvDataPreventa.Rows[indice].Cells["Fecha"].Value.ToString();
                        string monto = dgvDataPreventa.Rows[indice].Cells["Monto"].Value.ToString().Substring(1);
                        string cliente = dgvDataPreventa.Rows[indice].Cells["Cliente"].Value.ToString();
                        string estado = dgvDataPreventa.Rows[indice].Cells["estado"].Value.ToString();
                        string sucursal = dgvDataPreventa.Rows[indice].Cells["Sucursal"].Value.ToString();
                        SetearCamposPreventa(fecha, monto, cliente, estado, sucursal);

                        IdOperacion = Convert.ToInt32(dgvDataPreventa.Rows[indice].Cells["numeroOperacion"].Value.ToString());
                        NumeroPreventa = Convert.ToInt32(dgvDataPreventa.Rows[indice].Cells["Numero"].Value.ToString());
                        IdCliente = Convert.ToInt32(dgvDataPreventa.Rows[indice].Cells["IdenCliente"].Value.ToString());
                        IdPreventa = Convert.ToInt32(dgvDataPreventa.Rows[indice].Cells["IdenPreventa"].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            txtMonto.Text = "";
            txtCliente.Text = "";
            txtDate.Value = DateTime.Now;
            cbbEstado.Items.Clear();
            listarSucursal(cbbSucursal);
            listarEstado(cbbEstado);
        }

        private void labelBuscar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;

            // Verifica si se ha seleccionado un elemento en el ComboBox
            if (cbbBusqueda.SelectedItem != null)
            {
                string columnaFiltro = ((OpcionCombo)cbbBusqueda.SelectedItem).Texto;
                if (!string.IsNullOrEmpty(columnaFiltro))
                {
                    try
                    {
                        if (dgvDataPreventa.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow row in dgvDataPreventa.Rows)
                            {
                                if (row.Cells[columnaFiltro].Value != null && row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                                    row.Visible = true;
                                else
                                    row.Visible = false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("El campo de búsqueda se encuentra vacío", "Campos Incompletos", btn, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una columna de búsqueda", "Campos Incompletos", btn, MessageBoxIcon.Error);
            }


        }

        private void labelLimpiar_Click(object sender, EventArgs e)
        {
            dgvDataPreventa.Rows.Clear();
            listarPreventas();
            iniciarCbbBuscar();
            txtBuscar.Text = "";
        }
    }


    
}
