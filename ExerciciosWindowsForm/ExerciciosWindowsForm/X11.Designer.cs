namespace ExerciciosWindowsForm
{
    partial class X11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(X11));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lNota1 = new System.Windows.Forms.Label();
            this.txNota1 = new System.Windows.Forms.TextBox();
            this.txNota2 = new System.Windows.Forms.TextBox();
            this.lNota2 = new System.Windows.Forms.Label();
            this.txNota3 = new System.Windows.Forms.TextBox();
            this.lNota3 = new System.Windows.Forms.Label();
            this.txNota4 = new System.Windows.Forms.TextBox();
            this.lNota4 = new System.Windows.Forms.Label();
            this.bMedia = new System.Windows.Forms.Button();
            this.rtbResposta = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X.11";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(27, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(450, 95);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // lNota1
            // 
            this.lNota1.AutoSize = true;
            this.lNota1.Location = new System.Drawing.Point(27, 142);
            this.lNota1.Name = "lNota1";
            this.lNota1.Size = new System.Drawing.Size(42, 13);
            this.lNota1.TabIndex = 2;
            this.lNota1.Text = "Nota 1:";
            // 
            // txNota1
            // 
            this.txNota1.Location = new System.Drawing.Point(76, 142);
            this.txNota1.Name = "txNota1";
            this.txNota1.Size = new System.Drawing.Size(100, 20);
            this.txNota1.TabIndex = 3;
            this.txNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNota1_KeyPress);
            // 
            // txNota2
            // 
            this.txNota2.Location = new System.Drawing.Point(76, 168);
            this.txNota2.Name = "txNota2";
            this.txNota2.Size = new System.Drawing.Size(100, 20);
            this.txNota2.TabIndex = 5;
            this.txNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNota1_KeyPress);
            // 
            // lNota2
            // 
            this.lNota2.AutoSize = true;
            this.lNota2.Location = new System.Drawing.Point(27, 168);
            this.lNota2.Name = "lNota2";
            this.lNota2.Size = new System.Drawing.Size(42, 13);
            this.lNota2.TabIndex = 4;
            this.lNota2.Text = "Nota 2:";
            // 
            // txNota3
            // 
            this.txNota3.Location = new System.Drawing.Point(310, 142);
            this.txNota3.Name = "txNota3";
            this.txNota3.Size = new System.Drawing.Size(100, 20);
            this.txNota3.TabIndex = 7;
            this.txNota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNota1_KeyPress);
            // 
            // lNota3
            // 
            this.lNota3.AutoSize = true;
            this.lNota3.Location = new System.Drawing.Point(261, 142);
            this.lNota3.Name = "lNota3";
            this.lNota3.Size = new System.Drawing.Size(42, 13);
            this.lNota3.TabIndex = 6;
            this.lNota3.Text = "Nota 3:";
            // 
            // txNota4
            // 
            this.txNota4.Location = new System.Drawing.Point(310, 168);
            this.txNota4.Name = "txNota4";
            this.txNota4.Size = new System.Drawing.Size(100, 20);
            this.txNota4.TabIndex = 9;
            this.txNota4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNota1_KeyPress);
            // 
            // lNota4
            // 
            this.lNota4.AutoSize = true;
            this.lNota4.Location = new System.Drawing.Point(261, 168);
            this.lNota4.Name = "lNota4";
            this.lNota4.Size = new System.Drawing.Size(42, 13);
            this.lNota4.TabIndex = 8;
            this.lNota4.Text = "Nota 4:";
            // 
            // bMedia
            // 
            this.bMedia.Location = new System.Drawing.Point(207, 214);
            this.bMedia.Name = "bMedia";
            this.bMedia.Size = new System.Drawing.Size(75, 23);
            this.bMedia.TabIndex = 10;
            this.bMedia.Text = "Gerar Média";
            this.bMedia.UseVisualStyleBackColor = true;
            this.bMedia.Click += new System.EventHandler(this.bMedia_Click);
            // 
            // rtbResposta
            // 
            this.rtbResposta.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbResposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbResposta.Location = new System.Drawing.Point(27, 257);
            this.rtbResposta.Name = "rtbResposta";
            this.rtbResposta.Size = new System.Drawing.Size(450, 69);
            this.rtbResposta.TabIndex = 11;
            this.rtbResposta.Text = "";
            // 
            // X11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 338);
            this.Controls.Add(this.rtbResposta);
            this.Controls.Add(this.bMedia);
            this.Controls.Add(this.txNota4);
            this.Controls.Add(this.lNota4);
            this.Controls.Add(this.txNota3);
            this.Controls.Add(this.lNota3);
            this.Controls.Add(this.txNota2);
            this.Controls.Add(this.lNota2);
            this.Controls.Add(this.txNota1);
            this.Controls.Add(this.lNota1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "X11";
            this.Text = "X11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lNota1;
        private System.Windows.Forms.TextBox txNota1;
        private System.Windows.Forms.TextBox txNota2;
        private System.Windows.Forms.Label lNota2;
        private System.Windows.Forms.TextBox txNota3;
        private System.Windows.Forms.Label lNota3;
        private System.Windows.Forms.TextBox txNota4;
        private System.Windows.Forms.Label lNota4;
        private System.Windows.Forms.Button bMedia;
        private System.Windows.Forms.RichTextBox rtbResposta;
    }
}