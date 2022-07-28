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

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public VandCoinEntity VandCoins 
        {
            get { return vandCoins;  }
            set { vandCoins = value; }
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

    }
}
