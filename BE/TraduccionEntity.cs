using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TraduccionEntity
    {
        Guid Id { get; set; }
        public EtiquetaEntity Etiqueta { get; set; }
        public string Texto { get; set; }
    }
}
