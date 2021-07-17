using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class TraduccionBusiness
    {

        public static IDictionary<string, TraduccionEntity> ObtenerTraducciones(IdiomaEntity idioma = null)
        {
            return McTraductor.ObtenerTraducciones(idioma);
        }

        public static List<IdiomaEntity> ObtenerIdiomas()
        {
            return McTraductor.ObtenerIdiomas();
        }
    }
}
