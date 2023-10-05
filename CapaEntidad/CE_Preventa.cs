using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class CE_Preventa { 
    

        public int iden { get; set; }
        public int GN_Sucursal_iden { get; set; }
        public int GN_Cliente_iden { get; set; }
        public string fechadecarga { get; set; }
        public int numero { get; set; }
        public int monto { get; set; }
        public int baja { get; set; }
        public int idOperacion { get; set; }
    }
}

