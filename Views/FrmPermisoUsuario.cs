using BE;
using BLL;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class FrmPermisoUsuario : Form, IIdiomaObserver
    {

        UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
        
        public FrmPermisoUsuario()
        {
            InitializeComponent();
        }

        public void UpdateLanguage(IdiomaEntity idioma)
        {
            throw new NotImplementedException();
        }

        private void FrmPermisoUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
            
            //LlenarTreeView(Sesion.ObtenerInstancia.EsteUsuario);
            //Subject.AgregarObserver(this);


        }

        private void LlenarTreeView(UsuarioEntity usu)
        {

            trAutorizaciones.Nodes.Clear();

            foreach (PermisoEntity permiso in usu.Permisos)
            {
                funcionRecursiva(permiso);
            }
            trAutorizaciones.ExpandAll();

        }

        private void funcionRecursiva(PermisoEntity permiso, TreeNode NodoPadre = null, TreeNode EsteNodo = null)
        {
            if (permiso.GetType() == typeof(GrupoEntity))
            { //si entra aca es por que es permiso
                if (NodoPadre == null)
                {//si entra aca es por que es permiso suelto
                    NodoPadre = new TreeNode();
                    NodoPadre.Tag = permiso;
                    NodoPadre.Text = permiso.Descripcion;
                    NodoPadre.Name = permiso.Descripcion; //si pincha aca es por que debo sacar el null de la firma
                    

                    foreach(PermisoEntity permisoHijo in ((GrupoEntity)permiso).Permisos)
                    {
                        EsteNodo = new TreeNode();
                        EsteNodo.Tag = permisoHijo;
                        EsteNodo.Text = permisoHijo.Descripcion;
                        EsteNodo.Name = permisoHijo.Descripcion;
                        NodoPadre.Nodes.Add(EsteNodo);
                    }
                    trAutorizaciones.Nodes.Add(NodoPadre);
                }
                else
                {//si entra aca es por que es permiso que pertenece a un rol
                    EsteNodo = new TreeNode();
                    EsteNodo.Tag = permiso;
                    EsteNodo.Text = permiso.Descripcion;
                    EsteNodo.Name = permiso.Descripcion;
                    NodoPadre.Nodes.Add(EsteNodo);

                }
            }


        }



        public void CargarDatos()
        {
            lstUsuario.Items.Clear();
            lstUsuario.DataSource = usuarioBusiness.ListarNoBoss();
            lstUsuario.DisplayMember = "Nombre";

            lstPermiso.Items.Clear();
            lstPermiso.DataSource = PermisoBusiness.Listar();
            lstPermiso.DisplayMember = "Descripcion";

            lstGrupos.Items.Clear();
            lstGrupos.DataSource = PermisoBusiness.ListarPermisosPadre();
            lstGrupos.DisplayMember = "Nombre";
        }

        private void lstUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTreeView((UsuarioEntity)lstUsuario.SelectedItem);
        }
    }
}
