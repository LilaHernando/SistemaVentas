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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CE_Usuario objUsuario = new CN_Usuario().Listar().Where(u => u.Dni == inputUsuario.Text && u.Clave == inputClave.Text).FirstOrDefault();

            if (inputClave.Text.Equals("") || inputUsuario.Text.Equals(""))
            {
                MessageBox.Show("Uno o más de los Campos estan vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(objUsuario != null) 
            {
                Inicio inicio = new Inicio();

                inicio.Show();

                this.Hide();

                inicio.FormClosing += Form_Closing;
            }
            else 
            {
                MessageBox.Show("Documento o Contraseña incorrectas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
            }
        }

        private void Form_Closing(object sender, FormClosingEventArgs e )
        {
            inputUsuario.Text = "";
            inputClave.Text = "";

            this.Show();
        }
    }
}
