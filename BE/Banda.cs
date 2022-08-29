using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Banda : Abstractions.IBanda
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fundacion { get; set; }
        public string Genero { get; set; }
        public string UrlBanda { get; set; }
    }
}
