using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBancario.BE;

namespace SistemaBancario.Mapper
{
    public class UsuarioMapper
    {
        public Usuario Mapear(SqlDataReader lector)
        {
            Usuario usuario = new Usuario();

            usuario.IdUsuario =
                Convert.ToInt32(lector["IdUsuario"]);

            usuario.Nombre=
                lector["Nombre"].ToString();

            usuario.Apellido =
                lector["Apellido"].ToString();

            usuario.DNI =
                lector["DNI"].ToString();

            usuario.NombreUsuario =
                lector["NombreUsuario"].ToString();

            usuario.Contrasena =
                lector["Contrasena"].ToString();

            usuario.Activo =
                Convert.ToBoolean(lector["Activo"]);

            usuario.Rol =
                lector["Rol"].ToString();

            return usuario;

        }
    }
}
