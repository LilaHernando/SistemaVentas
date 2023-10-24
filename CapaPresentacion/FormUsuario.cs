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
    public partial class FormUsuario : Form
    {
        //Instanciamos dos atributos
        private int DgvIndice { get; set; } //Aca almacenamos el Indice de la Grid
        private int DgvIden { get; set; } //Aca almacenamos el ID de la Grid

        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            //A los atributos les asignamos valores predeterminados
            DgvIndice = -1;
            DgvIden = 0;

            inputNombre.Select(); //Al iniciar dejamos seleccionado el input Nombre
            inputBuscar.Text = "Filtrar por DNI o Rol"; //Agregamos "Placeholder" al input Buscar
            inputBuscar.ForeColor = Color.Gray;

            //Agregamos Items al Combo Estado por medio del Objeto OpcionCombo ubicado en la carpeta Utilidades
            comboEstado.Items.Add(new OpcionCombo()
            {
                //La clase OpcionCombo maneja dos atributos, "Valor" que es de tipo object t "Texto" que es de tipo string
                Valor = 1,
                Texto = "Activo"
            });
            comboEstado.Items.Add(new OpcionCombo()
            {
                Valor = 0,
                Texto = "Inactivo"
            });
            comboEstado.DisplayMember = "Texto"; //De manera visual (En el Formulario) se vera el Texto
            comboEstado.ValueMember = "Valor"; // Y como valor del campo (Atras, en la logica) maneja Valor
            comboEstado.SelectedIndex = 0; // Inicia en 0, o sea la primera opción, que seria "Activo"

            List<CE_Rol> listaRoles = new CN_Rol().Listar();

            foreach (CE_Rol rol in listaRoles) 
            {
                comboRol.Items.Add(new OpcionCombo()
                {
                    //La clase OpcionCombo maneja dos atributos, "Valor" que es de tipo object t "Texto" que es de tipo string
                    Valor = Convert.ToInt32(rol.Iden),
                    Texto = rol.Rol
                });
            }
            comboRol.DisplayMember = "Texto"; //De manera visual (En el Formulario) se vera el Texto
            comboRol.ValueMember = "Valor"; // Y como valor del campo (Atras, en la logica) maneja Valor
            comboRol.SelectedIndex = 1; // Inicia en 1, o sea la segunda opción

            ////Agregamos los Campos de la Grid al ComboBox Buscar
            //foreach (DataGridViewColumn column in dgvData.Columns) 
            //{
            //    //Agregamos aquellos que sean Visibles (Los NO Visibles y el Boton quedan excluidos)
            //    //if (column.Visible == true && column.GetType().ToString() != "System.Windows.Forms.DataGridViewButtonColumn") 
            //    if (column.Name == "dni" || column.Name == "rol")
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

        private void Limpiar() //Metodo para limpiar los Campos, Seleccionar el input Nombre y Restablecer el Boton Guardar a su estado Original
        {
            //Vaciamos Campos y Restablecemos Valores
            DgvIndice = -1;
            DgvIden = 0;
            inputNombre.Text = "";
            inputApellido.Text = "";
            inputDNI.Text = "";
            inputClave.Text = "";
            inputConfClave.Text = "";
            comboRol.SelectedIndex = 1;
            comboEstado.SelectedIndex = 0;

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

        private void btnLimpiar_Click(object sender, EventArgs e) //Evento Click del boton Limpiar
        {
            Limpiar(); //Ejecutamos el Metodo Limpiar
        }

        private void btnGuardar_Click(object sender, EventArgs e) //Evento Click del boton Guardar
        {
            //Declaramos una variable de tipo string y le damos como valor un vacio
            string mensaje = string.Empty;

            //Instanciamos un Objeto de tipo Entidad Usuario
            CE_Usuario ObjUsuario = new CE_Usuario()
            {
                //Guardamos valores en sus Atributos
                Iden = this.DgvIden,
                Nombre = inputNombre.Text,
                Apellido = inputApellido.Text,
                Dni = inputDNI.Text,
                Rol = new CE_Rol()
                {
                    Iden = Convert.ToInt32(((OpcionCombo)comboRol.SelectedItem).Valor)
                },
                Estado = Convert.ToInt32(((OpcionCombo)comboEstado.SelectedItem).Valor) == 1 ? true : false, //Preguntamos si es 1, si lo es, su Valor es true, caso contrario false
                Clave = inputClave.Text
            };

            if (ObjUsuario.Iden == 0) //Si el ID del Usuario es 0...
            {
                //Se registra y almacenamos el resultado...
                int resultado = new CN_Usuario().Registrar(ObjUsuario, out mensaje, inputConfClave.Text);

                //Si el resultado es distinto de 0 es porque el registro se completo con éxito
                if (resultado != 0)
                {
                    //Agregamos el nuevo Usuario a una fila de la Grid
                    dgvData.Rows.Add(new object[]
                    {
                        resultado, //El resultado vendria a representar el ID del nuevo Usuario
                        inputNombre.Text,
                        inputApellido.Text,
                        inputDNI.Text,
                        ((OpcionCombo)comboEstado.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)comboEstado.SelectedItem).Texto.ToString(),
                        ((OpcionCombo)comboRol.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)comboRol.SelectedItem).Texto.ToString(),
                        inputClave.Text,
                        "",
                    });

                    Limpiar(); //Limpiamos

                    MessageBox.Show("Usuario registrado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje); //Caso contrario, se notifica el por qué
                }
            }
            else //Si el ID del Usuario es distinto de 0...
            {
                //Preguntamos si desea editar
                if (MessageBox.Show("¿Desea EDITAR el Usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    //Se edita y almacenamos el resultado...
                    bool resultado = new CN_Usuario().Editar(ObjUsuario, out mensaje, inputConfClave.Text);

                    if (resultado) //Si el resultado es true
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(DgvIndice)]; //Almacenamos en una variable de tipo DataGridViewRow la fila que se alamceno previamente en el evento CellContentClick
                        //Y asignamos los nuevos valores a cada celda de la fila
                        row.Cells["nombre"].Value = inputNombre.Text;
                        row.Cells["apellido"].Value = inputApellido.Text;
                        row.Cells["dni"].Value = inputDNI.Text;
                        row.Cells["valorEstado"].Value = ((OpcionCombo)comboEstado.SelectedItem).Valor.ToString();
                        row.Cells["estado"].Value = ((OpcionCombo)comboEstado.SelectedItem).Texto.ToString();
                        row.Cells["idRol"].Value = ((OpcionCombo)comboRol.SelectedItem).Valor.ToString();
                        row.Cells["rol"].Value = ((OpcionCombo)comboRol.SelectedItem).Texto.ToString();
                        row.Cells["clave"].Value = inputClave.Text;

                        //dgvData.Rows[DgvIndice].Selected = true;

                        MessageBox.Show("Usuario editado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar(); //Limpiamos
                    }
                    else
                    {
                        MessageBox.Show(mensaje); //Caso contrario, se notifica el por qué
                    }
                }
            }
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) //Evento para Pintar una Imagen en una Celda de tipo Boton en la Grid
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 9) 
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
                    DgvIden = Convert.ToInt32(dgvData.Rows[indice].Cells["idUsuario"].Value); //Almacenamos el ID en el atributo DgvIden
                    //Asignamos en las Cajas de Texto los valores de cada Celda correspondiente
                    inputNombre.Text = dgvData.Rows[indice].Cells["nombre"].Value.ToString();
                    inputApellido.Text = dgvData.Rows[indice].Cells["apellido"].Value.ToString();
                    inputDNI.Text = dgvData.Rows[indice].Cells["dni"].Value.ToString();


                    //Asignamos en los Combos los valores de cada Celda correspondiente
                    foreach (OpcionCombo oc in comboEstado.Items) //Recorremos los Items del Combo
                    {
                        //Buscamos que el Item coincida con el Valor de la Celda
                        if(Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["valorEstado"].Value)) 
                        {
                            //Almacenamos el Index
                            int indice_combo = comboEstado.Items.IndexOf(oc);
                            comboEstado.SelectedIndex = indice_combo; //Y lo seleccionamos
                            break; //Rompemos el foreach
                        }
                    }
                    //Asignamos en los Combos los valores de cada Celda correspondiente
                    foreach (OpcionCombo oc in comboRol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["idRol"].Value))
                        {
                            int indice_combo = comboRol.Items.IndexOf(oc);
                            comboRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void inputDNI_KeyPress(object sender, KeyPressEventArgs e) //Evento KeyPress para el input DNI
        {
            //Cosume el Evento si lo que se intenta ingresar por Teclado NO es Numero y No es la tecla "borrar"
            if(!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back) 
            {
                e.Handled = true;
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

            //Filtramos lo Usuarios
            List<CE_Usuario> listaUsuarios = new CN_Usuario().Filtrar(inputBuscar.Text);

            //Modificamos el Alto de las filas
            DataGridViewRow row = dgvData.RowTemplate;
            row.Height = 28;

            //Recorremos la Lista de Usuarios
            foreach (CE_Usuario usuario in listaUsuarios)
            {
                //Y agregamos a cada Usuario a la Grid
                dgvData.Rows.Add(new object[]
                {
                    usuario.Iden,
                    usuario.Nombre,
                    usuario.Apellido,
                    usuario.Dni,
                    usuario.Estado == true ? 1 : 0, //Preguntamos si es True, si lo es, su Valor es 1, caso contrario 0
                    usuario.Estado == true ? "Activo" : "Inactivo", //Preguntamos si es True, si lo es, su Valor es "Activo", caso contrario "Inactivo"
                    usuario.Rol.Iden,
                    usuario.Rol.Rol,
                    usuario.Clave,
                    "",
                });
            }
        }

        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Clear(); //Vaciar tabla
            inputBuscar.Text = ""; //Vaciar campo
            Listar(); //Volver a Listar los Usuarios
        }

        private void Listar() 
        {
            //Listamos lo Usuarios
            List<CE_Usuario> listaUsuarios = new CN_Usuario().Listar();

            //Modificamos el Alto de las filas
            DataGridViewRow row = dgvData.RowTemplate;
            row.Height = 28;

            //Recorremos la Lista de Usuarios
            foreach (CE_Usuario usuario in listaUsuarios)
            {
                //Y agregamos a cada Usuario a la Grid
                dgvData.Rows.Add(new object[]
                {
                    usuario.Iden,
                    usuario.Nombre,
                    usuario.Apellido,
                    usuario.Dni,
                    usuario.Estado == true ? 1 : 0, //Preguntamos si es True, si lo es, su Valor es 1, caso contrario 0
                    usuario.Estado == true ? "Activo" : "Inactivo", //Preguntamos si es True, si lo es, su Valor es "Activo", caso contrario "Inactivo"
                    usuario.Rol.Iden,
                    usuario.Rol.Rol,
                    usuario.Clave,
                    "",
                });
            }
        }

        private void inputBuscar_Click(object sender, EventArgs e)
        {
            if (inputBuscar.Text == "Filtrar por DNI o Rol")
            {
                inputBuscar.Text = "";
                inputBuscar.ForeColor = Color.Black;
            }
        }

        private void inputBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputBuscar.Text))
            {
                inputBuscar.Text = "Filtrar por DNI o Rol";
                inputBuscar.ForeColor = Color.Gray;
            }
        }
    }
}
