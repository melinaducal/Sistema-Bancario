using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.BE
{
    public class Transferencia
    {
        public int IdTransferencia { get; set; }
        public int UsuarioEmisorId { get; set; }
        public int UsuarioReceptorId { get; set; }
        public double Importe { get; set; }
        public DateTime FechaHora { get; set; }

    }
}
