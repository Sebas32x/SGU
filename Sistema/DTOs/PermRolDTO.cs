using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.DTOs
{
    public class PermRolDTO
    {
        public int Id_Usuario { get; set; }

        public int Id_Permisos { get; set; }
        public int Id_usuario { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; } = string.Empty;


        public int Id_Rol { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public List<Permiso> Permisos { get; set; } = new List<Permiso>();


    }
}
