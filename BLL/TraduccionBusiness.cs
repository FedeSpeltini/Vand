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


        public static List<TraduccionEntity> ListarTraducciones(IdiomaEntity idioma)
        {
            return McTraductor.ListarTraducciones(idioma);
        }
        
        public static void AgregarTraduccion(IdiomaEntity idioma, EtiquetaEntity etiqueta, TraduccionEntity traduccion)
        {
            McTraductor.AgregarTraduccion(idioma, etiqueta, traduccion);
        }

        public static void ModificarTraduccion(TraduccionEntity traduccion, string nuevoValor)
        {
            McTraductor.ModificarTraduccion(traduccion, nuevoValor);
        }

        public static void EliminarTraduccion(TraduccionEntity traduccion)
        {
            McTraductor.EliminarTraduccion(traduccion);
        }

        public static Func<int, int, int> Multiplicar = (x, y) => x * y;
        static Func<int, int> square = x => x * x;
    }
}
