using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class VentaEntity: CompraEntity
    {
        private decimal honorarios;

        public decimal Honorarios
        {
            get { return honorarios; }
            set { honorarios = value; }
        }

    }
}
