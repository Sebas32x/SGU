using Sistema.DTOs;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Sistema.Mapp
{
    public class OtoRol_PermMapper
    {
        public static Roles ToRol(PermRolDTO dto)
        {
            return new Roles
            {
                Id_Rol = dto.Id_Rol,
                Nombre = dto.Nombre,

            };

        }

        public static Usuario ToUsa1(PermRolDTO dto)
        {
            return new Usuario
            {
                Id_usuario = dto.Id_usuario


            };

        }

        public static Permiso ToPermiso(PermRolDTO dto)
        {
            return new Permiso
            {
                Id_Permisos = dto.Id_Permisos,
                Codigo = dto.Codigo,
                Descripcion = dto.Descripcion
            };

        }
    }
}