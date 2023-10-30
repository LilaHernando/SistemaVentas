using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class CN_Remito
    {
        private CD_Remito cD_Remito = new CD_Remito();

        public List<CE_Remito> Listar()
        {                                   
 
            return cD_Remito.Listar();          
        }
        
        public bool VerFactura(int idOperacion, out string message)
        {

            return cD_Remito.VerFactura(idOperacion, out message);
        }

        public void CrearRemito(CE_Remito Remito, out string mensaje)
        {
            cD_Remito.CrearRemito(Remito, out mensaje);
        }
    }
    
}