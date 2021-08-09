using BE;
using BLL;
using EjemploArquitectura.Services;
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
            Traducir();
        }

        private void FrmPermisoUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos();

            //LlenarTreeView(Sesion.ObtenerInstancia.EsteUsuario);
            //Subject.AgregarObserver(this);
            Traducir();


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
            //lstUsuario.Items.Clear();

            lstUsuario.DataSource = usuarioBusiness.ListarNoBoss();
            lstUsuario.DisplayMember = "Nombre";

            //lstPermiso.Items.Clear();
            lstPermiso.DataSource = PermisoBusiness.ListarSubPermisos();
            lstPermiso.DisplayMember = "Descripcion";

            //lstGrupos.Items.Clear();
            lstGrupos.DataSource = PermisoBusiness.ListarPermisosPadre();
            lstGrupos.DisplayMember = "Descripcion";

            //lstSubPermiso.Items.Clear();
            //lstSubPermiso.DataSource = PermisoBusiness.ListarPermisosPadre();
            //lstSubPermiso.DisplayMember = "Descripcion";
        }

        private void lstUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTreeView((UsuarioEntity)lstUsuario.SelectedItem);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PermisoBusiness.AgregarHijo((PermisoEntity)lstGrupos.SelectedItem, (PermisoEntity)lstPermiso.SelectedItem);
            CargarDatos();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            PermisoBusiness.SacarHijo((PermisoEntity)lstGrupos.SelectedItem, (PermisoEntity)lstPermiso.SelectedItem);
            CargarDatos();
        }

        private void lstGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lstSubPermiso.DataSource = PermisoBusiness.ListarPermisosHijo((PermisoEntity)lstGrupos.SelectedItem);
            lstSubPermiso.DisplayMember = "Descripcion";
        }

        private void Traducir()
        {
            IdiomaEntity idioma = null;
            if (ManejadorDeSesion.IsLogged())
                idioma = ManejadorDeSesion.Session.Idioma;


            var traducciones = TraduccionBusiness.ObtenerTraducciones(idioma);
            if (btnAgregar.Tag != null && traducciones.ContainsKey(btnAgregar.Tag.ToString()))
                btnAgregar.Text = traducciones[btnAgregar.Tag.ToString()].Texto;

            if (btnAgregarObjeto.Tag != null && traducciones.ContainsKey(btnAgregarObjeto.Tag.ToString()))
                btnAgregarObjeto.Text = traducciones[btnAgregarObjeto.Tag.ToString()].Texto;

            if (btnSacar.Tag != null && traducciones.ContainsKey(btnSacar.Tag.ToString()))
                btnSacar.Text = traducciones[btnSacar.Tag.ToString()].Texto;


            if (PermisosLbl.Tag != null && traducciones.ContainsKey(PermisosLbl.Tag.ToString()))
                PermisosLbl.Text = traducciones[PermisosLbl.Tag.ToString()].Texto;

            if (RolesLbl.Tag != null && traducciones.ContainsKey(RolesLbl.Tag.ToString()))
                RolesLbl.Text = traducciones[RolesLbl.Tag.ToString()].Texto;

            if (UsuariosLbl.Tag != null && traducciones.ContainsKey(UsuariosLbl.Tag.ToString()))
                UsuariosLbl.Text = traducciones[UsuariosLbl.Tag.ToString()].Texto;


            if (AutsUsuarioLbl.Tag != null && traducciones.ContainsKey(AutsUsuarioLbl.Tag.ToString()))
                AutsUsuarioLbl.Text = traducciones[AutsUsuarioLbl.Tag.ToString()].Texto;

            if (rdGrupo.Tag != null && traducciones.ContainsKey(rdGrupo.Tag.ToString()))
                rdGrupo.Text = traducciones[rdGrupo.Tag.ToString()].Texto;

            if (rdPermiso.Tag != null && traducciones.ContainsKey(rdPermiso.Tag.ToString()))
                rdPermiso.Text = traducciones[rdPermiso.Tag.ToString()].Texto;


            if (AutsUsuarioLbl.Tag != null && traducciones.ContainsKey(AutsUsuarioLbl.Tag.ToString()))
                AutsUsuarioLbl.Text = traducciones[AutsUsuarioLbl.Tag.ToString()].Texto;

            if (UsuariosLbl.Tag != null && traducciones.ContainsKey(UsuariosLbl.Tag.ToString()))
                UsuariosLbl.Text = traducciones[UsuariosLbl.Tag.ToString()].Texto;

            if (lblRolPermission.Tag != null && traducciones.ContainsKey(lblRolPermission.Tag.ToString()))
                lblRolPermission.Text = traducciones[lblRolPermission.Tag.ToString()].Texto;

            if (this.Tag != null && traducciones.ContainsKey(this.Tag.ToString()))
                this.Text = traducciones[this.Tag.ToString()].Texto;

        }
        private void btnAgregarObjeto_Click(object sender, EventArgs e)
        {
            if (rdGrupo.Checked)
            {
                PermisoBusiness.CrearPermisoPadre(txtObjeto.Text);
                CargarDatos();
            }
            if (rdPermiso.Checked)
            {
                PermisoBusiness.CrearPermisoHijo(txtObjeto.Text);
                CargarDatos();
            }
        }
    }
}
