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
                    //Abrimos la Conexion
                    conexion.Open();

                    SqlCommand cmd = new SqlCommand("US_TraerUsuarios_SEL_Todos", conexion); //Pasamos la Conexion y el SP a ejecutar al CMD

                    cmd.CommandType = CommandType.StoredProcedure; //Especificamos que el tipo de Comando que va a recibir el CMD es un SP

                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader()) //Usamos SqlDataReader para leer los datos devueltos por la DB
                    {
                        while (dr.Read()) //Mientras lea datos...
                        {
                            lista.Add(new CE_Usuario() //Añadimos a la Lista nuevos Objetos de tipo Usuario
                            {
                                //Atributos
                                Iden = Convert.ToInt32(dr["u.iden"]),
                                Rol = new CE_Rol()
                                {
                                    Iden = Convert.ToInt32(dr["r.iden"]),
                                    Rol = dr["r.rol"].ToString()
                                },
                                Nombre = dr["u.Nombre"].ToString(),
                                Apellido = dr["u.Apellido"].ToString(),
                                Dni = dr["u.DNI"].ToString(),
                                Clave = dr["u.Clave"].ToString(),
                                Estado = Convert.ToInt32(dr["u.Estado"])
                            });
                        }
                    }

                    conexion.Close(); //Cerramos la Conexion
                }
                catch (Exception ex)
                {
                    lista = new List<CE_Usuario>(); //En caso de error retornamos una Lista vacia
                }
            }
            return lista; //Retornamos la Lista
        }
    }
}
