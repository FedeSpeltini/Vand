using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class InversionEntity
    {
        private decimal montoInicial;
        public decimal MontoInicial
        {
            get { return montoInicial; }
            set { montoInicial = value; }
        }

        private decimal montoFinal;
        public decimal MontoFinal
        {
            get { return montoFinal; }
            set { montoFinal = value; }
        }

        private UsuarioComercialEntity usuario;

        public UsuarioComercialEntity Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private DateTime fecInicio;

        public DateTime FecInicio
        {
            get { return fecInicio; }
            set { fecInicio = value; }
        }

        private DateTime fecFin;

        public DateTime FecFin
        {
            get { return fecFin; }
            set { fecFin = value; }
        }



    }
}
