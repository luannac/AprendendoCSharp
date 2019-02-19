namespace ExerciciosWindowsForm
{
    partial class Login
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
            this.lUsu = new System.Windows.Forms.Label();
            this.tbUsu = new System.Windows.Forms.TextBox();
            this.lSenha = new System.Windows.Forms.Label();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lUsu
            // 
            this.lUsu.AutoSize = true;
            this.lUsu.Location = new System.Drawing.Point(45, 46);
            this.lUsu.Name = "lUsu";
            this.lUsu.Size = new System.Drawing.Size(46, 13);
            this.lUsu.TabIndex = 0;
            this.lUsu.Text = "Usuário:";
            // 
            // tbUsu
            // 
            this.tbUsu.Location = new System.Drawing.Point(48, 62);
            this.tbUsu.Name = "tbUsu";
            this.tbUsu.Size = new System.Drawing.Size(171, 20);
            this.tbUsu.TabIndex = 1;
            // 
            // lSenha
            // 
            this.lSenha.AutoSize = true;
            this.lSenha.Location = new System.Drawing.Point(48, 104);
            this.lSenha.Name = "lSenha";
            this.lSenha.Size = new System.Drawing.Size(41, 13);
            this.lSenha.TabIndex = 2;
            this.lSenha.Text = "Senha:";
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(48, 121);
            this.txSenha.Name = "txSenha";
            this.txSenha.Size = new System.Drawing.Size(171, 20);
            this.txSenha.TabIndex = 3;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(95, 177);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(75, 23);
            this.bLogin.TabIndex = 4;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.lSenha);
            this.Controls.Add(this.tbUsu);
            this.Controls.Add(this.lUsu);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUsu;
        private System.Windows.Forms.TextBox tbUsu;
        private System.Windows.Forms.Label lSenha;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Button bLogin;
    }
}