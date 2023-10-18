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

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                CE_Articulo art = new CE_Articulo()
                {
                    iden = textBoxIden.Text != "" ? Convert.ToInt32(textBoxIden.Text) : 0,
                    codigoDeMaterial = Convert.ToInt32(textBoxCodigoMaterial.Text),
                    rubro = ((OpcionCombo)comboRubro.SelectedItem).Texto,
                    costo = Convert.ToDecimal(textBoxCosto.Text),
                    marca = ((OpcionCombo)comboMarca.SelectedItem).Texto,
                    baja = checkBoxBaja.Checked
                };

                if (art.iden == 0)
                {
                    int articuloGenerado = new CN_Articulo().Registrar(art);

                    if (articuloGenerado != 0)
                    {
                        dataGridArticulo.Rows.Add(new object[] {articuloGenerado.ToString(), textBoxCodigoMaterial.Text, ((OpcionCombo)comboRubro.SelectedItem).Texto,
                textBoxCosto.Text,((OpcionCombo)comboMarca.SelectedItem).Texto,(checkBoxBaja.Checked == true ? "Si" : "No")});

                        Limpiar();
                    }

                }else
                {
                    bool articuloEditado = new CN_Articulo().Editar(art);

                    if (articuloEditado)
                    {
                        int indiceFilaSeleccionada = -1; // Establece un valor predeterminado

                        if (dataGridArticulo.SelectedCells.Count > 0)
                        {
                            // Obtiene el índice de la fila de la celda seleccionada.
                            indiceFilaSeleccionada = dataGridArticulo.SelectedCells[0].RowIndex;
                        }

                        DataGridViewRow row = dataGridArticulo.Rows[indiceFilaSeleccionada];
                        row.Cells["idenArticulo"].Value = textBoxIden.Text;
                        row.Cells["CodigoMaterial"].Value = textBoxCodigoMaterial.Text;
                        row.Cells["RubroArticulo"].Value = ((OpcionCombo)comboRubro.SelectedItem).Texto;
                        row.Cells["CostoArticulo"].Value = textBoxCosto.Text;
                        row.Cells["MarcaArticulo"].Value = ((OpcionCombo)comboMarca.SelectedItem).Texto;
                        row.Cells["Baja"].Value = (checkBoxBaja.Checked == true ? "Si" : "No");

                        Limpiar();
                    }
                }

            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Limpiar()
        {
            textBoxIden.Text = "";
            textBoxCodigoMaterial.Text = "";
            comboRubro.SelectedIndex = 0;
            textBoxCosto.Text = "";
            comboMarca.SelectedIndex = 0;
            checkBoxBaja.Checked = false;
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
                    comboMarca.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Electrolux" });
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

        private void textBoxCodigoMaterial_TextChanged(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un dígito o es el carácter '-' (menos)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 es el código ASCII de la tecla Retroceso (Backspace)
            {
                e.Handled = true; // Bloquear la entrada de caracteres no válidos
            }
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
            textBoxCosto.KeyPress += textBoxCosto_TextChanged;

            List<CE_Articulo> listadoArticulo = new CN_Articulo().Listar(0, null);

            DataGridViewRow row = dataGridArticulo.RowTemplate;
            row.Height = 28;

            foreach (CE_Articulo articulo in listadoArticulo)
            {
                dataGridArticulo.Rows.Add(new object[]
                {
                    articulo.iden,
                    articulo.codigoDeMaterial,
                    articulo.rubro,
                    articulo.costo,
                    articulo.marca,
                    articulo.baja == true ? "Si": "No"

                });
            }
        }

        private void textBoxCosto_TextChanged(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un dígito o es el carácter '-' (menos)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 es el código ASCII de la tecla Retroceso (Backspace)
            {
                e.Handled = true; // Bloquear la entrada de caracteres no válidos
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            textBoxBuscador_TextChanged(textBoxBuscador, EventArgs.Empty);
        }

        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text;
            dataGridArticulo.Rows.Clear();

            // Intenta convertir el valor del TextBox a un número entero
            if (int.TryParse(input, out int numeroEntero))
            {
                List<CE_Articulo> listadoArticulo = new CN_Articulo().Listar(numeroEntero, null);
                foreach (CE_Articulo articulo in listadoArticulo)
                {
                    dataGridArticulo.Rows.Add(new object[]
                    {
                    articulo.iden,
                    articulo.codigoDeMaterial,
                    articulo.rubro,
                    articulo.costo,
                    articulo.marca,
                    articulo.baja == true ? "Si": "No"

                    });
                }
            }
            else
            {
                List<CE_Articulo> listadoArticulo = new CN_Articulo().Listar(null, input);
                foreach (CE_Articulo articulo in listadoArticulo)
                {
                    dataGridArticulo.Rows.Add(new object[]
                    {
                    articulo.iden,
                    articulo.codigoDeMaterial,
                    articulo.rubro,
                    articulo.costo,
                    articulo.marca,
                    articulo.baja == true ? "Si": "No"

                    });
                }
            }
        }
        private void dataGridArticulo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.before.Width;
                var h = Properties.Resources.before.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.before, new Rectangle(x, y, w, h));

                e.Handled = true;
            }
        }

        private void dataGridArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridArticulo.Columns[e.ColumnIndex].Name == "botonSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    textBoxIden.Text = dataGridArticulo.Rows[indice].Cells["idenArticulo"].Value.ToString();
                    textBoxCodigoMaterial.Text = dataGridArticulo.Rows[indice].Cells["CodigoMaterial"].Value.ToString();
                    textBoxCosto.Text = dataGridArticulo.Rows[indice].Cells["CostoArticulo"].Value.ToString();
                    checkBoxBaja.Checked = (dataGridArticulo.Rows[indice].Cells["Baja"].Value.ToString() == "Si") ? true : false;

                    foreach (OpcionCombo oc in comboRubro.Items)
                    {
                        if (oc.Texto == dataGridArticulo.Rows[indice].Cells["RubroArticulo"].Value.ToString())
                        {
                            int indiceCombo = comboRubro.Items.IndexOf(oc);
                            comboRubro.SelectedIndex = indiceCombo;
                            ActualizarComboMarca(indiceCombo);
                            break;
                        }
                    }
                    foreach (OpcionCombo oc in comboMarca.Items)
                    {
                        if (oc.Texto == dataGridArticulo.Rows[indice].Cells["MarcaArticulo"].Value.ToString())
                        {
                            int indiceCombo = comboMarca.Items.IndexOf(oc);
                            comboMarca.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                }
            }
        }

        private void textBoxCodigoMaterial_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCodigoMaterial.Text))
            {
                errorProvider1.SetError(textBoxCodigoMaterial, "Este campo es obligatorio");
                e.Cancel = true; // Evita que el usuario cambie el foco
            }
            else
            {
                errorProvider1.SetError(textBoxCodigoMaterial, ""); // Borra el mensaje de error
            }
        }

        private void textBoxCosto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCosto.Text))
            {
                errorProvider1.SetError(textBoxCosto, "Este campo es obligatorio");
                e.Cancel = true; // Evita que el usuario cambie el foco
            }
            else
            {
                errorProvider1.SetError(textBoxCosto, ""); // Borra el mensaje de error
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                CE_Articulo art = new CE_Articulo()
                {
                    iden = Convert.ToInt32(textBoxIden.Text),
                    codigoDeMaterial = Convert.ToInt32(textBoxCodigoMaterial.Text),
                    rubro = ((OpcionCombo)comboRubro.SelectedItem).Texto,
                    costo = Convert.ToDecimal(textBoxCosto.Text),
                    marca = ((OpcionCombo)comboMarca.SelectedItem).Texto,
                    baja = checkBoxBaja.Checked
                };

                bool articuloEditado = new CN_Articulo().Editar(art);

                if (articuloEditado)
                {
                    int indiceFilaSeleccionada = -1; // Establece un valor predeterminado

                    if (dataGridArticulo.SelectedCells.Count > 0)
                    {
                        // Obtiene el índice de la fila de la celda seleccionada.
                        indiceFilaSeleccionada = dataGridArticulo.SelectedCells[0].RowIndex;
                    }

                    DataGridViewRow row = dataGridArticulo.Rows[indiceFilaSeleccionada];
                    row.Cells["idenArticulo"].Value = textBoxIden.Text;
                    row.Cells["CodigoMaterial"].Value = textBoxCodigoMaterial.Text;
                    row.Cells["RubroArticulo"].Value = ((OpcionCombo)comboRubro.SelectedItem).Texto;
                    row.Cells["CostoArticulo"].Value = textBoxCosto.Text;
                    row.Cells["MarcaArticulo"].Value = ((OpcionCombo)comboMarca.SelectedItem).Texto;
                    row.Cells["Baja"].Value = (checkBoxBaja.Checked == true ? "Si" : "No");
                }

                Limpiar();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLimipiar_Click(object sender, EventArgs e)
        {
            textBoxBuscador.Text = "";
            dataGridArticulo.Rows.Clear();      // Borra todas las filas
            List<CE_Articulo> listadoArticulo = new CN_Articulo().Listar(0, null);
            DataGridViewRow row = dataGridArticulo.RowTemplate;
            row.Height = 28;

            foreach (CE_Articulo articulo in listadoArticulo)
            {
                dataGridArticulo.Rows.Add(new object[]
                {
                    articulo.iden,
                    articulo.codigoDeMaterial,
                    articulo.rubro,
                    articulo.costo,
                    articulo.marca,
                    articulo.baja == true ? "Si": "No"

                });
            }
        }
    }
}
