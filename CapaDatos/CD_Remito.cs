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
        public List<CE_Remito> Listar() {                                                       //Metodo publico de Listar remitos
                List<CE_Remito> listarRemitos = new List<CE_Remito>();                          //Creo el objeto y lo almaceno en la variable listarRemitos

            using (SqlConnection onConexion = new SqlConnection(Conexion.cadena)) {             //Creo la conexion con la DB

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
                                //Atributos del SP, definirlos y convertirlos. ODEN DE LOS CAMPOS: idRemito, descripcionSucursal,  descripcionEstado,  idOperacion, numeroRemito, letraRemito, tipoRemito, fechaRemito
                                //  iden, nombreSucursal, estadoRemito, idOperacion, numero, letra, tipoRemito, fechaRemito.
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
        }
    
    
}
