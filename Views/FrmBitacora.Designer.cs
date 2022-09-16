namespace Views
{
    partial class FrmBitacora
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelHasta = new System.Windows.Forms.Label();
            this.labelDesde = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxActividad = new System.Windows.Forms.CheckBox();
            this.checkBoxfecha = new System.Windows.Forms.CheckBox();
            this.checkBoxUsuario = new System.Windows.Forms.CheckBox();
            this.AplicarBtn = new System.Windows.Forms.Button();
            this.listViewEventos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1167, 371);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 28);
            this.button1.TabIndex = 27;
            this.button1.Text = "Generar PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbUser
            // 
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.Enabled = false;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(1252, 55);
            this.cbUser.Margin = new System.Windows.Forms.Padding(4);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(265, 24);
            this.cbUser.TabIndex = 26;
            this.cbUser.SelectedIndexChanged += new System.EventHandler(this.cbUser_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(1288, 201);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 22);
            this.textBox2.TabIndex = 25;
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Location = new System.Drawing.Point(1193, 159);
            this.labelHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(43, 16);
            this.labelHasta.TabIndex = 24;
            this.labelHasta.Tag = "69";
            this.labelHasta.Text = "Hasta";
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Location = new System.Drawing.Point(1193, 127);
            this.labelDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(48, 16);
            this.labelDesde.TabIndex = 23;
            this.labelDesde.Tag = "68";
            this.labelDesde.Text = "Desde";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(1252, 151);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 22;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(1252, 119);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBoxActividad
            // 
            this.checkBoxActividad.AutoSize = true;
            this.checkBoxActividad.Location = new System.Drawing.Point(1144, 201);
            this.checkBoxActividad.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxActividad.Name = "checkBoxActividad";
            this.checkBoxActividad.Size = new System.Drawing.Size(115, 20);
            this.checkBoxActividad.TabIndex = 20;
            this.checkBoxActividad.Tag = "57";
            this.checkBoxActividad.Text = "Palabra Clave";
            this.checkBoxActividad.UseVisualStyleBackColor = true;
            this.checkBoxActividad.CheckedChanged += new System.EventHandler(this.checkBoxActividad_CheckedChanged);
            // 
            // checkBoxfecha
            // 
            this.checkBoxfecha.AutoSize = true;
            this.checkBoxfecha.Location = new System.Drawing.Point(1144, 94);
            this.checkBoxfecha.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxfecha.Name = "checkBoxfecha";
            this.checkBoxfecha.Size = new System.Drawing.Size(67, 20);
            this.checkBoxfecha.TabIndex = 19;
            this.checkBoxfecha.Tag = "67";
            this.checkBoxfecha.Text = "Fecha";
            this.checkBoxfecha.UseVisualStyleBackColor = true;
            this.checkBoxfecha.CheckedChanged += new System.EventHandler(this.checkBoxfecha_CheckedChanged);
            // 
            // checkBoxUsuario
            // 
            this.checkBoxUsuario.AutoSize = true;
            this.checkBoxUsuario.Location = new System.Drawing.Point(1143, 58);
            this.checkBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxUsuario.Name = "checkBoxUsuario";
            this.checkBoxUsuario.Size = new System.Drawing.Size(76, 20);
            this.checkBoxUsuario.TabIndex = 18;
            this.checkBoxUsuario.Tag = "44";
            this.checkBoxUsuario.Text = "Usuario";
            this.checkBoxUsuario.UseVisualStyleBackColor = true;
            this.checkBoxUsuario.CheckedChanged += new System.EventHandler(this.checkBoxUsuario_CheckedChanged);
            // 
            // AplicarBtn
            // 
            this.AplicarBtn.Location = new System.Drawing.Point(1373, 254);
            this.AplicarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AplicarBtn.Name = "AplicarBtn";
            this.AplicarBtn.Size = new System.Drawing.Size(145, 28);
            this.AplicarBtn.TabIndex = 17;
            this.AplicarBtn.Tag = "32";
            this.AplicarBtn.Text = "Aplicar";
            this.AplicarBtn.UseVisualStyleBackColor = true;
            this.AplicarBtn.Click += new System.EventHandler(this.AplicarBtn_Click);
            // 
            // listViewEventos
            // 
            this.listViewEventos.HideSelection = false;
            this.listViewEventos.Location = new System.Drawing.Point(-44, 52);
            this.listViewEventos.Margin = new System.Windows.Forms.Padding(4);
            this.listViewEventos.Name = "listViewEventos";
            this.listViewEventos.Size = new System.Drawing.Size(1161, 346);
            this.listViewEventos.TabIndex = 16;
            this.listViewEventos.UseCompatibleStateImageBehavior = false;
            // 
            // FrmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelHasta);
            this.Controls.Add(this.labelDesde);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBoxActividad);
            this.Controls.Add(this.checkBoxfecha);
            this.Controls.Add(this.checkBoxUsuario);
            this.Controls.Add(this.AplicarBtn);
            this.Controls.Add(this.listViewEventos);
            this.Name = "FrmBitacora";
            this.Text = "FrmBitacora";
            this.Load += new System.EventHandler(this.FrmBitacora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelHasta;
        private System.Windows.Forms.Label labelDesde;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxActividad;
        private System.Windows.Forms.CheckBox checkBoxfecha;
        private System.Windows.Forms.CheckBox checkBoxUsuario;
        private System.Windows.Forms.Button AplicarBtn;
        private System.Windows.Forms.ListView listViewEventos;
    }
}