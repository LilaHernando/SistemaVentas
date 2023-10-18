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
                try {
                    SqlCommand cmd = new SqlCommand("PVTA_List_Preventa_SEL", onConexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    onConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read()) {
                            listPreventas.Add(new CE_Preventa()
                            {
                                IdPreventa = Convert.ToInt32(dr["iden"]),
                                Fecha = Convert.ToDateTime(dr["fechadecarga"]),
                                Numero = Convert.ToInt32(dr["numero"]),
                                Monto = Convert.ToDecimal(dr["monto"]),
                                Baja = Convert.ToInt32(dr["baja"]),
                                IdOperacion = Convert.ToInt32(dr["idOperacion"]),
                                CE_Surcusal = new CE_Sucursal() {Id=Convert.ToInt32(dr["iden"]),Descripcion = Convert.ToString(dr["descripcion"]) },
                                CE_Cliente = new CE_Cliente {Nombre = Convert.ToString(dr["nombre"]), Apellido = Convert.ToString(dr["apellido"])},
                            });
                        }
                    }
                    onConexion.Close();
                }
                catch (SqlException e) {
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
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@iden", SqlDbType.Int)).Value = Preventa.IdPreventa;
                    cmd.Parameters.Add(new SqlParameter("@numero", SqlDbType.Int)).Value = Preventa.Numero;
                    cmd.Parameters.Add(new SqlParameter("@GN_Sucursal_iden", SqlDbType.Int)).Value = Preventa.Id_Sucursal;
                    cmd.Parameters.Add(new SqlParameter("@GN_Cliente_iden", SqlDbType.Int)).Value = Preventa.Id_Cliente;
                    cmd.Parameters.Add(new SqlParameter("@baja", SqlDbType.Bit)).Value = Preventa.Baja;
                    cmd.Parameters.Add(new SqlParameter("@monto", SqlDbType.Money)).Value = Preventa.Monto;
                    cmd.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime)).Value = Preventa.Fecha;
                    cmd.Parameters.Add(new SqlParameter("@idOperacion", SqlDbType.Int)).Value = Preventa.IdOperacion;

                    onConexion.Open();
                
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    onConexion.Close();

                    if (filasAfectadas >= 0)
                    {
                        Console.WriteLine("Inserción exitosa.");
                    }
                    else
                    {
                        Console.WriteLine("No se insertaron registros.");
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error SQL: " + e);
                }

            }
        }

        public int ObtenerIdCliente(int dni)
        {
            int idCliente = 0;

            using (SqlConnection onConexion = new SqlConnection(Conexion.cadena))
            {
                onConexion.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT iden FROM GN_Cliente WHERE dni = @Dni", onConexion))
                {
                    cmd.Parameters.AddWithValue("@Dni", dni);
                    idCliente = (int)cmd.ExecuteScalar();
                    onConexion.Close();
                }
            }
            return idCliente;
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
                            }) ;
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
