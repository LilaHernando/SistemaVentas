using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Remito
    {
        public int iden {get;set;}
        public String nombreSucursal { get; set; }
        public String estadoRemito { get; set; }
        public int idOperacion { get; set; }
        public int numero { get; set; }

        public char letra { get; set; }
        public string tipoRemito { get; set; }
        public DateTime fechaRemito { get; set; }

    }
}
