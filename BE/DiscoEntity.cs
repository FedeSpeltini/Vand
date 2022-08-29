using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DiscoEntity //: IDisco
    {
        public int Id {get; set; }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private DateTime fundacion;

        public DateTime Fundacion
        {
            get { return fundacion; }
            set { fundacion = value; }
        }

        //private List<string> musicos;

        //public List<string> Musicos
        //{
        //    get { return musicos; }
        //    set { musicos = value; }
        //}

        public Banda Banda { get; set; }
        public string UrlPortada { get; set; }
    }
}
