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
    public class CD_Permiso
    {
        public List<CE_Permiso> Listar(int idUsuario) //Este método va a retornar una Lista de tipo CE_Permiso (Clase Entidad de la tabla Permiso en la DB)
        {
            List<CE_Permiso> lista = new List<CE_Permiso>(); //Instanciamos una Lista de tipo CE_Permiso

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) //Consumimos la Cadena de Conexion de la Clase Conexion situada en CapaDatos
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PER_TraerPermisos_SEL_Todos", conexion); //Pasamos la Conexion y el SP a ejecutar al CMD

                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario); //Pasamos el id del Usuario logeado como parametro al SP

                    cmd.CommandType = CommandType.StoredProcedure; //Especificamos que el tipo de Comando que va a recibir el CMD es un SP

                    //Abrimos la Conexion
                    conexion.Open();

                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader()) //Usamos SqlDataReader para leer los datos devueltos por la DB
                    {
                        while (dr.Read()) //Mientras lea datos...
                        {
                            lista.Add(new CE_Permiso() //Añadimos a la Lista nuevos Objetos de tipo Permiso
                            {
                                //Atributos
                                Rol = new CE_Rol()
                                {
                                    Iden = Convert.ToInt32(dr["idenR"]),
                                },
                                NombreMenu = dr["nombremenu"].ToString(),
                            });
                        }
                    }

                    conexion.Close(); //Cerramos la Conexion
                }
                catch (Exception ex)
                {
                    lista = new List<CE_Permiso>(); //En caso de error retornamos una Lista vacia
                }
            }
            return lista; //Retornamos la Lista
        }
    }
}
