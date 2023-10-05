using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agragamos la libreria System.Configuration
using System.Configuration;

/*
Verificar App.config antes de intentar una conexion a la base
*/

namespace CapaDatos
{
    public class Conexion
    {
        //Consumo de la libreria anterior mente nombrada
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
    }
}
