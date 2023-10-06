using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class CE_FacturaPorPreventa
    {
        public int Iden { get; set; }
        public int GN_Sucursal_iden { get; set; }
        public int PVTA_Preventa_iden { get; set; }
        public int PVTA_Preventa_sucursal { get; set; }
        public int CMP_Factura_iden { get; set; }
        public int CMP_Factura_sucursal { get; set; }

    }
   
}
