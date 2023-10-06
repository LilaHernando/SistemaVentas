using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class CE_Preventa {

        private int id { get; set; }
        private DateTime fecha { get; set; }
        private int numero { get; set; }
        private int monto { get; set; }
        private int baja { get; set; } 
        private int idOperacion { get; set; }

        /*Foreign Key*/
        private int id_sucursal { get; set; }
        private int id_cliente { get; set; }
        
       
    }
}

