using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    
    public class Traduccion 
    {
        Guid Id { get; set; }
        public Etiqueta Etiqueta { get; set; }
        public string Texto { get; set; }
    }
}
