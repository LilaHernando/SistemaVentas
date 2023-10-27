using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Factura
    {
        private CD_Factura ObjFactura = new CD_Factura(); 
        public List<CE_Factura> ListarFacturas(int idOperacion)
        { 
           return ObjFactura.ObtenerFacturas(idOperacion); 
        }

        public List<CE_Preventa> ObtenerPreventasPorDNI(int dni)
        {
            return ObjFactura.ObtenerPreventasPorDNI(dni);
        }
        public void CrearFactura(CE_Factura Factura, out string mensaje)
        {
            ObjFactura.CrearFactura(Factura, out mensaje);
        }
    }
}
