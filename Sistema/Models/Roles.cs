using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Models
{
    public class Roles
    {
        public int Id_Rol { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public List<Permiso> Permisos { get; set; } = new List<Permiso>();
    }
}