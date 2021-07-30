using BE;
using BLL;
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
    public partial class FrmTraducciones : Form
    {
        public FrmTraducciones()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            IdiomaEntity idioma = new IdiomaEntity();
            idioma.Nombre = txtIdioma.Text;
            IdiomaBusiness.CrearIdioma(idioma);
            CargarIdiomas();
        }

        private void FrmTraducciones_Load(object sender, EventArgs e)
        {
            CargarIdiomas();

            btnModificarEtiqueta.Enabled = false;
            btnModificarTraduccion.Enabled = false;
            btnAgregarEtiqueta.Enabled = false;
            btnAgregarTraduccion.Enabled = false;
        }

        public void CargarIdiomas()
        {
            lstIdioma.DataSource = null;
            lstIdioma.DataSource = TraduccionBusiness.ObtenerIdiomas();
            lstIdioma.DisplayMember = "Nombre";
        }

        public void CargarGrillas()
        {

            dtEtiquetas.DataSource = null;
            dtEtiquetas.DataSource = EtiquetaBusiness.ObtenerEtiquetas();

            dtTraducciones.Rows.Clear();
            if((IdiomaEntity)lstIdioma.SelectedItem != null)
            {
                foreach (TraduccionEntity traduccion in TraduccionBusiness.ListarTraducciones((IdiomaEntity)lstIdioma.SelectedItem))
                {
                    dtTraducciones.Rows.Add(traduccion.Etiqueta.Nombre, traduccion.Texto);
                }
            }



        }

        private void lstIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrillas();
        }

        private void rdAgregar_CheckedChanged(object sender, EventArgs e)
        {
            txtEtiqueta.Text = "";
            txtTraduccion.Text = "";
            btnModificarEtiqueta.Enabled = false;
            btnModificarTraduccion.Enabled = false;
            btnAgregarEtiqueta.Enabled = true;
            btnAgregarTraduccion.Enabled = true;

            dtEtiquetas.Enabled = false;
            dtTraducciones.Enabled = false;
        }

        private void rdModificar_CheckedChanged(object sender, EventArgs e)
        {
            btnAgregarEtiqueta.Enabled = false;
            btnAgregarTraduccion.Enabled = false;

            btnModificarEtiqueta.Enabled = true;
            btnModificarTraduccion.Enabled = true;

            dtEtiquetas.Enabled = true;
            dtTraducciones.Enabled = true;
        }

        private void btnAgregarEtiqueta_Click(object sender, EventArgs e)
        {
            EtiquetaEntity etiqueta = new EtiquetaEntity();
            etiqueta.Nombre = txtEtiqueta.Text;
            EtiquetaBusiness.AgregarEtiqueta(etiqueta);
        }
    }
}
