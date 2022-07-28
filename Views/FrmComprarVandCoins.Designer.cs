namespace Views
{
    partial class FrmComprarVandCoins
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
            this.txtNroTarjeta = new System.Windows.Forms.TextBox();
            this.txtFechaHasta = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ndCantVandCoins = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnComprarVand = new System.Windows.Forms.Button();
            this.txtValorRef = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPesosAGastar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVandCoinAComprar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ndCantVandCoins)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNroTarjeta
            // 
            this.txtNroTarjeta.Location = new System.Drawing.Point(108, 12);
            this.txtNroTarjeta.Name = "txtNroTarjeta";
            this.txtNroTarjeta.Size = new System.Drawing.Size(298, 22);
            this.txtNroTarjeta.TabIndex = 1;
            this.txtNroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(108, 49);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(120, 22);
            this.txtFechaHasta.TabIndex = 2;
            this.txtFechaHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFechaHasta_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(108, 93);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(120, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero tarjeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo";
            // 
            // ndCantVandCoins
            // 
            this.ndCantVandCoins.Location = new System.Drawing.Point(401, 50);
            this.ndCantVandCoins.Name = "ndCantVandCoins";
            this.ndCantVandCoins.Size = new System.Drawing.Size(120, 22);
            this.ndCantVandCoins.TabIndex = 7;
            this.ndCantVandCoins.ValueChanged += new System.EventHandler(this.ndCantVandCoins_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad de VandCoin";
            // 
            // btnComprarVand
            // 
            this.btnComprarVand.Location = new System.Drawing.Point(12, 218);
            this.btnComprarVand.Name = "btnComprarVand";
            this.btnComprarVand.Size = new System.Drawing.Size(125, 52);
            this.btnComprarVand.TabIndex = 9;
            this.btnComprarVand.Text = "Comprar";
            this.btnComprarVand.UseVisualStyleBackColor = true;
            this.btnComprarVand.Click += new System.EventHandler(this.btnComprarVand_Click);
            // 
            // txtValorRef
            // 
            this.txtValorRef.Enabled = false;
            this.txtValorRef.Location = new System.Drawing.Point(401, 99);
            this.txtValorRef.Name = "txtValorRef";
            this.txtValorRef.Size = new System.Drawing.Size(101, 22);
            this.txtValorRef.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Un Vandcoin vale: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vas a gastar";
            // 
            // txtPesosAGastar
            // 
            this.txtPesosAGastar.Enabled = false;
            this.txtPesosAGastar.Location = new System.Drawing.Point(108, 164);
            this.txtPesosAGastar.Name = "txtPesosAGastar";
            this.txtPesosAGastar.Size = new System.Drawing.Size(120, 22);
            this.txtPesosAGastar.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "para comprar";
            // 
            // txtVandCoinAComprar
            // 
            this.txtVandCoinAComprar.Enabled = false;
            this.txtVandCoinAComprar.Location = new System.Drawing.Point(330, 162);
            this.txtVandCoinAComprar.Name = "txtVandCoinAComprar";
            this.txtVandCoinAComprar.Size = new System.Drawing.Size(62, 22);
            this.txtVandCoinAComprar.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "VandCoins";
            // 
            // FrmComprarVandCoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 320);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVandCoinAComprar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPesosAGastar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorRef);
            this.Controls.Add(this.btnComprarVand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ndCantVandCoins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtFechaHasta);
            this.Controls.Add(this.txtNroTarjeta);
            this.Name = "FrmComprarVandCoins";
            this.Text = "FrmComprarVandCoins";
            this.Load += new System.EventHandler(this.FrmComprarVandCoins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ndCantVandCoins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNroTarjeta;
        private System.Windows.Forms.TextBox txtFechaHasta;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ndCantVandCoins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnComprarVand;
        private System.Windows.Forms.TextBox txtValorRef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPesosAGastar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVandCoinAComprar;
        private System.Windows.Forms.Label label8;
    }
}