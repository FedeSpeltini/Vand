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
    public partial class FrmLogistica : Form
    {
        public FrmLogistica()
        {
            InitializeComponent();
        }

        private void FrmLogistica_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        EnvioBusiness envioBc = new EnvioBusiness();
        public void CargarDatos()
        {
            foreach (EnvioEntity copia in envioBc.Listar())
            {
                lstEnvios.Items.Add(copia);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            envioBc.Despachar((EnvioEntity)lstEnvios.SelectedItem);
        }
    }
}
