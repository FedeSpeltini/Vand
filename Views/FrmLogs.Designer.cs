namespace Views
{
    partial class FrmLogs
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
            this.dtLogs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dtLogs
            // 
            this.dtLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLogs.Location = new System.Drawing.Point(297, 32);
            this.dtLogs.Name = "dtLogs";
            this.dtLogs.RowHeadersWidth = 51;
            this.dtLogs.RowTemplate.Height = 24;
            this.dtLogs.Size = new System.Drawing.Size(477, 371);
            this.dtLogs.TabIndex = 3;
            // 
            // FrmLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtLogs);
            this.Name = "FrmLogs";
            this.Text = "FrmLogs";
            ((System.ComponentModel.ISupportInitialize)(this.dtLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtLogs;
    }
}