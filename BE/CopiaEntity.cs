using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CopiaEntity: DiscoEntity
    {
        private VandCoinEntity precio;

        public VandCoinEntity Precio
        {
            get { return precio; }
            set { precio = value; }
        }

    }
}
