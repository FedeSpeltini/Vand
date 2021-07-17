using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class PermisoBusiness
    {

        public static List<PermisoEntity> Listar()
        {
            return McPermiso.Listar();   
        }


        public static List<PermisoEntity> ListarPermisosPadre()
        {
            return McPermiso.ListarPermisosPadre();
        }
        public static List<PermisoEntity> ListarPermisosHijo(PermisoEntity permiso)
        {
            return McPermiso.ListarPermisosHijo(permiso);
        }

        public static List<PermisoEntity> ListarSubPermisos()
        {
            return McPermiso.ListarSubPermisos();
        }
    }
}
