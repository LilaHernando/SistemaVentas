using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class CE_Factura
    {
        public int Iden { get; set; }
        public int GN_Sucursal_iden { get; set; }
        public char Letra { get; set; }
        public int Numero { get; set; }
        public decimal MontoTotal { get; set; }
        public int CMP_Estado_iden { get; set; }
        public int IdOperacion { get; set; }
        public DateTime FechaDeCarga { get; set; }
    }


    class CE_FacturaPorPreventa
    {
        public int Iden { get; set; }
        public int GN_Sucursal_iden { get; set; }
        public int PVTA_Preventa_iden { get; set; }
        public int PVTA_Preventa_sucursal { get; set; }
        public int CMP_Factura_iden { get; set; }
        public int CMP_Factura_sucursal { get; set; }

    }
    class CE_Estado
    {
        public int Iden { get; set; }
        public string Descripcion { get; set; }
    }
}
