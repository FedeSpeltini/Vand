
namespace Views
{
    partial class FrmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.rdSpanish = new System.Windows.Forms.RadioButton();
            this.rdEnglish = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(94, 215);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 42);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(97, 38);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(113, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(97, 88);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(113, 22);
            this.txtPwd.TabIndex = 2;
            // 
            // rdSpanish
            // 
            this.rdSpanish.AutoSize = true;
            this.rdSpanish.Location = new System.Drawing.Point(97, 141);
            this.rdSpanish.Name = "rdSpanish";
            this.rdSpanish.Size = new System.Drawing.Size(80, 21);
            this.rdSpanish.TabIndex = 3;
            this.rdSpanish.TabStop = true;
            this.rdSpanish.Text = "Espanol";
            this.rdSpanish.UseVisualStyleBackColor = true;
            // 
            // rdEnglish
            // 
            this.rdEnglish.AutoSize = true;
            this.rdEnglish.Location = new System.Drawing.Point(97, 177);
            this.rdEnglish.Name = "rdEnglish";
            this.rdEnglish.Size = new System.Drawing.Size(66, 21);
            this.rdEnglish.TabIndex = 4;
            this.rdEnglish.TabStop = true;
            this.rdEnglish.Text = "Ingles";
            this.rdEnglish.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 290);
            this.Controls.Add(this.rdEnglish);
            this.Controls.Add(this.rdSpanish);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.RadioButton rdSpanish;
        private System.Windows.Forms.RadioButton rdEnglish;
    }
}