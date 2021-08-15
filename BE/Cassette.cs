using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cassette : ICopia
    {
        public decimal Precio { get; set; }
        public IUsuario Propietario { get; set; }
        public string Nombre { get; set; }
        public string Banda { get; set; }
        public DateTime Year { get; set; }
        public List<string> Musicos { get; set; }
        public string UrlPortada { get; set; }
    }
}
