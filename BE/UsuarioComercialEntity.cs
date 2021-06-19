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

        private WalletEntity wallet = new WalletEntity();

        public WalletEntity Wallet
        {
            get { return wallet; }
            set { wallet = value; }
        }


        private List<CopiaEntity> discos = new List<CopiaEntity>();

        public List<CopiaEntity> Discos
        {
            get { return discos; }
            set { discos = value; }
        }

        private List<VentaEntity> ventas;

        public List<VentaEntity> Ventas
        {
            get { return ventas; }
            set { ventas = value; }
        }


    }
}
