using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Usuario
    {
        public int Iden { get; set; }
        public CE_Rol Rol { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }
    }
}
