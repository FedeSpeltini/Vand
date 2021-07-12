using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DAL
{
    public class McInversion
    {
        public void Agregar(InversionEntity inversion)
        {
            //int id = ProxId();


            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            
            parameters.Add(Acceso.CrearParametro("@Nombre", inversion.Usuario.Nombre));
            parameters.Add(Acceso.CrearParametro("@MontoInicial", inversion.MontoInicial));
            parameters.Add(Acceso.CrearParametro("@MontoFinal", inversion.MontoFinal));
            parameters.Add(Acceso.CrearParametro("@FecInicial", inversion.FecInicio));
            parameters.Add(Acceso.CrearParametro("@FecFinal", inversion.FecFin));

            Acceso.Escribir("spCrearInversion", parameters);

            Acceso.Cerrar();

            //mcWallet.Agregar(id);

        }


        public void LiquidarPlazoFijo(InversionEntity inversion)
        {
            //int id = ProxId();


            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();


            parameters.Add(Acceso.CrearParametro("@Nombre", inversion.Usuario.Nombre));
            parameters.Add(Acceso.CrearParametro("@MontoInicial", inversion.MontoInicial));
            parameters.Add(Acceso.CrearParametro("@MontoFinal", inversion.MontoFinal));
            parameters.Add(Acceso.CrearParametro("@FecInicial", inversion.FecInicio));
            parameters.Add(Acceso.CrearParametro("@FecFinal", inversion.FecFin));

            Acceso.Escribir("spCrearInversion", parameters);

            Acceso.Cerrar();


        }

        public List<InversionEntity> ListarPendientes()
        {
            List<InversionEntity> tablaInversion = new List<InversionEntity>();

            Acceso.Abrir();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();


            parameters.Add(Acceso.CrearParametro("@FecFin", DateTime.Today));
            DataTable tabla = Acceso.Leer("spListarInversionesSinFinalizar", parameters);
            Acceso.Cerrar();
            

            foreach (DataRow registro in tabla.Rows)
            {
                InversionEntity inversion = new InversionEntity();

                inversion.FecInicio = DateTime.Parse(registro["fecInicio"].ToString());
                inversion.FecFin = DateTime.Parse(registro["fecFin"].ToString());
                inversion.MontoInicial = decimal.Parse(registro["MontoInicio"].ToString());
                inversion.MontoFinal = decimal.Parse(registro["MontoFin"].ToString());
                UsuarioComercialEntity usuario = new UsuarioComercialEntity();
                usuario.Nombre = registro["NombreUsuario"].ToString();
                inversion.Usuario = usuario;
                tablaInversion.Add(inversion);
            }

            return tablaInversion;
        }
    }
}
