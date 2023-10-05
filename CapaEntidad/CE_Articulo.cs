using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class CE_Articulo
    {
        public int iden { get; set; }
        public int codigoDeMaterial { get; set; }
        public string rubro { get; set; }
        public decimal costo { get; set; }
        public string marca { get; set; }
        public bool baja { get; set; }
    }
}
