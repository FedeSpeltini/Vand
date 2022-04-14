using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class WalletBusiness
    {
        public void ActuliazarPrecioVandCoin()
        {

        }

        public void AgregarVanCoin(WalletEntity wallet, int cantVandCoin)
        {
            McWallet.AgregarVandCoin(wallet, cantVandCoin);
        }
    }
}
