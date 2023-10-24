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
    public class CD_Rol
    {
        public List<CE_Rol> Listar() //Este método va a retornar una Lista de tipo CE_Permiso (Clase Entidad de la tabla Permiso en la DB)
        {
            List<CE_Rol> lista = new List<CE_Rol>(); //Instanciamos una Lista de tipo CE_Permiso

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) //Consumimos la Cadena de Conexion de la Clase Conexion situada en CapaDatos
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ROL_TraerRoles_SEL_Todos", conexion); //Pasamos la Conexion y el SP a ejecutar al CMD

                    cmd.CommandType = CommandType.StoredProcedure; //Especificamos que el tipo de Comando que va a recibir el CMD es un SP

                    //Abrimos la Conexion
                    conexion.Open();

                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader()) //Usamos SqlDataReader para leer los datos devueltos por la DB
                    {
                        while (dr.Read()) //Mientras lea datos...
                        {
                            lista.Add(new CE_Rol() //Añadimos a la Lista nuevos Objetos de tipo Permiso
                            {
                                //Atributos
                                Iden = Convert.ToInt32(dr["iden"]),
                                Rol = dr["rol"].ToString()
                            });
                        }
                    }

                    conexion.Close(); //Cerramos la Conexion
                }
                catch (Exception ex)
                {
                    lista = new List<CE_Rol>(); //En caso de error retornamos una Lista vacia
                }
            }
            return lista; //Retornamos la Lista
        }
    }
}
