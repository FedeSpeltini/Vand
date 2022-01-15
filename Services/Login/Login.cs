using Abstractions;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Login
{
    public sealed class Login
    {


        #region singleton 

        private Login() { }

        private static Login instancia = null;
        public static Login ObtenerInstancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Login();
                }
                return instancia;

            }
        }

        #endregion

        

        public List<ILog> LeerBitacora()
        {
            try
            {
                return McLog.GetLogs();
            }
            catch (Exception)
            {

                throw;
            }



        }



        public List<ILog> Filtrar(List<ILog> aFiltrar, DateTime desde, DateTime hasta)
        {
            List<ILog> filtrados = new List<ILog>();
            foreach (ILog evento in aFiltrar)
            {
                if (desde <= evento.fecha && evento.fecha <= hasta)
                {
                    filtrados.Add(evento);

                }

            }
            return filtrados;
        }


        public List<ILog> Filtrar(List<ILog> aFiltrar, IUsuario usr)
        {

            List<ILog> filtrados = new List<ILog>();
            foreach (ILog evento in aFiltrar)
            {
                if (evento.Usuario == usr)
                {
                    filtrados.Add(evento);
                }

            }
            return filtrados;
        }


        public List<ILog> Filtrar(List<ILog> aFiltrar, string palabra)
        {

            List<ILog> filtrados = new List<ILog>();
            foreach (ILog evento in aFiltrar)
            {
                if (evento.actividad.Contains(palabra) || evento.información.Contains(palabra))
                {
                    filtrados.Add(evento);
                }

            }
            return filtrados;

        }



        public void Grabar(string evento, string info)
        {
            try
            {
                mapper.Grabar(evento, info, Sesion.ObtenerInstancia.EsteUsuario.IdUsuario);
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
