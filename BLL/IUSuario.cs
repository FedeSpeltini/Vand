using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IUSuario
    {
         void ValidarUsuario(UsuarioEntity usuario);

         void CrearUsuario(UsuarioEntity usuario);

         

    }
}
