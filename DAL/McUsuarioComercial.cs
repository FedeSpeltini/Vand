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
        private Acceso acceso = new Acceso();
        public void QuitarCopia(UsuarioComercialEntity vendedor, CopiaEntity copia)
        {
            acceso.Abrir();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(acceso.CrearParametro("@Nombre", vendedor.Nombre));

            parameters.Add(acceso.CrearParametro("@nombreCopia", copia.Nombre));
            acceso.Escribir("spGuardarHistorial", parameters);

            acceso.Cerrar();
        }
    }
}
