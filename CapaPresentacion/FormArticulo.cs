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
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class FormArticulo : Form
    {
        public FormArticulo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLateralLeft_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            dataGridArticulo.Rows.Add(new object[] {"", textBoxCodigoMaterial.Text, ((OpcionCombo)comboRubro.SelectedItem).Texto, textBoxCosto.Text,
            ((OpcionCombo)comboMarca.SelectedItem).Texto});

            //Limpiar();
        }

        //private void Limpiar() {
        //}

        private void comboBoxRubro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCodigoMaterial_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void ComboRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtener la selección actual del comboRubro
            int rubroSeleccionado = (int)((OpcionCombo)comboRubro.SelectedItem).Valor;

            // Actualizar el comboMarca según el rubro seleccionado
            ActualizarComboMarca(rubroSeleccionado);
        }
        private void ActualizarComboMarca(int rubroSeleccionado)
        {
            comboMarca.Items.Clear(); // Limpiar las opciones anteriores

            // Agregar opciones al ComboBox comboMarca en función del rubro seleccionado
            switch (rubroSeleccionado)
            {
                case 0: // HELADERAS
                case 3: // LAVARROPAS
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Samsung" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Electrolux" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Whirlpool" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 3, Texto = "Drean" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 4, Texto = "Philco" });
                    break;
                case 1: // TELEFONOS
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Samsung" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 5, Texto = "Alcatel" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 6, Texto = "Iphone" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 7, Texto = "Motorola" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 12, Texto = "Noblex" });
                    break;
                case 2: // COCINAS
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 8, Texto = "Florencia" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Whirlpool" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 3, Texto = "Drean" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 4, Texto = "Philco" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 9, Texto = "Longvie" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 10, Texto = "Escorial" });
                    break;
                case 4: // TELEVISORES
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Samsung" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 4, Texto = "Philco" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 11, Texto = "Philips" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 12, Texto = "Noblex" });
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 13, Texto = "Lg" });
                    break;
                default:
                    break;
            }
            comboMarca.DisplayMember = "Texto";
            comboMarca.ValueMember = "Valor";
            comboMarca.SelectedIndex = 0; // Establecer una selección predeterminada si es necesario
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCodigoMaterial_TextChanged(object sender, KeyPressEventArgs e)
        {
                // Verificar si la tecla presionada no es un dígito o es el carácter '-' (menos)
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 es el código ASCII de la tecla Retroceso (Backspace)
                {
                    e.Handled = true; // Bloquear la entrada de caracteres no válidos
                }
        }

        private void buttonEditar_Click_1(object sender, EventArgs e)
        {

        }

        private void FormArticulo_Load_1(object sender, EventArgs e)
        {
            //Agregar opciones al ComboBox comboRubro
            comboRubro.Items.Add(new OpcionCombo() { Valor = 0, Texto = "HELADERAS" });
            comboRubro.Items.Add(new OpcionCombo() { Valor = 1, Texto = "TELEFONOS" });
            comboRubro.Items.Add(new OpcionCombo() { Valor = 2, Texto = "COCINAS" });
            comboRubro.Items.Add(new OpcionCombo() { Valor = 3, Texto = "LAVARROPAS" });
            comboRubro.Items.Add(new OpcionCombo() { Valor = 4, Texto = "TELEVISORES" });

            // Establecer el valor predeterminado en comboRubro
            comboRubro.SelectedIndex = 0;

            // Configurar el ComboBox comboRubro
            comboRubro.DisplayMember = "Texto";
            comboRubro.ValueMember = "Valor";
            comboRubro.SelectedIndexChanged += ComboRubro_SelectedIndexChanged;
            // Agregar opciones al ComboBox comboMarca (inicialmente, según la selección predeterminada)
            ActualizarComboMarca(0); // Usar 0 como índice predeterminado

            textBoxCodigoMaterial.KeyPress += textBoxCodigoMaterial_TextChanged;

            //List<CE_Articulo> listadoArticulo = new CN_Articulo().Listar(textBoxBuscador.Text);
            foreach (DataGridViewColumn columna in dataGridArticulo.Columns)
            {
                if (columna.Visible == true)
                {

                }
            }
        }

        private void textBoxCosto_TextChanged_1(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un dígito o es el carácter '-' (menos)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 es el código ASCII de la tecla Retroceso (Backspace)
            {
                e.Handled = true; // Bloquear la entrada de caracteres no válidos
            }
        }
    }
}
