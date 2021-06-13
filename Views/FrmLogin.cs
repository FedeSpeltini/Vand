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

            UsuarioEntity u = new UsuarioEntity();
            u.Nombre = txtUserName.Text;
            u.Password = ub.Encriptar(txtPwd.Text);

            ub.ValidarUsuario(u);
        }
    }
}
