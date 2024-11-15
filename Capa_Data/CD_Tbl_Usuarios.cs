using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Data
{
    public class CD_Tbl_Usuarios
    {
        public List<Tbl_Usuarios> Listar() 
        {
            List<Tbl_Usuarios> lista = new List<Tbl_Usuarios>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    string query = "SELECT Id_Usuario, Usuario, Contrasena FROM Tbl_Usuarios";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Tbl_Usuarios()
                            {
                                Id_Usuario = Convert.ToInt32(dr["Id_Usuario"]),
                                Usuario = dr["Usuario"].ToString(),
                                Contrasena = dr["Contrasena"].ToString()
                            }
                            );
                        }
                    }
                }
            }
            catch 
            { 
                lista = new List<Tbl_Usuarios>();
            }

            return lista;
        }
    }
}
