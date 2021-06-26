
namespace Views
{
    partial class FrmGaleria
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lstDiscos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(80, 264);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(130, 48);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Tag = "Detail";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lstDiscos
            // 
            this.lstDiscos.FormattingEnabled = true;
            this.lstDiscos.ItemHeight = 16;
            this.lstDiscos.Location = new System.Drawing.Point(12, 12);
            this.lstDiscos.Name = "lstDiscos";
            this.lstDiscos.Size = new System.Drawing.Size(285, 228);
            this.lstDiscos.TabIndex = 1;
            // 
            // FrmGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 341);
            this.Controls.Add(this.lstDiscos);
            this.Controls.Add(this.btnIngresar);
            this.Name = "FrmGaleria";
            this.Text = "FrmGaleria";
            this.Load += new System.EventHandler(this.FrmGaleria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ListBox lstDiscos;
    }
}