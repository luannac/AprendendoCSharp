namespace ExerciciosWindowsForm
{
    partial class H01
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
            this.lRecebe = new System.Windows.Forms.Label();
            this.txtRecebe = new System.Windows.Forms.TextBox();
            this.bAvaliar = new System.Windows.Forms.Button();
            this.lResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lRecebe
            // 
            this.lRecebe.AutoSize = true;
            this.lRecebe.Location = new System.Drawing.Point(13, 13);
            this.lRecebe.Name = "lRecebe";
            this.lRecebe.Size = new System.Drawing.Size(92, 13);
            this.lRecebe.TabIndex = 0;
            this.lRecebe.Text = "Digite um número:";
            // 
            // txtRecebe
            // 
            this.txtRecebe.Location = new System.Drawing.Point(16, 30);
            this.txtRecebe.Name = "txtRecebe";
            this.txtRecebe.Size = new System.Drawing.Size(100, 20);
            this.txtRecebe.TabIndex = 1;
            this.txtRecebe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecebe_KeyPress);
            // 
            // bAvaliar
            // 
            this.bAvaliar.Location = new System.Drawing.Point(101, 91);
            this.bAvaliar.Name = "bAvaliar";
            this.bAvaliar.Size = new System.Drawing.Size(75, 23);
            this.bAvaliar.TabIndex = 2;
            this.bAvaliar.Text = "Avaliar";
            this.bAvaliar.UseVisualStyleBackColor = true;
            this.bAvaliar.Click += new System.EventHandler(this.bAvaliar_Click);
            // 
            // lResultado
            // 
            this.lResultado.AutoSize = true;
            this.lResultado.Location = new System.Drawing.Point(43, 156);
            this.lResultado.Name = "lResultado";
            this.lResultado.Size = new System.Drawing.Size(0, 13);
            this.lResultado.TabIndex = 3;
            // 
            // H01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lResultado);
            this.Controls.Add(this.bAvaliar);
            this.Controls.Add(this.txtRecebe);
            this.Controls.Add(this.lRecebe);
            this.Name = "H01";
            this.Text = "H01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lRecebe;
        private System.Windows.Forms.TextBox txtRecebe;
        private System.Windows.Forms.Button bAvaliar;
        private System.Windows.Forms.Label lResultado;
    }
}