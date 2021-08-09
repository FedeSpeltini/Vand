
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
            this.lblRolPermission = new System.Windows.Forms.Label();
            this.lstSubPermiso = new System.Windows.Forms.ListBox();
            this.DescripcionLbl_ = new System.Windows.Forms.Label();
            this.PermisosLbl = new System.Windows.Forms.Label();
            this.lstPermiso = new System.Windows.Forms.ListBox();
            this.RolesLbl = new System.Windows.Forms.Label();
            this.lstGrupos = new System.Windows.Forms.ListBox();
            this.AutsUsuarioLbl = new System.Windows.Forms.Label();
            this.trAutorizaciones = new System.Windows.Forms.TreeView();
            this.lstUsuario = new System.Windows.Forms.ListBox();
            this.UsuariosLbl = new System.Windows.Forms.Label();
            this.txtObjeto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdPermiso = new System.Windows.Forms.RadioButton();
            this.rdGrupo = new System.Windows.Forms.RadioButton();
            this.btnAgregarObjeto = new System.Windows.Forms.Button();
            this.groupBoxAutorizaciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(218, 258);
            this.btnSacar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(115, 36);
            this.btnSacar.TabIndex = 13;
            this.btnSacar.Tag = "Remove";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(95, 258);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 36);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Tag = "Add";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBoxAutorizaciones
            // 
            this.groupBoxAutorizaciones.Controls.Add(this.btnAgregar);
            this.groupBoxAutorizaciones.Controls.Add(this.btnSacar);
            this.groupBoxAutorizaciones.Controls.Add(this.lblRolPermission);
            this.groupBoxAutorizaciones.Controls.Add(this.lstSubPermiso);
            this.groupBoxAutorizaciones.Controls.Add(this.DescripcionLbl_);
            this.groupBoxAutorizaciones.Controls.Add(this.PermisosLbl);
            this.groupBoxAutorizaciones.Controls.Add(this.lstPermiso);
            this.groupBoxAutorizaciones.Controls.Add(this.RolesLbl);
            this.groupBoxAutorizaciones.Controls.Add(this.lstGrupos);
            this.groupBoxAutorizaciones.Location = new System.Drawing.Point(461, 46);
            this.groupBoxAutorizaciones.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAutorizaciones.Name = "groupBoxAutorizaciones";
            this.groupBoxAutorizaciones.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAutorizaciones.Size = new System.Drawing.Size(430, 507);
            this.groupBoxAutorizaciones.TabIndex = 11;
            this.groupBoxAutorizaciones.TabStop = false;
            this.groupBoxAutorizaciones.Tag = "37";
            this.groupBoxAutorizaciones.Text = "Autorizaciones";
            // 
            // lblRolPermission
            // 
            this.lblRolPermission.AutoSize = true;
            this.lblRolPermission.Location = new System.Drawing.Point(40, 331);
            this.lblRolPermission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRolPermission.Name = "lblRolPermission";
            this.lblRolPermission.Size = new System.Drawing.Size(0, 17);
            this.lblRolPermission.TabIndex = 7;
            this.lblRolPermission.Tag = "RolPermission";
            // 
            // lstSubPermiso
            // 
            this.lstSubPermiso.FormattingEnabled = true;
            this.lstSubPermiso.ItemHeight = 16;
            this.lstSubPermiso.Location = new System.Drawing.Point(162, 331);
            this.lstSubPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.lstSubPermiso.Name = "lstSubPermiso";
            this.lstSubPermiso.Size = new System.Drawing.Size(187, 148);
            this.lstSubPermiso.TabIndex = 6;
            this.lstSubPermiso.Tag = "0";
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
            // PermisosLbl
            // 
            this.PermisosLbl.AutoSize = true;
            this.PermisosLbl.Location = new System.Drawing.Point(231, 21);
            this.PermisosLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PermisosLbl.Name = "PermisosLbl";
            this.PermisosLbl.Size = new System.Drawing.Size(66, 17);
            this.PermisosLbl.TabIndex = 3;
            this.PermisosLbl.Tag = "Permission";
            this.PermisosLbl.Text = "Permisos";
            // 
            // lstPermiso
            // 
            this.lstPermiso.FormattingEnabled = true;
            this.lstPermiso.ItemHeight = 16;
            this.lstPermiso.Location = new System.Drawing.Point(218, 53);
            this.lstPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.lstPermiso.Name = "lstPermiso";
            this.lstPermiso.Size = new System.Drawing.Size(188, 180);
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
            this.RolesLbl.Tag = "Rols";
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
            this.lstGrupos.SelectedIndexChanged += new System.EventHandler(this.lstGrupos_SelectedIndexChanged);
            // 
            // AutsUsuarioLbl
            // 
            this.AutsUsuarioLbl.AutoSize = true;
            this.AutsUsuarioLbl.Location = new System.Drawing.Point(201, 31);
            this.AutsUsuarioLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AutsUsuarioLbl.Name = "AutsUsuarioLbl";
            this.AutsUsuarioLbl.Size = new System.Drawing.Size(0, 17);
            this.AutsUsuarioLbl.TabIndex = 10;
            this.AutsUsuarioLbl.Tag = "UserAuhorization";
            // 
            // trAutorizaciones
            // 
            this.trAutorizaciones.Location = new System.Drawing.Point(205, 68);
            this.trAutorizaciones.Margin = new System.Windows.Forms.Padding(4);
            this.trAutorizaciones.Name = "trAutorizaciones";
            this.trAutorizaciones.Size = new System.Drawing.Size(229, 423);
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
            this.lstUsuario.Size = new System.Drawing.Size(171, 420);
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
            this.UsuariosLbl.Size = new System.Drawing.Size(0, 17);
            this.UsuariosLbl.TabIndex = 7;
            this.UsuariosLbl.Tag = "Users";
            // 
            // txtObjeto
            // 
            this.txtObjeto.Location = new System.Drawing.Point(383, 37);
            this.txtObjeto.Name = "txtObjeto";
            this.txtObjeto.Size = new System.Drawing.Size(150, 22);
            this.txtObjeto.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdPermiso);
            this.groupBox1.Controls.Add(this.rdGrupo);
            this.groupBox1.Controls.Add(this.btnAgregarObjeto);
            this.groupBox1.Controls.Add(this.txtObjeto);
            this.groupBox1.Location = new System.Drawing.Point(13, 584);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ABM";
            // 
            // rdPermiso
            // 
            this.rdPermiso.AutoSize = true;
            this.rdPermiso.Location = new System.Drawing.Point(92, 49);
            this.rdPermiso.Name = "rdPermiso";
            this.rdPermiso.Size = new System.Drawing.Size(17, 16);
            this.rdPermiso.TabIndex = 16;
            this.rdPermiso.TabStop = true;
            this.rdPermiso.Tag = "Permission";
            this.rdPermiso.UseVisualStyleBackColor = true;
            // 
            // rdGrupo
            // 
            this.rdGrupo.AutoSize = true;
            this.rdGrupo.Location = new System.Drawing.Point(92, 22);
            this.rdGrupo.Name = "rdGrupo";
            this.rdGrupo.Size = new System.Drawing.Size(17, 16);
            this.rdGrupo.TabIndex = 15;
            this.rdGrupo.TabStop = true;
            this.rdGrupo.Tag = "Group";
            this.rdGrupo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarObjeto
            // 
            this.btnAgregarObjeto.Location = new System.Drawing.Point(250, 30);
            this.btnAgregarObjeto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarObjeto.Name = "btnAgregarObjeto";
            this.btnAgregarObjeto.Size = new System.Drawing.Size(115, 36);
            this.btnAgregarObjeto.TabIndex = 14;
            this.btnAgregarObjeto.Tag = "Add";
            this.btnAgregarObjeto.UseVisualStyleBackColor = true;
            this.btnAgregarObjeto.Click += new System.EventHandler(this.btnAgregarObjeto_Click);
            // 
            // FrmPermisoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 742);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxAutorizaciones);
            this.Controls.Add(this.AutsUsuarioLbl);
            this.Controls.Add(this.trAutorizaciones);
            this.Controls.Add(this.lstUsuario);
            this.Controls.Add(this.UsuariosLbl);
            this.Name = "FrmPermisoUsuario";
            this.Tag = "UserPermission";
            this.Load += new System.EventHandler(this.FrmPermisoUsuario_Load);
            this.groupBoxAutorizaciones.ResumeLayout(false);
            this.groupBoxAutorizaciones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBoxAutorizaciones;
        private System.Windows.Forms.Label DescripcionLbl_;
        private System.Windows.Forms.Label PermisosLbl;
        private System.Windows.Forms.ListBox lstPermiso;
        private System.Windows.Forms.Label RolesLbl;
        private System.Windows.Forms.ListBox lstGrupos;
        private System.Windows.Forms.Label AutsUsuarioLbl;
        private System.Windows.Forms.TreeView trAutorizaciones;
        private System.Windows.Forms.ListBox lstUsuario;
        private System.Windows.Forms.Label UsuariosLbl;
        private System.Windows.Forms.Label lblRolPermission;
        private System.Windows.Forms.ListBox lstSubPermiso;
        private System.Windows.Forms.TextBox txtObjeto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarObjeto;
        private System.Windows.Forms.RadioButton rdPermiso;
        private System.Windows.Forms.RadioButton rdGrupo;
    }
}