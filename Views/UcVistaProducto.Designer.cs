
namespace Views
{
    partial class UcVistaProducto
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
            this.btnAcceder = new System.Windows.Forms.Button();
            this.lblDisco = new System.Windows.Forms.Label();
            this.lblBanda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(63, 157);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(91, 41);
            this.btnAcceder.TabIndex = 0;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            // 
            // lblDisco
            // 
            this.lblDisco.AutoSize = true;
            this.lblDisco.Location = new System.Drawing.Point(81, 42);
            this.lblDisco.Name = "lblDisco";
            this.lblDisco.Size = new System.Drawing.Size(46, 17);
            this.lblDisco.TabIndex = 1;
            this.lblDisco.Text = "label1";
            // 
            // lblBanda
            // 
            this.lblBanda.AutoSize = true;
            this.lblBanda.Location = new System.Drawing.Point(81, 81);
            this.lblBanda.Name = "lblBanda";
            this.lblBanda.Size = new System.Drawing.Size(46, 17);
            this.lblBanda.TabIndex = 2;
            this.lblBanda.Text = "label2";
            // 
            // UcVistaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBanda);
            this.Controls.Add(this.lblDisco);
            this.Controls.Add(this.btnAcceder);
            this.Name = "UcVistaProducto";
            this.Size = new System.Drawing.Size(218, 201);
            this.Load += new System.EventHandler(this.UcVistaProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label lblDisco;
        private System.Windows.Forms.Label lblBanda;
    }
}
