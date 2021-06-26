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

            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("spListarCopias");
            Acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                CopiaEntity copia = new CopiaEntity();
                copia.Nombre = registro["NombreCopia"].ToString();
                copia.Precio = decimal.Parse(registro["Precio"].ToString());
                copia.Year = Convert.ToDateTime(registro["Year"].ToString());
                UsuarioComercialEntity usuario = new UsuarioComercialEntity();
                usuario.Nombre = registro["NombrePropietario"].ToString();
                copia.Propetario = usuario;
                tablaCopia.Add(copia);
            }

            return tablaCopia;
        }



    }
}
