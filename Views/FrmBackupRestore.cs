using Abstractions;
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
    public partial class FrmBackupRestore : Form, IIdiomaObserver
    {
        public FrmBackupRestore()
        {
            InitializeComponent();
        }

        public FrmPrincipal formpadre;
        string fileName = null;
        BackupRestore gestorBackupRestore = new BackupRestore();
        private void backupBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\BackupRestoreSADAET\\";
            openFileDialog1.ShowDialog();
            fileName = openFileDialog1.FileName; // capturo el string de directorio + filename
            textBox1.Text = fileName;
        }

        private void backupBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                gestorBackupRestore.Backup();
                MessageBox.Show("**Backup exitoso**");
            }
            catch (Exception ex)
            {
                MessageBox.Show("**Fallo el intento de Backup**" + Environment.NewLine + " Excepción: " + ex.Message);
            }
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                String fileName = openFileDialog1.FileName;
                String extension = System.IO.Path.GetExtension(fileName);
                if (".bak".Equals(extension))
                {
                    try
                    {
                        gestorBackupRestore.Restore(openFileDialog1.FileName);
                        MessageBox.Show("Restore Exitoso, es necesario volver a iniciar sesión.");
                        //formpadre.SalirDelSistema();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("**Fallo el intento de Restauración**" + Environment.NewLine + " Excepción: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("**Seleccione un archivo .BAK**");
                }
            }
        }

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir();
        }


        private void Traducir()
        {
            IIdioma idioma = null;
            if (ManejadorDeSesion.IsLogged())
                idioma = ManejadorDeSesion.Session.Idioma;


            var traducciones = TraduccionBusiness.ObtenerTraducciones(idioma);
            //if (btnIngresar.Tag != null && traducciones.ContainsKey(btnIngresar.Tag.ToString()))
            //    btnIngresar.Text = traducciones[btnIngresar.Tag.ToString()].Texto;

            if (this.Tag != null && traducciones.ContainsKey(this.Tag.ToString()))
                this.Text = traducciones[this.Tag.ToString()].Texto;

        }
    }
}
