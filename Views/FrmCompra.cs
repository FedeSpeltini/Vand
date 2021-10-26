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
    public partial class FrmCompra : Form
    {
        public FrmCompra()
        {
            InitializeComponent();
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {

                //CopiaEntity copia = new CopiaEntity();
                //CompraBusiness compraBs = new CompraBusiness();
                //compraBs.CompraRealizada += c_ThresholdReached;
               // compraBs.CompraRealizada += new EventHandler((sender, e) => PlayMusicEvent(sender, e, copia));
                // provide remaining implementation for the class
            
        }
        static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
        }

    }
}
