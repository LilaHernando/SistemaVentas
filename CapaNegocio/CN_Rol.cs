using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Consumimos la Capa Datos y Capa Entidad
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Rol
    {
        private CD_Rol ObjRol = new CD_Rol(); //Instanciamos un Objeto de la Clase CE_Permiso, la encargada de consumir la DB

        public List<CE_Rol> Listar() //Método que retorna una Lista de tipo CE_Usuario (Clase Entidad de la tabla Usuario en la DB)
        {
            return ObjRol.Listar(); //Retorna el Obj con su método
        }
    }
}
