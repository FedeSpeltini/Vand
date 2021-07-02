
namespace Views
{
    partial class FrmLogistica
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
            this.lstEnvios = new System.Windows.Forms.ListBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEnvios
            // 
            this.lstEnvios.FormattingEnabled = true;
            this.lstEnvios.ItemHeight = 16;
            this.lstEnvios.Location = new System.Drawing.Point(569, 70);
            this.lstEnvios.Name = "lstEnvios";
            this.lstEnvios.Size = new System.Drawing.Size(120, 84);
            this.lstEnvios.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(436, 282);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar Paquete";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FrmLogistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lstEnvios);
            this.Name = "FrmLogistica";
            this.Text = "FrmLogistica";
            this.Load += new System.EventHandler(this.FrmLogistica_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEnvios;
        private System.Windows.Forms.Button btnEnviar;
    }
}