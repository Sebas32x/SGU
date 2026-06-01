using System.Data;
using Microsoft.Data.SqlClient;
using Sistema.DTOs;
using Datos;

namespace Logica
{
    public class OrtorgarRol_Permis
    {
        public void Otorgar(PermRolDTO dto)
        {
            ConexionSQL conexion = new ConexionSQL();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_insert_rol", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_usuario", dto.Id_usuario);
                cmd.Parameters.AddWithValue("@Id_Rol", dto.Id_Rol);
                cmd.Parameters.AddWithValue("@Id_Permisos", dto.Id_Permisos);

                cmd.ExecuteNonQuery();
            }
        }





        public DataTable ObtenerPermisos()
        {
            ConexionSQL conexion = new ConexionSQL();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT Id_Permisos, Descripcion FROM Permisos",
                    cn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public DataTable ObtenerRoles()
        {
            ConexionSQL conexion = new ConexionSQL();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT Id_Rol, Nombre FROM Roles",
                    cn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public DataTable ObtenerUsuarios()
        {
            ConexionSQL conexion = new ConexionSQL();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT Id_usuario, user_name FROM Usuario",
                    cn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}
