using Abstractions;
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
    public partial class FrmDisco : Form, IIdiomaObserver
    {
        internal ICopia Copia;
        internal FrmPrincipal frmPrincipal = new FrmPrincipal();
        public FrmDisco()
        {
            InitializeComponent();
        }

        private void FrmDisco_Load(object sender, EventArgs e)
        {
            ucVistaDisco1.CargarDatosCopia(Copia);
            Traducir();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea comprar este disco?", "Compra", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UsuarioClienteBusiness user = new UsuarioClienteBusiness();
                //frmPrincipal.Usuario
                UsuarioEntity usuario = SessionState.RetornarUsuario();

                //(UsuarioEntity)frmPrincipal.Usuario
                UsuarioClienteEntity cliente = new UsuarioClienteEntity();
                cliente.Nombre = usuario.Nombre;

                user.Comprar(Copia, cliente);

                FrmGaleria frmGaleria = new FrmGaleria();
                frmGaleria.MdiParent = frmPrincipal;
                frmGaleria.frmPrincipal = frmPrincipal;
                MessageBox.Show("Compra Realizada exitosamente", "Compra");
                frmGaleria.Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Compra Cancelada", "Cancelada");
            }

        }

        private void Traducir()
        {
            IIdioma idioma = null;
            if (ManejadorDeSesion.IsLogged())
                idioma = ManejadorDeSesion.Session.Idioma;


            var traducciones = TraduccionBusiness.ObtenerTraducciones(idioma);
            if (btnComprar.Tag != null && traducciones.ContainsKey(btnComprar.Tag.ToString()))
                btnComprar.Text = traducciones[btnComprar.Tag.ToString()].Texto;

            if (this.Tag != null && traducciones.ContainsKey(this.Tag.ToString()))
                this.Text = traducciones[this.Tag.ToString()].Texto;

        }



        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir();
        }
    }
}
