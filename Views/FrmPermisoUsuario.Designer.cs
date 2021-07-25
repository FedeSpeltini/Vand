
namespace Views
{
    partial class FrmPermisoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBoxAutorizaciones = new System.Windows.Forms.GroupBox();
            this.DescripcionLbl_ = new System.Windows.Forms.Label();
            this.DescripcionLbl = new System.Windows.Forms.Label();
            this.PermisosLbl = new System.Windows.Forms.Label();
            this.lstPermiso = new System.Windows.Forms.ListBox();
            this.RolesLbl = new System.Windows.Forms.Label();
            this.lstGrupos = new System.Windows.Forms.ListBox();
            this.AutsUsuarioLbl = new System.Windows.Forms.Label();
            this.trAutorizaciones = new System.Windows.Forms.TreeView();
            this.lstUsuario = new System.Windows.Forms.ListBox();
            this.UsuariosLbl = new System.Windows.Forms.Label();
            this.groupBoxAutorizaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(458, 244);
            this.btnSacar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(115, 36);
            this.btnSacar.TabIndex = 13;
            this.btnSacar.Tag = "19";
            this.btnSacar.Text = "Quitar";
            this.btnSacar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(458, 99);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 36);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Tag = "18";
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // groupBoxAutorizaciones
            // 
            this.groupBoxAutorizaciones.Controls.Add(this.DescripcionLbl_);
            this.groupBoxAutorizaciones.Controls.Add(this.DescripcionLbl);
            this.groupBoxAutorizaciones.Controls.Add(this.PermisosLbl);
            this.groupBoxAutorizaciones.Controls.Add(this.lstPermiso);
            this.groupBoxAutorizaciones.Controls.Add(this.RolesLbl);
            this.groupBoxAutorizaciones.Controls.Add(this.lstGrupos);
            this.groupBoxAutorizaciones.Location = new System.Drawing.Point(601, 46);
            this.groupBoxAutorizaciones.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAutorizaciones.Name = "groupBoxAutorizaciones";
            this.groupBoxAutorizaciones.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAutorizaciones.Size = new System.Drawing.Size(427, 331);
            this.groupBoxAutorizaciones.TabIndex = 11;
            this.groupBoxAutorizaciones.TabStop = false;
            this.groupBoxAutorizaciones.Tag = "37";
            this.groupBoxAutorizaciones.Text = "Autorizaciones";
            // 
            // DescripcionLbl_
            // 
            this.DescripcionLbl_.AutoSize = true;
            this.DescripcionLbl_.Location = new System.Drawing.Point(23, 290);
            this.DescripcionLbl_.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescripcionLbl_.Name = "DescripcionLbl_";
            this.DescripcionLbl_.Size = new System.Drawing.Size(0, 17);
            this.DescripcionLbl_.TabIndex = 5;
            // 
            // DescripcionLbl
            // 
            this.DescripcionLbl.AutoSize = true;
            this.DescripcionLbl.Location = new System.Drawing.Point(19, 251);
            this.DescripcionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescripcionLbl.Name = "DescripcionLbl";
            this.DescripcionLbl.Size = new System.Drawing.Size(82, 17);
            this.DescripcionLbl.TabIndex = 4;
            this.DescripcionLbl.Tag = "39";
            this.DescripcionLbl.Text = "Descripcion";
            // 
            // PermisosLbl
            // 
            this.PermisosLbl.AutoSize = true;
            this.PermisosLbl.Location = new System.Drawing.Point(231, 21);
            this.PermisosLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PermisosLbl.Name = "PermisosLbl";
            this.PermisosLbl.Size = new System.Drawing.Size(66, 17);
            this.PermisosLbl.TabIndex = 3;
            this.PermisosLbl.Tag = "34";
            this.PermisosLbl.Text = "Permisos";
            // 
            // lstPermiso
            // 
            this.lstPermiso.FormattingEnabled = true;
            this.lstPermiso.ItemHeight = 16;
            this.lstPermiso.Location = new System.Drawing.Point(231, 53);
            this.lstPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.lstPermiso.Name = "lstPermiso";
            this.lstPermiso.Size = new System.Drawing.Size(187, 180);
            this.lstPermiso.TabIndex = 2;
            this.lstPermiso.Tag = "0";
            // 
            // RolesLbl
            // 
            this.RolesLbl.AutoSize = true;
            this.RolesLbl.Location = new System.Drawing.Point(19, 22);
            this.RolesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RolesLbl.Name = "RolesLbl";
            this.RolesLbl.Size = new System.Drawing.Size(44, 17);
            this.RolesLbl.TabIndex = 1;
            this.RolesLbl.Tag = "38";
            this.RolesLbl.Text = "Roles";
            // 
            // lstGrupos
            // 
            this.lstGrupos.FormattingEnabled = true;
            this.lstGrupos.ItemHeight = 16;
            this.lstGrupos.Location = new System.Drawing.Point(23, 53);
            this.lstGrupos.Margin = new System.Windows.Forms.Padding(4);
            this.lstGrupos.Name = "lstGrupos";
            this.lstGrupos.Size = new System.Drawing.Size(187, 180);
            this.lstGrupos.TabIndex = 0;
            this.lstGrupos.Tag = "0";
            // 
            // AutsUsuarioLbl
            // 
            this.AutsUsuarioLbl.AutoSize = true;
            this.AutsUsuarioLbl.Location = new System.Drawing.Point(201, 31);
            this.AutsUsuarioLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AutsUsuarioLbl.Name = "AutsUsuarioLbl";
            this.AutsUsuarioLbl.Size = new System.Drawing.Size(177, 17);
            this.AutsUsuarioLbl.TabIndex = 10;
            this.AutsUsuarioLbl.Tag = "36";
            this.AutsUsuarioLbl.Text = "Autorizaciones del Usuario";
            // 
            // trAutorizaciones
            // 
            this.trAutorizaciones.Location = new System.Drawing.Point(205, 68);
            this.trAutorizaciones.Margin = new System.Windows.Forms.Padding(4);
            this.trAutorizaciones.Name = "trAutorizaciones";
            this.trAutorizaciones.Size = new System.Drawing.Size(229, 308);
            this.trAutorizaciones.TabIndex = 9;
            this.trAutorizaciones.Tag = "0";
            // 
            // lstUsuario
            // 
            this.lstUsuario.FormattingEnabled = true;
            this.lstUsuario.ItemHeight = 16;
            this.lstUsuario.Location = new System.Drawing.Point(13, 68);
            this.lstUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.lstUsuario.Name = "lstUsuario";
            this.lstUsuario.Size = new System.Drawing.Size(171, 308);
            this.lstUsuario.TabIndex = 8;
            this.lstUsuario.Tag = "0";
            this.lstUsuario.SelectedIndexChanged += new System.EventHandler(this.lstUsuario_SelectedIndexChanged);
            // 
            // UsuariosLbl
            // 
            this.UsuariosLbl.AutoSize = true;
            this.UsuariosLbl.Location = new System.Drawing.Point(9, 31);
            this.UsuariosLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsuariosLbl.Name = "UsuariosLbl";
            this.UsuariosLbl.Size = new System.Drawing.Size(64, 17);
            this.UsuariosLbl.TabIndex = 7;
            this.UsuariosLbl.Tag = "35";
            this.UsuariosLbl.Text = "Usuarios";
            // 
            // FrmPermisoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 468);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBoxAutorizaciones);
            this.Controls.Add(this.AutsUsuarioLbl);
            this.Controls.Add(this.trAutorizaciones);
            this.Controls.Add(this.lstUsuario);
            this.Controls.Add(this.UsuariosLbl);
            this.Name = "FrmPermisoUsuario";
            this.Text = "FrmPermisoUsuario";
            this.Load += new System.EventHandler(this.FrmPermisoUsuario_Load);
            this.groupBoxAutorizaciones.ResumeLayout(false);
            this.groupBoxAutorizaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBoxAutorizaciones;
        private System.Windows.Forms.Label DescripcionLbl_;
        private System.Windows.Forms.Label DescripcionLbl;
        private System.Windows.Forms.Label PermisosLbl;
        private System.Windows.Forms.ListBox lstPermiso;
        private System.Windows.Forms.Label RolesLbl;
        private System.Windows.Forms.ListBox lstGrupos;
        private System.Windows.Forms.Label AutsUsuarioLbl;
        private System.Windows.Forms.TreeView trAutorizaciones;
        private System.Windows.Forms.ListBox lstUsuario;
        private System.Windows.Forms.Label UsuariosLbl;
    }
}