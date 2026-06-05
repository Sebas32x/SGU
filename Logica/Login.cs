using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Sistema.DTOs;
using Datos;

//No deberia estar esto en la capa de datos o sesion?
namespace Logica
{
    public class Login
    {
        public bool Login1(LoginDTO dto)
        {
            ConexionSQL conexion = new ConexionSQL();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("ver_user_cont", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@user_name", dto.user_name);
                    cmd.Parameters.AddWithValue("@Password", dto.password);



                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }
    }
}