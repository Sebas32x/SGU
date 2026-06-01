using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Sistema.DTOs;
using Datos;

namespace Logica
{
    public class Registrar
    {
        public bool RegiPersonas(ViviedaDTO dto)
        {
            ConexionSQL conexion = new ConexionSQL();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("dbo.Registrar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;



                    cmd.Parameters.AddWithValue("@Nombre", dto.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", dto.Apellido);
                    cmd.Parameters.AddWithValue("@Imagen_URL", (object)dto.Imagen_URL ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DNI", dto.DNI);
                    cmd.Parameters.AddWithValue("@Fecha_nac", dto.Fecha_nac);
                    cmd.Parameters.AddWithValue("@Calle", dto.Calle);
                    cmd.Parameters.AddWithValue("@Altura", dto.Altura);
                    cmd.Parameters.AddWithValue("@Piso", (object)dto.Piso ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Depa", (object)dto.Depa ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Principal", dto.Principal);
                    cmd.Parameters.AddWithValue("@Id_Provincia", dto.Id_Provincia);
                    cmd.Parameters.AddWithValue("@Id_Partido", dto.Id_Partido);
                    cmd.Parameters.AddWithValue("@Id_Localidad", dto.Id_Localidad);


                    cmd.Parameters.AddWithValue("@Codigo_Postal", dto.Codigo_Postal);
                    cmd.Parameters.AddWithValue("@Nombre_Local", dto.Nombre_Local);
                    cmd.Parameters.AddWithValue("@Nombre_partido", dto.Nombre_partido);
                    cmd.Parameters.AddWithValue("@Nombre_prov", dto.Nombre_prov);


                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }


                    int filasAfectadas = cmd.ExecuteNonQuery();


                    return filasAfectadas > 0;
                }
            }
        }


        public DataTable ObtenerLocalidad()
        {
            ConexionSQL conexion = new ConexionSQL();
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Id_Localidad, Nombre_Local FROM Localidad", cn))
                {
                    if (cn.State == ConnectionState.Closed) cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable ObtenerPartido()
        {
            ConexionSQL conexion = new ConexionSQL();
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Id_Partido, Nombre_partido FROM Partido", cn))
                {
                    if (cn.State == ConnectionState.Closed) cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable ObtenerProvincia()
        {
            ConexionSQL conexion = new ConexionSQL();
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Id_Provincia, Nombre_prov FROM Provincia", cn))
                {
                    if (cn.State == ConnectionState.Closed) cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}

