using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DiscoEntity
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string banda;

        public string Banda
        {
            get { return banda; }
            set { banda = value; }
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

    }
}
