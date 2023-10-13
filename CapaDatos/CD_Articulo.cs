using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Articulo
    {
        public List<CE_Articulo> Listar(int? iden, string filtro)
        {
            List<CE_Articulo> lista = new List<CE_Articulo>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GN_Articulo_SEL", conexion);
                    cmd.Parameters.AddWithValue("iden", iden);
                    cmd.Parameters.AddWithValue("rubroMarca", filtro);

                    cmd.CommandType = CommandType.StoredProcedure;


                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CE_Articulo()
                            {
                                iden = Convert.ToInt32(dr["iden"]),
                                codigoDeMaterial = Convert.ToInt32(dr["codigoDeMaterial"]),
                                rubro = dr["rubro"].ToString(),
                                costo = Convert.ToDecimal(dr["costo"]),
                                marca = dr["marca"].ToString(),
                                baja = Convert.ToBoolean(dr["baja"]) 
                            });
                        }
                    }
                    conexion.Close();

                }
                catch (Exception ex)
                {
                    lista = new List<CE_Articulo>();
                }
            }
            return lista;
        }
    }
}
