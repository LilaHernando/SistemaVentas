using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Cliente
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public string Correo_electronico { get; set; }
        public string Telefono { get; set; }

    }
}
