using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class McWallet
    {
        private Acceso acceso = new Acceso();
        public int Agregar(int id)
        {
            acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(acceso.CrearParametro("@Id", id));
            return acceso.Escribir("spCrearWallet", parameters);

        }


        //public int ProxId()
        //{
        //    acceso.Abrir();


        //    List<IDbDataParameter> parameters = new List<IDbDataParameter>();
        //    parameters.Add(acceso.CrearParametro("@Tabla", "tUsuario"));
        //    DataTable tabla = acceso.Leer("spObtenerUltimoId");
        //    acceso.Cerrar();
        //    int proxLegajo = 1;
        //    foreach (DataRow registro in tabla.Rows)
        //    {
        //        proxLegajo = int.Parse(registro["IdConcepto"].ToString());
        //    }

        //    return proxLegajo;
        //}
    }
}
