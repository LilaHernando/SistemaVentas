using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class CMP_RemitoPorFactura {
        public int iden { get; set; }
        public int GN_Sucursal_iden { get; set; }

        //Llaves de factura
        public int CMP_Factura_iden { get; set; }  
        public int CMP_Factura_sucursal { get; set; }

        //Llaves de remito
        public int CMP_Remito_iden { get; set; }
        public int CMP_Remito_sucursal { get; set; }
        
    }
}
