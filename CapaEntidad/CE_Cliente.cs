using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Cliente
    {
        public int id { get; set; }
        public string dni { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public DateTime feche_nacimiento { get; set; }
        public string correo_electronico { get; set; }
        public string telefono { get; set; }

    }
}
