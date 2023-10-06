using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class CE_ItemPreventaPorArticulo
    {
        /*Primary Key*/
        public int id { get; set; }

        /*Foreing Key*/
        public int id_sucursal { get; set; }
        public int id_preventa { get; set; }
        public int id_articulo { get; set; }

        /*Primary Key Compuesta*/
        public int id_preventa_sucursal { get; set; }
    }
}
