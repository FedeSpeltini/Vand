using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class McDisco
    {
        public static List<DiscoEntity> Listar(int idBanda)
        {
            List<DiscoEntity> tablaDisco = new List<DiscoEntity>();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(Acceso.CrearParametro("@idBanda", idBanda));
            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("spListarDiscos", parameters);
            Acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                DiscoEntity disco = new DiscoEntity();
                disco.Id = int.Parse(registro["Id"].ToString());
 
                disco.UrlPortada = "";

                tablaDisco.Add(disco);
            }

            return tablaDisco;
        }


        public static void Agregar(DiscoEntity disco)
        {
            //int id = ProxId();


            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            //parameters.Add(Acceso.CrearParametro("@Id", id));
            parameters.Add(Acceso.CrearParametro("@Nombre", disco.Nombre));
            parameters.Add(Acceso.CrearParametro("@Fundacion", disco.Fundacion));
            parameters.Add(Acceso.CrearParametro("@UrlBanda", disco.UrlPortada));

            Acceso.Escribir("spCrearBanda", parameters);

            Acceso.Cerrar();

            //mcWallet.Agregar(id);

        }
    }
}
