using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Factura
    {
        public List<CE_Factura> ObtenerFacturas()
        {
            List<CE_Factura> ListaFacturas = new List<CE_Factura>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))

            try
            {
                SqlCommand cmd = new SqlCommand("CMP_ObtenerFacturas_SEL", conexion);
                cmd.CommandType = CommandType.StoredProcedure; 

                conexion.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read()) //Mientras lea datos...
                    {
                        ListaFacturas.Add(new CE_Factura()
                        {

        //Atributos
                            Iden = Convert.ToInt32(dr["iden"]),
                            GN_Sucursal_iden = Convert.ToInt32(dr["GN_Sucursal_iden"]),
                            Letra = Convert.ToChar(dr["letra"]),
                            Numero = Convert.ToInt32(dr["numero"]),
                            MontoTotal = Convert.ToInt32(dr["monto"]),
                            CMP_Estado_iden = Convert.ToInt32(dr["CMP_Estado_iden"]),
                            IdOperacion = Convert.ToInt32(dr["idOperacion"]),
                            FechaDeCarga = Convert.ToDateTime(dr["fechadecarga"]),



                        });
                    }
                }

                conexion.Close(); //Cerramos la Conexion
            }
            catch (Exception ex)
            {
                ListaFacturas = new List<CE_Factura>(); //En caso de error retornamos una Lista vacia
            }
        }
    }
}


