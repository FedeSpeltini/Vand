﻿using BE;
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
    public partial class FrmDisco : Form
    {
        internal CopiaEntity Copia = new CopiaEntity();
        internal FrmPrincipal frmPrincipal = new FrmPrincipal();
        public FrmDisco()
        {
            InitializeComponent();
        }

        private void FrmDisco_Load(object sender, EventArgs e)
        {
            lblNombreBanda.Text = Copia.Banda;
            lblNombreDisco.Text = Copia.Nombre;
            lblYear.Text = Copia.Year.ToString();
            lblPrecio.Text = Copia.Precio.ToString();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            UsuarioClienteBusiness user = new UsuarioClienteBusiness();
            //frmPrincipal.Usuario

            user.Comprar(Copia, (UsuarioClienteEntity)frmPrincipal.Usuario);
        }
    }
}