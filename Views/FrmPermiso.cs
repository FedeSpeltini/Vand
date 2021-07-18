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
    public partial class FrmPermiso : Form
    {
        public FrmPermiso()
        {
            InitializeComponent();
        }

        private void FrmPermiso_Load(object sender, EventArgs e)
        {
            foreach(PermisoEntity permiso in PermisoBusiness.ListarPermisosPadre())
            {
                lstPadre.DisplayMember = nameof(permiso.Descripcion);
                lstPadre.ValueMember = nameof(permiso);
                lstPadre.Items.Add(permiso);
            }

            foreach (PermisoEntity permiso in PermisoBusiness.ListarSubPermisos())
            {
                lstSubPermisos.DisplayMember = nameof(permiso.Descripcion);
                lstSubPermisos.ValueMember = nameof(permiso);
                lstSubPermisos.Items.Add(permiso);
            }
        }

        private void lstPadre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTablaHijo();
        }

        public void ActualizarTablaHijo()
        {
            lstHijo.Items.Clear();
            foreach (PermisoEntity permiso in PermisoBusiness.ListarPermisosHijo((PermisoEntity)lstPadre.SelectedItem))
            {
                lstHijo.DisplayMember = nameof(permiso.Descripcion);
                lstHijo.ValueMember = nameof(permiso);
                lstHijo.Items.Add(permiso);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PermisoBusiness.AgregarHijo((PermisoEntity)lstPadre.SelectedItem, (PermisoEntity)lstSubPermisos.SelectedItem);
            ActualizarTablaHijo();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            PermisoBusiness.SacarHijo((PermisoEntity)lstPadre.SelectedItem, (PermisoEntity)lstHijo.SelectedItem);
            ActualizarTablaHijo();
        }
    }
}
