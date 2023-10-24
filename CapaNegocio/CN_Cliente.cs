using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        //public List<CE_Cliente> ListarClientes(int dni)
        //{
        //    //lógica para listar clientes
        //}
      
        private CD_Cliente ObjCliente = new CD_Cliente(); //Instanciamos un Objeto de la Clase CD_Cliente, la encargada de consumir la DB

        public List<CE_Cliente> ListarClientes(int dni) //Método que retorna una Lista de tipo CE_Cliente (Clase Entidad de la tabla Cliente en la DB)
        {
              return ObjCliente.ObtenerClientes(dni); //Retorna el Obj con su método
        }

        public int Registrar(CE_Cliente Obj, out string mensaje) //Este método va a registrar un Cliente en la DB atravez de un SP
        {
            //Al parametro mensaje le damos valor vacio
            mensaje = string.Empty;

            //Reglas
            if (Obj.Nombre == "" || Obj.Apellido == "" || Obj.Dni == "" || Obj.Correo_electronico == "" || Obj.Telefono == "") //Verificar si hay campos vacios
            {
                mensaje = "Uno o más de los campos estan vacios";
            }

            if (mensaje != string.Empty) //Si mensaje no esta vacio, retornamos 0 y no completamos el registro
            {
                return 0;
            }
            else
            {
                return ObjCliente.Registrar(Obj, out mensaje); //Retorna el Obj con su método, pasamos el Obj y el mensaje de salida
            }
        }

        public bool Editar(CE_Cliente Obj, out string mensaje) //Este método va a editar un Usuario en la DB atravez de un SP
        {
            //Al parametro mensaje le damos valor vacio
            mensaje = string.Empty;

            //Reglas
            if (Obj.Nombre == "" || Obj.Apellido == "" || Obj.Dni == "" || Obj.Correo_electronico == "" || Obj.Telefono == "") //Verificar si hay campos vacios
            {
                mensaje = "Uno o más de los campos estan vacios";
            }

            if (mensaje != string.Empty) //Si mensaje no esta vacio, retornamos false y no completamos la edicion
            {
                return false;
            }
            else
            {
                return ObjCliente.Editar(Obj, out mensaje); //Retorna el Obj con su método, pasamos el Obj y el mensaje de salida
            }
        }

        public List<CE_Cliente> Filtrar(string filtrar) //Método que retorna una Lista Filtrada de tipo CE_Cliente (Clase Entidad de la tabla Cliente en la DB)
        {
            return ObjCliente.Filtrar(filtrar); //Retorna el Obj con su método
        }
    }
}
