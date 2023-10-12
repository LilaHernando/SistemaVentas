using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Consumimos la Capa Datos y Capa Entidad
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario ObjUsuario = new CD_Usuario(); //Instanciamos un Objeto de la Clase CD_Usuario, la encargada de consumir la DB

        public List<CE_Usuario> Listar() //Método que retorna una Lista de tipo CE_Usuario (Clase Entidad de la tabla Usuario en la DB)
        {
            return ObjUsuario.Listar(); //Retorna el Obj con su método
        }

        public int Registrar(CE_Usuario Obj, out string mensaje, string confirmar) //Este método va a registrar un Usuario en la DB atravez de un SP
        {
            //Al parametro mensaje le damos valor vacio
            mensaje = string.Empty;

            //Reglas
            if (Obj.Nombre == "" || Obj.Apellido == "" || Obj.Dni == "" || Obj.Clave == "") //Verificar si hay campos vacios
            {
                mensaje = "Uno o más de los campos estan vacios";
            }
            else if (confirmar == "") //Verificar si la confirmacion de la contraseña esta vacia
            {
                mensaje = "Falta confirmación de la contraseña";
            }     
            else if (!Obj.Clave.Equals(confirmar)) //Verificamos si las contraseñas coinciden
            {
                mensaje = "Las contraseñas no coinciden";
            }

            if (mensaje != string.Empty ) //Si mensaje no esta vacio, retornamos 0 y no completamos el registro
            {
                return 0;
            }
            else 
            {
                return ObjUsuario.Registrar(Obj, out mensaje); //Retorna el Obj con su método, pasamos el Obj y el mensaje de salida
            }
        }

        public bool Editar(CE_Usuario Obj, out string mensaje, string confirmar) //Este método va a editar un Usuario en la DB atravez de un SP
        {
            //Al parametro mensaje le damos valor vacio
            mensaje = string.Empty;

            //Reglas
            if (Obj.Nombre == "" || Obj.Apellido == "" || Obj.Dni == "") //Verificar si hay campos vacios
            {
                mensaje = "Uno o más de los campos estan vacios";
            }
            else if (Obj.Clave == "") //Si la clave esta vacia
            {
                Obj.Clave =  null; //Asignamos a la propiedad Clave un valor Null para evitar la modificacion de la clave
            }
            else if (Obj.Clave != "") //Si la clave no esta vacia
            {
                if (confirmar == "") //Verificar si la confirmacion de la contraseña esta vacia
                    mensaje = "Falta confirmación de la contraseña";
            }
            else if (!Obj.Clave.Equals(confirmar)) //Verificamos si las contraseñas coinciden
            {
                mensaje = "Las contraseñas no coinciden";
            }
            if (mensaje != string.Empty) //Si mensaje no esta vacio, retornamos false y no completamos la edicion
            {
                return false;
            }
            else
            {
                return ObjUsuario.Editar(Obj, out mensaje); //Retorna el Obj con su método, pasamos el Obj y el mensaje de salida
            }
        }
    }
}
