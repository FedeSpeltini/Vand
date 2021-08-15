
namespace Views
{
    partial class UcVistaDisco
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.lblDisco = new System.Windows.Forms.Label();
            this.lblBanda = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPortada
            // 
            this.pbPortada.Location = new System.Drawing.Point(16, 3);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(319, 263);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 1;
            this.pbPortada.TabStop = false;
            // 
            // lblDisco
            // 
            this.lblDisco.AutoSize = true;
            this.lblDisco.Location = new System.Drawing.Point(143, 275);
            this.lblDisco.Name = "lblDisco";
            this.lblDisco.Size = new System.Drawing.Size(41, 17);
            this.lblDisco.TabIndex = 2;
            this.lblDisco.Text = "disco";
            // 
            // lblBanda
            // 
            this.lblBanda.AutoSize = true;
            this.lblBanda.Location = new System.Drawing.Point(143, 301);
            this.lblBanda.Name = "lblBanda";
            this.lblBanda.Size = new System.Drawing.Size(48, 17);
            this.lblBanda.TabIndex = 3;
            this.lblBanda.Text = "banda";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(143, 331);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 17);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "year";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(143, 360);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 17);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "precio";
            // 
            // UcVistaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblBanda);
            this.Controls.Add(this.lblDisco);
            this.Controls.Add(this.pbPortada);
            this.Name = "UcVistaDisco";
            this.Size = new System.Drawing.Size(355, 390);
            this.Load += new System.EventHandler(this.UcVistaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Label lblDisco;
        private System.Windows.Forms.Label lblBanda;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPrecio;
    }
}
