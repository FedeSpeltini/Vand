using System;
using BE;
using BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using EjemploArquitectura.Services;

namespace Views
{
    public partial class FrmIdioma : Form, IIdiomaObserver
    {
        internal FrmPrincipal frmPrincipal;
        public FrmIdioma()
        {
            InitializeComponent();
        }

        private void FrmIdioma_Load(object sender, EventArgs e)
        {
            ManejadorDeSesion.SuscribirObservador(this);
            foreach (IdiomaEntity idioma in TraduccionBusiness.ObtenerIdiomas())
            {
                lstIdioma.DisplayMember = nameof(idioma.Nombre);
                lstIdioma.ValueMember = nameof(idioma);
                lstIdioma.Items.Add(idioma);
            }
            Traducir();
        }

        public void Traducir()
        {
            IdiomaEntity idioma = null;
            if (ManejadorDeSesion.IsLogged())
                idioma = ManejadorDeSesion.Session.Idioma;


            var traducciones = TraduccionBusiness.ObtenerTraducciones(idioma);
            if (btnSeleccionar.Tag != null && traducciones.ContainsKey(btnSeleccionar.Tag.ToString()))
                btnSeleccionar.Text = traducciones[btnSeleccionar.Tag.ToString()].Texto;
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //frmPrincipal.Traducciones = TraduccionBusiness.ObtenerTraducciones(2);
            ManejadorDeSesion.CambiarIdioma((IdiomaEntity)lstIdioma.SelectedItem);
        }

        public void UpdateLanguage(IdiomaEntity idioma)
        {
            Traducir();
        }
    }
}
