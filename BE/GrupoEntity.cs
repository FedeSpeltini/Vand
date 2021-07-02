using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GrupoEntity
    {
        private List<PermisoEntity> permisos = new List<PermisoEntity>();

        public List<PermisoEntity> Permisos
        {
            get { return permisos; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        //public class GrupoEntity : PermisoEntity

    }
}
