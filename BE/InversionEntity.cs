using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class InversionEntity
    {
        private decimal vandCoinInvertido;
        public decimal VandCoinInvertido
        {
            get { return vandCoinInvertido; }
            set { vandCoinInvertido = value; }
        }

        private decimal vandCoinGenerado;
        public decimal VandCoinGenerado
        {
            get { return vandCoinGenerado; }
            set { vandCoinGenerado = value; }
        }
    }
}
