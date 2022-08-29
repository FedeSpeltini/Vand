using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface IDisco 
    {
        int Id { get; set; }
        string Nombre { get; set; }

        IBanda Banda { get; set; }

        DateTime Year { get; set; }

        List<string> Musicos { get; set; }

        string UrlPortada { get; set; }
    }
}
