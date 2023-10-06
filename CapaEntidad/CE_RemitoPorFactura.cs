using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class CMP_RemitoPorFactura {
        /*Tabla de llaves*/
        private int iden { get; set; }
        private int GN_Sucursal_iden { get; set; }  //Identificador de sucursal

                //Llaves de factura
        private int CMP_Factura_iden { get; set; }  
        private int CMP_Factura_sucursal { get; set; }

                //Llaves de remito
        private int CMP_Remito_iden { get; set; }
        private int CMP_Remito_sucursal { get; set; }


    }
}
