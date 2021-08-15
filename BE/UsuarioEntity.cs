using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public  class UsuarioEntity: IEntity, IUsuario
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string rol;

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }


        private List<PermisoEntity> permisos = new List<PermisoEntity>();

        public List<PermisoEntity> Permisos
        {
            get { return permisos; }
            set { permisos = value; }
        }

        private IdiomaEntity idioma2;

        public IdiomaEntity Idioma2
        {
            get { return idioma2; }
            set { idioma2 = value; }
        }

        public int Id { get; set; }
        IIdioma IUsuario.Idioma { get; set; }
    }
}
