using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Models
{
    public class Permiso
    {
        public int Id_Permisos { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    }
}
