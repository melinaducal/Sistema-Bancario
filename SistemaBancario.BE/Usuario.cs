using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.BE
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI {  get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public double Saldo { get; set; }
        public bool Activo { get; set; }
        public string Rol {  get; set; }

    }
}
