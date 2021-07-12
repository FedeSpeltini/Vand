using BE;
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
    public partial class FrmPrincipal : Form
    {
        public IDictionary<string, TraduccionEntity> Traducciones;

        internal UsuarioEntity Usuario = new UsuarioEntity();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.MdiParent = this;
            frmLogin.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro();
            frmRegistro.MdiParent = this;
            frmRegistro.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            foreach(PermisoEntity permiso in Usuario.Permisos)
            {
                if(permiso.Descripcion == "Cliente")
                {
                    publicarToolStripMenuItem.Enabled = false;
                    controlToolStripMenuItem.Enabled = false;
                }
                if (permiso.Descripcion == "Empresa")
                {
                    galeriaToolStripMenuItem.Enabled = false;
                    controlToolStripMenuItem.Enabled = false;
                }
            }

            if (loginToolStripMenuItem.Tag != null && Traducciones.ContainsKey(loginToolStripMenuItem.Tag.ToString()))
                loginToolStripMenuItem.Text = Traducciones[loginToolStripMenuItem.Tag.ToString()].Texto;

            if (registroToolStripMenuItem.Tag != null && Traducciones.ContainsKey(registroToolStripMenuItem.Tag.ToString()))
                registroToolStripMenuItem.Text = Traducciones[registroToolStripMenuItem.Tag.ToString()].Texto;
        }

        private void galeriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGaleria frmGaleria = new FrmGaleria();
            frmGaleria.MdiParent = this;
            frmGaleria.frmPrincipal = this;
            frmGaleria.Show();
        }

        private void controlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void publicarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIdioma frmIdioma = new FrmIdioma();
            frmIdioma.MdiParent = this;
            frmIdioma.frmPrincipal = this;
            frmIdioma.Show();
        }
    }
}
