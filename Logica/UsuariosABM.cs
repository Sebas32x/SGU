using Datos;
using Microsoft.Data.SqlClient;
using Sistema.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UsuariosABM
    {

        public bool ALTA(ABMuser dto)
        {
            ConexionSQL conexion = new ConexionSQL();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("Usu_alta", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@user_name", dto.user_name);
                    cmd.Parameters.AddWithValue("@Password", dto.Password);
                    cmd.Parameters.AddWithValue("@DiasValidezPass", dto.DiasValidezPass);
                    cmd.Parameters.AddWithValue("@DebeCambiarPass", dto.DebeCambiarPass);

                    cmd.Parameters.AddWithValue("@Intentos_Fallidos", 0);
                    cmd.Parameters.AddWithValue("@Hora_ult_Intento", DateTime.Now);

                    cmd.Parameters.AddWithValue("@Id_Rol", dto.Id_Rol);
                    cmd.Parameters.AddWithValue("@Id_Persona", dto.Id_Persona);

                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
            }
        }

        public bool BAJA(ABMuser dto)
        {
            ConexionSQL conexion = new ConexionSQL();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("Usu_Baja", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@user_name", dto.user_name);
                   

                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
            }
        }

        public bool Modificacion(ABMuser dto)
        {
            ConexionSQL conexion = new ConexionSQL();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("Usu_Modif", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@user_name", dto.user_name);
                    cmd.Parameters.AddWithValue("@Id_Rol", dto.Id_Rol);


                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
            }
        }


        public DataTable ObtenerPersonas()
        {
            ConexionSQL conexion = new ConexionSQL();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT Id_Persona,  Nombre FROM Persona",
                    cn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

    }
}
