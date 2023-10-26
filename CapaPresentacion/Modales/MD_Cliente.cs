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
    public partial class MD_Cliente : Form
    {
        public CE_Cliente _Cliente { get; set; }
        public List<CE_Cliente> ListaClientes;
        public MD_Cliente()
        {
            InitializeComponent();
        }

        private void ListarClientes(int dni)
        {

            ListaClientes = new CN_Cliente().ListarClientes(dni);

            foreach (CE_Cliente cliente in ListaClientes)
            {
                GridClientes.Rows.Add(new object[] {

                    cliente.Id,
                    cliente.Dni,
                    cliente.Nombre,
                    cliente.Apellido,
                });
            }

        }

        private void MD_Cliente_Load(object sender, EventArgs e)
        {
            ListarClientes(0);
            SearchBtn.Enabled = false;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            GridClientes.Rows.Clear();
            int dni = Convert.ToInt32(BoxIdUsuario.Text);
            ListarClientes(dni);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            GridClientes.Rows.Clear();
            ListarClientes(0);
            BoxIdUsuario.Text = "";
        }

        private void GridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            if (iRow >= 0 && iColumn > 0)
            {

                _Cliente = new CE_Cliente()
                {
                    Id = Convert.ToInt32(GridClientes.Rows[iRow].Cells["Iden"].Value.ToString()),
                    Dni = GridClientes.Rows[iRow].Cells["DNI"].Value.ToString(),
                    Nombre = GridClientes.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Apellido = GridClientes.Rows[iRow].Cells["Apellido"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BoxIdUsuario_TextChanged(object sender, EventArgs e)
        {
            SearchBtn.Enabled = true;
        }
    }
}
