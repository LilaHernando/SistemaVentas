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


namespace CapaPresentacion.Modales
{
    public partial class MD_Articulo : Form
    {
        public MD_Articulo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            iniciarCbbBusqueda();
        }

        public void iniciarCbbBusqueda()
        {
            cbbBusqueda.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Código" });
            cbbBusqueda.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Rubro" });
            cbbBusqueda.DisplayMember = "Texto";
            cbbBusqueda.ValueMember = "Valor";
            cbbBusqueda.SelectedIndex = -1;
        }
    }
}
