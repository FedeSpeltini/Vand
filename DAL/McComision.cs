using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class McComision
    {
        private Acceso acceso = new Acceso();
        public void Agregar(ComisionEntity comision)
        {
            acceso.Abrir();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(acceso.CrearParametro("@Porcentaje", comision.Porcentaje));
            parameters.Add(acceso.CrearParametro("@Ganancia", comision.Ganancia));
            //parameters.Add(acceso.CrearParametro("@Empatada", comision.Venta.));
            //parameters.Add(acceso.CrearParametro("@Derrota", 0));
            //parameters.Add(acceso.CrearParametro("@Puntos", ganador.Puntos));
            acceso.Escribir("spGuardarHistorial", parameters);

            acceso.Cerrar();
        }
    }
}
