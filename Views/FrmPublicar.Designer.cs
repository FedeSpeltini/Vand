namespace Views
{
    partial class FrmPublicar
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
            this.txtBandUrl = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chkNewBand = new System.Windows.Forms.CheckBox();
            this.chkNewAlbum = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewBand = new System.Windows.Forms.TextBox();
            this.txtNewAlbum = new System.Windows.Forms.TextBox();
            this.txtUrlAlbum = new System.Windows.Forms.TextBox();
            this.lblNewBand = new System.Windows.Forms.Label();
            this.lblBandUrl = new System.Windows.Forms.Label();
            this.lblNewAlbum = new System.Windows.Forms.Label();
            this.lblAlbumUrl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPublish = new System.Windows.Forms.Button();
            this.lstBands = new System.Windows.Forms.ListBox();
            this.lstAlbums = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBandUrl
            // 
            this.txtBandUrl.Location = new System.Drawing.Point(708, 86);
            this.txtBandUrl.Name = "txtBandUrl";
            this.txtBandUrl.Size = new System.Drawing.Size(250, 22);
            this.txtBandUrl.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(220, 615);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(138, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // chkNewBand
            // 
            this.chkNewBand.AutoSize = true;
            this.chkNewBand.Location = new System.Drawing.Point(220, 249);
            this.chkNewBand.Name = "chkNewBand";
            this.chkNewBand.Size = new System.Drawing.Size(118, 20);
            this.chkNewBand.TabIndex = 4;
            this.chkNewBand.Text = "Nueva banda?";
            this.chkNewBand.UseVisualStyleBackColor = true;
            this.chkNewBand.CheckedChanged += new System.EventHandler(this.chkNewBand_CheckedChanged);
            // 
            // chkNewAlbum
            // 
            this.chkNewAlbum.AutoSize = true;
            this.chkNewAlbum.Location = new System.Drawing.Point(226, 542);
            this.chkNewAlbum.Name = "chkNewAlbum";
            this.chkNewAlbum.Size = new System.Drawing.Size(112, 20);
            this.chkNewAlbum.TabIndex = 5;
            this.chkNewAlbum.Text = "Nuevo disco?";
            this.chkNewAlbum.UseVisualStyleBackColor = true;
            this.chkNewAlbum.CheckedChanged += new System.EventHandler(this.chkNewAlbum_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione la banda";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccione lel album";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNewBand
            // 
            this.txtNewBand.Location = new System.Drawing.Point(708, 39);
            this.txtNewBand.Name = "txtNewBand";
            this.txtNewBand.Size = new System.Drawing.Size(250, 22);
            this.txtNewBand.TabIndex = 9;
            // 
            // txtNewAlbum
            // 
            this.txtNewAlbum.Location = new System.Drawing.Point(708, 159);
            this.txtNewAlbum.Name = "txtNewAlbum";
            this.txtNewAlbum.Size = new System.Drawing.Size(250, 22);
            this.txtNewAlbum.TabIndex = 11;
            // 
            // txtUrlAlbum
            // 
            this.txtUrlAlbum.Location = new System.Drawing.Point(708, 203);
            this.txtUrlAlbum.Name = "txtUrlAlbum";
            this.txtUrlAlbum.Size = new System.Drawing.Size(250, 22);
            this.txtUrlAlbum.TabIndex = 10;
            // 
            // lblNewBand
            // 
            this.lblNewBand.AutoSize = true;
            this.lblNewBand.Location = new System.Drawing.Point(528, 39);
            this.lblNewBand.Name = "lblNewBand";
            this.lblNewBand.Size = new System.Drawing.Size(131, 16);
            this.lblNewBand.TabIndex = 12;
            this.lblNewBand.Text = "Nombre de la banda";
            this.lblNewBand.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBandUrl
            // 
            this.lblBandUrl.AutoSize = true;
            this.lblBandUrl.Location = new System.Drawing.Point(528, 89);
            this.lblBandUrl.Name = "lblBandUrl";
            this.lblBandUrl.Size = new System.Drawing.Size(177, 16);
            this.lblBandUrl.TabIndex = 13;
            this.lblBandUrl.Text = "Ingrese foto (url) de la banda";
            this.lblBandUrl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNewAlbum
            // 
            this.lblNewAlbum.AutoSize = true;
            this.lblNewAlbum.Location = new System.Drawing.Point(527, 156);
            this.lblNewAlbum.Name = "lblNewAlbum";
            this.lblNewAlbum.Size = new System.Drawing.Size(114, 16);
            this.lblNewAlbum.TabIndex = 14;
            this.lblNewAlbum.Text = "Nombre del disco";
            this.lblNewAlbum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAlbumUrl
            // 
            this.lblAlbumUrl.AutoSize = true;
            this.lblAlbumUrl.Location = new System.Drawing.Point(527, 206);
            this.lblAlbumUrl.Name = "lblAlbumUrl";
            this.lblAlbumUrl.Size = new System.Drawing.Size(160, 16);
            this.lblAlbumUrl.TabIndex = 15;
            this.lblAlbumUrl.Text = "Ingrese foto (url) del disco";
            this.lblAlbumUrl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Precio";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(220, 702);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(128, 45);
            this.btnPublish.TabIndex = 17;
            this.btnPublish.Text = "Publicar";
            this.btnPublish.UseVisualStyleBackColor = true;
            // 
            // lstBands
            // 
            this.lstBands.FormattingEnabled = true;
            this.lstBands.ItemHeight = 16;
            this.lstBands.Location = new System.Drawing.Point(220, 33);
            this.lstBands.Name = "lstBands";
            this.lstBands.Size = new System.Drawing.Size(202, 212);
            this.lstBands.TabIndex = 18;
            this.lstBands.SelectedIndexChanged += new System.EventHandler(this.lstBands_SelectedIndexChanged);
            // 
            // lstAlbums
            // 
            this.lstAlbums.FormattingEnabled = true;
            this.lstAlbums.ItemHeight = 16;
            this.lstAlbums.Location = new System.Drawing.Point(220, 315);
            this.lstAlbums.Name = "lstAlbums";
            this.lstAlbums.Size = new System.Drawing.Size(202, 212);
            this.lstAlbums.TabIndex = 19;
            // 
            // FrmPublicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 846);
            this.Controls.Add(this.lstAlbums);
            this.Controls.Add(this.lstBands);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAlbumUrl);
            this.Controls.Add(this.lblNewAlbum);
            this.Controls.Add(this.lblBandUrl);
            this.Controls.Add(this.lblNewBand);
            this.Controls.Add(this.txtNewAlbum);
            this.Controls.Add(this.txtUrlAlbum);
            this.Controls.Add(this.txtNewBand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkNewAlbum);
            this.Controls.Add(this.chkNewBand);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtBandUrl);
            this.Name = "FrmPublicar";
            this.Text = "FrmPublicar";
            this.Load += new System.EventHandler(this.FrmPublicar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBandUrl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox chkNewBand;
        private System.Windows.Forms.CheckBox chkNewAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewBand;
        private System.Windows.Forms.TextBox txtNewAlbum;
        private System.Windows.Forms.TextBox txtUrlAlbum;
        private System.Windows.Forms.Label lblNewBand;
        private System.Windows.Forms.Label lblBandUrl;
        private System.Windows.Forms.Label lblNewAlbum;
        private System.Windows.Forms.Label lblAlbumUrl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.ListBox lstBands;
        private System.Windows.Forms.ListBox lstAlbums;
    }
}