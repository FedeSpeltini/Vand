using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class WalletEntity
    {
        private VandCoinEntity vandCoins = new VandCoinEntity();

        public VandCoinEntity VandCoins 
        {
            get { return vandCoins;  }
            set { vandCoins = value; }
        }

        private decimal cantidad;

        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

    }
}
