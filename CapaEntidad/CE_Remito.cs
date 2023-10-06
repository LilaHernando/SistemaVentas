using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class CE_Remito
    {
        /*Atributos llave*/
        private int iden {get;set;}
        private int GN_Sucursal_iden { get; set; }
        private int CMP_Estado_iden { get; set; }
        /*---------------*/
        private int idOperacion { get; set; }
        private int numero { get; set; }
        private string tipoRemito { get; set; }
        private DateTime fechadecarga { get; set; }

        public CE_Remito() { }
        
        public CE_Remito(int id,char letra,string tipo,long numero,DateTime fecha,int sucursal, int estado)
        {
            this.id = id;
            this.letra = letra;
            this.numero = numero;
            this.fecha = fecha;
            this.sucursal = sucursal;
            this.estado = estado;
        }
    }
}
