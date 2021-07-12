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
        //internal IDictionary<string, TraduccionEntity> Traducciones;

        internal FrmPrincipal frmPrincipal;
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
            foreach(CopiaEntity copia in copiaBc.ObtenerDiscos(frmPrincipal.Usuario))
            {
                lstDiscos.Items.Add(copia);
            }
        }

        private void FrmGaleria_Load(object sender, EventArgs e)
        {
            Traducir();
            CargarDatos();

        }


        private void Traducir()
        {
            if (btnIngresar.Tag != null && frmPrincipal.Traducciones.ContainsKey(btnIngresar.Tag.ToString()))
                btnIngresar.Text = frmPrincipal.Traducciones[btnIngresar.Tag.ToString()].Texto;

        }

    }
}
