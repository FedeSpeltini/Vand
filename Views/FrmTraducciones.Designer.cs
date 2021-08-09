
namespace Views
{
    partial class FrmTraducciones
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
            this.lstIdioma = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.dtEtiquetas = new System.Windows.Forms.DataGridView();
            this.dtTraducciones = new System.Windows.Forms.DataGridView();
            this.Etiqueta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Traduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEtiqueta = new System.Windows.Forms.TextBox();
            this.btnAgregarEtiqueta = new System.Windows.Forms.Button();
            this.btnModificarEtiqueta = new System.Windows.Forms.Button();
            this.txtTraduccion = new System.Windows.Forms.TextBox();
            this.btnAgregarTraduccion = new System.Windows.Forms.Button();
            this.btnModificarTraduccion = new System.Windows.Forms.Button();
            this.rdAgregar = new System.Windows.Forms.RadioButton();
            this.rdModificar = new System.Windows.Forms.RadioButton();
            this.btnBorrarIdioma = new System.Windows.Forms.Button();
            this.btnSacarTraduccion = new System.Windows.Forms.Button();
            this.btnSacarEtiqueta = new System.Windows.Forms.Button();
            this.rdElminar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTraducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lstIdioma
            // 
            this.lstIdioma.FormattingEnabled = true;
            this.lstIdioma.ItemHeight = 16;
            this.lstIdioma.Location = new System.Drawing.Point(12, 12);
            this.lstIdioma.Name = "lstIdioma";
            this.lstIdioma.Size = new System.Drawing.Size(250, 228);
            this.lstIdioma.TabIndex = 0;
            this.lstIdioma.SelectedIndexChanged += new System.EventHandler(this.lstIdioma_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 333);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(183, 31);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Tag = "Add";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(30, 297);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(183, 22);
            this.txtIdioma.TabIndex = 3;
            // 
            // dtEtiquetas
            // 
            this.dtEtiquetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEtiquetas.Location = new System.Drawing.Point(315, 33);
            this.dtEtiquetas.Name = "dtEtiquetas";
            this.dtEtiquetas.RowHeadersWidth = 51;
            this.dtEtiquetas.RowTemplate.Height = 24;
            this.dtEtiquetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtEtiquetas.Size = new System.Drawing.Size(382, 185);
            this.dtEtiquetas.TabIndex = 4;
            this.dtEtiquetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEtiquetas_CellContentClick);
            // 
            // dtTraducciones
            // 
            this.dtTraducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTraducciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Etiqueta,
            this.Traduccion});
            this.dtTraducciones.Location = new System.Drawing.Point(704, 33);
            this.dtTraducciones.Margin = new System.Windows.Forms.Padding(4);
            this.dtTraducciones.Name = "dtTraducciones";
            this.dtTraducciones.ReadOnly = true;
            this.dtTraducciones.RowHeadersWidth = 51;
            this.dtTraducciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtTraducciones.Size = new System.Drawing.Size(441, 185);
            this.dtTraducciones.TabIndex = 26;
            this.dtTraducciones.Tag = "0";
            this.dtTraducciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTraducciones_CellContentClick);
            // 
            // Etiqueta
            // 
            this.Etiqueta.HeaderText = "Etiqueta";
            this.Etiqueta.MinimumWidth = 6;
            this.Etiqueta.Name = "Etiqueta";
            this.Etiqueta.ReadOnly = true;
            this.Etiqueta.Width = 125;
            // 
            // Traduccion
            // 
            this.Traduccion.HeaderText = "Traduccion";
            this.Traduccion.MinimumWidth = 6;
            this.Traduccion.Name = "Traduccion";
            this.Traduccion.ReadOnly = true;
            this.Traduccion.Width = 125;
            // 
            // txtEtiqueta
            // 
            this.txtEtiqueta.Location = new System.Drawing.Point(380, 297);
            this.txtEtiqueta.Name = "txtEtiqueta";
            this.txtEtiqueta.Size = new System.Drawing.Size(183, 22);
            this.txtEtiqueta.TabIndex = 28;
            // 
            // btnAgregarEtiqueta
            // 
            this.btnAgregarEtiqueta.Location = new System.Drawing.Point(380, 333);
            this.btnAgregarEtiqueta.Name = "btnAgregarEtiqueta";
            this.btnAgregarEtiqueta.Size = new System.Drawing.Size(183, 31);
            this.btnAgregarEtiqueta.TabIndex = 27;
            this.btnAgregarEtiqueta.Tag = "Add";
            this.btnAgregarEtiqueta.UseVisualStyleBackColor = true;
            this.btnAgregarEtiqueta.Click += new System.EventHandler(this.btnAgregarEtiqueta_Click);
            // 
            // btnModificarEtiqueta
            // 
            this.btnModificarEtiqueta.Location = new System.Drawing.Point(380, 370);
            this.btnModificarEtiqueta.Name = "btnModificarEtiqueta";
            this.btnModificarEtiqueta.Size = new System.Drawing.Size(183, 31);
            this.btnModificarEtiqueta.TabIndex = 29;
            this.btnModificarEtiqueta.Tag = "Modify";
            this.btnModificarEtiqueta.UseVisualStyleBackColor = true;
            this.btnModificarEtiqueta.Click += new System.EventHandler(this.btnModificarEtiqueta_Click);
            // 
            // txtTraduccion
            // 
            this.txtTraduccion.Location = new System.Drawing.Point(736, 297);
            this.txtTraduccion.Name = "txtTraduccion";
            this.txtTraduccion.Size = new System.Drawing.Size(183, 22);
            this.txtTraduccion.TabIndex = 30;
            // 
            // btnAgregarTraduccion
            // 
            this.btnAgregarTraduccion.Location = new System.Drawing.Point(736, 335);
            this.btnAgregarTraduccion.Name = "btnAgregarTraduccion";
            this.btnAgregarTraduccion.Size = new System.Drawing.Size(183, 31);
            this.btnAgregarTraduccion.TabIndex = 31;
            this.btnAgregarTraduccion.Tag = "Add";
            this.btnAgregarTraduccion.UseVisualStyleBackColor = true;
            this.btnAgregarTraduccion.Click += new System.EventHandler(this.btnAgregarTraduccion_Click);
            // 
            // btnModificarTraduccion
            // 
            this.btnModificarTraduccion.Location = new System.Drawing.Point(736, 372);
            this.btnModificarTraduccion.Name = "btnModificarTraduccion";
            this.btnModificarTraduccion.Size = new System.Drawing.Size(183, 31);
            this.btnModificarTraduccion.TabIndex = 32;
            this.btnModificarTraduccion.Tag = "Modify";
            this.btnModificarTraduccion.UseVisualStyleBackColor = true;
            this.btnModificarTraduccion.Click += new System.EventHandler(this.btnModificarTraduccion_Click);
            // 
            // rdAgregar
            // 
            this.rdAgregar.AutoSize = true;
            this.rdAgregar.Location = new System.Drawing.Point(506, 238);
            this.rdAgregar.Name = "rdAgregar";
            this.rdAgregar.Size = new System.Drawing.Size(17, 16);
            this.rdAgregar.TabIndex = 33;
            this.rdAgregar.TabStop = true;
            this.rdAgregar.Tag = "Add";
            this.rdAgregar.UseVisualStyleBackColor = true;
            this.rdAgregar.CheckedChanged += new System.EventHandler(this.rdAgregar_CheckedChanged);
            // 
            // rdModificar
            // 
            this.rdModificar.AutoSize = true;
            this.rdModificar.Location = new System.Drawing.Point(611, 238);
            this.rdModificar.Name = "rdModificar";
            this.rdModificar.Size = new System.Drawing.Size(17, 16);
            this.rdModificar.TabIndex = 34;
            this.rdModificar.TabStop = true;
            this.rdModificar.Tag = "Modify";
            this.rdModificar.UseVisualStyleBackColor = true;
            this.rdModificar.CheckedChanged += new System.EventHandler(this.rdModificar_CheckedChanged);
            // 
            // btnBorrarIdioma
            // 
            this.btnBorrarIdioma.Location = new System.Drawing.Point(30, 370);
            this.btnBorrarIdioma.Name = "btnBorrarIdioma";
            this.btnBorrarIdioma.Size = new System.Drawing.Size(183, 31);
            this.btnBorrarIdioma.TabIndex = 35;
            this.btnBorrarIdioma.Tag = "Remove";
            this.btnBorrarIdioma.UseVisualStyleBackColor = true;
            this.btnBorrarIdioma.Click += new System.EventHandler(this.btnBorrarIdioma_Click);
            // 
            // btnSacarTraduccion
            // 
            this.btnSacarTraduccion.Location = new System.Drawing.Point(736, 409);
            this.btnSacarTraduccion.Name = "btnSacarTraduccion";
            this.btnSacarTraduccion.Size = new System.Drawing.Size(183, 31);
            this.btnSacarTraduccion.TabIndex = 36;
            this.btnSacarTraduccion.Tag = "Remove";
            this.btnSacarTraduccion.UseVisualStyleBackColor = true;
            this.btnSacarTraduccion.Click += new System.EventHandler(this.btnSacarTraduccion_Click);
            // 
            // btnSacarEtiqueta
            // 
            this.btnSacarEtiqueta.Location = new System.Drawing.Point(380, 409);
            this.btnSacarEtiqueta.Name = "btnSacarEtiqueta";
            this.btnSacarEtiqueta.Size = new System.Drawing.Size(183, 31);
            this.btnSacarEtiqueta.TabIndex = 37;
            this.btnSacarEtiqueta.Tag = "Remove";
            this.btnSacarEtiqueta.UseVisualStyleBackColor = true;
            this.btnSacarEtiqueta.Click += new System.EventHandler(this.btnSacarEtiqueta_Click);
            // 
            // rdElminar
            // 
            this.rdElminar.AutoSize = true;
            this.rdElminar.Location = new System.Drawing.Point(733, 238);
            this.rdElminar.Name = "rdElminar";
            this.rdElminar.Size = new System.Drawing.Size(17, 16);
            this.rdElminar.TabIndex = 38;
            this.rdElminar.TabStop = true;
            this.rdElminar.Tag = "Remove";
            this.rdElminar.UseVisualStyleBackColor = true;
            this.rdElminar.CheckedChanged += new System.EventHandler(this.rdElminar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Etiqueta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(792, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Traducción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Idioma";
            // 
            // FrmTraducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdElminar);
            this.Controls.Add(this.btnSacarEtiqueta);
            this.Controls.Add(this.btnSacarTraduccion);
            this.Controls.Add(this.btnBorrarIdioma);
            this.Controls.Add(this.rdModificar);
            this.Controls.Add(this.rdAgregar);
            this.Controls.Add(this.btnModificarTraduccion);
            this.Controls.Add(this.btnAgregarTraduccion);
            this.Controls.Add(this.txtTraduccion);
            this.Controls.Add(this.btnModificarEtiqueta);
            this.Controls.Add(this.txtEtiqueta);
            this.Controls.Add(this.btnAgregarEtiqueta);
            this.Controls.Add(this.dtTraducciones);
            this.Controls.Add(this.dtEtiquetas);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstIdioma);
            this.Name = "FrmTraducciones";
            this.Text = "Traducciones";
            this.Load += new System.EventHandler(this.FrmTraducciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTraducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstIdioma;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.DataGridView dtEtiquetas;
        private System.Windows.Forms.DataGridView dtTraducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etiqueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Traduccion;
        private System.Windows.Forms.TextBox txtEtiqueta;
        private System.Windows.Forms.Button btnAgregarEtiqueta;
        private System.Windows.Forms.Button btnModificarEtiqueta;
        private System.Windows.Forms.TextBox txtTraduccion;
        private System.Windows.Forms.Button btnAgregarTraduccion;
        private System.Windows.Forms.Button btnModificarTraduccion;
        private System.Windows.Forms.RadioButton rdAgregar;
        private System.Windows.Forms.RadioButton rdModificar;
        private System.Windows.Forms.Button btnBorrarIdioma;
        private System.Windows.Forms.Button btnSacarTraduccion;
        private System.Windows.Forms.Button btnSacarEtiqueta;
        private System.Windows.Forms.RadioButton rdElminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}