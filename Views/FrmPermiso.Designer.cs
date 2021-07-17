
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
            this.lstPadre = new System.Windows.Forms.ListBox();
            this.lstHijo = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.lstSubPermisos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstPadre
            // 
            this.lstPadre.FormattingEnabled = true;
            this.lstPadre.ItemHeight = 16;
            this.lstPadre.Location = new System.Drawing.Point(26, 71);
            this.lstPadre.Name = "lstPadre";
            this.lstPadre.Size = new System.Drawing.Size(178, 164);
            this.lstPadre.TabIndex = 0;
            this.lstPadre.SelectedIndexChanged += new System.EventHandler(this.lstPadre_SelectedIndexChanged);
            // 
            // lstHijo
            // 
            this.lstHijo.FormattingEnabled = true;
            this.lstHijo.ItemHeight = 16;
            this.lstHijo.Location = new System.Drawing.Point(568, 71);
            this.lstHijo.Name = "lstHijo";
            this.lstHijo.Size = new System.Drawing.Size(250, 164);
            this.lstHijo.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(210, 71);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(210, 153);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 3;
            this.btnSacar.Text = "Quitar";
            this.btnSacar.UseVisualStyleBackColor = true;
            // 
            // lstSubPermisos
            // 
            this.lstSubPermisos.FormattingEnabled = true;
            this.lstSubPermisos.ItemHeight = 16;
            this.lstSubPermisos.Location = new System.Drawing.Point(232, 274);
            this.lstSubPermisos.Name = "lstSubPermisos";
            this.lstSubPermisos.Size = new System.Drawing.Size(309, 196);
            this.lstSubPermisos.TabIndex = 4;
            // 
            // FrmPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 534);
            this.Controls.Add(this.lstSubPermisos);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstHijo);
            this.Controls.Add(this.lstPadre);
            this.Name = "FrmPermiso";
            this.Text = "FrmPermiso";
            this.Load += new System.EventHandler(this.FrmPermiso_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPadre;
        private System.Windows.Forms.ListBox lstHijo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.ListBox lstSubPermisos;
    }
}