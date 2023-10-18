using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class CN_Remito
    {
        private CD_Remito cD_Remito = new CD_Remito();  //Instancio un objeto de clase remito, de la capa de datos, para hacer uso de todos los atributos provenientes de la base de datos.

        public List<CE_Remito> Listar()
        {                                               //Metodo que muestra una lista de objetos de la entidad CE_Remito y lo retorna. 
 
            return cD_Remito.Listar();                  //Retorna el metodo Listar del objeto cD_Remito.
        }
    }
}