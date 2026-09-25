using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBancario.DAL;
using SistemaBancario.BE;

namespace SistemBancario.BLL
{
    public class UsuarioBLL
    {
        private readonly UsuarioDAL usuarioDAL;

        public UsuarioBLL()
        {
            usuarioDAL = new UsuarioDAL();
        }
        
        public Usuario IniciarSesion(
            string nombreUsuario,
            string contrasena)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                throw new Exception(
                    "Debe ingresar el nombre de usuario.");

            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                throw new Exception(
                    "Debe ingresar la contrasena");
            }
            Usuario usuario = usuarioDAL.BuscarParaLogin(
                nombreUsuario.Trim(),
                contrasena);

            if (usuarioDAL == null)
            {
                throw new Exception(
                    "El usuario o la contrasena son incorrectos");
            }

            return usuario;
        }
    }
}
