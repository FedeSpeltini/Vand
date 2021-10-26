using Abstractions;
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

        public void generarPlazoFijo(IInversion inversion)
        {
            inversion.MontoActual = inversion.MontoActual * inversion.Porcentaje;
            
            
        }

        public void ActualizarMontos(IInversion inversion)
        {
            //Buscar fecha de inicio de la inversion y restarla a la fecha del día corriente
            int diasPasados = (int)(DateTime.Today - inversion.FecCorriente).TotalDays;
            //Después actualizar los montos y guardarlo en BD.
            for(int i = 0; i<= diasPasados; i++)
            {
                inversion.MontoActual *= inversion.Porcentaje;
            }
            //Actualizar la última fecha registrada.
        }
        public void GuardarGananciaDiaria(IInversion inversion)
        {
            //guardar datos en SQL de la inversion
        }
    }
}
