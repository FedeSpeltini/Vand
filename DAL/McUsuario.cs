using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class McUsuario
    {
        private Acceso acceso = new Acceso();

        public bool ValidarUsuario(UsuarioEntity usuario)
        {
            acceso.Abrir();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(acceso.CrearParametro("@Username", usuario.Nombre));
            parameters.Add(acceso.CrearParametro("@Clave", usuario.Password));

            DataTable tabla = acceso.Leer("spValidarUsuario", parameters);
            acceso.Cerrar();

            if (tabla.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
