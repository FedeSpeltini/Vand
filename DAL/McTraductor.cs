using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class McTraductor
    {


        public static IdiomaEntity ObtenerIdiomaDefault()
        {
            return ObtenerIdiomas().Where(i => i.Default).FirstOrDefault();
        }



        public  static List<IdiomaEntity> ObtenerIdiomas()
        {
            List<IdiomaEntity> _idiomas = new List<IdiomaEntity>();
            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("spObtenerIdiomas");
            Acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                _idiomas.Add(
                 new IdiomaEntity()
                 {
                     Id = int.Parse(registro["id_idioma"].ToString()),
                     Nombre = registro["nombre"].ToString(),
                     Default = bool.Parse(registro["idioma_default"].ToString())

                 });
            }

            return _idiomas;
        }



        public static IDictionary<string, TraduccionEntity> ObtenerTraducciones(IdiomaEntity idioma = null)
        {
            if (idioma == null)
            {
                idioma = ObtenerIdiomaDefault();
            }
            //List<IdiomaEntity> tablaTraduccion = new List<IdiomaEntity>();
            IDictionary<string, TraduccionEntity> _traducciones = new Dictionary<string, TraduccionEntity>();
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            
            parameters.Add(Acceso.CrearParametro("@id_idioma", idioma.Id));

            DataTable tabla = Acceso.Leer("spObtenerTraducciones", parameters);
            Acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                string etiquetaAux = registro["nombre_etiqueta"].ToString();
                _traducciones.Add(etiquetaAux,
                    new TraduccionEntity()
                    {

                        Texto = registro["traduccion_traduccion"].ToString(),

                        Etiqueta = new EtiquetaEntity()
                        {
                            Id = int.Parse(registro["id_etiqueta"].ToString()),
                            Nombre = etiquetaAux
                            
                        }

                    });
            }

            return _traducciones;
        }


        public static List<TraduccionEntity> ListarTraducciones(IdiomaEntity idioma)
        {
            List<TraduccionEntity> traducciones = new List<TraduccionEntity>();
            Acceso.Abrir();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(Acceso.CrearParametro("@idioma", idioma.Nombre));
            DataTable tabla = Acceso.Leer("spListarTraducciones", parameters);
            Acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                EtiquetaEntity etiqueta = new EtiquetaEntity()
                {
                    Nombre = registro["Etiqueta"].ToString(),
                };
                
                traducciones.Add(
                 new TraduccionEntity()
                 {
                     Etiqueta = etiqueta,
                     Texto = registro["Traduccion"].ToString()
                 }); 
                

            }

            return traducciones;
        }


        public static void AgregarTraduccion(IdiomaEntity idioma,EtiquetaEntity etiqueta, TraduccionEntity traduccion)
        {
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@Idioma", idioma.Nombre));
            parameters.Add(Acceso.CrearParametro("@Etiqueta", etiqueta.Nombre));
            parameters.Add(Acceso.CrearParametro("@Traduccion", traduccion.Texto));
            Acceso.Escribir("spCrearTraduccion", parameters);

            Acceso.Cerrar();
        }

        public static void ModificarTraduccion(TraduccionEntity traduccion, string nuevoValor)
        {
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@Traduccion", traduccion.Texto));
            parameters.Add(Acceso.CrearParametro("@NuevoValor", nuevoValor));
            Acceso.Escribir("spModificarTraduccion", parameters);

            Acceso.Cerrar();
        }

        public static void EliminarTraduccion(TraduccionEntity traduccion)
        {
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@Traduccion", traduccion.Texto));
            Acceso.Escribir("spEliminarTraduccion", parameters);

            Acceso.Cerrar();
        }
    }
}
