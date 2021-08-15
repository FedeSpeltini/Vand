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

        public void CargarDatos(ICopia copia)
        {
            pbPortada.Load(copia.UrlPortada);
            lblBanda.Text = copia.Banda;
            lblDisco.Text = copia.Nombre;
            lblYear.Text = copia.Year.ToString();
            lblPrecio.Text = $"{copia.Precio.ToString()} VandCoins";
        }
    }
}
