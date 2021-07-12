using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class McUsuarioCliente
    {
        public decimal ObtenerSaldoActual(UsuarioClienteEntity usuario)
        {


            Acceso.Abrir();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            
            parameters.Add(Acceso.CrearParametro("@Nombre", usuario.Nombre));
            DataTable tabla = Acceso.Leer("spObtenerSaldoActual", parameters);
            Acceso.Cerrar();

            return decimal.Parse(tabla.Rows[0]["Cantidad"].ToString());

        }
    }
}
