using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class Remito
    {
        private int id {get;set;}
        private char letra { get; set; }
        private string tipo { get; set; }
        private long numero { get; set; }
        private DateTime fecha { get; set; }
        /*Atributos de FK*/
        private int sucursal { get; set; }
        private int estado { get; set; }

        public Remito() { }
        
        public Remito(int id,char letra,string tipo,long numero,DateTime fecha,int sucursal, int estado)
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
