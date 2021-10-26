using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface IInversion
    {
        decimal Porcentaje { get; set; }
        decimal MontoActual { get; set; }
        DateTime FecInicial { get; set; }
        DateTime FecCorriente { get; set; }
    }
}
