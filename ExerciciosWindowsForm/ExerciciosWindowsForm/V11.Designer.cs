namespace ExerciciosWindowsForm
{
    partial class V11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V11));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txValor = new System.Windows.Forms.TextBox();
            this.lValor = new System.Windows.Forms.Label();
            this.bAdicionar = new System.Windows.Forms.Button();
            this.bRelatorio = new System.Windows.Forms.Button();
            this.rtbResposta = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(395, 100);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // dgvTabela
            // 
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.ColumnHeadersVisible = false;
            this.dgvTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTabela.Location = new System.Drawing.Point(13, 151);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.RowHeadersVisible = false;
            this.dgvTabela.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTabela.Size = new System.Drawing.Size(153, 109);
            this.dgvTabela.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 30;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 30;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 30;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 30;
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(250, 151);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(100, 20);
            this.txValor.TabIndex = 2;
            this.txValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txValor_KeyPress);
            // 
            // lValor
            // 
            this.lValor.AutoSize = true;
            this.lValor.Location = new System.Drawing.Point(199, 151);
            this.lValor.Name = "lValor";
            this.lValor.Size = new System.Drawing.Size(34, 13);
            this.lValor.TabIndex = 3;
            this.lValor.Text = "Valor:";
            // 
            // bAdicionar
            // 
            this.bAdicionar.Location = new System.Drawing.Point(228, 201);
            this.bAdicionar.Name = "bAdicionar";
            this.bAdicionar.Size = new System.Drawing.Size(75, 23);
            this.bAdicionar.TabIndex = 4;
            this.bAdicionar.Text = "Adicionar";
            this.bAdicionar.UseVisualStyleBackColor = true;
            this.bAdicionar.Click += new System.EventHandler(this.bAdicionar_Click);
            // 
            // bRelatorio
            // 
            this.bRelatorio.Location = new System.Drawing.Point(214, 247);
            this.bRelatorio.Name = "bRelatorio";
            this.bRelatorio.Size = new System.Drawing.Size(89, 23);
            this.bRelatorio.TabIndex = 5;
            this.bRelatorio.Text = "Gerar Relatório";
            this.bRelatorio.UseVisualStyleBackColor = true;
            this.bRelatorio.Click += new System.EventHandler(this.bRelatorio_Click);
            // 
            // rtbResposta
            // 
            this.rtbResposta.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbResposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbResposta.Location = new System.Drawing.Point(13, 303);
            this.rtbResposta.Name = "rtbResposta";
            this.rtbResposta.Size = new System.Drawing.Size(395, 96);
            this.rtbResposta.TabIndex = 6;
            this.rtbResposta.Text = "";
            // 
            // V11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 422);
            this.Controls.Add(this.rtbResposta);
            this.Controls.Add(this.bRelatorio);
            this.Controls.Add(this.bAdicionar);
            this.Controls.Add(this.lValor);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.dgvTabela);
            this.Controls.Add(this.richTextBox1);
            this.Name = "V11";
            this.Text = "V11";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.Label lValor;
        private System.Windows.Forms.Button bAdicionar;
        private System.Windows.Forms.Button bRelatorio;
        private System.Windows.Forms.RichTextBox rtbResposta;
    }
}