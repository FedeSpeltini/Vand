using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class UsuarioComercialBusiness : UsuarioBusiness
    {
        McVenta mcVenta = new McVenta();

        McUsuarioComercial mcUsuarioComercial = new McUsuarioComercial();
        public List<CopiaEntity> DesprenderCopia(UsuarioComercialEntity vendedor, CopiaEntity copia)
        {
            vendedor.Discos.Remove(copia);
            mcUsuarioComercial.QuitarCopia(vendedor, copia);
            return vendedor.Discos;

        }
        public virtual VentaEntity CargarVenta(CopiaEntity copia, UsuarioClienteEntity comprador, UsuarioComercialEntity vendedor)
        {
            ComisionBusiness comision = new ComisionBusiness();
            VentaEntity venta = new VentaEntity();

            venta.Comprador = comprador;
            venta.Vendedor = vendedor;
            venta.Producto = copia;
            venta.Honorarios = comision.AplicarComision(copia, venta);

            mcVenta.Agregar(venta);
            return venta;
        }
    }
}
