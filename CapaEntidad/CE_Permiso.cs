using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Permiso
    {
        public int Iden { get; set; }
        public CE_Rol Rol { get; set; }
        public string NombreMenu { get; set; }
    }
}
