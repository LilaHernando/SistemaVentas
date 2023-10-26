using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaNegocio
{
    public class CN_Preventa
    {
        private CD_Preventa cD_Preventa = new CD_Preventa();

        public List<CE_Preventa> listar_Preventas()
        {
            return cD_Preventa.ListarPreventas();
        }

        public int InsertarPreventa(CE_Preventa cE_Preventa){
            return cD_Preventa.InsertarPreventa(cE_Preventa);
        }

        public List<CE_Sucursal> Listar_Sucursales()
        {
            return cD_Preventa.ObtenerSucursales();
        }

        public int ObtenerUltimoIdPreventa()
        {
            return cD_Preventa.ObtenerUltimoIDPreventa();
        }
        public void INS_Preventa_Articulo(CE_Item_Preventa_Articulo Item_Preventa_Articulo)
        {
            cD_Preventa.INS_Preventa_Articulo(Item_Preventa_Articulo);
        }

        public List<CE_Articulo> ListarPreventaArticulo(int IdPreventa)
        {
            return cD_Preventa.ListarArticulosPreventa(IdPreventa);
        }

        public void UpdateMontoPreventa(Decimal Monto, int IdPreventa)
        {
            cD_Preventa.UpdateMontoPreventa(Monto, IdPreventa);
        }
    }
}
