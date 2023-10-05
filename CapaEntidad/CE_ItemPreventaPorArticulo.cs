using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class CE_ItemPreventaPorArticulo
    {
        public int iden { get; set; }
        public int GN_Sucursal_iden { get; set; }
        public int PVTA_Preventa_iden { get; set; }
        public int GN_Articulo_iden { get; set; }
        public int PVTA_Preventa_sucursal { get; set; }
    }
}
