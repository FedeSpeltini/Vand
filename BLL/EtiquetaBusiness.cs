using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class EtiquetaBusiness
    {

        public static List<EtiquetaEntity> ObtenerEtiquetas()
        {
            return McEtiqueta.ObtenerEtiquetas();
        }

        public static void AgregarEtiqueta(EtiquetaEntity etiqueta)
        {
            McEtiqueta.CrearEtiqueta(etiqueta);
        }
        public static void ModificarEtiqueta(EtiquetaEntity etiqueta, string nuevoValor)
        {
            McEtiqueta.ModificarEtiqueta(etiqueta, nuevoValor);
        }

        public static void EliminarEtiqueta(EtiquetaEntity etiqueta)
        {
            McEtiqueta.EliminarEtiqueta(etiqueta);
        }
    }
}
