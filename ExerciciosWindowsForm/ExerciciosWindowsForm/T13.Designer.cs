namespace ExerciciosWindowsForm
{
    partial class T13
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
            this.bRelatorio = new System.Windows.Forms.Button();
            this.bAdicionar = new System.Windows.Forms.Button();
            this.txValor = new System.Windows.Forms.TextBox();
            this.lValor = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.dgTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bRelatorio
            // 
            this.bRelatorio.Location = new System.Drawing.Point(200, 155);
            this.bRelatorio.Name = "bRelatorio";
            this.bRelatorio.Size = new System.Drawing.Size(107, 23);
            this.bRelatorio.TabIndex = 12;
            this.bRelatorio.Text = "Ordenar";
            this.bRelatorio.UseVisualStyleBackColor = true;
            this.bRelatorio.Click += new System.EventHandler(this.bRelatorio_Click);
            // 
            // bAdicionar
            // 
            this.bAdicionar.Location = new System.Drawing.Point(200, 81);
            this.bAdicionar.Name = "bAdicionar";
            this.bAdicionar.Size = new System.Drawing.Size(75, 23);
            this.bAdicionar.TabIndex = 11;
            this.bAdicionar.Text = "Adicionar";
            this.bAdicionar.UseVisualStyleBackColor = true;
            this.bAdicionar.Click += new System.EventHandler(this.bAdicionar_Click);
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(217, 55);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(100, 20);
            this.txValor.TabIndex = 10;
            // 
            // lValor
            // 
            this.lValor.AutoSize = true;
            this.lValor.Location = new System.Drawing.Point(176, 55);
            this.lValor.Name = "lValor";
            this.lValor.Size = new System.Drawing.Size(31, 13);
            this.lValor.TabIndex = 9;
            this.lValor.Text = "Valor";
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(12, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(221, 22);
            this.lTitle.TabIndex = 8;
            this.lTitle.Text = "Tabela de Valores (Matriz)";
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
            this.dgTable.Location = new System.Drawing.Point(12, 46);
            this.dgTable.Name = "dgTable";
            this.dgTable.RowHeadersVisible = false;
            this.dgTable.Size = new System.Drawing.Size(158, 150);
            this.dgTable.TabIndex = 7;
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
            // T13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 226);
            this.Controls.Add(this.bRelatorio);
            this.Controls.Add(this.bAdicionar);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.lValor);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.dgTable);
            this.Name = "T13";
            this.Text = "T13";
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRelatorio;
        private System.Windows.Forms.Button bAdicionar;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.Label lValor;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.DataGridView dgTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}