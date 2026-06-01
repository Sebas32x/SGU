using Datos;
using Microsoft.Data.SqlClient;
using Sistema.DTOs;
using Sistema.Mapp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Logica
{
    public class BajaRoles
    {
        
        public DataTable Baja2(PermRolDTO dto)
        {
            var roles = OtoRol_PermMapper.ToRol(dto);
            var permisos = OtoRol_PermMapper.ToPermiso(dto);

            ConexionSQL conexion = new ConexionSQL();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_delete_permiso", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Rol", roles.Id_Rol);
                cmd.Parameters.AddWithValue("@Nombre", roles.Nombre);
                cmd.Parameters.AddWithValue("@Codigo", permisos.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", permisos.Descripcion);
                cmd.Parameters.AddWithValue("Id_Permisos", permisos.Id_Permisos);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
        }

    }

}
