using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InversionBusiness
    {

        public void generarPlazoFijo(WalletEntity wallet, decimal cantidad)
        {
            wallet.VandCoins.Cantidad -= cantidad;
            
            
        }
    }
}
