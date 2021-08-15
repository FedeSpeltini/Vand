
namespace Views
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vinilosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galeriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plazoFijoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logísticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.misComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.vinilosToolStripMenuItem,
            this.inversiónToolStripMenuItem,
            this.logísticaToolStripMenuItem,
            this.permisosToolStripMenuItem,
            this.idiomaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.idiomaToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.loginToolStripMenuItem.Tag = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.registroToolStripMenuItem.Tag = "Register";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.idiomaToolStripMenuItem.Tag = "Idiom";
            this.idiomaToolStripMenuItem.Click += new System.EventHandler(this.idiomaToolStripMenuItem_Click);
            // 
            // vinilosToolStripMenuItem
            // 
            this.vinilosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.galeriaToolStripMenuItem,
            this.publicarToolStripMenuItem,
            this.misComprasToolStripMenuItem});
            this.vinilosToolStripMenuItem.Name = "vinilosToolStripMenuItem";
            this.vinilosToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.vinilosToolStripMenuItem.Text = "Vinilos";
            // 
            // galeriaToolStripMenuItem
            // 
            this.galeriaToolStripMenuItem.Name = "galeriaToolStripMenuItem";
            this.galeriaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.galeriaToolStripMenuItem.Text = "Galeria";
            this.galeriaToolStripMenuItem.Click += new System.EventHandler(this.galeriaToolStripMenuItem_Click);
            // 
            // publicarToolStripMenuItem
            // 
            this.publicarToolStripMenuItem.Name = "publicarToolStripMenuItem";
            this.publicarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.publicarToolStripMenuItem.Text = "Publicar";
            this.publicarToolStripMenuItem.Click += new System.EventHandler(this.publicarToolStripMenuItem_Click);
            // 
            // inversiónToolStripMenuItem
            // 
            this.inversiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plazoFijoToolStripMenuItem});
            this.inversiónToolStripMenuItem.Name = "inversiónToolStripMenuItem";
            this.inversiónToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.inversiónToolStripMenuItem.Text = "Inversión";
            // 
            // plazoFijoToolStripMenuItem
            // 
            this.plazoFijoToolStripMenuItem.Name = "plazoFijoToolStripMenuItem";
            this.plazoFijoToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.plazoFijoToolStripMenuItem.Text = "Plazo Fijo";
            // 
            // logísticaToolStripMenuItem
            // 
            this.logísticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlToolStripMenuItem});
            this.logísticaToolStripMenuItem.Name = "logísticaToolStripMenuItem";
            this.logísticaToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.logísticaToolStripMenuItem.Text = "Logística";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.controlToolStripMenuItem.Text = "Control";
            this.controlToolStripMenuItem.Click += new System.EventHandler(this.controlToolStripMenuItem_Click);
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem,
            this.permisosUsuarioToolStripMenuItem});
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.permisosToolStripMenuItem.Text = "Permisos";
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.aBMToolStripMenuItem.Text = "ABM";
            this.aBMToolStripMenuItem.Click += new System.EventHandler(this.aBMToolStripMenuItem_Click);
            // 
            // permisosUsuarioToolStripMenuItem
            // 
            this.permisosUsuarioToolStripMenuItem.Name = "permisosUsuarioToolStripMenuItem";
            this.permisosUsuarioToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.permisosUsuarioToolStripMenuItem.Text = "PermisosUsuario";
            this.permisosUsuarioToolStripMenuItem.Click += new System.EventHandler(this.permisosUsuarioToolStripMenuItem_Click);
            // 
            // idiomaToolStripMenuItem1
            // 
            this.idiomaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem1});
            this.idiomaToolStripMenuItem1.Name = "idiomaToolStripMenuItem1";
            this.idiomaToolStripMenuItem1.Size = new System.Drawing.Size(70, 24);
            this.idiomaToolStripMenuItem1.Text = "Idioma";
            // 
            // aBMToolStripMenuItem1
            // 
            this.aBMToolStripMenuItem1.Name = "aBMToolStripMenuItem1";
            this.aBMToolStripMenuItem1.Size = new System.Drawing.Size(124, 26);
            this.aBMToolStripMenuItem1.Text = "ABM";
            this.aBMToolStripMenuItem1.Click += new System.EventHandler(this.aBMToolStripMenuItem1_Click);
            // 
            // misComprasToolStripMenuItem
            // 
            this.misComprasToolStripMenuItem.Name = "misComprasToolStripMenuItem";
            this.misComprasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.misComprasToolStripMenuItem.Text = "Mis compras";
            this.misComprasToolStripMenuItem.Click += new System.EventHandler(this.misComprasToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "VAND";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vinilosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galeriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plazoFijoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logísticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem misComprasToolStripMenuItem;
    }
}