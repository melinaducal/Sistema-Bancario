using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace SistemaBancario.DAL
{
    public static class Conexion
    {
        public static SqlConnection CrearConexion() {
            string cadena = ConfigurationManager
                .ConnectionStrings["SistemaBancario"]
                .ConnectionString;

            return new SqlConnection(cadena);
        }
    }
}
