using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Remito
    {
        /*Atributos llave*/
        public int iden {get;set;}
        public int GN_Sucursal_iden { get; set; }
        public int CMP_Estado_iden { get; set; }
        public int idOperacion { get; set; }
        public int numero { get; set; }
        public string tipoRemito { get; set; }
        public DateTime fechadecarga { get; set; }
    }
}
