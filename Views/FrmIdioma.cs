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

namespace Views
{
    public partial class FrmIdioma : Form
    {
        internal FrmPrincipal frmPrincipal;
        public FrmIdioma()
        {
            InitializeComponent();
        }

        private void FrmIdioma_Load(object sender, EventArgs e)
        {
            foreach(IdiomaEntity idioma in TraduccionBusiness.ObtenerIdiomas())
            {
             
                lstIdioma.DisplayMember = nameof(idioma.Nombre);
                lstIdioma.ValueMember = nameof(idioma);
                lstIdioma.Items.Add(idioma);

            }
            Traducir();
        }

        public void Traducir()
        {
            if (btnSeleccionar.Tag != null && frmPrincipal.Traducciones.ContainsKey(btnSeleccionar.Tag.ToString()))
                btnSeleccionar.Text = frmPrincipal.Traducciones[btnSeleccionar.Tag.ToString()].Texto;
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmPrincipal.Traducciones = TraduccionBusiness.ObtenerTraducciones();
            this.MdiParent = frmPrincipal;
            Traducir();
        }
    }
}
