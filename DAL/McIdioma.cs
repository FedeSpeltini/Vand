using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class McIdioma
    {

        public static void CrearIdioma(IdiomaEntity idioma)
        {
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@Idioma", idioma.Nombre));
            Acceso.Escribir("spCrearIdioma", parameters);

            Acceso.Cerrar();
        }
    }
}
