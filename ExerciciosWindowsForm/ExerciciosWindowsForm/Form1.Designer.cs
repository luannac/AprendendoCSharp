namespace ExerciciosWindowsForm
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçãoFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçãoHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitF01 = new System.Windows.Forms.ToolStripMenuItem();
            this.mitH01 = new System.Windows.Forms.ToolStripMenuItem();
            this.mitH02 = new System.Windows.Forms.ToolStripMenuItem();
            this.mitH04 = new System.Windows.Forms.ToolStripMenuItem();
            this.mitSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.seçãoFToolStripMenuItem,
            this.seçãoHToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitSair});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // seçãoFToolStripMenuItem
            // 
            this.seçãoFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitF01});
            this.seçãoFToolStripMenuItem.Name = "seçãoFToolStripMenuItem";
            this.seçãoFToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.seçãoFToolStripMenuItem.Text = "Seção F";
            // 
            // seçãoHToolStripMenuItem
            // 
            this.seçãoHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitH01,
            this.mitH02,
            this.mitH04});
            this.seçãoHToolStripMenuItem.Name = "seçãoHToolStripMenuItem";
            this.seçãoHToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.seçãoHToolStripMenuItem.Text = "Seção H";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // mitF01
            // 
            this.mitF01.Name = "mitF01";
            this.mitF01.Size = new System.Drawing.Size(152, 22);
            this.mitF01.Text = "F -01";
            this.mitF01.Click += new System.EventHandler(this.mitF01_Click);
            // 
            // mitH01
            // 
            this.mitH01.Name = "mitH01";
            this.mitH01.Size = new System.Drawing.Size(152, 22);
            this.mitH01.Text = "H - 01";
            this.mitH01.Click += new System.EventHandler(this.mitH01_Click);
            // 
            // mitH02
            // 
            this.mitH02.Name = "mitH02";
            this.mitH02.Size = new System.Drawing.Size(152, 22);
            this.mitH02.Text = "H - 02";
            this.mitH02.Click += new System.EventHandler(this.mitH02_Click);
            // 
            // mitH04
            // 
            this.mitH04.Name = "mitH04";
            this.mitH04.Size = new System.Drawing.Size(152, 22);
            this.mitH04.Text = "H - 04";
            this.mitH04.Click += new System.EventHandler(this.mitH04_Click);
            // 
            // mitSair
            // 
            this.mitSair.Name = "mitSair";
            this.mitSair.Size = new System.Drawing.Size(152, 22);
            this.mitSair.Text = "Sair";
            this.mitSair.Click += new System.EventHandler(this.mitSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 536);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitSair;
        private System.Windows.Forms.ToolStripMenuItem seçãoFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitF01;
        private System.Windows.Forms.ToolStripMenuItem seçãoHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitH01;
        private System.Windows.Forms.ToolStripMenuItem mitH02;
        private System.Windows.Forms.ToolStripMenuItem mitH04;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}

