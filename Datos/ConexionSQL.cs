using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using Datos;

namespace Datos
{

    public class ConexionSQL
    {
        private string cadena =
            "Server=localhost;Database=SistemaUsuario;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();
            return cn;
        }
    }

}