using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Preventa {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public int numero { get; set; }
        public Decimal monto { get; set; }
        public int baja { get; set; }
        public int idOperacion { get; set; }

        /*Foreign Key*/
        public int id_sucursal { get; set; }
        public int id_cliente { get; set; }
        
    }
}

