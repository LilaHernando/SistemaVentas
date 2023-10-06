using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Agregamos las Capas Entidad y Negocio
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e) //Método para cerrar el Formulario Login
        {
            this.Close(); //Cierra el Login
        }

        private void btnIngresar_Click(object sender, EventArgs e) //Método para Ingresar al Formulario Inicio
        {
            //Instanciamos un Objeto de tipo Usuario con su Método Listar 
            //Buscamos un Usuario en la base de datos él cual contega los mismos datos ingresados en los Inputs del Formulario
            CE_Usuario objUsuario = new CN_Usuario().Listar().Where(u => u.Dni == inputUsuario.Text && u.Clave == inputClave.Text).FirstOrDefault();

            //Si uno o más de los Campos estan vacios, se lo notificamos al Usuario
            if (inputClave.Text.Equals("") || inputUsuario.Text.Equals(""))
            {
                //Mensaje
                MessageBox.Show("Uno o más de los Campos estan vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(objUsuario != null) //Si la busqueda arroja distinto de nulo, significa que se encontro una coincidencia
            {
                Inicio inicio = new Inicio(objUsuario); //Se instancia el Formulario Inicio y le pasamos por parametro el Usuario logeado

                inicio.Show(); //Mostramos Inicio

                this.Hide(); //Ocultamos Login

                inicio.FormClosing += Form_Closing; //Añadimos el metodo Form_Closing al Formulario Inicio y solo se ejecuta cuando se cierra el mismo
            }
            else //Caso de no encontrar un coincidencia, lo notificamos...
            {
                //Mensaje
                MessageBox.Show("Documento o Contraseña incorrectas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
            }
        }

        private void Form_Closing(object sender, FormClosingEventArgs e ) //Método para volver a mostrar el Formulario Login cuando se cierra el Formulario Inicio
        {
            //Se vacian los campos para que no se mantengan los datos en los campos de texto
            inputUsuario.Text = "";
            inputClave.Text = "";

            this.Show(); //Se muestra el Login
        }
    }
}
