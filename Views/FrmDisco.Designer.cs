
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
            this.ucVistaDisco1 = new Views.UcVistaDisco();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(202, 436);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(118, 45);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Tag = "Buy";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // ucVistaDisco1
            // 
            this.ucVistaDisco1.Location = new System.Drawing.Point(42, 12);
            this.ucVistaDisco1.Name = "ucVistaDisco1";
            this.ucVistaDisco1.Size = new System.Drawing.Size(387, 418);
            this.ucVistaDisco1.TabIndex = 9;
            // 
            // FrmDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 568);
            this.Controls.Add(this.ucVistaDisco1);
            this.Controls.Add(this.btnComprar);
            this.Name = "FrmDisco";
            this.Tag = "Disc";
            this.Load += new System.EventHandler(this.FrmDisco_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComprar;
        private UcVistaDisco ucVistaDisco1;
    }
}