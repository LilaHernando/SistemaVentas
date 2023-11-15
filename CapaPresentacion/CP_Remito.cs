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
using CapaPresentacion.Modales;
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
        private void CP_Remito_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = tablaRemito.RowTemplate;
            row.Height = 32;
            LimpiarCampos();
            Listar();
            CrearNumeroRemito();
            btnLimpiar.Enabled = false;

            List<CE_Sucursal> listarSucursal = new CN_Sucursal().ListarSucursal();

            foreach (CE_Sucursal cE_Sucursal in listarSucursal)
            {

                cbSucursal.Items.Add(new OpcionCombo { Texto = cE_Sucursal.descripcion, Valor = cE_Sucursal.iden });

            }
            cbSucursal.DisplayMember = "Texto";
            cbSucursal.ValueMember = "Valor";

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

        private void Listar()
        {
            List<CE_Remito> listaRemitos = new CN_Remito().Listar();

            foreach (CE_Remito cE_Remito in listaRemitos)
            {
                tablaRemito.Rows.Add(new object[]{

                    "",
                    cE_Remito.iden,
                    cE_Remito.Sucursal.descripcion,
                    cE_Remito.estadoRemito.descripcion,
                    cE_Remito.idOperacion,
                    cE_Remito.numero,
                    cE_Remito.letra,
                    cE_Remito.tipoRemito,
                    cE_Remito.fechaRemito
                });
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            var idOpRemitos =
                (from DataGridViewRow rows in tablaRemito.Rows
                 where rows.Cells["idOperacion"].Value.ToString() == txtIDOP.Text
                 select rows).FirstOrDefault();
            if (idOpRemitos != null)
            {
                MessageBox.Show("Ya existe un remito con el ID de Operación");
            }
            else
            {
                if (!txtIDOP.Text.Equals(""))
                {
                    bool resultado = new CN_Remito().VerFactura(Convert.ToInt32(txtIDOP.Text), out message);
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
                else
                {
                    MessageBox.Show("Ingrese un dato en el campo");
                }

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (!string.IsNullOrWhiteSpace(cbSucursal.Text) && !string.IsNullOrWhiteSpace(cbEstado.Text))
            {
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
                    fechaRemito = DateTime.Now,
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
            } else
            {
            MessageBox.Show("Complete todos los datos");
            }
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
            }
            return true;
        }

        private void tablaRemito_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.PDF_image.Width;
                var h = Properties.Resources.PDF_image.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.PDF_image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void tablaRemito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaRemito.Columns[e.ColumnIndex].Name == "btnPdfRemito")
            {
                int iRow = e.RowIndex;
                int iColumn = e.ColumnIndex;

                if (iRow >= 0 && iColumn == 0)
                {
                    int IdRemito = Convert.ToInt32(tablaRemito.Rows[iRow].Cells["IDRemito"].Value.ToString());

                    FormReporteRemito reporteRemito = new FormReporteRemito();

                    reporteRemito.SolicitarIdRemito(IdRemito);

                    reporteRemito.Show();
                }
            }
        }
    }
}
