using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class McUsuarioComercial
    {

        public void QuitarCopia(UsuarioComercialEntity vendedor, CopiaEntity copia)
        {
            Acceso.Abrir();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(Acceso.CrearParametro("@Nombre", vendedor.Nombre));

            parameters.Add(Acceso.CrearParametro("@nombreCopia", copia.Nombre));
            Acceso.Escribir("spGuardarHistorial", parameters);

            Acceso.Cerrar();
        }
    }
}
