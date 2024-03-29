﻿using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class McUsuario
    {


        public static  string ValidarUsuario(UsuarioEntity usuario)
        {
            Acceso.Abrir();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            parameters.Add(Acceso.CrearParametro("@Username", usuario.Nombre));
            parameters.Add(Acceso.CrearParametro("@Clave", usuario.Password));

            DataTable tabla = Acceso.Leer("spValidarUsuario", parameters);
            Acceso.Cerrar();

            if (tabla.Rows.Count == 1)
            {
                return tabla.Rows[0]["PERMISO"].ToString();
            }
            else
            {
                return "";
            }
        }
        public static List<UsuarioEntity> ListarUsuariosNoBoss()
        {
            List<UsuarioEntity> usuarios = new List<UsuarioEntity>();
            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("spListarUsuariosNoBoss");
            Acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                UsuarioEntity usuario = new UsuarioEntity();
                usuario.Nombre = registro["nombre"].ToString();
                usuario.Permisos = McPermiso.Listar(usuario);
                usuarios.Add(usuario);
            }
            return usuarios;
        }


        public  void Agregar(UsuarioEntity usuario, int rol)
        {
            //int id = ProxId();


            Acceso.Abrir();

            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            //parameters.Add(Acceso.CrearParametro("@Id", id));
            parameters.Add(Acceso.CrearParametro("@Nombre", usuario.Nombre));
            parameters.Add(Acceso.CrearParametro("@Clave", usuario.Password));
            parameters.Add(Acceso.CrearParametro("@Rol", rol));

            Acceso.Escribir("spCrearUsuario", parameters);

            Acceso.Cerrar();

            //mcWallet.Agregar(id);

        }


        public static int ProxId()
        {
            Acceso.Abrir();


            List<IDbDataParameter> parameters = new List<IDbDataParameter>();
            parameters.Add(Acceso.CrearParametro("@Tabla", "tUsuario"));
            DataTable tabla = Acceso.Leer("spObtenerUltimoId");
            Acceso.Cerrar();
            int proxLegajo = 1;
            foreach (DataRow registro in tabla.Rows)
            {
                proxLegajo = int.Parse(registro["IdConcepto"].ToString());
            }

            return proxLegajo;
        }




        //public static int ObtenerId()
        //{
        //    Acceso.Abrir();


        //    List<IDbDataParameter> parameters = new List<IDbDataParameter>();
        //    parameters.Add(Acceso.CrearParametro("@Tabla", "tUsuario"));

        //    Acceso.Cerrar();
        //    int proxLegajo = 1;
        //    foreach (DataRow registro in tabla.Rows)
        //    {
        //        proxLegajo = int.Parse(registro["IdConcepto"].ToString());
        //    }

        //    return proxLegajo;
        //}

    }
}
