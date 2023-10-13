using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Articulo
    {
        private CD_Articulo cdArticulo = new CD_Articulo();

        public List<CE_Articulo> Listar(int? iden,string rubroMarca)
        {
           
            return cdArticulo.Listar(iden,rubroMarca);
        }

    }
}
