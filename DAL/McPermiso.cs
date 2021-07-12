using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class McPermiso
    {

        public static List<PermisoEntity> Listar()
        {

            List<PermisoEntity> lista = new List<PermisoEntity>();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("PERMISO_Listar", parameters);
            foreach (DataRow registro in tabla.Rows)
            {

                PermisoEntity obj;
                if (registro["ID_PERMISO"].ToString() == "P")
                {
                    obj = new PermisoEntity();
                }
                else
                {
                    obj = new GrupoEntity();
                }
                obj.Id = int.Parse(registro["ID_PERMISO"].ToString());
                obj.Descripcion = registro["PERMISO"].ToString();
                lista.Add(obj);
            }
            tabla = null;
            if (lista.Count > 0)
            {
                tabla = Acceso.Leer("GRUPO_LISTAR", parameters);
                foreach (DataRow registro in tabla.Rows)
                {
                    GrupoEntity grupo = (from GrupoEntity g in lista
                                          where g.Id == int.Parse(registro["ID_GRUPO"].ToString())
                                          select g).FirstOrDefault();
                    PermisoEntity permiso = (from PermisoEntity p in lista
                                              where p.Id == int.Parse(registro["ID_PERMISO"].ToString())
                                              select p).FirstOrDefault();
                    grupo.Permisos.Add(permiso);
                }
            }
            Acceso.Cerrar();
            return lista;
        }


        public static List<PermisoEntity> Listar(UsuarioEntity usuario)
        {
            List<PermisoEntity> lista = Listar();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@nombre", usuario.Nombre));
            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("USUARIO_PERMISO_LISTAR", parameters);
            foreach (DataRow registro in tabla.Rows)
            {
                PermisoEntity permisoAux = new PermisoEntity();
                permisoAux.Id = int.Parse(registro["ID_PERMISO"].ToString());
                permisoAux.Descripcion = registro["PERMISO"].ToString();
                //usuario.Permisos.Add((from PermisoEntity p in lista
                //                      where p.Id == int.Parse(registro["ID_PERMISO"].ToString())
                //                      select p).FirstOrDefault());
                usuario.Permisos.Add(permisoAux);

            }
            Acceso.Cerrar();

            return usuario.Permisos;
        }
    }
}
