using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Modales
{
    public partial class MD_Articulo : Form
    {
        private int CantidadSeleccionados;
        private int IdPreventa;
        private int IdSucursal;
        private int IdCliente;
        public MD_Articulo(int IdPreventa, int IdSucursal, int IdCliente)
        {
            InitializeComponent();
            this.IdPreventa = IdPreventa;
            this.IdSucursal = IdSucursal;
            this.IdCliente = IdCliente;
            this.StartPosition = FormStartPosition.CenterScreen;
            iniciarCbbBusqueda();
            ListarArticulosActivos();
        }

        public void iniciarCbbBusqueda()
        {
            cbbBusqueda.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Código" });
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
            CN_Preventa cN_Preventa = new CN_Preventa();
            List<CE_Articulo> listaArticulos = CrearLista();
            foreach(CE_Articulo articulos in listaArticulos)
            {
                CE_Item_Preventa_Articulo IPA = new CE_Item_Preventa_Articulo()
                {
                    GN_Sucursal_iden = IdSucursal,
                    PVTA_Preventa_iden = IdPreventa,
                    PVTA_Preventa_sucursal = IdSucursal,
                    GN_Articulo_iden = articulos.iden
                   
                };
                cN_Preventa.INS_Preventa_Articulo(IPA);
            }

        }

        public List<CE_Articulo> CrearLista()
        {
            List<CE_Articulo> listaArticulos = new List<CE_Articulo>();
            listaArticulos.Clear();
            foreach (DataGridViewRow row in dgvDataArticulos.Rows)
            {
                if (row.Index == dgvDataArticulos.Rows.Count - 1)
                    continue;

                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Seleccionar"] as DataGridViewCheckBoxCell;
                if (checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                {

                    int iden = Convert.ToInt32(row.Cells["Iden"].Value);
                    
                    // Crea una instancia de CE_Articulo y agrega a la lista
                    CE_Articulo articulo = new CE_Articulo
                    {
                        iden = iden,  
                    };

                    listaArticulos.Add(articulo);
                }
            }
            return listaArticulos;
        }
        
    }
}
