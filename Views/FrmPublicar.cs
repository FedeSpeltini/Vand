using Abstractions;
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
    public partial class FrmPublicar : Form, IIdiomaObserver
    {
        public FrmPublicar()
        {
            InitializeComponent();
        }
        internal FrmPrincipal frmPrincipal;
        private void FrmPublicar_Load(object sender, EventArgs e)
        {
            lstBands.Items.AddRange(BandaBusiness.GetBands().ToArray());
            //lstBands.DisplayMember = nameof(copia.Nombre);
            lstBands.DisplayMember = "Nombre";


        }

        private void chkNewBand_CheckedChanged(object sender, EventArgs e)
        {
            lstAlbums.Enabled = !lstAlbums.Enabled;
            lstBands.Enabled = !lstBands.Enabled;

            lblAlbumUrl.Visible = !lblAlbumUrl.Visible;
            lblBandUrl.Visible = !lblBandUrl.Visible;
            lblNewAlbum.Visible = !lblNewAlbum.Visible;
            lblNewBand.Visible = !lblNewBand.Visible;
        }

        private void chkNewAlbum_CheckedChanged(object sender, EventArgs e)
        {
            lstAlbums.Enabled = !lstAlbums.Enabled;

            lblNewAlbum.Visible = !lblNewAlbum.Visible;
            lblAlbumUrl.Visible = !lblAlbumUrl.Visible;
        }

        private void cbBands_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbBands.SelectedItem.Equals
            //cbBands.Items.AddRange(DiscoBusiness.GetAlbums( ).ToArray());
        }

        private void lstBands_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAlbums.Items.Clear();
            lstAlbums.Items.AddRange(DiscoBusiness.GetAlbums((Banda)lstBands.SelectedItem).ToArray());
            lstAlbums.DisplayMember = "Nombre";
        }

        public void UpdateLanguage(IIdioma idioma)
        {
            throw new NotImplementedException();
        }
    }
}
