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
    }
}
