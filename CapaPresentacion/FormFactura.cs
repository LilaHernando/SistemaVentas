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



namespace CapaPresentacion
{
    public partial class FormFactura : Form
    {
        Random random = new Random();
        //OpcionCombo opcionCombo = new OpcionCombo();


        public FormFactura()
        {
            InitializeComponent();
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {


            string numFactura = Convert.ToString(random.Next(10000000, 99999999));
            BoxNumeroFactura.Text = numFactura;

            //Box Tipo Factura
            BoxTipoFactura.Items.Add(new OpcionCombo { Texto = "A", Valor = "A" });
            BoxTipoFactura.Items.Add(new OpcionCombo { Texto = "B", Valor = "B" });
            BoxTipoFactura.DisplayMember = "Texto";
            BoxTipoFactura.ValueMember = "Valor";

            //Box Estado Factura
            BoxEstado.Items.Add(new OpcionCombo { Texto = "Activo", Valor = "Activo" });
            BoxEstado.Items.Add(new OpcionCombo { Texto = "Inactivo", Valor = "Inactivo" });
            BoxEstado.DisplayMember = "Texto";
            BoxEstado.ValueMember = "Valor";

        }

        private void LabelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void BoxTipoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BoxIdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxIdOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InputMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxNumeroFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
