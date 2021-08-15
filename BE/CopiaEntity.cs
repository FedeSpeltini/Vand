using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace BE
{
    public class CopiaEntity: ICopia
    {

        public string Nombre { get; set; }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public IUsuario Propietario { get; set; }
        public string Banda { get; set; }
        public DateTime Year { get; set; }
        public List<string> Musicos { get; set; }


        /// <summary>
        /// //////////////////////////////////////////
        /// </summary>
        private UsuarioComercialEntity propietario2;

        public UsuarioComercialEntity Propetario2
        {
            get { return propietario2; }
            set { propietario2 = value; }
        }

        public string UrlPortada { get; set; }
    }
}
