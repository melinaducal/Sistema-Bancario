using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.BE
{
    public class Movimiento
    {
        public int IdMovimiento { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaHora { get; set; }
        public string Tipo { get; set; }
        public double Importe { get; set; }
        public int IdUsuarioRelacionado { get; set; }
        public string Concepto { get; set; }
        public int IdTransferencia { get; set; }
        
    }
}
