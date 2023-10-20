using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Preventa {
        public int IdPreventa { get; set; }
        public DateTime Fecha { get; set; }
        public int Numero { get; set; }
        public Decimal Monto { get; set; }
        public int Baja { get; set; }
        public int IdOperacion { get; set; }

        /*Foreign Key*/
        public int Id_Sucursal { get; set; }
        public int Id_Cliente { get; set; }
        public CE_Sucursal CE_Sucursal { get; set; }
        public CE_Cliente CE_Cliente { get; set; }
    }
}

