﻿using System;
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
            //Si uno o más de los Campos estan vacios, se lo notificamos al Usuario
            if (inputClave.Text.Equals(string.Empty) || inputUsuario.Text.Equals(string.Empty))
            {
                //Mensaje
                MessageBox.Show("Uno o más de los Campos estan vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                inputClave.Text = string.Empty;
            }
            else if (inputUsuario.TextLength <= 7) 
            {
                //Mensaje
                MessageBox.Show("Faltan digitos en su Documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                inputClave.Text = string.Empty;
            }
            else
            {
                //Instanciamos un Objeto de tipo Usuario con su Método Listar 
                //Buscamos un Usuario en la base de datos él cual contega los mismos datos ingresados en los Inputs del Formulario
                List<CE_Usuario> listaUsuarios = new CN_Usuario().Listar();
                //Codigo anterior: CE_Usuario objUsuario = new CN_Usuario().Listar().Where(u => u.Dni == inputUsuario.Text && u.Clave == inputClave.Text).FirstOrDefault();

                //aplicamos Linq
                var userQuery =
                    (from u in listaUsuarios
                     where u.Dni == inputUsuario.Text
                     && u.Clave == inputClave.Text
                     select u).FirstOrDefault(); //Gracias a FirstOrDefault nos quedamos con un Usuario en vez de una Lista, por lo tanto no es necesario usar un foreach para ejecutar la query

                if (userQuery != null) //Si la busqueda arroja distinto de nulo, significa que se encontro una coincidencia
                {
                    if (userQuery.Estado != true) //Preguntamos si el Usuario esta INACTIVO
                    {
                        MessageBox.Show("Usuario INACTIVO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        inputClave.Text = string.Empty;
                    }
                    else //Si esta ACTIVO se logea
                    {
                        Inicio inicio = new Inicio(userQuery); //Se instancia el Formulario Inicio y le pasamos por parametro el Usuario logeado

                        inicio.Show(); //Mostramos Inicio

                        this.Hide(); //Ocultamos Login

                        inicio.FormClosing += Form_Closing; //Añadimos el metodo Form_Closing al Formulario Inicio y solo se ejecuta cuando se cierra el mismo
                    }
                }
                else //Caso de no encontrar un coincidencia, lo notificamos...
                {
                    //Mensaje
                    MessageBox.Show("Documento o Contraseña incorrectas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    inputClave.Text = string.Empty;
                }
            }
        }

        private void Form_Closing(object sender, FormClosingEventArgs e ) //Método para volver a mostrar el Formulario Login cuando se cierra el Formulario Inicio
        {
            //Se vacian los campos para que no se mantengan los datos en los campos de texto
            inputUsuario.Text = string.Empty;
            inputClave.Text = string.Empty;

            this.Show(); //Se muestra el Login
            inputUsuario.Select();
        }

        private void inputUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            inputUsuario.Select();
        }

        private void inputClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar_Click(sender, e);
            }
        }
    }
}
