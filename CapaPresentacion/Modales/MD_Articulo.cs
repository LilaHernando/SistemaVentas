using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Modales
{
    public partial class MD_Articulo : Form
    {
       
        CE_Preventa Preventa = new CE_Preventa();
        public MD_Articulo(CE_Preventa preventa)
        {
            InitializeComponent();
            this.Preventa = preventa;
            this.StartPosition = FormStartPosition.CenterScreen;
            iniciarCbbBusqueda();
            ListarArticulosActivos();
        }

        public void iniciarCbbBusqueda()
        {
            cbbBusqueda.Items.Clear();
            cbbBusqueda.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Codigo" });
            cbbBusqueda.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Rubro" });
            cbbBusqueda.DisplayMember = "Texto";
            cbbBusqueda.ValueMember = "Valor";
            cbbBusqueda.SelectedIndex = -1;
        }

        public void ListarArticulosActivos()
        {
            
            List<CE_Articulo> ListArticulosActivos = new CN_Articulo().ListarArticulosActivos();
            foreach (CE_Articulo articulo in ListArticulosActivos)
            {
               
                dgvDataArticulos.Rows.Add(new Object[]{
                    articulo.iden,
                    articulo.codigoDeMaterial,
                    articulo.rubro,
                    "$"+articulo.costo
                });
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Decimal MontoTotal = 0;
            MessageBoxButtons botones = MessageBoxButtons.OK;
            CN_Preventa cN_Preventa = new CN_Preventa();
            List<CE_Articulo> listaArticulos = CrearLista();
            try {
                int UltimoIdPreventa =cN_Preventa.InsertarPreventa(Preventa);
                foreach (CE_Articulo articulos in listaArticulos)
                {
                    CE_Item_Preventa_Articulo IPA = new CE_Item_Preventa_Articulo()
                    {
                        GN_Sucursal_iden = Preventa.Id_Sucursal,
                        PVTA_Preventa_iden = UltimoIdPreventa,
                        PVTA_Preventa_sucursal = Preventa.Id_Sucursal,
                        GN_Articulo_iden = articulos.iden,
                    };
                    MontoTotal += articulos.costo;
                    cN_Preventa.INS_Preventa_Articulo(IPA);
                    
                }
                cN_Preventa.UpdateMontoPreventa(MontoTotal, UltimoIdPreventa);
                MessageBox.Show("Registro de Preventa " +
                        "Efectuado Correctamente", "Informe de Registro", botones, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public List<CE_Articulo> CrearLista()
        {
            List<CE_Articulo> listaArticulos = new List<CE_Articulo>();
            listaArticulos.Clear();
            foreach (DataGridViewRow row in dgvDataArticulos.Rows)
            {
                

                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Seleccionar"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkBoxCell.Value) == true)
                {

                    int iden = Convert.ToInt32(row.Cells["Iden"].Value);
                   
                    string costoString = row.Cells["Costo"].Value.ToString();
                    costoString = costoString.Substring(1);
                    // Crea una instancia de CE_Articulo y agrega a la lista
                    CE_Articulo articulo = new CE_Articulo
                    {
                        iden = iden, 
                        costo = Convert.ToDecimal(costoString)
                };

                    listaArticulos.Add(articulo);
                }
            }
            return listaArticulos;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
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
                        if (dgvDataArticulos.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow row in dgvDataArticulos.Rows)
                            {
                                if (row.Cells[columnaFiltro].Value != null && row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
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

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            dgvDataArticulos.Rows.Clear();
            ListarArticulosActivos();
            iniciarCbbBusqueda();
            txtBusqueda.Text = "";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
