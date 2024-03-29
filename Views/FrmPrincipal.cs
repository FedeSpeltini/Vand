﻿using Abstractions;
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
    public partial class FrmPrincipal : Form, IIdiomaObserver
    {
        

        
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
            ManejadorDeSesion.SuscribirObservador(this);

            //SessionState.PermisosUsuario()
            //Usuario.Permisos
            //SessionState.Usuario.Permisos = new List<PermisoEntity>();
            //inversiónToolStripMenuItem.Enabled = false;
            controlToolStripMenuItem.Enabled = false;
            //aBMToolStripMenuItem.Enabled = false;
            foreach (PermisoEntity permiso in SessionState.PermisosUsuario())
            {
                if(permiso.Descripcion == "Compra")
                {
                    publicarToolStripMenuItem.Enabled = true;
                    controlToolStripMenuItem.Enabled = true;
                    inversiónToolStripMenuItem.Enabled = true;

                }
            }
            Traducir();

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
            FrmPublicar frmPublicar = new FrmPublicar();
            frmPublicar.MdiParent = this;
            frmPublicar.frmPrincipal = this;
            frmPublicar.Show();
        }


        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIdioma frmIdioma = new FrmIdioma();
            frmIdioma.MdiParent = this;
            frmIdioma.frmPrincipal = this;
            frmIdioma.Show();
        }



        private void Traducir()
        {
            IIdioma idioma = null;
            if (ManejadorDeSesion.IsLogged())
                idioma = ManejadorDeSesion.Session.Idioma;


            var traducciones = TraduccionBusiness.ObtenerTraducciones(idioma);

            if (loginToolStripMenuItem.Tag != null && traducciones.ContainsKey(loginToolStripMenuItem.Tag.ToString()))
                loginToolStripMenuItem.Text = traducciones[loginToolStripMenuItem.Tag.ToString()].Texto;

            if (registroToolStripMenuItem.Tag != null && traducciones.ContainsKey(registroToolStripMenuItem.Tag.ToString()))
                registroToolStripMenuItem.Text = traducciones[registroToolStripMenuItem.Tag.ToString()].Texto;

            if (idiomaToolStripMenuItem.Tag != null && traducciones.ContainsKey(idiomaToolStripMenuItem.Tag.ToString()))
                idiomaToolStripMenuItem.Text = traducciones[idiomaToolStripMenuItem.Tag.ToString()].Texto;


        }


        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPermiso frmPermiso = new FrmPermiso();
            frmPermiso.MdiParent = this;
            
            frmPermiso.Show();
        }

        private void permisosUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPermisoUsuario frmPermisoUsuario = new FrmPermisoUsuario();
            frmPermisoUsuario.MdiParent = this;

            frmPermisoUsuario.Show();
        }

        private void aBMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTraducciones frmTraducciones = new FrmTraducciones();

            frmTraducciones.MdiParent = this;
            frmTraducciones.Show();
        }

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir();
        }

        private void misComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMisCompras frmMisCompras = new FrmMisCompras();

            frmMisCompras.MdiParent = this;
            frmMisCompras.Show();
        }

        private void comprarVandCoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComprarVandCoins frmComprarVandCoins = new FrmComprarVandCoins();

            frmComprarVandCoins.MdiParent = this;
            frmComprarVandCoins.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBitacora frmBitacora = new FrmBitacora();

            frmBitacora.MdiParent = this;
            frmBitacora.Show();
        }
    }
}
