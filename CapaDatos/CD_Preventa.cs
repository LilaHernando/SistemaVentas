using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Preventa
    {
        public List<CE_Preventa> ListarPreventas()
        {
            List<CE_Preventa> listPreventas = new List<CE_Preventa>();
            using (SqlConnection onConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PVTA_List_Preventa_SEL", onConexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    onConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listPreventas.Add(new CE_Preventa()
                            {
                                IdPreventa = Convert.ToInt32(dr["iden"]),
                                Fecha = Convert.ToDateTime(dr["fechadecarga"]),
                                Numero = Convert.ToInt32(dr["numero"]),
                                Monto = Convert.ToDecimal(dr["monto"]),
                                Baja = Convert.ToInt32(dr["baja"]),
                                IdOperacion = Convert.ToInt32(dr["idOperacion"]),
                                CE_Sucursal = new CE_Sucursal() { Id = Convert.ToInt32(dr["iden"]), Descripcion = Convert.ToString(dr["descripcion"]) },
                                CE_Cliente = new CE_Cliente { Id = Convert.ToInt32(dr["iden"]), Nombre = Convert.ToString(dr["nombre"]), Apellido = Convert.ToString(dr["apellido"]) },
                            });
                        }
                    }
                    onConexion.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error SQL: " + e);
                }
                return listPreventas;
            }

        }

        public int InsertarPreventa(CE_Preventa Preventa)
        {
            int IdPreventaGenerada = 0;
            using (SqlConnection onConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PVTA_Preventa_INSUPD", onConexion);
                   
                    cmd.Parameters.AddWithValue("iden", Preventa.IdPreventa);
                    cmd.Parameters.AddWithValue("numero", Preventa.Numero);
                    cmd.Parameters.AddWithValue("GN_Sucursal_iden", Preventa.Id_Sucursal);
                    cmd.Parameters.AddWithValue("GN_Cliente_iden", Preventa.Id_Cliente);
                    cmd.Parameters.AddWithValue("baja", Preventa.Baja);
                    cmd.Parameters.AddWithValue("monto", Preventa.Monto);
                    cmd.Parameters.AddWithValue("fecha", Preventa.Fecha);
                    cmd.Parameters.AddWithValue("idOperacion", Preventa.IdOperacion);
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    onConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IdPreventaGenerada = Convert.ToInt32(reader["UltimoIdPreventa"]);
                        }
                    }

                onConexion.Close();

                    
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error SQL: " + e);
                }
                return IdPreventaGenerada;
            }
        }


        public List<CE_Sucursal> ObtenerSucursales()
        {
            List<CE_Sucursal> listSucursales = new List<CE_Sucursal>();
            using (SqlConnection onConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GN_ObtenerSuc_SEL", onConexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    onConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listSucursales.Add(new CE_Sucursal()
                            {
                                Id = Convert.ToInt32(dr["iden"]),
                                Descripcion = Convert.ToString(dr["descripcion"]),
                            });
                        }
                    }
                    onConexion.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error SQL: " + e);
                }
                return listSucursales;
            }
        }

        public int ObtenerUltimoIDPreventa()
        {
            int ultimoID = 0;

            using (SqlConnection onConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PVTA_UltimoIDPreventa_SEL", onConexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    onConexion.Open();

                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        ultimoID = Convert.ToInt32(result);
                    }

                    onConexion.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error SQL: " + e);
                }

                return ultimoID;
            }
        }

        public void INS_Preventa_Articulo(CE_Item_Preventa_Articulo Item_Preventa_Articulo)
        {
            using (SqlConnection onConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PVTA_ItemPreventaPorArticulo_INSUPD", onConexion);

                    cmd.Parameters.AddWithValue("GN_Sucursal_iden", Item_Preventa_Articulo.GN_Sucursal_iden);
                    cmd.Parameters.AddWithValue("PVTA_Preventa_iden", Item_Preventa_Articulo.PVTA_Preventa_iden);
                    cmd.Parameters.AddWithValue("PVTA_Preventa_sucursal", Item_Preventa_Articulo.PVTA_Preventa_sucursal);
                    cmd.Parameters.AddWithValue("GN_Articulo_iden", Item_Preventa_Articulo.GN_Articulo_iden);
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    onConexion.Open();
                    cmd.ExecuteNonQuery();

                    onConexion.Close();


                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error SQL: " + e);
                }

            }
        }

        public List<CE_Articulo> ListarArticulosPreventa(int IdPreventa)
        {
            List<CE_Articulo> articulos_preventa = new List<CE_Articulo>();

            using (SqlConnection onConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PVTA_Preventa_Articulo_SEL", onConexion);                
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_preventa", IdPreventa);
                    onConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            articulos_preventa.Add(new CE_Articulo()
                            {
                                codigoDeMaterial = Convert.ToInt32(dr["codigoDeMaterial"]),
                                rubro = Convert.ToString(dr["rubro"]),
                                costo= Convert.ToInt32(dr["costo"]) 
                            });
                            
                        }
                    }
                    onConexion.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error SQL: " + e);
                }

                return articulos_preventa;
            }
        }

        public void UpdateMontoPreventa(Decimal Monto, int IdPreventa)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                string consulta = "UPDATE PVTA_Preventa SET monto = @NuevoValor WHERE iden = @ID";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NuevoValor", Monto);
                    comando.Parameters.AddWithValue("@ID", IdPreventa);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error SQL: " + ex.Message);
                    }
                }
            }
        }

    }
}
