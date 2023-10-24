using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Consumimos Utilidades, Capa Entidad y la carpeta Utilidades
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormCliente : Form
    {
        //Instanciamos dos atributos
        private int DgvIndice { get; set; } //Aca almacenamos el Indice de la Grid
        private int DgvIden { get; set; } //Aca almacenamos el ID de la Grid

        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            //A los atributos les asignamos valores predeterminados
            DgvIndice = -1;
            DgvIden = 0;

            inputFechaNacimiento.MaxDate = DateTime.Today;

            inputNombre.Select(); //Al iniciar dejamos seleccionado el input Nombre
            inputBuscar.Text = "Filtrar por DNI o Apellido"; //Agregamos "Placeholder" al input Buscar
            inputBuscar.ForeColor = Color.Gray;

            ////Agregamos los Campos de la Grid al ComboBox Buscar
            //foreach (DataGridViewColumn column in dgvData.Columns)
            //{
            //    //Agregamos aquellos que sean Visibles (Los NO Visibles y el Boton quedan excluidos)
            //    //if (column.Visible == true && column.GetType().ToString() != "System.Windows.Forms.DataGridViewButtonColumn")
            //    if (column.Name == "dni" || column.Name == "correo")
            //    {
            //        comboBuscar.Items.Add(new OpcionCombo()
            //        {
            //            Valor = column.Name,
            //            Texto = column.HeaderText
            //        });
            //    }
            //}
            //comboBuscar.DisplayMember = "Texto"; //De manera visual (En el Formulario) se vera el Texto
            //comboBuscar.ValueMember = "Valor"; // Y como valor del campo (Atras, en la logica) maneja Valor
            //comboBuscar.SelectedIndex = 0; // Inicia en 0, o sea la primera opción

            Listar();
        }

        private void inputDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cosume el Evento si lo que se intenta ingresar por Teclado NO es Numero, tecla "borrar"
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void inputTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cosume el Evento si lo que se intenta ingresar por Teclado NO es Numero, tecla "borrar", tecla "+" y tecla "space"
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back) //&& e.KeyChar != (char)Keys.Subtract && e.KeyChar != (char)Keys.Add && e.KeyChar != (char)Keys.Space
            {
                e.Handled = true;
            }
        }

        private void Limpiar() //Metodo para limpiar los Campos, Seleccionar el input Nombre y Restablecer el Boton Guardar a su estado Original
        {
            //Vaciamos Campos y Restablecemos Valores
            DgvIndice = -1;
            DgvIden = 0;
            inputNombre.Text = "";
            inputApellido.Text = "";
            inputDNI.Text = "";
            inputFechaNacimiento.Value = DateTime.Today;
            inputCorreo.Text = "";
            inputTelefono.Text = "";

            inputNombre.Select(); //Seleccionar el input Nombre

            //Restablecer el Boton Guardar a su estado Original
            btnGuardar.BackColor = Color.MediumSeaGreen;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnGuardar.Text = "Guardar";
        }

        private void ModificarBoton() //Metodo para Modificar el boton Guardar a "Editar"
        {
            btnGuardar.BackColor = Color.DodgerBlue; //Cambiamos el Color
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare; //El Icono
            btnGuardar.Text = "Editar"; //Y su Texto
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(); //Ejecutamos el Metodo Limpiar
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) //Evento para Pintar una Imagen en una Celda de tipo Boton en la Grid
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.edit_info.Width;
                var h = Properties.Resources.edit_info.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit_info, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e) //Evento CellContentClick a la Grid
        {
            //Si la Columna que se Capto atravez del evento es el Boton Seleccionar, entonces...
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                inputNombre.Select();

                ModificarBoton(); //Llamamos al metodo para Modificar las propiedades del Boton Guardar

                int indice = e.RowIndex; //Almacenamos el Indice de la Fila captada por el Evento

                if (indice >= 0) //Si el indice es mayor o igual a 0...
                {
                    DgvIndice = indice; //Almacenamos el Indice en el atributo DgvIndice
                    DgvIden = Convert.ToInt32(dgvData.Rows[indice].Cells["idCliente"].Value); //Almacenamos el ID en el atributo DgvIden
                    //Asignamos en las Cajas de Texto los valores de cada Celda correspondiente
                    inputNombre.Text = dgvData.Rows[indice].Cells["nombre"].Value.ToString();
                    inputApellido.Text = dgvData.Rows[indice].Cells["apellido"].Value.ToString();
                    inputDNI.Text = dgvData.Rows[indice].Cells["dni"].Value.ToString();
                    inputFechaNacimiento.Value = Convert.ToDateTime(dgvData.Rows[indice].Cells["fechaNacimiento"].Value);
                    inputCorreo.Text = dgvData.Rows[indice].Cells["correo"].Value.ToString();
                    inputTelefono.Text = dgvData.Rows[indice].Cells["telefono"].Value.ToString();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) //Evento Click del boton Guardar
        {
            //Declaramos una variable de tipo string y le damos como valor un vacio
            string mensaje = string.Empty;

            //Instanciamos un Objeto de tipo Entidad Cliente
            CE_Cliente ObjCliente = new CE_Cliente()
            {
                //Guardamos valores en sus Atributos
                Id = this.DgvIden,
                Nombre = inputNombre.Text,
                Apellido = inputApellido.Text,
                Dni = inputDNI.Text,
                Fecha_nacimiento = Convert.ToDateTime(inputFechaNacimiento.Value),
                Correo_electronico = inputCorreo.Text,
                Telefono = inputTelefono.Text
            };

            if (ObjCliente.Id == 0) //Si el ID del Cliente es 0...
            {
                //Se registra y almacenamos el resultado...
                int resultado = new CN_Cliente().Registrar(ObjCliente, out mensaje);

                //Si el resultado es distinto de 0 es porque el registro se completo con éxito
                if (resultado != 0)
                {
                    //Agregamos el nuevo Cliente a una fila de la Grid
                    dgvData.Rows.Add(new object[]
                    {
                        resultado, //El resultado vendria a representar el ID del nuevo Cliente
                        inputNombre.Text,
                        inputApellido.Text,
                        inputDNI.Text,
                        inputFechaNacimiento.Value,
                        inputCorreo.Text,
                        inputTelefono.Text,
                        "",
                    });

                    MessageBox.Show("Cliente registrado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar(); //Limpiamos
                }
                else
                {
                    MessageBox.Show(mensaje); //Caso contrario, se notifica el por qué
                }
            }
            else //Si el ID del Usuario es distinto de 0...
            {
                //Preguntamos si desea editar
                if (MessageBox.Show("¿Desea EDITAR el Cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Se edita y almacenamos el resultado...
                    bool resultado = new CN_Cliente().Editar(ObjCliente, out mensaje);

                    if (resultado) //Si el resultado es true
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(DgvIndice)]; //Almacenamos en una variable de tipo DataGridViewRow la fila que se alamceno previamente en el evento CellContentClick
                        //Y asignamos los nuevos valores a cada celda de la fila
                        row.Cells["nombre"].Value = inputNombre.Text;
                        row.Cells["apellido"].Value = inputApellido.Text;
                        row.Cells["dni"].Value = inputDNI.Text;
                        row.Cells["fechaNacimiento"].Value = inputFechaNacimiento.Value;
                        row.Cells["correo"].Value = inputCorreo.Text;
                        row.Cells["telefono"].Value = inputTelefono.Text;

                        //dgvData.Rows[DgvIndice].Selected = true;

                        MessageBox.Show("Cliente editado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar(); //Limpiamos
                    }
                    else
                    {
                        MessageBox.Show(mensaje); //Caso contrario, se notifica el por qué
                    }
                }
            }
        }

        private void inputNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cosume el Evento si lo que se intenta ingresar por Teclado NO es Numero, tecla "borrar"
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inputApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Cosume el Evento si lo que se intenta ingresar por Teclado NO es Numero, tecla "borrar"
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Clear(); //Vaciar tabla

            //Filtramos los Clientes
            List<CE_Cliente> listaClientes = new CN_Cliente().Filtrar(inputBuscar.Text);

            //Modificamos el Alto de las filas
            DataGridViewRow row = dgvData.RowTemplate;
            row.Height = 28;

            //Recorremos la Lista de Clientes
            foreach (CE_Cliente cliente in listaClientes)
            {
                //Y agregamos a cada Usuario a la Grid
                dgvData.Rows.Add(new object[]
                {
                    cliente.Id,
                    cliente.Nombre,
                    cliente.Apellido,
                    cliente.Dni,
                    cliente.Fecha_nacimiento,
                    cliente.Correo_electronico,
                    cliente.Telefono,
                    "",
                });
            }

        }

        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Clear(); //Vaciar tabla
            inputBuscar.Text = "";
            Listar(); //Volver a Listar los Clientes
        }

        private void Listar()
        {
            //Listamos los Clientes
            List<CE_Cliente> listaClientes = new CN_Cliente().ListarClientes(0);

            //Modificamos el Alto de las filas
            DataGridViewRow row = dgvData.RowTemplate;
            row.Height = 28;

            //Recorremos la Lista de Clientes
            foreach (CE_Cliente cliente in listaClientes)
            {
                //Y agregamos a cada Usuario a la Grid
                dgvData.Rows.Add(new object[]
                {
                    cliente.Id,
                    cliente.Nombre,
                    cliente.Apellido,
                    cliente.Dni,
                    cliente.Fecha_nacimiento,
                    cliente.Correo_electronico,
                    cliente.Telefono,
                    "",
                });
            }
        }

        private void inputBuscar_Click(object sender, EventArgs e)
        {
            if (inputBuscar.Text == "Filtrar por DNI o Apellido")
            {
                inputBuscar.Text = "";
                inputBuscar.ForeColor = Color.Black;
            }
        }

        private void inputBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputBuscar.Text))
            {
                inputBuscar.Text = "Filtrar por DNI o Apellido";
                inputBuscar.ForeColor = Color.Gray;
            }
        }
    }
}
