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
    public partial class FrmTraducciones : Form, IIdiomaObserver
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
            btnBorrarIdioma.Enabled = false;
        }

        private void FrmTraducciones_Load(object sender, EventArgs e)
        {
            CargarIdiomas();

            btnModificarEtiqueta.Enabled = false;
            btnModificarTraduccion.Enabled = false;
            btnAgregarEtiqueta.Enabled = false;
            btnAgregarTraduccion.Enabled = false;
            btnBorrarIdioma.Enabled = false;
            Traducir();
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
            btnBorrarIdioma.Enabled = true;
        }

        private void rdAgregar_CheckedChanged(object sender, EventArgs e)
        {
            txtEtiqueta.Text = "";
            txtTraduccion.Text = "";
            btnModificarEtiqueta.Enabled = false;
            btnModificarTraduccion.Enabled = false;
            btnAgregarEtiqueta.Enabled = true;
            btnAgregarTraduccion.Enabled = true;

            btnSacarEtiqueta.Enabled = false;
            btnSacarTraduccion.Enabled = false;

            txtEtiqueta.Enabled = true;
            txtTraduccion.Enabled = true;

            //dtEtiquetas.Enabled = false;
            // dtTraducciones.Enabled = false;
        }

        private void rdModificar_CheckedChanged(object sender, EventArgs e)
        {
            btnAgregarEtiqueta.Enabled = false;
            btnAgregarTraduccion.Enabled = false;

            btnModificarEtiqueta.Enabled = true;
            btnModificarTraduccion.Enabled = true;

            btnSacarEtiqueta.Enabled = false;
            btnSacarTraduccion.Enabled = false;

            txtEtiqueta.Enabled = true;
            txtTraduccion.Enabled = true;

            //dtEtiquetas.Enabled = true;
            //dtTraducciones.Enabled = true;
        }

        private void rdElminar_CheckedChanged(object sender, EventArgs e)
        {

            txtEtiqueta.Enabled = false;
            txtTraduccion.Enabled = false;


            btnAgregarEtiqueta.Enabled = false;
            btnAgregarTraduccion.Enabled = false;

            btnModificarEtiqueta.Enabled = false;
            btnModificarTraduccion.Enabled = false;

            btnSacarEtiqueta.Enabled = true;
            btnSacarTraduccion.Enabled = true;
        }

        private void btnAgregarEtiqueta_Click(object sender, EventArgs e)
        {

            try
            {
                EtiquetaEntity etiqueta = new EtiquetaEntity();
                etiqueta.Nombre = txtEtiqueta.Text;
                EtiquetaBusiness.AgregarEtiqueta(etiqueta);
                CargarGrillas();
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrió un error al agregar la etiqueta");
            }

        }

        private void btnBorrarIdioma_Click(object sender, EventArgs e)
        {
            if(((IdiomaEntity)lstIdioma.SelectedItem).Nombre != "english" && ((IdiomaEntity)lstIdioma.SelectedItem).Nombre != "spanish")
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea borrar este idioma? Se borraran todas las traducciones del mismo", "Compra", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (dialogResult == DialogResult.Yes)
                        IdiomaBusiness.BorrarIdioma((IdiomaEntity)lstIdioma.SelectedItem);
                    CargarIdiomas();
                }
                else
                {
                    MessageBox.Show("No se borró el idioma", "Cancelada");
                }
            }
            else
            {
                MessageBox.Show("Esta prohibido borrar el inglés y es español", "Cancelada");
            }


        }

        private void btnModificarEtiqueta_Click(object sender, EventArgs e)
        {
            try
            {
                EtiquetaEntity etiqueta = new EtiquetaEntity();
                etiqueta.Nombre = dtEtiquetas.SelectedCells[1].FormattedValue.ToString();
                EtiquetaBusiness.ModificarEtiqueta(etiqueta, txtEtiqueta.Text);
                CargarGrillas(); 
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un problema al modificar la etiqueta", "Modificar");
            }


        }

        private void btnModificarTraduccion_Click(object sender, EventArgs e)
        {
            try
            {
                TraduccionEntity traduccion = new TraduccionEntity();
                traduccion.Texto = dtTraducciones.SelectedCells[1].FormattedValue.ToString();
                TraduccionBusiness.ModificarTraduccion(traduccion, txtTraduccion.Text);
                CargarGrillas();
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un problema al modificar la traducción", "Modificar");
            }

        }

        private void btnAgregarTraduccion_Click(object sender, EventArgs e)
        {
            try
            {
                EtiquetaEntity etiqueta = new EtiquetaEntity();
                etiqueta.Nombre = dtEtiquetas.SelectedCells[1].FormattedValue.ToString();
                TraduccionEntity traduccion = new TraduccionEntity();
                traduccion.Texto = txtTraduccion.Text;

                TraduccionBusiness.AgregarTraduccion((IdiomaEntity)lstIdioma.SelectedItem, etiqueta, traduccion);
                CargarGrillas();
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un problema al agregar la traducción", "Agergar");
            }


            //TraduccionBusiness.Multiplicar(1, 2);
            
        }

        private void dtEtiquetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!rdAgregar.Checked)
                {
                    //txtEtiqueta.Text = dtEtiquetas.SelectedCells[1].FormattedValue.ToString();
                    txtEtiqueta.Text = dtEtiquetas.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor seleccione el contenido dentro de la tabla", "Información");
            }

        }





        private void dtTraducciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!rdAgregar.Checked)
                {
                    txtTraduccion.Text = dtTraducciones.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor seleccione el contenido dentro de la tabla", "Información");
            }

        }

        private void btnSacarEtiqueta_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(dtEtiquetas.SelectedRows[0].Cells[0].FormattedValue.ToString()) > 19)
                {

                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea borrar esta etiqueta? Se borraran todas las traducciones de la misma", "Compra", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        EtiquetaEntity etiqueta = new EtiquetaEntity();
                        etiqueta.Nombre = txtEtiqueta.Text;
                        EtiquetaBusiness.EliminarEtiqueta(etiqueta);
                        CargarGrillas();
                    }
                    else
                    {
                        MessageBox.Show("No se borró la etiqueta", "Cancelada");
                    }


                }
                else
                {
                    MessageBox.Show("Esta etiqueta no debe ser borrada", "Cancelada");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un problema al borrar la etiqueta", "Eliminar");
            }
        }



        private void btnSacarTraduccion_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea borrar esta traducción?", "Compra", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TraduccionEntity t = new TraduccionEntity();
                    t.Texto = txtTraduccion.Text;
                    TraduccionBusiness.EliminarTraduccion(t);
                    CargarGrillas();
                }
                else
                {
                    MessageBox.Show("No se borró la traducción", "Cancelada");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un problema al borrar la traducció", "Eliminar");
            }
        }

        public void UpdateLanguage(IdiomaEntity idioma)
        {
            Traducir();
        }

        private void Traducir()
        {
            IdiomaEntity idioma = null;
            if (ManejadorDeSesion.IsLogged())
                idioma = ManejadorDeSesion.Session.Idioma;


            var traducciones = TraduccionBusiness.ObtenerTraducciones(idioma);
            if (btnAgregar.Tag != null && traducciones.ContainsKey(btnAgregar.Tag.ToString()))
                btnAgregar.Text = traducciones[btnAgregar.Tag.ToString()].Texto;

            if (btnAgregarEtiqueta.Tag != null && traducciones.ContainsKey(btnAgregarEtiqueta.Tag.ToString()))
                btnAgregarEtiqueta.Text = traducciones[btnAgregarEtiqueta.Tag.ToString()].Texto;

            if (btnAgregarTraduccion.Tag != null && traducciones.ContainsKey(btnAgregarTraduccion.Tag.ToString()))
                btnAgregarTraduccion.Text = traducciones[btnAgregarTraduccion.Tag.ToString()].Texto;

            if (btnBorrarIdioma.Tag != null && traducciones.ContainsKey(btnBorrarIdioma.Tag.ToString()))
                btnBorrarIdioma.Text = traducciones[btnBorrarIdioma.Tag.ToString()].Texto;

            if (btnModificarEtiqueta.Tag != null && traducciones.ContainsKey(btnModificarEtiqueta.Tag.ToString()))
                btnModificarEtiqueta.Text = traducciones[btnModificarEtiqueta.Tag.ToString()].Texto;

            if (btnModificarTraduccion.Tag != null && traducciones.ContainsKey(btnModificarTraduccion.Tag.ToString()))
                btnModificarTraduccion.Text = traducciones[btnModificarTraduccion.Tag.ToString()].Texto;

            if (btnSacarEtiqueta.Tag != null && traducciones.ContainsKey(btnSacarEtiqueta.Tag.ToString()))
                btnSacarEtiqueta.Text = traducciones[btnSacarEtiqueta.Tag.ToString()].Texto;

            if (btnSacarTraduccion.Tag != null && traducciones.ContainsKey(btnSacarTraduccion.Tag.ToString()))
                btnSacarTraduccion.Text = traducciones[btnSacarTraduccion.Tag.ToString()].Texto;

            if (rdAgregar.Tag != null && traducciones.ContainsKey(rdAgregar.Tag.ToString()))
                rdAgregar.Text = traducciones[rdAgregar.Tag.ToString()].Texto;

            if (rdElminar.Tag != null && traducciones.ContainsKey(rdElminar.Tag.ToString()))
                rdElminar.Text = traducciones[rdElminar.Tag.ToString()].Texto;

            if (rdModificar.Tag != null && traducciones.ContainsKey(rdModificar.Tag.ToString()))
                rdModificar.Text = traducciones[rdModificar.Tag.ToString()].Texto;







            if (this.Tag != null && traducciones.ContainsKey(this.Tag.ToString()))
                this.Text = traducciones[this.Tag.ToString()].Texto;

        }
    }
}
