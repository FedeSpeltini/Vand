using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CompraBusiness
    {
        McCompra mc = new McCompra();


        public event EventHandler CompraRealizada;

        //static void Main()
        //{
        //    CopiaEntity copia = new CopiaEntity();
        //    CompraBusiness compraBs = new CompraBusiness();
        //    compraBs.CompraRealizada += c_ThresholdReached;
        //    compraBs.CompraRealizada += new EventHandler((sender, e) => PlayMusicEvent(sender, e, copia));
        //    // provide remaining implementation for the class
        //}

        protected virtual void OnCompraRealizada(EventArgs e)
        {
            EventHandler handler = CompraRealizada;
            handler?.Invoke(this, e);
        }
        public void Comprar(CopiaEntity copia, UsuarioClienteEntity comprador)
        {
            CompraEntity compra = new CompraEntity();
            compra.Comprador = comprador;
            compra.Producto = copia;
            mc.Agregar(compra);
        }



    }
}
