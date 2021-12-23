using Abstractions;
using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class McLog
    {

        public static void CreateLog(ILog log)
        {
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@Nombre", log.Usuario.Nombre));
            parameters.Add(Acceso.CrearParametro("@FecIngreso", log.FecIngreso));
            Acceso.Escribir("spCrearLog", parameters);

            Acceso.Cerrar();
        }

        public static List<ILog> GetLogs()
        {
            List<ILog> tablaLogs = new List<ILog>();
            Acceso.Abrir();

            DataTable tabla = Acceso.Leer("spListarCopias");
            Acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                Log log = new Log();
                UsuarioEntity usuario = new UsuarioEntity();
                usuario.Nombre = registro["fecIngreso"].ToString();
                log.Usuario = usuario;
                log.FecIngreso = DateTime.Parse(registro["fecIngreso"].ToString());
                if (registro["fecEgreso"] != null)
                {
                    log.FecEgreso = DateTime.Parse(registro["fecEgreso"].ToString());
                }
                tablaLogs.Add(log);
            }
            return tablaLogs;
        }

        public static List<ILog> GetLog(IUsuario usuario)
        {
            List<ILog> tablaLogs = new List<ILog>();        
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@Nombre", usuario.Nombre));
            
            DataTable tabla = Acceso.Leer("spListarCopias", parameters);
            Acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                Log log = new Log();

                log.Usuario = usuario;
                log.FecIngreso = DateTime.Parse(registro["fecIngreso"].ToString());
                if(registro["fecEgreso"] != null)
                {
                    log.FecEgreso = DateTime.Parse(registro["fecEgreso"].ToString());
                }
                tablaLogs.Add(log);
            }
            return tablaLogs;
        }

        public static void PutFinishHourLog(ILog log)
        {
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@Nombre", log.Usuario.Nombre));
            parameters.Add(Acceso.CrearParametro("@FecIngreso", log.FecIngreso));
            parameters.Add(Acceso.CrearParametro("@FecEgreso", log.FecEgreso));
            Acceso.Escribir("spPutFinishHourLog", parameters);

            Acceso.Cerrar();
        }

    }
}
