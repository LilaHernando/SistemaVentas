using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class CE_Factura
    {
        public int Iden { get; set; }
        public int GN_Sucursal_iden { get; set; }
        public char Letra { get; set; }
        public int Numero { get; set; }
        public decimal MontoTotal { get; set; }
        public int CMP_Estado_iden { get; set; }
        public int IdOperacion { get; set; }
        public DateTime FechaDeCarga { get; set; }
        public CE_Sucursal CE_Sucursal { get; set; }

    }
}
