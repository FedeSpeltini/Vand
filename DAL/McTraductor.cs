﻿using BE;
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

        private Acceso acceso = new Acceso();



        public  IdiomaEntity ObtenerIdiomaDefault()
        {
            return ObtenerIdiomas().Where(i => i.Default).FirstOrDefault();
        }



        public  List<IdiomaEntity> ObtenerIdiomas()
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
                     Id = Guid.Parse(registro["id_idioma"].ToString()),
                     Nombre = registro["nombre"].ToString(),
                     Default = bool.Parse(registro["idioma_default"].ToString())

                 });
            }

            return _idiomas;
        }



        public static IDictionary<string, TraduccionEntity> ObtenerTraducciones()
        {
            //List<IdiomaEntity> tablaTraduccion = new List<IdiomaEntity>();
            IDictionary<string, TraduccionEntity> _traducciones = new Dictionary<string, TraduccionEntity>();
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(Acceso.CrearParametro("@id_idioma", 2));
            //ARREGLAR
            //Cambiar Hardcode de multilenguaje
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
    }
}