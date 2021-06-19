using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CopiaEntity: DiscoEntity
    {
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

    }
}
