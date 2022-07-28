using Abstractions;
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
        public void Comprar(ICopia copia, UsuarioClienteEntity comprador)
        {   
            CompraEntity compra = new CompraEntity();

            compra.Comprador = comprador;

            compra.Vendedor = copia.Propietario;
            comision.Ganancia = copia.Precio * comision.Porcentaje;
            compra.ValorFinal = copia.Precio - (copia.Precio * comision.Porcentaje);
            compra.Producto = copia;
            compra.Comision = comision;
            if(SaldoSuficiente(comprador, copia.Precio + comision.Ganancia))
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
