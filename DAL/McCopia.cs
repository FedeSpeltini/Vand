using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class McCopia
    {
        private Acceso acceso = new Acceso();
        public List<CopiaEntity> Listar()
        {
            List<CopiaEntity> tablaCopia = new List<CopiaEntity>();

            acceso.Abrir();
            DataTable tabla = acceso.Leer("spObtenerHistorial");
            acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                CopiaEntity copia = new CopiaEntity();
                copia.Nombre = registro["NombreJugador"].ToString();
                copia.Precio = decimal.Parse(registro["PartidasGanadas"].ToString());
                copia.Year = Convert.ToDateTime(registro["PartidasEmpatadas"].ToString());
                //copia.Musicos = int.Parse(registro["PartidasPerdidas"].ToString());
                tablaCopia.Add(copia);
            }

            return tablaCopia;
        }



    }
}
