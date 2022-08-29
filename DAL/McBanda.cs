using Abstractions;
using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBanda = Abstractions.IBanda;

namespace DAL
{
    public static class McBanda
    {
        public static List<Abstractions.IBanda> Listar()
        {
            List<Abstractions.IBanda> tablaBanda = new List<Abstractions.IBanda>();
            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("spListarBandas");
            Acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                Banda banda = new Banda();
                banda.Id = int.Parse(registro["Id"].ToString());
                banda.Nombre = registro["nombre"].ToString();                
                banda.UrlBanda = "";

                tablaBanda.Add(banda);
            }

            return tablaBanda;
        }

        public static void Agregar(IBanda banda)
        {
            //int id = ProxId();


            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            //parameters.Add(Acceso.CrearParametro("@Id", id));
            parameters.Add(Acceso.CrearParametro("@Nombre", banda.Nombre));
            parameters.Add(Acceso.CrearParametro("@Fundacion", banda.Fundacion));
            parameters.Add(Acceso.CrearParametro("@UrlBanda", banda.UrlBanda));

            Acceso.Escribir("spCrearBanda", parameters);

            Acceso.Cerrar();

            //mcWallet.Agregar(id);

        }
    }
}
