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
   public class CD_Cliente
    {
        public List<CE_Cliente> ObtenerClientes(int dni) 
        {
            List<CE_Cliente> ListaClientes = new List<CE_Cliente>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GN_ObtenerCliente_SEL", conexion); //Pasamos la Conexion y el SP a ejecutar al CMD
                    cmd.Parameters.AddWithValue("dni", dni);

                    cmd.CommandType = CommandType.StoredProcedure; //Especificamos que el tipo de Comando que va a recibir el CMD es un SP

                    //Abrimos la Conexion
                    conexion.Open();


                    using (SqlDataReader dr = cmd.ExecuteReader()) //Usamos SqlDataReader para leer los datos devueltos por la DB
                    {
                        while (dr.Read()) //Mientras lea datos...
                        {
                            ListaClientes.Add(new CE_Cliente() 
                            {
                                //Atributos
                                Id = Convert.ToInt32(dr["iden"]),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                Dni = dr["DNI"].ToString(),
                              
                            });
                        }
                    }

                    conexion.Close(); //Cerramos la Conexion
                }
                catch (Exception ex)
                {
                    ListaClientes = new List<CE_Cliente>(); //En caso de error retornamos una Lista vacia
                }
            }
            return ListaClientes; //Retornamos la Lista

        }
            }
}
