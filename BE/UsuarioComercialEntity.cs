using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class UsuarioComercialEntity : UsuarioEntity
    {
        private string ctaBancaria;

        public string CtaBancaria
        {
            get { return ctaBancaria; }
            set { ctaBancaria = value; }
        }


        private decimal vandCoins;

        public decimal VandCoins
        {
            get { return vandCoins; }
            set { vandCoins = value; }
        }

        private decimal dinero;

        public decimal Dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }

        private InversionEntity inversion;

        public InversionEntity Inversion
        {
            get { return inversion; }
            set { inversion = value; }
        }
    }
}
