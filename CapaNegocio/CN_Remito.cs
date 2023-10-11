using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Utilizamos la capa de datos y de entidades.
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Remito
    {
        private CD_Remito cD_Remito = new CD_Remito();  //Instancio un objeto de clase Remito, de la capa de datos.

        public List<CE_Remito> Listar() {   //Defino el metodo List que va a listar los objetos Remito que voy a necesitar.

            return cD_Remito.Listar();  //Retorna el metodo Listar del objeto remito
        } 
    }
}
