using Abstractions;
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
    public partial class FrmMisCompras : Form
    {
        public FrmMisCompras()
        {
            InitializeComponent();
        }

        private void FrmMisCompras_Load(object sender, EventArgs e)
        {
            int auxX = 0;
            int auxY = 0;
            int breakLine = 0;
            List<ICopia> copias = UsuarioBusiness.ListarCompras(SessionState.RetornarUsuario());
            foreach (ICopia copia in copias)
            {
                if(breakLine == 2)
                {
                    breakLine = 0;
                    auxX = 0;
                    auxY += 300;
                    
                }
                UcVistaDisco uc = new UcVistaDisco();
                uc.CargarDatos(copia);

                uc.Location = new Point(5 + auxX, 5 + auxY);
                //uc.Size = new System.Drawing.Size(300, 300);
                this.Controls.Add(uc);

                auxX += 300;
                breakLine++;
            }
        }
    }
}
