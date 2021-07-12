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
        //public List<CopiaEntity> DesprenderCopia(UsuarioComercialEntity vendedor, CopiaEntity copia)
        //{
        //    vendedor.Discos.Remove(copia);
        //    mcUsuarioComercial.QuitarCopia(vendedor, copia);
        //    return vendedor.Discos;

        //}
        //public virtual VentaEntity CargarVenta(CompraEntity compra)
        //{
        //    ComisionBusiness comision = new ComisionBusiness();
        //    VentaEntity venta = new VentaEntity();

        //    venta.Comprador = compra.Comprador;
        //    venta.Vendedor = compra.Vendedor;
        //    venta.Producto = compra.Producto;
        //    venta.Honorarios = comision.AplicarComision(copia, venta);

        //    mcVenta.Agregar(venta);
        //    return venta;
        //}


        public override void CrearUsuario(UsuarioEntity usuario)
        {
            base.CrearUsuario(usuario);
            McUsuario mc = new McUsuario();

            mc.Agregar(usuario, 102);
        }
    }
}
