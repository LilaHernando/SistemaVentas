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
    public class CN_Usuario
    {
        private CD_Usuario ObjUsuario = new CD_Usuario(); //Instanciamos un Objeto de la Clase CD_Usuario, la encargada de consumir la DB

        public List<CE_Usuario> Listar() //Método que retorna una Lista de tipo CE_Usuario (Clase Entidad de la tabla Usuario en la DB)
        {
            return ObjUsuario.Listar(); //Retorna el Obj con su método
        }
    }
}
