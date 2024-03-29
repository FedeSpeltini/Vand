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
    public partial class FrmPermiso : Form
    {
        public FrmPermiso()
        {
            InitializeComponent();
        }

        private void FrmPermiso_Load(object sender, EventArgs e)
        {
            CargarGrillas();
        }


        public void CargarGrillas()
        {
            dtGrupos.DataSource = null;
            dtGrupos.DataSource = PermisoBusiness.ListarPermisosPadre();

            dtPermisos.DataSource = null;
            dtPermisos.DataSource = PermisoBusiness.ListarSubPermisos();
        }

        private void dtGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreGrupo.Text = dtGrupos.CurrentRow.Cells["Descripcion"].Value.ToString();
        }

        private void btnSacarGrupo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(rdGrupo.Checked)
            {
                PermisoBusiness.CrearPermisoPadre(txtAgregar.Text);
                CargarGrillas();
            }
            if(rdPermiso.Checked)
            {
                PermisoBusiness.CrearPermisoHijo(txtAgregar.Text);
                CargarGrillas();
            }

        }

        private void btnModificarGrupo_Click(object sender, EventArgs e)
        {

        }

        private void btnSacarPermiso_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarPermiso_Click(object sender, EventArgs e)
        {

        }
    }
}
