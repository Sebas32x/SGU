using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Models
{
    public class Domicilio
    {
        public int Id_Domicilio { get; set; }
        public string Calle { get; set; } = string.Empty;
        public int Altura { get; set; }
        public string Piso { get; set; } = string.Empty;
        public string Depa { get; set; } = string.Empty;
        public int Id_Localidad { get; set; }
        public bool Principal { get; set; }
    }
}
