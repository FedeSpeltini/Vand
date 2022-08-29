using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DiscoBusiness
    {
        public static List<DiscoEntity> GetAlbums(Banda banda)
        {
            return McDisco.Listar(banda.Id);
        }

        public static void CreateAlbum(DiscoEntity disco)
        {
            McDisco.Agregar(disco);
        }
    }
}
