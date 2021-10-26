using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface IBanda
    {
        string Nombre { get; set; }

        DateTime Fundacion { get; set; }

        string Genero { get; set; }

        string UrlBanda { get; set; }
    }
}
