
namespace Views
{
    partial class UcVistaDisco
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
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPortada
            // 
            this.pbPortada.Location = new System.Drawing.Point(16, 3);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(319, 263);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 1;
            this.pbPortada.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(63, 292);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(41, 17);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "disco";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(58, 323);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(48, 17);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "banda";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(63, 349);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(36, 17);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "year";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(58, 381);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(47, 17);
            this.lbl4.TabIndex = 5;
            this.lbl4.Text = "precio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 316);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(177, 344);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(177, 376);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 9;
            this.textBox4.Visible = false;
            // 
            // UcVistaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pbPortada);
            this.Name = "UcVistaDisco";
            this.Size = new System.Drawing.Size(355, 427);
            this.Load += new System.EventHandler(this.UcVistaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}
