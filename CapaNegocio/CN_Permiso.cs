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
    public class CN_Permiso
    {
        private CD_Permiso ObjPermiso = new CD_Permiso(); //Instanciamos un Objeto de la Clase CE_Permiso, la encargada de consumir la DB

        public List<CE_Permiso> Listar(int idUsuario) //Método que retorna una Lista de tipo CE_Usuario (Clase Entidad de la tabla Usuario en la DB)
        {
            return ObjPermiso.Listar(idUsuario); //Retorna el Obj con su método
        }
    }
}
