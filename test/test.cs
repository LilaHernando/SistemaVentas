using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaEntidad;

namespace test
{
    public class test
    {

        public static void Main(string[] args)
        {
            CN_Preventa cN_Preventa = new CN_Preventa();
            List<CE_Preventa> list = cN_Preventa.listar_Preventas();
        }

    }
}
