using System;
using System.Collections.Generic;
using System.Text;
using Sistema.DTOs;
using Sistema.Models;



namespace Sistema.Mapp
{
    //Toman un objeto de un tipo y lo transforman en otro,Traduce objetos entre capas.

    public static class UsuarioMapp
    {
        public static Usuario ToModel(LoginDTO dto)
        {
            return new Usuario
            {
                user_name = dto.user_name,
                Password = dto.password
            };
        }


        public static Usuario ToModel2(ABMuser dto)
        {
            return new Usuario
            {
                user_name = dto.user_name,
                Password = dto.Password,
                DiasValidezPass = dto.DiasValidezPass,
                DebeCambiarPass = dto.DebeCambiarPass,
                Activo = dto.Activo,
                Intentos_Fallidos = dto.Intentos_Fallidos,
                Hora_ult_Intento = dto.Hora_ult_Intento,
                Id_Rol = dto.Id_Rol,
                Id_Persona = dto.Id_Persona
            };
        }
    }
}
