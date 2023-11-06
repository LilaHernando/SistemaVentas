using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Usuario
    {
        public static CE_Usuario instance = null;

        public static readonly object lockObject = new object();

        public int Iden { get; set; }
        public CE_Rol Rol { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }

        public static CE_Usuario Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (lockObject)
                    {
                        if(instance== null)
                        {
                            instance = new CE_Usuario();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
