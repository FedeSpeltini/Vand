using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class InversionPasiva : IInversion
    {
        public decimal Porcentaje { get; set; }
        public decimal MontoActual { get; set; }
        public decimal MontoInicial { get; set; }
        public DateTime FecInicial { get; set; }
        public DateTime FecCorriente { get; set; }
    }
}
