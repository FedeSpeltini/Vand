using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioClienteBusiness: UsuarioComercialBusiness
    {

        McCompra mcCompra = new McCompra();
        ComisionEntity comision = new ComisionEntity();
        McUsuarioCliente mcUsuario = new McUsuarioCliente();
        public void Comprar(CopiaEntity copia, UsuarioClienteEntity comprador)
        {   
            CompraEntity compra = new CompraEntity();

            compra.Comprador = comprador;

            compra.Vendedor = copia.Propetario;
            comision.Ganancia = copia.Precio * comision.Porcentaje;
            compra.ValorFinal = copia.Precio - (copia.Precio * comision.Porcentaje);
            compra.Producto = copia;
            compra.Comision = comision;
           // UsuarioComercialBusiness ucb = new UsuarioComercialBusiness();

            //comprador.Wallet = DescontarVandCoins(copia, comprador.Wallet);

            //ucb.CargarVenta(copia, comprador, vendedor);

            //ucb.DesprenderCopia(vendedor, copia);

            mcCompra.Agregar(compra);



        }

        public bool SaldoSuficiente(UsuarioClienteEntity usuario, decimal costo)
        {
           if(costo > mcUsuario.ObtenerSaldoActual(usuario))
           {
                return true;
           }
           else
            {
                return false;
            }
            

        }



        public override void CrearUsuario(UsuarioEntity usuario)
        {
           // base.CrearUsuario(usuario);
            McUsuario mc = new McUsuario();

            mc.Agregar(usuario, 101);
        }
    }
}
