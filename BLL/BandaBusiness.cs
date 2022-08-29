using Abstractions;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BandaBusiness
    {
        public static List<IBanda> GetBands()
        {
            return McBanda.Listar();
        }

        public static void CreateBand(IBanda banda)
        {
             McBanda.Agregar(banda);
        }
    }
}
