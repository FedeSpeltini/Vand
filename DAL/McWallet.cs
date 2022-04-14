using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class McWallet
    {

        public static int Agregar(int id)
        {
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(Acceso.CrearParametro("@Id", id));
            return Acceso.Escribir("spCrearWallet", parameters);

        }

        public static int Descontar(UsuarioEntity usuario, decimal cantidad)
        {
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(Acceso.CrearParametro("@Nombre", usuario.Nombre));
            parameters.Add(Acceso.CrearParametro("@Cantidad", cantidad));
            return Acceso.Escribir("spDescontarVandCoin", parameters);

        }

        public static int AgregarVandCoin(WalletEntity wallet, int cantVandCoin)
        {
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(Acceso.CrearParametro("@Id", wallet.Id));
            parameters.Add(Acceso.CrearParametro("@CantVandCoin", cantVandCoin));
            return Acceso.Escribir("spAgregarVandCoin", parameters);

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
