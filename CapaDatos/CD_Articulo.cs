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
                    cmd.Parameters.AddWithValue("codigoMaterial", iden);
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

        public int Registrar(CE_Articulo articulo)
        {
            int idArticuloGenerado = 0;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GN_Articulo_INSUPD", conexion);

                    cmd.Parameters.AddWithValue("codigoMaterial", articulo.codigoDeMaterial);
                    cmd.Parameters.AddWithValue("rubro", articulo.rubro);
                    cmd.Parameters.AddWithValue("costo", articulo.costo);
                    cmd.Parameters.AddWithValue("marca", articulo.marca);
                    cmd.Parameters.AddWithValue("baja", articulo.baja);

                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    //cmd.ExecuteNonQuery();

                    // Ejecutar el stored procedure
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idArticuloGenerado = Convert.ToInt32(reader["NuevoID"]);
                        }
                    }

                    conexion.Close();

                }
                catch (Exception ex)
                {
                    idArticuloGenerado = 0;
                    string mensaje = "Ocurrió un error inesperado: " + ex.Message;
                    Console.WriteLine(mensaje);
                }
            }

            return idArticuloGenerado;
        }

        public bool Editar(CE_Articulo articulo)
        {
            bool respuesta = false;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GN_Articulo_INSUPD", conexion);
                    cmd.Parameters.AddWithValue("iden", articulo.iden);
                    cmd.Parameters.AddWithValue("codigoMaterial", articulo.codigoDeMaterial);
                    cmd.Parameters.AddWithValue("rubro", articulo.rubro);
                    cmd.Parameters.AddWithValue("costo", articulo.costo);
                    cmd.Parameters.AddWithValue("marca", articulo.marca);
                    cmd.Parameters.AddWithValue("baja", articulo.baja);

                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = true;

                    conexion.Close();

                }
                catch (Exception ex)
                {
                    respuesta = false;
                    string mensaje = "Ocurrió un error inesperado: " + ex.Message;
                    Console.WriteLine(mensaje);
                }
            }

            return respuesta;
        }

        public List<CE_Articulo> ListarArticulosActivos()
        {
            List<CE_Articulo> ListArticulosActivos = new List<CE_Articulo>();
            using (SqlConnection onConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GN_Articulo_SEL_Activos", onConexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    onConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ListArticulosActivos.Add(new CE_Articulo()
                            {
                                iden = Convert.ToInt32(dr["iden"]),
                                codigoDeMaterial = Convert.ToInt32(dr["codigoDeMaterial"]),
                                descripcion = dr["descripcion"].ToString(),
                                costo = Convert.ToDecimal(dr["costo"]),
                            }) ;
                        }
                    }
                    onConexion.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error SQL: " + e);
                }
                return ListArticulosActivos;
            }

        }
    }
}
