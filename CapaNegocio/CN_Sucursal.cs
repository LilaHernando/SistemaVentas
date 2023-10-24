using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    //------------------ Clase Sucursal ------------------
    public class CN_Sucursal
    {
        private CD_Remito cD_Sucursal = new CD_Remito();

        public List<CE_Sucursal> ListarSucursal()
        {

            return cD_Sucursal.ListarSucursal();
        }

    }
}
