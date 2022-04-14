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
    public partial class FrmComprarVandCoins : Form
    {
        public FrmComprarVandCoins()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);

            if (txtNroTarjeta.Text.Length == 4 || txtNroTarjeta.Text.Length == 9 || txtNroTarjeta.Text.Length == 14)
            {
                txtNroTarjeta.Text = txtNroTarjeta.Text + " ";
            }

            if(txtNroTarjeta.Text.Length > 19)
            {
                txtNroTarjeta.Text = txtNroTarjeta.Text.Remove(txtNroTarjeta.Text.Length - 1, 1);
            }
            txtNroTarjeta.SelectionStart = txtNroTarjeta.Text.Length;
        }

        private void txtFechaHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);

            if (txtFechaHasta.Text.Length == 2)
            {
                txtFechaHasta.Text = txtFechaHasta.Text + "/";
            }
            if (txtFechaHasta.Text.Length > 4)
            {
                txtFechaHasta.Text = txtFechaHasta.Text.Remove(txtFechaHasta.Text.Length - 1, 1);
            }
            txtFechaHasta.SelectionStart = txtFechaHasta.Text.Length;
        }

        private void btnComprarVand_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int val = rnd.Next(1, 3);
            if(val == 1)
            {
                MessageBox.Show("Hubo un error, pruebe más tarde");
            }
            else
            {

            }
        }

        private void FrmComprarVandCoins_Load(object sender, EventArgs e)
        {
            txtValorRef.Text = "10";
            txtPesosAGastar.Text = "0 pesos";
            txtVandCoinAComprar.Text = "0";
        }

        private void ndCantVandCoins_ValueChanged(object sender, EventArgs e)
        {
            txtPesosAGastar.Text = (ndCantVandCoins.Value * int.Parse(txtValorRef.Text)).ToString() + " pesos";
            txtVandCoinAComprar.Text = ndCantVandCoins.Value.ToString();
        }
    }
}
