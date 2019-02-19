namespace ExerciciosWindowsForm
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitSair = new System.Windows.Forms.ToolStripMenuItem();
            this.seçãoFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitF01 = new System.Windows.Forms.ToolStripMenuItem();
            this.f02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f04ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçãoHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitH01 = new System.Windows.Forms.ToolStripMenuItem();
            this.t11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.t11ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreNósToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.seçãoFToolStripMenuItem,
            this.seçãoHToolStripMenuItem,
            this.t11ToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sobreNósToolStripMenuItem});
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
            // mitSair
            // 
            this.mitSair.Name = "mitSair";
            this.mitSair.Size = new System.Drawing.Size(93, 22);
            this.mitSair.Text = "Sair";
            this.mitSair.Click += new System.EventHandler(this.mitSair_Click);
            // 
            // seçãoFToolStripMenuItem
            // 
            this.seçãoFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitF01,
            this.f02ToolStripMenuItem,
            this.f04ToolStripMenuItem});
            this.seçãoFToolStripMenuItem.Name = "seçãoFToolStripMenuItem";
            this.seçãoFToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.seçãoFToolStripMenuItem.Text = "Seção F";
            // 
            // mitF01
            // 
            this.mitF01.Name = "mitF01";
            this.mitF01.Size = new System.Drawing.Size(103, 22);
            this.mitF01.Text = "F -01";
            this.mitF01.Click += new System.EventHandler(this.mitF01_Click);
            // 
            // f02ToolStripMenuItem
            // 
            this.f02ToolStripMenuItem.Name = "f02ToolStripMenuItem";
            this.f02ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.f02ToolStripMenuItem.Text = "F - 02";
            // 
            // f04ToolStripMenuItem
            // 
            this.f04ToolStripMenuItem.Name = "f04ToolStripMenuItem";
            this.f04ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.f04ToolStripMenuItem.Text = "F - 04";
            // 
            // seçãoHToolStripMenuItem
            // 
            this.seçãoHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitH01});
            this.seçãoHToolStripMenuItem.Name = "seçãoHToolStripMenuItem";
            this.seçãoHToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.seçãoHToolStripMenuItem.Text = "Seção H";
            // 
            // mitH01
            // 
            this.mitH01.Name = "mitH01";
            this.mitH01.Size = new System.Drawing.Size(106, 22);
            this.mitH01.Text = "H - 01";
            this.mitH01.Click += new System.EventHandler(this.mitH01_Click);
            // 
            // t11ToolStripMenuItem
            // 
            this.t11ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.t11ToolStripMenuItem1,
            this.toolStripMenuItem1});
            this.t11ToolStripMenuItem.Name = "t11ToolStripMenuItem";
            this.t11ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.t11ToolStripMenuItem.Text = "Seção T";
            // 
            // t11ToolStripMenuItem1
            // 
            this.t11ToolStripMenuItem1.Name = "t11ToolStripMenuItem1";
            this.t11ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.t11ToolStripMenuItem1.Text = "T - 11";
            this.t11ToolStripMenuItem1.Click += new System.EventHandler(this.t11ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "T - 13";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreNósToolStripMenuItem
            // 
            this.sobreNósToolStripMenuItem.Name = "sobreNósToolStripMenuItem";
            this.sobreNósToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.sobreNósToolStripMenuItem.Text = "Sobre nós";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(914, 536);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
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
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f02ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f04ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem t11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem t11ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreNósToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

