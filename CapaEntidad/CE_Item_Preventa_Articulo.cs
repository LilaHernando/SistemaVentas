using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /* Clase que modela la tabla intermedia n:n ItemPreventaPorArticulo */
    public class CE_Item_Preventa_Articulo
    {
        public int Iden { get; set; }
        public int GN_Sucursal_iden { get; set; }
        public int PVTA_Preventa_iden { get; set; }
        public int PVTA_Preventa_sucursal { get; set; }
        public int GN_Articulo_iden { get; set; }

    }
}
