using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    //------------------ Clase Estado ------------------
    public class CN_Estado
    {
        private CD_Remito cD_Estado = new CD_Remito();

        public List<CE_Estado> ListarEstado()
        {
            return cD_Estado.ListarEstado();

        }
    }
}
