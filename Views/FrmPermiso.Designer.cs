
namespace Views
{
    partial class FrmPermiso
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
            this.btnModificarPermiso = new System.Windows.Forms.Button();
            this.btnSacarPermiso = new System.Windows.Forms.Button();
            this.btnModificarGrupo = new System.Windows.Forms.Button();
            this.btnSacarGrupo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textBoxDescPermiso = new System.Windows.Forms.TextBox();
            this.txtNombrePermiso = new System.Windows.Forms.TextBox();
            this.textBoxIdPermiso = new System.Windows.Forms.TextBox();
            this.textBoxDescRol = new System.Windows.Forms.TextBox();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.descripcionRolLbl = new System.Windows.Forms.Label();
            this.nombreRolLbl = new System.Windows.Forms.Label();
            this.descripcionPermLbl = new System.Windows.Forms.Label();
            this.nombrePermLbl = new System.Windows.Forms.Label();
            this.idPermLbl = new System.Windows.Forms.Label();
            this.dtPermisos = new System.Windows.Forms.DataGridView();
            this.dtGrupos = new System.Windows.Forms.DataGridView();
            this.PermisosLbl = new System.Windows.Forms.Label();
            this.RolesLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdGrupo = new System.Windows.Forms.RadioButton();
            this.rdPermiso = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarPermiso
            // 
            this.btnModificarPermiso.Location = new System.Drawing.Point(886, 378);
            this.btnModificarPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarPermiso.Name = "btnModificarPermiso";
            this.btnModificarPermiso.Size = new System.Drawing.Size(100, 28);
            this.btnModificarPermiso.TabIndex = 41;
            this.btnModificarPermiso.Tag = "28";
            this.btnModificarPermiso.Text = "Modificar";
            this.btnModificarPermiso.UseVisualStyleBackColor = true;
            // 
            // btnSacarPermiso
            // 
            this.btnSacarPermiso.Location = new System.Drawing.Point(778, 378);
            this.btnSacarPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacarPermiso.Name = "btnSacarPermiso";
            this.btnSacarPermiso.Size = new System.Drawing.Size(100, 28);
            this.btnSacarPermiso.TabIndex = 40;
            this.btnSacarPermiso.Tag = "27";
            this.btnSacarPermiso.Text = "Sacar";
            this.btnSacarPermiso.UseVisualStyleBackColor = true;
            // 
            // btnModificarGrupo
            // 
            this.btnModificarGrupo.Location = new System.Drawing.Point(171, 378);
            this.btnModificarGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarGrupo.Name = "btnModificarGrupo";
            this.btnModificarGrupo.Size = new System.Drawing.Size(100, 28);
            this.btnModificarGrupo.TabIndex = 38;
            this.btnModificarGrupo.Tag = "25";
            this.btnModificarGrupo.Text = "Modificar";
            this.btnModificarGrupo.UseVisualStyleBackColor = true;
            // 
            // btnSacarGrupo
            // 
            this.btnSacarGrupo.Location = new System.Drawing.Point(63, 378);
            this.btnSacarGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacarGrupo.Name = "btnSacarGrupo";
            this.btnSacarGrupo.Size = new System.Drawing.Size(100, 28);
            this.btnSacarGrupo.TabIndex = 37;
            this.btnSacarGrupo.Tag = "24";
            this.btnSacarGrupo.Text = "Sacar";
            this.btnSacarGrupo.UseVisualStyleBackColor = true;
            this.btnSacarGrupo.Click += new System.EventHandler(this.btnSacarGrupo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(739, 541);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Tag = "23";
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // textBoxDescPermiso
            // 
            this.textBoxDescPermiso.Location = new System.Drawing.Point(670, 340);
            this.textBoxDescPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescPermiso.Name = "textBoxDescPermiso";
            this.textBoxDescPermiso.Size = new System.Drawing.Size(440, 22);
            this.textBoxDescPermiso.TabIndex = 35;
            // 
            // txtNombrePermiso
            // 
            this.txtNombrePermiso.Location = new System.Drawing.Point(670, 307);
            this.txtNombrePermiso.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePermiso.Name = "txtNombrePermiso";
            this.txtNombrePermiso.Size = new System.Drawing.Size(440, 22);
            this.txtNombrePermiso.TabIndex = 34;
            // 
            // textBoxIdPermiso
            // 
            this.textBoxIdPermiso.Location = new System.Drawing.Point(670, 274);
            this.textBoxIdPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdPermiso.Name = "textBoxIdPermiso";
            this.textBoxIdPermiso.Size = new System.Drawing.Size(440, 22);
            this.textBoxIdPermiso.TabIndex = 33;
            // 
            // textBoxDescRol
            // 
            this.textBoxDescRol.Location = new System.Drawing.Point(97, 340);
            this.textBoxDescRol.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescRol.Name = "textBoxDescRol";
            this.textBoxDescRol.Size = new System.Drawing.Size(440, 22);
            this.textBoxDescRol.TabIndex = 32;
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(97, 307);
            this.txtNombreGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(440, 22);
            this.txtNombreGrupo.TabIndex = 31;
            // 
            // descripcionRolLbl
            // 
            this.descripcionRolLbl.AutoSize = true;
            this.descripcionRolLbl.Location = new System.Drawing.Point(9, 344);
            this.descripcionRolLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descripcionRolLbl.Name = "descripcionRolLbl";
            this.descripcionRolLbl.Size = new System.Drawing.Size(82, 17);
            this.descripcionRolLbl.TabIndex = 30;
            this.descripcionRolLbl.Tag = "39";
            this.descripcionRolLbl.Text = "Descripcion";
            // 
            // nombreRolLbl
            // 
            this.nombreRolLbl.AutoSize = true;
            this.nombreRolLbl.Location = new System.Drawing.Point(9, 307);
            this.nombreRolLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreRolLbl.Name = "nombreRolLbl";
            this.nombreRolLbl.Size = new System.Drawing.Size(58, 17);
            this.nombreRolLbl.TabIndex = 29;
            this.nombreRolLbl.Tag = "41";
            this.nombreRolLbl.Text = "Nombre";
            // 
            // descripcionPermLbl
            // 
            this.descripcionPermLbl.AutoSize = true;
            this.descripcionPermLbl.Location = new System.Drawing.Point(582, 344);
            this.descripcionPermLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descripcionPermLbl.Name = "descripcionPermLbl";
            this.descripcionPermLbl.Size = new System.Drawing.Size(82, 17);
            this.descripcionPermLbl.TabIndex = 28;
            this.descripcionPermLbl.Tag = "39";
            this.descripcionPermLbl.Text = "Descripcion";
            // 
            // nombrePermLbl
            // 
            this.nombrePermLbl.AutoSize = true;
            this.nombrePermLbl.Location = new System.Drawing.Point(582, 311);
            this.nombrePermLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombrePermLbl.Name = "nombrePermLbl";
            this.nombrePermLbl.Size = new System.Drawing.Size(58, 17);
            this.nombrePermLbl.TabIndex = 27;
            this.nombrePermLbl.Tag = "41";
            this.nombrePermLbl.Text = "Nombre";
            // 
            // idPermLbl
            // 
            this.idPermLbl.AutoSize = true;
            this.idPermLbl.Location = new System.Drawing.Point(582, 277);
            this.idPermLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idPermLbl.Name = "idPermLbl";
            this.idPermLbl.Size = new System.Drawing.Size(19, 17);
            this.idPermLbl.TabIndex = 26;
            this.idPermLbl.Tag = "40";
            this.idPermLbl.Text = "Id";
            // 
            // dtPermisos
            // 
            this.dtPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPermisos.Location = new System.Drawing.Point(586, 68);
            this.dtPermisos.Margin = new System.Windows.Forms.Padding(4);
            this.dtPermisos.Name = "dtPermisos";
            this.dtPermisos.ReadOnly = true;
            this.dtPermisos.RowHeadersWidth = 51;
            this.dtPermisos.Size = new System.Drawing.Size(400, 185);
            this.dtPermisos.TabIndex = 25;
            this.dtPermisos.Tag = "0";
            // 
            // dtGrupos
            // 
            this.dtGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrupos.Location = new System.Drawing.Point(13, 68);
            this.dtGrupos.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrupos.Name = "dtGrupos";
            this.dtGrupos.ReadOnly = true;
            this.dtGrupos.RowHeadersWidth = 51;
            this.dtGrupos.Size = new System.Drawing.Size(448, 185);
            this.dtGrupos.TabIndex = 24;
            this.dtGrupos.Tag = "0";
            this.dtGrupos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrupos_CellClick);
            // 
            // PermisosLbl
            // 
            this.PermisosLbl.AutoSize = true;
            this.PermisosLbl.Location = new System.Drawing.Point(582, 34);
            this.PermisosLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PermisosLbl.Name = "PermisosLbl";
            this.PermisosLbl.Size = new System.Drawing.Size(66, 17);
            this.PermisosLbl.TabIndex = 23;
            this.PermisosLbl.Tag = "34";
            this.PermisosLbl.Text = "Permisos";
            // 
            // RolesLbl
            // 
            this.RolesLbl.AutoSize = true;
            this.RolesLbl.Location = new System.Drawing.Point(13, 34);
            this.RolesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RolesLbl.Name = "RolesLbl";
            this.RolesLbl.Size = new System.Drawing.Size(44, 17);
            this.RolesLbl.TabIndex = 22;
            this.RolesLbl.Tag = "38";
            this.RolesLbl.Text = "Roles";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 541);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(440, 22);
            this.textBox2.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 541);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 42;
            this.label2.Tag = "41";
            this.label2.Text = "Nombre";
            // 
            // rdGrupo
            // 
            this.rdGrupo.AutoSize = true;
            this.rdGrupo.Location = new System.Drawing.Point(34, 541);
            this.rdGrupo.Name = "rdGrupo";
            this.rdGrupo.Size = new System.Drawing.Size(69, 21);
            this.rdGrupo.TabIndex = 46;
            this.rdGrupo.TabStop = true;
            this.rdGrupo.Text = "Grupo";
            this.rdGrupo.UseVisualStyleBackColor = true;
            // 
            // rdPermiso
            // 
            this.rdPermiso.AutoSize = true;
            this.rdPermiso.Location = new System.Drawing.Point(34, 581);
            this.rdPermiso.Name = "rdPermiso";
            this.rdPermiso.Size = new System.Drawing.Size(80, 21);
            this.rdPermiso.TabIndex = 47;
            this.rdPermiso.TabStop = true;
            this.rdPermiso.Text = "Permiso";
            this.rdPermiso.UseVisualStyleBackColor = true;
            // 
            // FrmPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 679);
            this.Controls.Add(this.rdPermiso);
            this.Controls.Add(this.rdGrupo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificarPermiso);
            this.Controls.Add(this.btnSacarPermiso);
            this.Controls.Add(this.btnModificarGrupo);
            this.Controls.Add(this.btnSacarGrupo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textBoxDescPermiso);
            this.Controls.Add(this.txtNombrePermiso);
            this.Controls.Add(this.textBoxIdPermiso);
            this.Controls.Add(this.textBoxDescRol);
            this.Controls.Add(this.txtNombreGrupo);
            this.Controls.Add(this.descripcionRolLbl);
            this.Controls.Add(this.nombreRolLbl);
            this.Controls.Add(this.descripcionPermLbl);
            this.Controls.Add(this.nombrePermLbl);
            this.Controls.Add(this.idPermLbl);
            this.Controls.Add(this.dtPermisos);
            this.Controls.Add(this.dtGrupos);
            this.Controls.Add(this.PermisosLbl);
            this.Controls.Add(this.RolesLbl);
            this.Name = "FrmPermiso";
            this.Text = "FrmPermiso";
            this.Load += new System.EventHandler(this.FrmPermiso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModificarPermiso;
        private System.Windows.Forms.Button btnSacarPermiso;
        private System.Windows.Forms.Button btnModificarGrupo;
        private System.Windows.Forms.Button btnSacarGrupo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox textBoxDescPermiso;
        private System.Windows.Forms.TextBox txtNombrePermiso;
        private System.Windows.Forms.TextBox textBoxIdPermiso;
        private System.Windows.Forms.TextBox textBoxDescRol;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.Label descripcionRolLbl;
        private System.Windows.Forms.Label nombreRolLbl;
        private System.Windows.Forms.Label descripcionPermLbl;
        private System.Windows.Forms.Label nombrePermLbl;
        private System.Windows.Forms.Label idPermLbl;
        private System.Windows.Forms.DataGridView dtPermisos;
        private System.Windows.Forms.DataGridView dtGrupos;
        private System.Windows.Forms.Label PermisosLbl;
        private System.Windows.Forms.Label RolesLbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdGrupo;
        private System.Windows.Forms.RadioButton rdPermiso;
    }
}