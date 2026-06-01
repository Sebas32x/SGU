using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.DTOs
{
    public class ABMuser
    {

        public int Id_usuario { get; set; }
        public string user_name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int DiasValidezPass { get; set; }
        public bool DebeCambiarPass { get; set; }
        public bool Activo { get; set; }
        public int Intentos_Fallidos { get; set; }
        public DateTime Hora_ult_Intento { get; set; }
        public int Id_Rol { get; set; }
        public int Id_Persona { get; set; }

    }
}
