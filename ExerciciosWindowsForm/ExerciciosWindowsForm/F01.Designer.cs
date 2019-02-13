namespace ExerciciosWindowsForm
{
    partial class F01
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
            this.grtaProdutos = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labProduto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.bProduto = new System.Windows.Forms.Button();
            this.lResultadoId = new System.Windows.Forms.Label();
            this.lIdResultado = new System.Windows.Forms.Label();
            this.lResultadoProduto = new System.Windows.Forms.Label();
            this.lProdutoResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grtaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grtaProdutos
            // 
            this.grtaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grtaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Produto});
            this.grtaProdutos.Location = new System.Drawing.Point(58, 12);
            this.grtaProdutos.Name = "grtaProdutos";
            this.grtaProdutos.Size = new System.Drawing.Size(240, 150);
            this.grtaProdutos.TabIndex = 0;
            // 
            // Código
            // 
            this.Código.HeaderText = "Id";
            this.Código.Name = "Código";
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // labProduto
            // 
            this.labProduto.AutoSize = true;
            this.labProduto.Location = new System.Drawing.Point(58, 206);
            this.labProduto.Name = "labProduto";
            this.labProduto.Size = new System.Drawing.Size(61, 13);
            this.labProduto.TabIndex = 1;
            this.labProduto.Text = "Produto(id):";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(58, 223);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(159, 20);
            this.txtProduto.TabIndex = 2;
            // 
            // bProduto
            // 
            this.bProduto.Location = new System.Drawing.Point(223, 220);
            this.bProduto.Name = "bProduto";
            this.bProduto.Size = new System.Drawing.Size(75, 23);
            this.bProduto.TabIndex = 3;
            this.bProduto.Text = "Procurar";
            this.bProduto.UseVisualStyleBackColor = true;
            this.bProduto.Click += new System.EventHandler(this.bProduto_Click);
            // 
            // lResultadoId
            // 
            this.lResultadoId.AutoSize = true;
            this.lResultadoId.Location = new System.Drawing.Point(58, 281);
            this.lResultadoId.Name = "lResultadoId";
            this.lResultadoId.Size = new System.Drawing.Size(19, 13);
            this.lResultadoId.TabIndex = 4;
            this.lResultadoId.Text = "Id:";
            // 
            // lIdResultado
            // 
            this.lIdResultado.AutoSize = true;
            this.lIdResultado.Location = new System.Drawing.Point(141, 280);
            this.lIdResultado.Name = "lIdResultado";
            this.lIdResultado.Size = new System.Drawing.Size(0, 13);
            this.lIdResultado.TabIndex = 5;
            // 
            // lResultadoProduto
            // 
            this.lResultadoProduto.AutoSize = true;
            this.lResultadoProduto.Location = new System.Drawing.Point(58, 321);
            this.lResultadoProduto.Name = "lResultadoProduto";
            this.lResultadoProduto.Size = new System.Drawing.Size(47, 13);
            this.lResultadoProduto.TabIndex = 6;
            this.lResultadoProduto.Text = "Produto:";
            // 
            // lProdutoResultado
            // 
            this.lProdutoResultado.AutoSize = true;
            this.lProdutoResultado.Location = new System.Drawing.Point(144, 320);
            this.lProdutoResultado.Name = "lProdutoResultado";
            this.lProdutoResultado.Size = new System.Drawing.Size(0, 13);
            this.lProdutoResultado.TabIndex = 7;
            // 
            // F01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 391);
            this.Controls.Add(this.lProdutoResultado);
            this.Controls.Add(this.lResultadoProduto);
            this.Controls.Add(this.lIdResultado);
            this.Controls.Add(this.lResultadoId);
            this.Controls.Add(this.bProduto);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.labProduto);
            this.Controls.Add(this.grtaProdutos);
            this.Name = "F01";
            this.Text = "F01";
            ((System.ComponentModel.ISupportInitialize)(this.grtaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grtaProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.Label labProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button bProduto;
        private System.Windows.Forms.Label lResultadoId;
        private System.Windows.Forms.Label lIdResultado;
        private System.Windows.Forms.Label lResultadoProduto;
        private System.Windows.Forms.Label lProdutoResultado;
    }
}