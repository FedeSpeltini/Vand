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

        McWallet mcWallet = new McWallet();

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

        public void Agregar(string nombre, string clave)
        {
            int id = ProxId();


            acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(acceso.CrearParametro("@Id", id));
            parameters.Add(acceso.CrearParametro("@Nombre", nombre));
            parameters.Add(acceso.CrearParametro("@Clave", clave));
            parameters.Add(acceso.CrearParametro("@Rol", clave));

            acceso.Escribir("spCrearJugador", parameters);

            acceso.Cerrar();

            mcWallet.Agregar(id);

        }


        public int ProxId()
        {
            acceso.Abrir();


            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(acceso.CrearParametro("@Tabla", "tUsuario"));
            DataTable tabla = acceso.Leer("spObtenerUltimoId");
            acceso.Cerrar();
            int proxLegajo = 1;
            foreach (DataRow registro in tabla.Rows)
            {
                proxLegajo = int.Parse(registro["IdConcepto"].ToString());
            }

            return proxLegajo;
        }

    }
}
