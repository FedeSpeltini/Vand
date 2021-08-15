using Abstractions;
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
        
        public List<CopiaEntity> Listar(UsuarioEntity cliente)
        {
            List<CopiaEntity> tablaCopia = new List<CopiaEntity>();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(Acceso.CrearParametro("@NombreUsuario", cliente.Nombre));
            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("spListarCopias", parameters);
            Acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                CopiaEntity copia = new CopiaEntity();
                copia.Nombre = registro["NombreCopia"].ToString();
                copia.Precio = decimal.Parse(registro["Precio"].ToString());
                copia.Year = Convert.ToDateTime(registro["Year"].ToString());
                copia.UrlPortada = registro["urlPortada"].ToString();
                UsuarioComercialEntity usuario = new UsuarioComercialEntity();
                usuario.Nombre = registro["NombrePropietario"].ToString();
                copia.Propietario = usuario;
                tablaCopia.Add(copia);
            }

            return tablaCopia;
        }

        public void Agregar(CopiaEntity copia)
        {
            //int id = ProxId();


            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            //parameters.Add(Acceso.CrearParametro("@Id", id));
            parameters.Add(Acceso.CrearParametro("@Nombre", copia.Nombre));
            parameters.Add(Acceso.CrearParametro("@Precio", copia.Precio));
            parameters.Add(Acceso.CrearParametro("@Propietario", copia.Propietario.Nombre));

            Acceso.Escribir("spCrearCopia", parameters);

            Acceso.Cerrar();

            //mcWallet.Agregar(id);

        }

        public static List<ICopia> ListarCompradas(UsuarioEntity cliente)
        {
            List<ICopia> tablaCopia = new List<ICopia>();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(Acceso.CrearParametro("@NombreUsuario", cliente.Nombre));
            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("spListarMisCompras", parameters);
            Acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                CopiaEntity copia = new CopiaEntity();
                copia.Nombre = registro["nombre"].ToString();                
                copia.Year = Convert.ToDateTime(registro["Year"].ToString());
                copia.UrlPortada = registro["urlPortada"].ToString();
                tablaCopia.Add(copia);
            }

            return tablaCopia;
        }

    }
}
