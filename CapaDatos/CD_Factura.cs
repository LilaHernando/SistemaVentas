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
        public List<CE_Factura> ObtenerFacturas(int idOperacion)
        {
            List<CE_Factura> ListaFacturas = new List<CE_Factura>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))

                try
                {
                    SqlCommand cmd = new SqlCommand("CMP_ObtenerFacturas_SEL", conexion);
                    cmd.Parameters.AddWithValue("idOperacion", idOperacion);

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ListaFacturas.Add(new CE_Factura()
                            {
                                Iden = Convert.ToInt32(dr["iden"]),
                                Letra = Convert.ToChar(dr["letra"]),
                                Numero = Convert.ToInt32(dr["numero"]),
                                MontoTotal = Convert.ToDecimal(dr["montoTotal"]),
                                CMP_Estado_iden = Convert.ToInt32(dr["CMP_Estado_iden"]),
                                IdOperacion = Convert.ToInt32(dr["idOperacion"]),
                                FechaDeCarga = Convert.ToDateTime(dr["fechadecarga"]),
                                CE_Sucursal = new CE_Sucursal() { descripcion = Convert.ToString(dr["descripcion"]) },
                                CE_Cliente = new CE_Cliente() {
                                    Nombre = Convert.ToString(dr["nombre"]),
                                    Apellido = Convert.ToString(dr["apellido"]),
                                    Dni = Convert.ToString(dr["dni"])
                                }
                            });

                        }
                    }

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    ListaFacturas = new List<CE_Factura>();
                }

            return ListaFacturas;
        }

        public List<CE_Preventa> ObtenerPreventasPorDNI(int dni)
        {
            List<CE_Preventa> ListaPreventasPorDNI = new List<CE_Preventa>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))

                try
                {
                    SqlCommand cmd = new SqlCommand("PVTA_ObtenerPreventasPorDNI_SEL", conexion);
                    cmd.Parameters.AddWithValue("dni", dni);

                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ListaPreventasPorDNI.Add(new CE_Preventa()
                            {
                                Monto = Convert.ToDecimal(dr["monto"]),
                                IdOperacion = Convert.ToInt32(dr["idOperacion"]),
                                CE_Sucursal = new CE_Sucursal() { descripcion = Convert.ToString(dr["descripcion"]), iden = Convert.ToInt32(dr["iden"]) },
                                CE_Cliente = new CE_Cliente() { Nombre = Convert.ToString(dr["nombre"]), Apellido = Convert.ToString(dr["apellido"]) }

                            });

                        }
                    }

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    ListaPreventasPorDNI = new List<CE_Preventa>();
                }
            return ListaPreventasPorDNI;
        }

        public void CrearFactura(CE_Factura Factura, out string mensaje)
        {
            mensaje = string.Empty;

            CE_Factura NuevaFactura = new CE_Factura();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))

                try
                {
                    SqlCommand cmdFactura = new SqlCommand("CMP_CrearFactura_INSUPD", conexion);
                    cmdFactura.Parameters.AddWithValue("GN_Sucursal_iden", Factura.GN_Sucursal_iden);
                    cmdFactura.Parameters.AddWithValue("letra", Factura.Letra);
                    cmdFactura.Parameters.AddWithValue("numero", Factura.Numero);
                    cmdFactura.Parameters.AddWithValue("montoTotal", Factura.MontoTotal);
                    cmdFactura.Parameters.AddWithValue("CMP_Estado_iden", Factura.CMP_Estado_iden);
                    cmdFactura.Parameters.AddWithValue("idOperacion", Factura.IdOperacion);
                    cmdFactura.Parameters.AddWithValue("fechadecarga", Factura.FechaDeCarga);

                    cmdFactura.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmdFactura.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    cmdFactura.ExecuteNonQuery();

                    if (Convert.ToString(cmdFactura.Parameters["mensaje"].Value) != "")
                    {
                        mensaje = Convert.ToString(cmdFactura.Parameters["mensaje"].Value);
                    }
                    else
                    {
                        SqlCommand cmdFacturaPreventa = new SqlCommand("CMP_CrearFacturaPorPreventa_INSUPD", conexion);
                        cmdFacturaPreventa.Parameters.AddWithValue("GN_Sucursal_iden", Factura.GN_Sucursal_iden);
                        cmdFacturaPreventa.Parameters.AddWithValue("idOperacion", Factura.IdOperacion);

                        cmdFacturaPreventa.CommandType = CommandType.StoredProcedure;
                        cmdFacturaPreventa.ExecuteNonQuery();
                    }

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }
        }
    }

}


