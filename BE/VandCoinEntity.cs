using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class VandCoinEntity
    {
        private decimal cantidad;

        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private decimal valor;

        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }


    }
}
