using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Consumimos la Capa Entidad
using CapaEntidad;
//Consumir Sql
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<CE_Usuario> Listar() //Este método va a retornar una Lista de tipo CE_Usuario (Clase Entidad de la tabla Usuario en la DB)
        {
            List<CE_Usuario> lista = new List<CE_Usuario>(); //Instanciamos una Lista de tipo CE_Usuario

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) //Consumimos la Cadena de Conexion de la Clase Conexion situada en CapaDatos
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("US_TraerUsuarios_SEL_Todos", conexion); //Pasamos la Conexion y el SP a ejecutar al CMD

                    cmd.CommandType = CommandType.StoredProcedure; //Especificamos que el tipo de Comando que va a recibir el CMD es un SP

                    //Abrimos la Conexion
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader()) //Usamos SqlDataReader para leer los datos devueltos por la DB
                    {
                        while (dr.Read()) //Mientras lea datos...
                        {
                            lista.Add(new CE_Usuario() //Añadimos a la Lista nuevos Objetos de tipo Usuario
                            {
                                //Atributos
                                Iden = Convert.ToInt32(dr["idenU"]),
                                Rol = new CE_Rol()
                                {
                                    Iden = Convert.ToInt32(dr["idenR"]),
                                    Rol = dr["rol"].ToString()
                                },
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                Dni = dr["DNI"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }

                    conexion.Close(); //Cerramos la Conexion
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    lista = new List<CE_Usuario>(); //En caso de error retornamos una Lista vacia
                }
            }
            return lista; //Retornamos la Lista
        }

        public int Registrar(CE_Usuario ObjUsuario, out string mensaje) //Este método va a registrar un Usuario en la DB atravez de un SP
        {
            //Declaramos dos variables, una de tipo int y una de tipo string
            int resultado = 0;
            mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) //Consumimos la Cadena de Conexion de la Clase Conexion situada en CapaDatos
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("US_Usuarios_INSUPD", conexion); //Pasamos la Conexion y el SP a ejecutar al CMD

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("idenR", ObjUsuario.Rol.Iden); //Pasamos los valores de cada atributo del Objeto CE_Usuario
                    cmd.Parameters.AddWithValue("nombre", ObjUsuario.Nombre);
                    cmd.Parameters.AddWithValue("apellido", ObjUsuario.Apellido);
                    cmd.Parameters.AddWithValue("dni", ObjUsuario.Dni);
                    cmd.Parameters.AddWithValue("clave", ObjUsuario.Clave);
                    cmd.Parameters.AddWithValue("estado", ObjUsuario.Estado);

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

        public bool Editar(CE_Usuario ObjUsuario, out string mensaje) //Este método va a editar un Usuario en la DB atravez de un SP
        {
            //Declaramos dos variables, una de tipo bool y una de tipo string
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) //Consumimos la Cadena de Conexion de la Clase Conexion situada en CapaDatos
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("US_Usuarios_INSUPD", conexion); //Pasamos la Conexion y el SP a ejecutar al CMD

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("idenU", ObjUsuario.Iden); //Pasamos los valores de cada atributo del Objeto CE_Usuario
                    cmd.Parameters.AddWithValue("idenR", ObjUsuario.Rol.Iden);
                    cmd.Parameters.AddWithValue("nombre", ObjUsuario.Nombre);
                    cmd.Parameters.AddWithValue("apellido", ObjUsuario.Apellido);
                    cmd.Parameters.AddWithValue("dni", ObjUsuario.Dni);
                    cmd.Parameters.AddWithValue("clave", ObjUsuario.Clave);
                    cmd.Parameters.AddWithValue("estado", ObjUsuario.Estado);

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

        public List<CE_Usuario> Filtrar(string filtrar) 
        {
            List<CE_Usuario> lista = new List<CE_Usuario>(); //Instanciamos una Lista de tipo CE_Usuario

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) //Consumimos la Cadena de Conexion de la Clase Conexion situada en CapaDatos
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("US_FiltrarUsuario_SEL", conexion); //Pasamos la Conexion y el SP a ejecutar al CMD

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("filtro",filtrar);

                    cmd.CommandType = CommandType.StoredProcedure; //Especificamos que el tipo de Comando que va a recibir el CMD es un SP

                    //Abrimos la Conexion
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader()) //Usamos SqlDataReader para leer los datos devueltos por la DB
                    {
                        while (dr.Read()) //Mientras lea datos...
                        {
                            lista.Add(new CE_Usuario() //Añadimos a la Lista nuevos Objetos de tipo Usuario
                            {
                                //Atributos
                                Iden = Convert.ToInt32(dr["idenU"]),
                                Rol = new CE_Rol()
                                {
                                    Iden = Convert.ToInt32(dr["idenR"]),
                                    Rol = dr["rol"].ToString()
                                },
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                Dni = dr["DNI"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }

                    conexion.Close(); //Cerramos la Conexion
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    lista = new List<CE_Usuario>(); //En caso de error retornamos una Lista vacia
                }
            }
            return lista; //Retornamos la Lista
        }
    }
}
