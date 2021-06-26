
namespace Views
{
    partial class FrmDisco
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
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblNombreDisco = new System.Windows.Forms.Label();
            this.lblNombreBanda = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(159, 270);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Tag = "Buy";
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblNombreDisco
            // 
            this.lblNombreDisco.AutoSize = true;
            this.lblNombreDisco.Location = new System.Drawing.Point(156, 61);
            this.lblNombreDisco.Name = "lblNombreDisco";
            this.lblNombreDisco.Size = new System.Drawing.Size(46, 17);
            this.lblNombreDisco.TabIndex = 1;
            this.lblNombreDisco.Text = "label1";
            // 
            // lblNombreBanda
            // 
            this.lblNombreBanda.AutoSize = true;
            this.lblNombreBanda.Location = new System.Drawing.Point(156, 117);
            this.lblNombreBanda.Name = "lblNombreBanda";
            this.lblNombreBanda.Size = new System.Drawing.Size(46, 17);
            this.lblNombreBanda.TabIndex = 2;
            this.lblNombreBanda.Text = "label1";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(156, 156);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(46, 17);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "label1";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(156, 198);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 17);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "label1";
            // 
            // FrmDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblNombreBanda);
            this.Controls.Add(this.lblNombreDisco);
            this.Controls.Add(this.btnComprar);
            this.Name = "FrmDisco";
            this.Text = "FrmDisco";
            this.Load += new System.EventHandler(this.FrmDisco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblNombreDisco;
        private System.Windows.Forms.Label lblNombreBanda;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPrecio;
    }
}