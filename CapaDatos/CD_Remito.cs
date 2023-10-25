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
        //------------- CONEX SP DE REMITO SELECT ------------------//
        public List<CE_Remito> Listar()                                                     //Creo un metodo de tipo LISTA de la Entidad Remito
        {
            List<CE_Remito> listarRemitos = new List<CE_Remito>();                          //Creo el objeto y lo almaceno en la variable listarRemitos

            using (SqlConnection onConexion = new SqlConnection(Conexion.cadena))           //Creo la conexion con la DB
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("[dbo].[CMP_Remito_SEL]", onConexion);      //Nuevo comando SQL, indico el SP a utilizar y la conexion
                    cmd.CommandType = CommandType.StoredProcedure;                              //Indico que es un comando de tipo SP

                    onConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())                              //Llamo a la funcion de SQL Data Reader encargada de leer los datos de la base.
                    {
                        while (dr.Read())                                                       //Mientras se ejecute dataReader, se construye uno a uno las instancias de la entidad CE_Remito, y se agregan a la lista.
                        {
                            listarRemitos.Add(new CE_Remito()                                   //Funciona como un consstructor y almacena los datos del SP en las variables.
                            {
                                iden = Convert.ToInt32(dr["idRemito"]),
                                Sucursal = new CE_Sucursal() { Descripcion = Convert.ToString(dr["descripcionSucursal"]) },
                                estadoRemito = new CE_Estado() { descripcion = Convert.ToString(dr["descripcionEstado"]) },
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

        //------------- CONEX SP DE REMITO INSERT ------------------//
        public void CrearRemito(CE_Remito Remito, out string mensaje)
        {
            mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))

                try
                {
                    SqlCommand cmdRemito = new SqlCommand("[dbo].[CMP_Remito_INSUPD]", conexion);
                    cmdRemito.Parameters.AddWithValue("GN_Sucursal_iden", Remito.Sucursal.iden);
                    cmdRemito.Parameters.AddWithValue("CMP_Estado_iden", Remito.estadoRemito.iden);
                    cmdRemito.Parameters.AddWithValue("letra", Remito.letra);
                    cmdRemito.Parameters.AddWithValue("tipoRemito", Remito.tipoRemito);
                    cmdRemito.Parameters.AddWithValue("numero", Remito.numero);
                    cmdRemito.Parameters.AddWithValue("idOperacion", Remito.idOperacion);
                    cmdRemito.Parameters.AddWithValue("fechadecarga", Remito.fechaRemito);

                    cmdRemito.CommandType = CommandType.StoredProcedure;

                    conexion.Open();

                    cmdRemito.ExecuteNonQuery();

                    SqlCommand cmdRemitoPorFactura = new SqlCommand("CMP_CrearRemitoPorFactura_INSUPD", conexion);
                    cmdRemitoPorFactura.Parameters.AddWithValue("GN_Sucursal_iden", Remito.Sucursal.iden);
                    cmdRemitoPorFactura.Parameters.AddWithValue("idOperacion", Remito.idOperacion);

                    cmdRemitoPorFactura.CommandType = CommandType.StoredProcedure;

                    cmdRemitoPorFactura.ExecuteNonQuery();

                    conexion.Close();

                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }
        }

        //------------- CONEX SP DE SUCURSALES ------------------//
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

        //------------- CONEX SP DE ESTADO ------------------//
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
        //------------- CONEX SP DE FACTURA ------------------//
        public bool VerFactura(int idOperacion, out string message)                                             //Metodo booleano que recibe un parametro de entrada INT, y sale un parametro string.
        {
            bool resultado = false;
            message = string.Empty;                                                                             //Inicializo las variables que por default inician en NULL
            using (SqlConnection onConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("[dbo].[CMP_Factura_SEL]", onConexion);                     //Nuevo comando sql denominado cmd de tipo SP
                    cmd.Parameters.AddWithValue("idOperacion", idOperacion);                                    //AddWithValue para parametro de entrada con valor, declarando el parametro para pasarlo al SP.
                    cmd.Parameters.Add("message", SqlDbType.VarChar, 50).Direction=ParameterDirection.Output;   //Add para parametro de salida, declarando el parametro para pasarlo al capa presentacion.
                    cmd.Parameters.Add("resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    

                    onConexion.Open();

                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["resultado"].Value);   //En la variable resultado, almaceno el parametro convertido a booleano
                    message = Convert.ToString(cmd.Parameters["message"].Value);        
                    onConexion.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error SQL: " + ex);
                    resultado = false;
                    message = ex.Message;
                }
            }
            return resultado;
        }

    }
   
}
