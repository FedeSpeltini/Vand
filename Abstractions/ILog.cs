using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface ILog
    {
        IUsuario Usuario { get; set; }

        DateTime FecIngreso { get; set; }

        DateTime FecEgreso { get; set; }
    }
}
