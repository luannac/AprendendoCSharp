namespace ExerciciosWindowsForm
{
    partial class T11
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
            this.dgTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lTitle = new System.Windows.Forms.Label();
            this.lValor = new System.Windows.Forms.Label();
            this.txValor = new System.Windows.Forms.TextBox();
            this.bAdicionar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bRelatorio = new System.Windows.Forms.Button();
            this.tResposta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTable
            // 
            this.dgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgTable.Location = new System.Drawing.Point(45, 50);
            this.dgTable.Name = "dgTable";
            this.dgTable.RowHeadersVisible = false;
            this.dgTable.Size = new System.Drawing.Size(158, 150);
            this.dgTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(45, 13);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(221, 22);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Tabela de Valores (Matriz)";
            // 
            // lValor
            // 
            this.lValor.AutoSize = true;
            this.lValor.Location = new System.Drawing.Point(209, 59);
            this.lValor.Name = "lValor";
            this.lValor.Size = new System.Drawing.Size(31, 13);
            this.lValor.TabIndex = 2;
            this.lValor.Text = "Valor";
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(250, 59);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(100, 20);
            this.txValor.TabIndex = 3;
            // 
            // bAdicionar
            // 
            this.bAdicionar.Location = new System.Drawing.Point(233, 85);
            this.bAdicionar.Name = "bAdicionar";
            this.bAdicionar.Size = new System.Drawing.Size(75, 23);
            this.bAdicionar.TabIndex = 4;
            this.bAdicionar.Text = "Adicionar";
            this.bAdicionar.UseVisualStyleBackColor = true;
            this.bAdicionar.Click += new System.EventHandler(this.bAdicionar_Click);
            // 
            // bRelatorio
            // 
            this.bRelatorio.Location = new System.Drawing.Point(233, 159);
            this.bRelatorio.Name = "bRelatorio";
            this.bRelatorio.Size = new System.Drawing.Size(107, 23);
            this.bRelatorio.TabIndex = 5;
            this.bRelatorio.Text = "Gerar Relatório";
            this.bRelatorio.UseVisualStyleBackColor = true;
            this.bRelatorio.Click += new System.EventHandler(this.bRelatorio_Click);
            // 
            // tResposta
            // 
            this.tResposta.Enabled = false;
            this.tResposta.Location = new System.Drawing.Point(45, 222);
            this.tResposta.Multiline = true;
            this.tResposta.Name = "tResposta";
            this.tResposta.ReadOnly = true;
            this.tResposta.Size = new System.Drawing.Size(295, 180);
            this.tResposta.TabIndex = 6;
            this.tResposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 560);
            this.Controls.Add(this.tResposta);
            this.Controls.Add(this.bRelatorio);
            this.Controls.Add(this.bAdicionar);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.lValor);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.dgTable);
            this.Name = "T11";
            this.Text = "T11";
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTable;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lValor;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.Button bAdicionar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button bRelatorio;
        private System.Windows.Forms.TextBox tResposta;
    }
}