using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class McEnvio
    {
        public List<EnvioEntity> Listar()
        {
            List<EnvioEntity> tablaEnvio = new List<EnvioEntity>();

            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("spListarEnviosNoFinalizados");
            Acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                EnvioEntity envio = new EnvioEntity();
                envio.Despachado = false;
                CompraEntity compra = new CompraEntity();
                
                UsuarioComercialEntity vendedor = new UsuarioComercialEntity();
                vendedor.Nombre = registro["NombreVendedor"].ToString();
                vendedor.CodigoPostal = registro["CodigoPostalVendedor"].ToString();
                compra.Vendedor = vendedor;
                UsuarioClienteEntity comprador = new UsuarioClienteEntity();
                comprador.Nombre = registro["NombreVendedor"].ToString();
                comprador.CodigoPostal = registro["CodigoPostalComprador"].ToString();
                tablaEnvio.Add(envio);
            }

            return tablaEnvio;
        }


        public void Despachar(EnvioEntity envio)
        {
            Acceso.Abrir();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(Acceso.CrearParametro("@IdCompra", 1));


            Acceso.Escribir("spAutorizarEnvio", parameters);

            Acceso.Cerrar();
        }
    }
}
