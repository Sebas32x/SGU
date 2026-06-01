using System;
using System.Collections.Generic;
using System.Text;
using Sistema.DTOs;
using Sistema.Models;

namespace Sistema.Mapp
{
    public class Us_pMapper
    {
        public static Us_Per ToUs1(Us_perDTO dto)
        {
            return new Us_Per
            {
                Id_usuario = dto.Id_usuario,
                Id_Permisos = dto.Id_Permisos
            };

        }

    }

}
