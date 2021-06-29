
namespace Views
{
    partial class FrmInversion
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
            this.btnInvertir = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.dtInversiones = new System.Windows.Forms.DataGridView();
            this.MontoInvertido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtInversiones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(24, 70);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(75, 23);
            this.btnInvertir.TabIndex = 0;
            this.btnInvertir.Text = "Invertir";
            this.btnInvertir.UseVisualStyleBackColor = true;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(141, 71);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 22);
            this.txtMonto.TabIndex = 1;
            // 
            // dtInversiones
            // 
            this.dtInversiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInversiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MontoInvertido,
            this.FechaFinalizacion,
            this.MontoFinal});
            this.dtInversiones.Location = new System.Drawing.Point(311, 71);
            this.dtInversiones.Name = "dtInversiones";
            this.dtInversiones.RowHeadersWidth = 51;
            this.dtInversiones.RowTemplate.Height = 24;
            this.dtInversiones.Size = new System.Drawing.Size(477, 150);
            this.dtInversiones.TabIndex = 2;
            // 
            // MontoInvertido
            // 
            this.MontoInvertido.HeaderText = "Monto Invertido";
            this.MontoInvertido.MinimumWidth = 6;
            this.MontoInvertido.Name = "MontoInvertido";
            this.MontoInvertido.Width = 125;
            // 
            // FechaFinalizacion
            // 
            this.FechaFinalizacion.HeaderText = "Fecha Finalización";
            this.FechaFinalizacion.MinimumWidth = 6;
            this.FechaFinalizacion.Name = "FechaFinalizacion";
            this.FechaFinalizacion.Width = 125;
            // 
            // MontoFinal
            // 
            this.MontoFinal.HeaderText = "Monto Final";
            this.MontoFinal.MinimumWidth = 6;
            this.MontoFinal.Name = "MontoFinal";
            this.MontoFinal.Width = 125;
            // 
            // FrmInversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtInversiones);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnInvertir);
            this.Name = "FrmInversion";
            this.Text = "FrmInversion";
            ((System.ComponentModel.ISupportInitialize)(this.dtInversiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.DataGridView dtInversiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoInvertido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoFinal;
    }
}