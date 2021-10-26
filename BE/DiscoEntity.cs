using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DiscoEntity : IDisco
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private DateTime year;

        public DateTime Year
        {
            get { return year; }
            set { year = value; }
        }

        private List<string> musicos;

        public List<string> Musicos
        {
            get { return musicos; }
            set { musicos = value; }
        }

        IBanda IDisco.Banda { get; set; }
        public string UrlPortada { get; set; }
    }
}
