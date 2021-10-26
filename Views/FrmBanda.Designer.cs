
namespace Views
{
    partial class FrmBanda
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
            this.lstBanda = new System.Windows.Forms.ListBox();
            this.ucVistaDisco1 = new Views.UcVistaDisco();
            this.chkAgregar = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBanda
            // 
            this.lstBanda.FormattingEnabled = true;
            this.lstBanda.ItemHeight = 16;
            this.lstBanda.Location = new System.Drawing.Point(12, 25);
            this.lstBanda.Name = "lstBanda";
            this.lstBanda.Size = new System.Drawing.Size(120, 212);
            this.lstBanda.TabIndex = 0;
            // 
            // ucVistaDisco1
            // 
            this.ucVistaDisco1.Location = new System.Drawing.Point(179, 25);
            this.ucVistaDisco1.Name = "ucVistaDisco1";
            this.ucVistaDisco1.Size = new System.Drawing.Size(355, 390);
            this.ucVistaDisco1.TabIndex = 1;
            // 
            // chkAgregar
            // 
            this.chkAgregar.AutoSize = true;
            this.chkAgregar.Location = new System.Drawing.Point(12, 277);
            this.chkAgregar.Name = "chkAgregar";
            this.chkAgregar.Size = new System.Drawing.Size(71, 21);
            this.chkAgregar.TabIndex = 2;
            this.chkAgregar.Text = "Nuevo";
            this.chkAgregar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 315);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 34);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // FrmBanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 463);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chkAgregar);
            this.Controls.Add(this.ucVistaDisco1);
            this.Controls.Add(this.lstBanda);
            this.Name = "FrmBanda";
            this.Text = "ABM";
            this.Load += new System.EventHandler(this.FrmBanda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBanda;
        private UcVistaDisco ucVistaDisco1;
        private System.Windows.Forms.CheckBox chkAgregar;
        private System.Windows.Forms.Button btnAgregar;
    }
}