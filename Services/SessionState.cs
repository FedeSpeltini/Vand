using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SessionState
    {
        private static object _lock = new Object();
        private static SessionState _sessionState;

        public UsuarioEntity Usuario { get; set; }
        public DateTime FechaInicio { get; set; }

        McUsuario mc = new McUsuario();
        public static SessionState GetInstance
        {
            get
            {
                if (_sessionState == null) throw new Exception("Sesión no iniciada");

                return _sessionState;
            }
        }

        public static bool Connect(UsuarioEntity usuario)
        {

            lock (_lock)
            {
                if (_sessionState == null)
                {
                    return true;
                    //_sessionState = new SessionState();
                    //_sessionState.Usuario = usuario;
                    //_sessionState.FechaInicio = DateTime.Now;
                }
                else
                {
                    return false;
                    //throw new Exception("Sesión ya iniciada");
                }
            }
        }


        public static bool Login(UsuarioEntity usuario) //IDictionary<string, Traduccion> 
        {

            if (String.IsNullOrEmpty(usuario.Nombre) || String.IsNullOrEmpty(usuario.Password)) throw new Exception("Debe completar todos los campos");
            try
            {
               // UsuarioEntity usuario = mc.ValidarUsuario(usuario);
                if (McUsuario.ValidarUsuario(usuario) == "")
                {
                    throw new Exception("Usuario o contraseña incorrecta");
                }
                else
                {
                    return Connect(usuario);
                }
                
                //return Traductor.ObtenerTraducciones(usuario.Idioma);

            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {

            }

        }

        public static void Logout()
        {
            lock (_lock)
            {
                if (_sessionState != null)
                {
                    _sessionState = null;
                }
                else
                {
                    throw new Exception("Sesión no iniciada");
                }
            }


        }

        private SessionState()
        {

        }
    }
}
