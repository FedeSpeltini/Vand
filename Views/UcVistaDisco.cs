using Abstractions;
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
    public partial class UcVistaDisco : UserControl
    {
        public UcVistaDisco()
        {
            InitializeComponent();
        }
        

        private void UcVistaDisco_Load(object sender, EventArgs e)
        {

        }

        public void CargarDatosCopia(ICopia copia)
        {
            pbPortada.Load(copia.UrlPortada);
            lbl2.Text = copia.Banda.Nombre;
            lbl1.Text = copia.Nombre;
            lbl3.Text = copia.Year.ToString();
            lbl4.Text = $"{copia.Precio.ToString()} VandCoins";
        }

        public void CargarDatosBanda(ICopia copia)
        {
            pbPortada.Load(copia.UrlPortada);
            lbl2.Text = copia.Banda.Nombre;
            lbl1.Text = copia.Nombre;
            lbl3.Text = copia.Year.ToString();
            lbl4.Text = $"{copia.Precio.ToString()} VandCoins";
        }

        public void Mostrar()
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        }
    }
}
