//using EjemploArquitectura.Services.Multiidioma;
using BE;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArquitectura.Services
{
    public static class ManejadorDeSesion
    {
        static UsuarioEntity _session;

        static IList<IIdiomaObserver> _observers = new List<IIdiomaObserver>();
        public static UsuarioEntity Session
        {
            get
            {
                return _session;
            }

        }


        public static bool IsLogged()
        {
            return _session != null;
        }
        public static void Login(UsuarioEntity usuario)
        {
            _session = usuario;
        }

        public static void Logout()
        {
            _session = null;
            Notificar(Traductor.ObtenerIdiomaDefault());
        }


        public static void SuscribirObservador(IIdiomaObserver o)
        {
            _observers.Add(o);
        }
        public static void DesuscribirObservador(IIdiomaObserver o)
        {
            _observers.Remove(o);
        }

        private static void Notificar(IdiomaEntity idioma)
        {
            foreach (var o in _observers)
            {
                o.UpdateLanguage(idioma);
            }
        }
        public static void CambiarIdioma(IdiomaEntity idioma)
        {
            if (_session != null)
            {
                _session.Idioma = idioma;
                Notificar(idioma);
            }
        }
    }
}
