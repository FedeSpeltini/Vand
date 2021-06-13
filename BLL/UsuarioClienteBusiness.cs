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
        public void Comprar(UsuarioComercialEntity vendedor, CopiaEntity copia, UsuarioClienteEntity comprador)
        {

            CompraEntity compra = new CompraEntity();

            compra.Comprador = comprador;

            compra.Vendedor = vendedor;

            compra.Producto = copia;

            UsuarioComercialBusiness ucb = new UsuarioComercialBusiness();

            comprador.Wallet = DescontarVandCoins(copia, comprador.Wallet);

            ucb.CargarVenta(copia, comprador, vendedor);

            ucb.DesprenderCopia(vendedor, copia);

            mcCompra.Agregar(compra);



        }

        public WalletEntity DescontarVandCoins(CopiaEntity copia, WalletEntity walletUsuario)
        {
            walletUsuario.VandCoins.Cantidad -= copia.Precio.Cantidad;

            return walletUsuario;
        }
    }
}
