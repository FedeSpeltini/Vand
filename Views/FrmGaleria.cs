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
    public partial class FrmGaleria : Form
    {
        internal IDictionary<string, TraduccionEntity> Traducciones;

        internal FrmPrincipal frmPrincipal = new FrmPrincipal();
        public FrmGaleria()
        {
            InitializeComponent();
        }


        CopiaBusiness copiaBc = new CopiaBusiness();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmDisco frmDisco = new FrmDisco();
            frmDisco.MdiParent = frmPrincipal;
            frmDisco.Copia = (CopiaEntity)lstDiscos.SelectedItem;
            frmDisco.frmPrincipal = frmPrincipal;
            frmDisco.Show();
            this.Close();

        }


        public void CargarDatos()
        {
            foreach(CopiaEntity copia in copiaBc.ObtenerDiscos())
            {
                lstDiscos.Items.Add(copia);
            }
        }

        private void FrmGaleria_Load(object sender, EventArgs e)
        {
            CargarDatos();

        }


        private void Traducir(Idioma idioma = null)
        {
            var traducciones = Traductor.ObtenerTraducciones(idioma);

            //if (this.Tag != null && traducciones.ContainsKey(this.Tag.ToString()))
            //    this.Text = traducciones[this.Tag.ToString()].Texto;

            if (btnIngresar.Tag != null && traducciones.ContainsKey(btnIngresar.Tag.ToString()))
                btnIngresar.Text = traducciones[btnIngresar.Tag.ToString()].Texto;

        }
        public void UpdateLanguage(Idioma idioma)
        {
            Traducir(idioma);
        }
    }
}
