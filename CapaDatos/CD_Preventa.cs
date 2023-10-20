using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                                CE_Surcusal = new CE_Sucursal() { Id = Convert.ToInt32(dr["iden"]), Descripcion = Convert.ToString(dr["descripcion"]) },
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

        public void InsertarPreventa(CE_Preventa Preventa)
        {
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
                    cmd.ExecuteNonQuery();

                    onConexion.Close();

                    
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error SQL: " + e);
                }

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
       




    }
}
