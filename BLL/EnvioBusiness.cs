using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EnvioBusiness
    {

        McEnvio mc = new McEnvio();
        public List<EnvioEntity> Listar()
        {
            return mc.Listar();
        }

        public void Despachar(EnvioEntity envio)
        {

        }
    }
}
