using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface ICopia : IDisco
    {
        decimal Precio { get; set; }

        IUsuario Propietario { get; set; }
    }
}
