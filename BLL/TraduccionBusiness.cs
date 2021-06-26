using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TraduccionBusiness
    {

        public static IDictionary<string, TraduccionEntity> ObtenerTraducciones()
        {
            return McTraductor.ObtenerTraducciones();
        }
    }
}
