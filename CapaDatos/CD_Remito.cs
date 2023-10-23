using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class CD_Remito
    {
        //------------- LISTA DE REMITOS ------------------//
        public List<CE_Remito> Listar()
        {                                                       
            List<CE_Remito> listarRemitos = new List<CE_Remito>();                          //Creo el objeto y lo almaceno en la variable listarRemitos

            using (SqlConnection onConexion = new SqlConnection(Conexion.cadena))
            {             //Creo la conexion con la DB

                try
                {
                    SqlCommand cmd = new SqlCommand("[dbo].[CMP_Remito_SEL]", onConexion);              //Nuevo comando SQL, indico el SP a utilizar y la conexion
                    cmd.CommandType = CommandType.StoredProcedure;                              //Indico que es un comando de tipo SP

                    onConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())                              //Llamo a la funcion de SQL Data Reader encargada de leer los datos de la base.
                    {
                        while (dr.Read())                                                       //Mientras se ejecute dataReader
                        {
                            listarRemitos.Add(new CE_Remito()
                            {
                                iden = Convert.ToInt32(dr["idRemito"]),
                                nombreSucursal = Convert.ToString(dr["descripcionSucursal"]),
                                estadoRemito = Convert.ToString(dr["descripcionEstado"]),
                                idOperacion = Convert.ToInt32(dr["idOperacion"]),
                                numero = Convert.ToInt32(dr["numeroRemito"]),
                                letra = Convert.ToChar(dr["letraRemito"]),
                                tipoRemito = Convert.ToString(dr["tipoRemito"]),
                                fechaRemito = Convert.ToDateTime(dr["fechaRemito"]),

                            });

                        }
                    }
                    onConexion.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error SQL: " + ex);
                }
                return listarRemitos;
            }

        }

        //------------- LISTA DE SUCURSALES ------------------//
        public List<CE_Sucursal> ListarSucursal()
        {                                                       
            List<CE_Sucursal> listarSucursal = new List<CE_Sucursal>();                          

            using (SqlConnection onConexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("[dbo].[GN_Sucursal_SEL]", onConexion);              
                    cmd.CommandType = CommandType.StoredProcedure;                              

                    onConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())                              
                    {
                        while (dr.Read())                                                       
                        {
                            listarSucursal.Add(new CE_Sucursal()
                            {
                                iden = Convert.ToInt32(dr["iden"]),
                                Descripcion = Convert.ToString(dr["descripcion"]),
                                Telefono = Convert.ToString(dr["telefono"]),
                            });

                        }
                    }
                    onConexion.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error SQL: " + ex);
                }
                return listarSucursal;
            }
        }

        //------------- LISTA DE ESTADOS ------------------//
        public List<CE_Estado> ListarEstado()
        {
            List<CE_Estado> listarEstado = new List<CE_Estado>();

            using (SqlConnection onConexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("[dbo].[CMP_Estado_SEL]", onConexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    onConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listarEstado.Add(new CE_Estado()
                            {
                                iden = Convert.ToInt32(dr["iden"]),
                                descripcion = Convert.ToString(dr["descripcion"])
                            });

                        }
                    }
                    onConexion.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error SQL: " + ex);
                }
                return listarEstado;
            }
        }

    }
}
