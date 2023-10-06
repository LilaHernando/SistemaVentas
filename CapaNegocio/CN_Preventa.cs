using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaNegocio
{
    public class CN_Preventa
    {
        private CD_Preventa cD_Preventa = new CD_Preventa();

        public List<CE_Preventa> listar_Preventas()
        {
            return cD_Preventa.ListarPreventas();
        }
    }
}
