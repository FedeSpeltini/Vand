using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GrupoEntity : PermisoEntity
    {
        private List<PermisoEntity> permisos = new List<PermisoEntity>();

        public List<PermisoEntity> Permisos
        {
            get { return permisos; }
        }
    }
}
