using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Preventa
    {
        public List<CE_Preventa> ListarPreventas()
        {
            List<CE_Preventa> listPreventas = new List<CE_Preventa>();
            using (SqlConnection onConexion = new SqlConnection(Conexion.cadena))
            {
                try {
                    SqlCommand cmd = new SqlCommand("PVTA_List_Preventa_SEL", onConexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    onConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read()) {
                            listPreventas.Add(new CE_Preventa()
                            {
                                IdPreventa = Convert.ToInt32(dr["iden"]),
                                Fecha = Convert.ToDateTime(dr["fechadecarga"]),
                                Numero = Convert.ToInt32(dr["numero"]),
                                Monto = Convert.ToDecimal(dr["monto"]),
                                Baja = Convert.ToInt32(dr["baja"]),
                                IdOperacion = Convert.ToInt32(dr["idOperacion"]),
                                CE_Surcusal = new CE_Sucursal() {Id=Convert.ToInt32(dr["iden"]),Descripcion = Convert.ToString(dr["descripcion"]) },
                                CE_Cliente = new CE_Cliente {Nombre = Convert.ToString(dr["nombre"]), Apellido = Convert.ToString(dr["apellido"])},
                            });
                        }
                    }
                    onConexion.Close();
                }
                catch (SqlException e) {
                    Console.WriteLine("Error SQL: " + e);   
                }
                return listPreventas;
            }
        
        }

       

    }
}
