using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class EnvioEntity
    {
        private CompraEntity compra;

        public CompraEntity Compra
        {
            get { return compra; }
            set { compra = value; }
        }

        private bool despachado;

        public bool Despachado
        {
            get { return despachado; }
            set { despachado = value; }
        }


    }
}
