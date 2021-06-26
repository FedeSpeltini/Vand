using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class McVenta
    {
        private Acceso acceso = new Acceso();
        public void Agregar(VentaEntity ganador)
        {
            Acceso.Abrir();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            //parameters.Add(acceso.CrearParametro("@Nombre", ganador.Jugador.Usuario));
            //parameters.Add(acceso.CrearParametro("@Ganada", 1));
            //parameters.Add(acceso.CrearParametro("@Empatada", 0));
            //parameters.Add(acceso.CrearParametro("@Derrota", 0));
            //parameters.Add(acceso.CrearParametro("@Puntos", ganador.Puntos));
            Acceso.Escribir("spGuardarHistorial", parameters);

            Acceso.Cerrar();
        }
    }
}
