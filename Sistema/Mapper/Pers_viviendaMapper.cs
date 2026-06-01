using Sistema.DTOs;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sistema.Mapp
{
    public static class Pers_viviendaMapper
    {
        public static Personas toPersona(ViviedaDTO dto)
        {
            return new Personas
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                DNI = dto.DNI,
                Imagen_URL = dto.Imagen_URL,
                Fecha_nac = dto.Fecha_nac
            };
        }

        public static Provincia ToProvincia(ViviedaDTO dto)
        {
            return new Provincia
            {
                Id_Provincia = dto.Id_Provincia,
                Nombre_prov = dto.Nombre_prov
            };
        }

        public static Partido ToPartido(ViviedaDTO dto)
        {
            return new Partido
            {
                Id_Partido = dto.Id_Partido,
                Nombre_partido = dto.Nombre_partido

            };
        }

        public static Localidad ToLocal(ViviedaDTO dto)
        {
            return new Localidad
            {
                Nombre_Local = dto.Nombre_Local,
                Codigo_Postal = dto.Codigo_Postal

            };
        }

        public static Domicilio ToDomi(ViviedaDTO dto)
        {
            return new Domicilio
            {
                Calle = dto.Calle,
                Altura = dto.Altura,
                Piso = dto.Piso,
                Depa = dto.Depa,
                Id_Localidad = dto.Id_Localidad,
                Principal = dto.Principal
            };
        }
    }
}

