using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistema.Models
{
    public class Personas
    {
        public int id_Personas { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public int DNI { get; set; }
        public string Imagen_URL { get; set; } = string.Empty;
        public DateTime? Fecha_nac { get; set; } = null;
        public DateTime? Fecha_Alta { get; set; } = null;
        public DateTime Fecha_baja { get; set; }
        public bool Activa { get; set; } = true;
        public string Legajo { get; set; } = string.Empty;
    }
}
