using BE;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBusiness : IUSuario
    {

        public virtual void CrearUsuario(string username, string pwd)
        {

        }

        public void ValidarUsuario(UsuarioEntity usuario)
        {
            if(SessionState.Login(usuario))
            {

            }
        }


    }
}
