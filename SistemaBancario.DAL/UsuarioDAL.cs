using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBancario.BE;
using SistemaBancario.Mapper;

namespace SistemaBancario.DAL
{
    public class UsuarioDAL
    {
        public Usuario BuscarParaLogin(
            string nombreUsuario,
            string contrasena)
        {
            string consulta = @"
                SELECT
                    IdUsuario,
                    Nombre,
                    Apellido,
                    DNI,
                    NombreUsuario,
                    Contrasena,
                    Saldo,
                    Activo,
                    Rol
                FROM Usuarios
                WHERE NombreUsuario = @NombreUsuario
                    AND Contrasena = @Contrasena
                    AND Activo = 1";
            using (SqlConnection conexion =
                Conexion.CrearConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@NombreUsuario",
                        nombreUsuario);

                    comando.Parameters.AddWithValue(
                        "@contrasena",
                        contrasena);

                    conexion.Open();

                    using (SqlDataReader lector =
                        comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            UsuarioMapper mapper =
                                new UsuarioMapper();

                            return mapper.Mapear(lector);
                        }
                    }
                }
            }

            return null;
        }
    }
}
