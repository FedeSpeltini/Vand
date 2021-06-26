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
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UsuarioEntity usuario = new UsuarioEntity();
            usuario.Nombre = txtUser.Text;
            if (rdCliente.Checked)
            {
                UsuarioClienteBusiness cliente = new UsuarioClienteBusiness();
                usuario.Password = cliente.Encriptar(txtPwd.Text);
                cliente.CrearUsuario(usuario);
            }
            else
            {
                UsuarioComercialBusiness empresa = new UsuarioComercialBusiness();
                usuario.Password = empresa.Encriptar(txtPwd.Text);
                empresa.CrearUsuario(usuario);
            }
        }
    }
}
