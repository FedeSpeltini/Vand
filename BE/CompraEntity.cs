using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CompraEntity
    {
        private CopiaEntity producto;

        public CopiaEntity Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        private UsuarioComercialEntity vendedor;

        public UsuarioComercialEntity Vendedor
        {
            get { return vendedor; }
            set { vendedor = value; }
        }

        private decimal valorFinal;

        public decimal ValorFinal
        {
            get { return valorFinal; }
            set { valorFinal = value; }
        }

        private ComisionEntity comision;

        public ComisionEntity Comision
        {
            get { return comision; }
            set { comision = value; }
        }


        private UsuarioClienteEntity comprador;

        public UsuarioClienteEntity Comprador
        {
            get { return comprador; }
            set { comprador = value; }
        }
    }
}
