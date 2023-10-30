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
using CapaEntidad;
using CapaNegocio;
//Consumimos FontAwesome para el Atributo MenuActivo
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static CE_Usuario UsuarioActual; //Atributo de tipo Static que va a almacenar el Usuario logeado
        private static IconMenuItem MenuActivo = null; //Atributo de tipo Static que va a almacenar el Menu seleccionado por el Usuario
        private static Form FormActivo = null; //Atributo de tipo Static que va a almacenar el Formulario seleccionado por el Usuario respecto del Menu

        public Inicio(CE_Usuario objUsuario) //El constructor solicita un parametro de tipo Objeto Usuario (clase de la CapaEntidad CE_Usuario)
        {
            UsuarioActual = objUsuario; //Este Objeto Usuario lo almacenamos en el Atributo de tipo Static UsuarioActual

            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e) //En el Método Filtramos que IconsMenu puede manipular el Usuario logeado
        {
            List<CE_Permiso> ListaPermiso = new CN_Permiso().Listar(UsuarioActual.Iden); //Generamos un listado de los Permisos

            foreach (IconMenuItem iconMenu in menu.Items) //Recorremos el Menu recolectando sus Items (O sea IconMenuItem)
            {
                bool permiso = ListaPermiso.Any(m => m.NombreMenu == iconMenu.Name); //En la ListaPermiso buscamos algun Menu que contenga el mismo nombre de su Atributo "NombreMenu"

                if(permiso == false) //Aquel que sea falso...
                {
                    iconMenu.Visible = false; //Se lo vuelve invisible
                }
            }

            textUsuarioActual.Text = UsuarioActual.Nombre + " " + UsuarioActual.Apellido; //Cargamos el Nombre y Apellido del Usuario logeado en un Label
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)  //Método encargado de Abrir el Formulario y marcar el Menu activo
        {
            if (MenuActivo != null) //Preguntamos si hay un Menu ACTIVO, en caso de "True" 
            {
                MenuActivo.BackColor = Color.White; //Cambiamos el color a Blanco, o sea, NO ACTIVO
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
            AbrirFormulario((IconMenuItem)sender, new FormUsuario());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormCliente());
        }

        private void menuArticulos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormArticulo());
        }

        private void menuPreventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormPreventa());
        }

        private void menuFacturas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormFactura());

        }
       

        private void menuRemitos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new CP_Remito()); //Instancia el formulario de remito.
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}
