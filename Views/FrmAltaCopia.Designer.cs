
namespace Views
{
    partial class FrmAltaCopia
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstDiscos = new System.Windows.Forms.ListBox();
            this.txtPrecio = new System.Windows.Forms.NumericUpDown();
            this.txtCantCopias = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarCopia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantCopias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantitad de Copias: ";
            // 
            // lstDiscos
            // 
            this.lstDiscos.FormattingEnabled = true;
            this.lstDiscos.ItemHeight = 16;
            this.lstDiscos.Location = new System.Drawing.Point(36, 12);
            this.lstDiscos.Name = "lstDiscos";
            this.lstDiscos.Size = new System.Drawing.Size(241, 260);
            this.lstDiscos.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(486, 46);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 22);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtCantCopias
            // 
            this.txtCantCopias.Location = new System.Drawing.Point(486, 179);
            this.txtCantCopias.Name = "txtCantCopias";
            this.txtCantCopias.Size = new System.Drawing.Size(120, 22);
            this.txtCantCopias.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Precio";
            // 
            // btnAgregarCopia
            // 
            this.btnAgregarCopia.Location = new System.Drawing.Point(348, 270);
            this.btnAgregarCopia.Name = "btnAgregarCopia";
            this.btnAgregarCopia.Size = new System.Drawing.Size(107, 36);
            this.btnAgregarCopia.TabIndex = 9;
            this.btnAgregarCopia.Text = "Agregar";
            this.btnAgregarCopia.UseVisualStyleBackColor = true;
            this.btnAgregarCopia.Click += new System.EventHandler(this.btnAgregarCopia_Click);
            // 
            // FrmAltaCopia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarCopia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantCopias);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lstDiscos);
            this.Controls.Add(this.label1);
            this.Name = "FrmAltaCopia";
            this.Text = "FrmAltaCopia";
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantCopias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDiscos;
        private System.Windows.Forms.NumericUpDown txtPrecio;
        private System.Windows.Forms.NumericUpDown txtCantCopias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarCopia;
    }
}