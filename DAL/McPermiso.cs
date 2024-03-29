﻿using BE;
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
                //PermisoEntity permisoAux = new PermisoEntity();
                //permisoAux.Id = int.Parse(registro["ID_PERMISO"].ToString());
                //permisoAux.Descripcion = registro["PERMISO"].ToString();
                usuario.Permisos.Add((from PermisoEntity p in lista
                                      where p.Id == int.Parse(registro["ID_PERMISO"].ToString())
                                      select p).FirstOrDefault());
                //usuario.Permisos.Add(permisoAux);

            }
            Acceso.Cerrar();

            return usuario.Permisos;
        }
      
        public static List<PermisoEntity> ListarSubPermisos()
        {
            List<PermisoEntity> lista = new List<PermisoEntity>();
            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("spListarSubPermisos");
            foreach (DataRow registro in tabla.Rows)
            {
                PermisoEntity permisoAux = new PermisoEntity();
                permisoAux.Id = int.Parse(registro["ID_PERMISO"].ToString());
                permisoAux.Descripcion = registro["PERMISO"].ToString();
                lista.Add(permisoAux);
            }
            Acceso.Cerrar();

            return lista;
        }


        public static List<PermisoEntity> ListarPermisosPadre()
        {
            List<PermisoEntity> lista = new List<PermisoEntity>();
            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("spListarPermisosPadre");
            foreach (DataRow registro in tabla.Rows)
            {
                PermisoEntity permisoAux = new PermisoEntity();
                permisoAux.Id = int.Parse(registro["ID_PERMISO"].ToString());
                permisoAux.Descripcion = registro["PERMISO"].ToString();
                lista.Add(permisoAux);
            }
            Acceso.Cerrar();

            return lista;
        }



        public static List<PermisoEntity> ListarPermisosHijo(PermisoEntity permiso)
        {
            List<PermisoEntity> lista = new List<PermisoEntity>();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@ID", permiso.Id));
            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("spListarPermisosHijo", parameters);
            foreach (DataRow registro in tabla.Rows)
            {
                PermisoEntity permisoAux = new PermisoEntity();
                permisoAux.Id = int.Parse(registro["ID_PERMISO"].ToString());
                permisoAux.Descripcion = registro["PERMISO"].ToString();
                lista.Add(permisoAux);
            }
            Acceso.Cerrar();

            return lista;
        }

        public static void AgregarHijo(PermisoEntity permisoPadre, PermisoEntity permisoHijo)
        {
            List<PermisoEntity> lista = new List<PermisoEntity>();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@IdPadre", permisoPadre.Id));
            parameters.Add(Acceso.CrearParametro("@IdHijo", permisoHijo.Id));
            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("spAgregarPermiso", parameters);
            Acceso.Cerrar();
        }

        public static void SacarHijo(PermisoEntity permisoPadre, PermisoEntity permisoHijo)
        {
            List<PermisoEntity> lista = new List<PermisoEntity>();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@IdPadre", permisoPadre.Id));
            parameters.Add(Acceso.CrearParametro("@IdHijo", permisoHijo.Id));
            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("spSacarPermiso", parameters);
            Acceso.Cerrar();
        }
        public static void CrearPermisoHijo(string nombre)
        {
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@Permiso", nombre));
            Acceso.Escribir("spCrearPermisoHijo", parameters);

            Acceso.Cerrar();
        }

        public static void CrearPermisoPadre(string nombre)
        {
            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@Permiso", nombre));
            Acceso.Escribir("spCrearPermisoPadre", parameters);

            Acceso.Cerrar();
        }
    }
}
