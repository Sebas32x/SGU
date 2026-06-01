using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.DTOs
{
    public class ViviedaDTO
    {
        /// <summary>
        /// ////
        /// </summary>
        //personas
        public int Id_Persona { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;


        public int DNI { get; set; }

        public string Imagen_URL { get; set; } = string.Empty;

        public DateTime Fecha_nac { get; set; }

        public DateTime Fecha_Alta { get; set; }

        public DateTime? Fecha_baja { get; set; }

        public bool Activa { get; set; }

        public string Legajo { get; set; } = string.Empty;

        /// <summary>
        /// /////
        /// </summary>
        //domicilio

        public int Id_Domicilio { get; set; }

        public string Calle { get; set; } = string.Empty;

        public int Altura { get; set; }

        public string Piso { get; set; } = string.Empty;

        public string Depa { get; set; } = string.Empty;

        public bool Principal { get; set; }


        /// <summary>
        /// /////localidad
        /// </summary>

        public int Id_Localidad { get; set; }

        public string Nombre_Local { get; set; } = string.Empty;

        public int Codigo_Postal { get; set; }

        /// <summary>
        /// //
        /// </summary>
        //partido

        public int Id_Partido { get; set; }

        public string Nombre_partido { get; set; } = string.Empty;

        public int Id_Provincia { get; set; }

        public string Nombre_prov { get; set; } = string.Empty;


    }
}

