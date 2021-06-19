using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CopiaBusiness
    {
        McCopia mc = new McCopia();
        public List<CopiaEntity> ObtenerDiscos()
        {
            return mc.Listar();
        }
    }
}
