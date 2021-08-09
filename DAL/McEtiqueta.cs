using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class McEtiqueta
    {
        public static List<EtiquetaEntity> ObtenerEtiquetas()
        {

            List<EtiquetaEntity> tablaEtiqueta = new List<EtiquetaEntity>();
            
            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("spListarEtiquetas");
            Acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                EtiquetaEntity etiqueta = new EtiquetaEntity();
                etiqueta.Id = int.Parse(registro["id_etiqueta"].ToString());
                etiqueta.Nombre = registro["nombre"].ToString();
                tablaEtiqueta.Add(etiqueta);
            }

            return tablaEtiqueta;
        }

        public static void CrearEtiqueta(EtiquetaEntity etiqueta)
        {
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@Etiqueta", etiqueta.Nombre));
            Acceso.Escribir("spCrearEtiqueta", parameters);

            Acceso.Cerrar();
        }

        public static void ModificarEtiqueta(EtiquetaEntity etiqueta, string nuevoValor)
        {
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@Etiqueta", etiqueta.Nombre));
            parameters.Add(Acceso.CrearParametro("@NuevoValor", nuevoValor));
            Acceso.Escribir("spModificarEtiqueta", parameters);

            Acceso.Cerrar();
        }

        public static void EliminarEtiqueta(EtiquetaEntity etiqueta)
        {
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@Etiqueta", etiqueta.Nombre));
            Acceso.Escribir("spEliminarEtiqueta", parameters);

            Acceso.Cerrar();
        }

    }
}
