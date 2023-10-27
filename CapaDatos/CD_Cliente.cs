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
                                Fecha_nacimiento = Convert.ToDateTime(dr["fechaNacimiento"]),
                                Correo_electronico = dr["correo"].ToString(),
                                Telefono = dr["telefono"].ToString()

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

        public int Registrar(CE_Cliente ObjCliente, out string mensaje) //Este método va a registrar un Cliente en la DB atravez de un SP
        {
            //Declaramos dos variables, una de tipo int y una de tipo string
            int resultado = 0;
            mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) //Consumimos la Cadena de Conexion de la Clase Conexion situada en CapaDatos
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GN_Cliente_INSUPD", conexion); //Pasamos la Conexion y el SP a ejecutar al CMD

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("nombre", ObjCliente.Nombre); //Pasamos los valores de cada atributo del Objeto CE_Cliente
                    cmd.Parameters.AddWithValue("apellido", ObjCliente.Apellido);
                    cmd.Parameters.AddWithValue("dni", ObjCliente.Dni);
                    cmd.Parameters.AddWithValue("fechaNacimiento", ObjCliente.Fecha_nacimiento);
                    cmd.Parameters.AddWithValue("correo", ObjCliente.Correo_electronico);
                    cmd.Parameters.AddWithValue("telefono", ObjCliente.Telefono);

                    //Parametros de salida
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure; //Especificamos que el tipo de Comando que va a recibir el CMD es un SP

                    //Abrimos la Conexion
                    conexion.Open();

                    cmd.ExecuteNonQuery(); //Ejecutamos el SP

                    //Almacenamos los valores de los Parametros de salida del SP en las variables declaradas al principio del Método 
                    resultado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();

                    conexion.Close(); //Cerramos la Conexion
                }
                catch (Exception ex)
                {
                    //Devolvemos el mensaje en caso de Error
                    resultado = 0;
                    mensaje = ex.Message;
                }
            }
            return resultado; //Retornamos el resultado del SP
        }

        public bool Editar(CE_Cliente ObjCliente, out string mensaje) //Este método va a editar un Cliente en la DB atravez de un SP
        {
            //Declaramos dos variables, una de tipo bool y una de tipo string
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) //Consumimos la Cadena de Conexion de la Clase Conexion situada en CapaDatos
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GN_Cliente_INSUPD", conexion); //Pasamos la Conexion y el SP a ejecutar al CMD

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("idenC", ObjCliente.Id); //Pasamos los valores de cada atributo del Objeto CE_Cliente
                    cmd.Parameters.AddWithValue("nombre", ObjCliente.Nombre);
                    cmd.Parameters.AddWithValue("apellido", ObjCliente.Apellido);
                    cmd.Parameters.AddWithValue("dni", ObjCliente.Dni);
                    cmd.Parameters.AddWithValue("fechaNacimiento", ObjCliente.Fecha_nacimiento);
                    cmd.Parameters.AddWithValue("correo", ObjCliente.Correo_electronico);
                    cmd.Parameters.AddWithValue("telefono", ObjCliente.Telefono);

                    //Parametros de salida
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure; //Especificamos que el tipo de Comando que va a recibir el CMD es un SP

                    //Abrimos la Conexion
                    conexion.Open();

                    cmd.ExecuteNonQuery(); //Ejecutamos el SP

                    //Almacenamos los valores de los Parametros de salida del SP en las variables declaradas al principio del Método
                    resultado = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();

                    conexion.Close(); //Cerramos la Conexion
                }
                catch (Exception ex)
                {
                    //Devolvemos el mensaje en caso de Error
                    resultado = false;
                    mensaje = ex.Message;
                }
            }
            return resultado; //Retornamos el resultado del SP
        }
                              
        public List<CE_Cliente> Filtrar(string filtrar)
        {
            List<CE_Cliente> ListaClientes = new List<CE_Cliente>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GN_FiltrarCliente_SEL", conexion); //Pasamos la Conexion y el SP a ejecutar al CMD
                    
                    //Parametros de Entrada
                    cmd.Parameters.AddWithValue("filtro", filtrar);

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
                                Fecha_nacimiento = Convert.ToDateTime(dr["fechaNacimiento"]),
                                Correo_electronico = dr["correo"].ToString(),
                                Telefono = dr["telefono"].ToString()
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
