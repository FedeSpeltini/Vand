
namespace Views
{
    partial class FrmIdioma
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstIdioma
            // 
            this.lstIdioma.FormattingEnabled = true;
            this.lstIdioma.ItemHeight = 16;
            this.lstIdioma.Location = new System.Drawing.Point(40, 24);
            this.lstIdioma.Name = "lstIdioma";
            this.lstIdioma.Size = new System.Drawing.Size(173, 180);
            this.lstIdioma.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(40, 234);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(173, 55);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Tag = "SelectIdiom";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // FrmIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 338);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lstIdioma);
            this.Name = "FrmIdioma";
            this.Tag = "Idiom";
            this.Load += new System.EventHandler(this.FrmIdioma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstIdioma;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}