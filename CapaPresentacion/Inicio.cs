using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Consumimos la Capa Entidad
//using CapaEntidad;
//using CapaNegocio;
//Consumimos FontAwesome para el Atributo MenuActivo
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static IconMenuItem MenuActivo = null; //Atributo de tipo Static que va a almacenar el Menu seleccionado por el Usuario
        private static Form FormActivo = null; //Atributo de tipo Static que va a almacenar el Formulario seleccionado por el Usuario respecto del Menu

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)  //Método encargado de Abril el Formulario y marcar el Menu activo
        {
            if (MenuActivo != null) //Preguntamos si hay un Menu ACTIVO, en caso de "True" 
            {
                MenuActivo.BackColor = Color.White; //Cambiamos el color a Blaco, o sea, NO ACTIVO
            }
            menu.BackColor = Color.Silver; //Cambiamos el color del Menu a Silver para marcar el Menu ACTIVO
            MenuActivo = menu; //Asignamos el Menu en el atributo Static MenuActivo

            if(FormActivo != null) //Preguntamos si hay un Formulario ACTIVO, en caso de "True" 
            {
                FormActivo.Close(); //Cerramos el Formulario ACTIVO para dar espacio al Siguiente...
            }
            FormActivo = formulario; //Asignamos el Formulario en el atributo Static FormActivo
            //Modificamos algunas Propiedades
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.WhiteSmoke;

            contenedor.Controls.Add(formulario); //Añadimos el Formulario ACTIVO al contenedor, este es de tipo Panel
            formulario.Show(); //Mostramos el Formulario
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            //Por defecto, se le intancia un Nuevo Formulario, esta completamente vacio
            //Por lo tanto donde dice "new Form()" remplazar por el Formulario adecuado...
            //Ejemplo: new Form() ---> new FormUsuario()
            AbrirFormulario((IconMenuItem)sender, new Form());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Form());
        }

        private void menuArticulos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Form());
        }

        private void menuPreventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Form());
        }

        private void menuFacturas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Form());
        }

        private void menuRemitos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Form());
        }
    }
}
