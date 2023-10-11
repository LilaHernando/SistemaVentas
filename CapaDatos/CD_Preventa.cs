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
                                id = Convert.ToInt32(dr["iden"]),
                                fecha = Convert.ToDateTime(dr["fechadecarga"]),
                                numero = Convert.ToInt32(dr["numero"]),
                                monto = Convert.ToDecimal(dr["monto"]),
                                baja = Convert.ToInt32(dr["baja"]),
                                idOperacion = Convert.ToInt32(dr["idOperacion"]),
                                id_sucursal = Convert.ToInt32(dr["GN_Sucursal_iden"]),
                                id_cliente= Convert.ToInt32(dr["GN_Cliente_iden"]),
                            });
                        }
                    }

                }
                catch (SqlException e) {
                    Console.WriteLine("Error SQL: " + e);   
                }
                
                return listPreventas;
            }
        
        }

       

    }
}
