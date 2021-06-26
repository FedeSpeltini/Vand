
namespace Views
{
    partial class FrmRegistro
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.rdCliente = new System.Windows.Forms.RadioButton();
            this.rdEmpresa = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(140, 79);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 22);
            this.txtUser.TabIndex = 0;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(140, 128);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 22);
            this.txtPwd.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(140, 233);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 58);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // rdCliente
            // 
            this.rdCliente.AutoSize = true;
            this.rdCliente.Location = new System.Drawing.Point(70, 181);
            this.rdCliente.Name = "rdCliente";
            this.rdCliente.Size = new System.Drawing.Size(72, 21);
            this.rdCliente.TabIndex = 3;
            this.rdCliente.TabStop = true;
            this.rdCliente.Text = "Cliente";
            this.rdCliente.UseVisualStyleBackColor = true;
            // 
            // rdEmpresa
            // 
            this.rdEmpresa.AutoSize = true;
            this.rdEmpresa.Location = new System.Drawing.Point(276, 181);
            this.rdEmpresa.Name = "rdEmpresa";
            this.rdEmpresa.Size = new System.Drawing.Size(85, 21);
            this.rdEmpresa.TabIndex = 4;
            this.rdEmpresa.TabStop = true;
            this.rdEmpresa.Text = "Empresa";
            this.rdEmpresa.UseVisualStyleBackColor = true;
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.rdEmpresa);
            this.Controls.Add(this.rdCliente);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.RadioButton rdCliente;
        private System.Windows.Forms.RadioButton rdEmpresa;
    }
}