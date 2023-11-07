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

namespace CapaPresentacion.Modales
{
    public partial class MD_VerArticulosPreventa : Form
    {
        private int IdPreventa;
        private int NumeroPreventa;
        public MD_VerArticulosPreventa(int IdPreventa,int NumeroPreventa)
        {
            InitializeComponent();
            this.IdPreventa = IdPreventa;
            this.NumeroPreventa = NumeroPreventa;
            labelNumPreventa.Text = Convert.ToString(NumeroPreventa);
            this.StartPosition = FormStartPosition.CenterScreen;
            ListarArticulosSeleccionados();
        }

        public void ListarArticulosSeleccionados()
        {
            List<CE_Articulo> ListArticulosPreventa = new CN_Preventa().ListarPreventaArticulo(IdPreventa);
            foreach (CE_Articulo articulo in ListArticulosPreventa)
            {

                dgvDataArticulosPreventa.Rows.Add(new Object[]{
                articulo.codigoDeMaterial,
                articulo.descripcion,
                "$"+articulo.costo
            });
            }
         
        }
    }
}
