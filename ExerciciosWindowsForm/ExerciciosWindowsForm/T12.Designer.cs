namespace T12
{
    partial class T12
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.somaR = new System.Windows.Forms.Label();
            this.mediaR = new System.Windows.Forms.Label();
            this.diagonalS = new System.Windows.Forms.Label();
            this.registrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATRIZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENTRE COM OS VALORES";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "GERAR RESULTADOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RESULTADOS:";
            // 
            // somaR
            // 
            this.somaR.AutoSize = true;
            this.somaR.Location = new System.Drawing.Point(19, 152);
            this.somaR.Name = "somaR";
            this.somaR.Size = new System.Drawing.Size(37, 13);
            this.somaR.TabIndex = 5;
            this.somaR.Text = "Soma:";
            // 
            // mediaR
            // 
            this.mediaR.AutoSize = true;
            this.mediaR.Location = new System.Drawing.Point(19, 184);
            this.mediaR.Name = "mediaR";
            this.mediaR.Size = new System.Drawing.Size(39, 13);
            this.mediaR.TabIndex = 6;
            this.mediaR.Text = "Média:";
            // 
            // diagonalS
            // 
            this.diagonalS.AutoSize = true;
            this.diagonalS.Location = new System.Drawing.Point(22, 215);
            this.diagonalS.Name = "diagonalS";
            this.diagonalS.Size = new System.Drawing.Size(109, 13);
            this.diagonalS.TabIndex = 7;
            this.diagonalS.Text = "Diagonal Segundaria:";
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(227, 49);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(45, 23);
            this.registrar.TabIndex = 8;
            this.registrar.Text = "OK";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.diagonalS);
            this.Controls.Add(this.mediaR);
            this.Controls.Add(this.somaR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label somaR;
        private System.Windows.Forms.Label mediaR;
        private System.Windows.Forms.Label diagonalS;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Label label4;
    }
}

