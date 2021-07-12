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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        UsuarioBusiness ub = new UsuarioBusiness();

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int idiomaAux = 1;
            if (rdEnglish.Checked)
            {
                idiomaAux = 2;
            }
            if (rdSpanish.Checked)
            {
                idiomaAux = 1;
            }
            if (rdEnglish.Checked || rdSpanish.Checked)
            {
                UsuarioEntity u = new UsuarioEntity();
                u.Nombre = txtUserName.Text;
                u.Password = ub.Encriptar(txtPwd.Text);

                var usuarioLogueado = UsuarioBusiness.Login(u);

                var traducciones = TraduccionBusiness.ObtenerTraducciones(idiomaAux);

                

                
                //ub.ValidarUsuario(u);

                //if (btnLogin.Tag != null && traducciones.ContainsKey(btnLogin.Tag.ToString()))
                //    btnLogin.Text = traducciones[btnLogin.Tag.ToString()].Texto;


                //FrmPrincipal frmPrincipal = new FrmPrincipal();
                //FrmTablero frmTablero = new FrmTablero();
                // FrmGaleria frmGaleria = new FrmGaleria();




                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Traducciones = traducciones;
                frmPrincipal.Usuario = usuarioLogueado;
                frmPrincipal.Show();
                //this.Close();
            }
            else
            {

            }

        }
    }
}
