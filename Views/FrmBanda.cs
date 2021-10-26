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
    public partial class FrmBanda : Form
    {
        public FrmBanda()
        {
            InitializeComponent();
        }

        private void FrmBanda_Load(object sender, EventArgs e)
        {
            lstBanda.DataSource = new List<IBanda>();
            lstBanda.DisplayMember = "Nombre";
        }
    }
}
