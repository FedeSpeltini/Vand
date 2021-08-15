using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface IUsuario
    {
        string Nombre { get; set; }

        string Password { get; set; }

        string Rol { get; set; }

        IIdioma Idioma { get; set; }

    }
}
