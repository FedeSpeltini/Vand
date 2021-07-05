using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class McCompra
    {

        private Acceso acceso = new Acceso();
        public void Agregar(CompraEntity compra)
        {
            Acceso.Abrir();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(Acceso.CrearParametro("@NombreComprador", compra.Comprador.Nombre));
            parameters.Add(Acceso.CrearParametro("@NombreVendedor", compra.Vendedor.Nombre));
            parameters.Add(Acceso.CrearParametro("@NombreCopia", compra.Producto.Nombre));
            parameters.Add(Acceso.CrearParametro("@PrecioCopia", compra.Producto.Precio));
            parameters.Add(Acceso.CrearParametro("@Porcentaje", compra.Comision.Porcentaje)); 
            parameters.Add(Acceso.CrearParametro("@Ganancia", compra.Comision.Ganancia));

            Acceso.Escribir("spCargarCompra", parameters);

            Acceso.Cerrar();
        }


    }
}
