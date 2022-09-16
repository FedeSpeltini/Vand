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
    public partial class FrmDigitosVerificadores : Form
    {
        public FrmDigitosVerificadores()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (DigitosVerificadores.GrabarDVHFull() == true)
            {
                MessageBox.Show("se generaron los DV");
            }
            else
            {
                MessageBox.Show("no se genero nada");
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (DigitosVerificadores.ValidarBBDD() == false)
            {
                textBox1.Text = DigitosVerificadores.RegistrosCorruptos();

            }
            else
            {
                MessageBox.Show("No hay registros corruptos");
            }
        }
    }
}
