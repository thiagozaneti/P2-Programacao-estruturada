namespace GestaoDeCadastros
{
    partial class CadastroDeProdutos
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
            btn_Excluir_Produto = new Button();
            dataGridView_Produto = new DataGridView();
            btn_cadastrar_novo_produto = new Button();
            txt_novo_preco = new TextBox();
            txt_novo_produto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_nova_descricao = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produto).BeginInit();
            SuspendLayout();
            // 
            // btn_Excluir_Produto
            // 
            btn_Excluir_Produto.BackColor = Color.Red;
            btn_Excluir_Produto.Location = new Point(649, 18);
            btn_Excluir_Produto.Name = "btn_Excluir_Produto";
            btn_Excluir_Produto.Size = new Size(117, 32);
            btn_Excluir_Produto.TabIndex = 21;
            btn_Excluir_Produto.Text = "Excluir";
            btn_Excluir_Produto.UseVisualStyleBackColor = false;
            // 
            // dataGridView_Produto
            // 
            dataGridView_Produto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Produto.Location = new Point(270, 56);
            dataGridView_Produto.Name = "dataGridView_Produto";
            dataGridView_Produto.RowHeadersWidth = 51;
            dataGridView_Produto.Size = new Size(496, 306);
            dataGridView_Produto.TabIndex = 20;
            // 
            // btn_cadastrar_novo_produto
            // 
            btn_cadastrar_novo_produto.Location = new Point(35, 283);
            btn_cadastrar_novo_produto.Name = "btn_cadastrar_novo_produto";
            btn_cadastrar_novo_produto.Size = new Size(94, 29);
            btn_cadastrar_novo_produto.TabIndex = 19;
            btn_cadastrar_novo_produto.Text = "Cadastrar";
            btn_cadastrar_novo_produto.UseVisualStyleBackColor = true;
            btn_cadastrar_novo_produto.Click += btn_cadastrar_novo_produto_Click;
            // 
            // txt_novo_preco
            // 
            txt_novo_preco.Location = new Point(35, 142);
            txt_novo_preco.Name = "txt_novo_preco";
            txt_novo_preco.Size = new Size(125, 27);
            txt_novo_preco.TabIndex = 15;
            // 
            // txt_novo_produto
            // 
            txt_novo_produto.Location = new Point(35, 70);
            txt_novo_produto.Name = "txt_novo_produto";
            txt_novo_produto.Size = new Size(125, 27);
            txt_novo_produto.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 119);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 13;
            label3.Text = "Preço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 47);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 12;
            label2.Text = "Nome do Produto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 18);
            label1.Name = "label1";
            label1.Size = new Size(210, 20);
            label1.TabIndex = 11;
            label1.Text = "CADASTRAR NOVO PRODUTO";
            // 
            // txt_nova_descricao
            // 
            txt_nova_descricao.Location = new Point(35, 225);
            txt_nova_descricao.Name = "txt_nova_descricao";
            txt_nova_descricao.Size = new Size(125, 27);
            txt_nova_descricao.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 202);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 22;
            label4.Text = "Descrição";
            // 
            // CadastroDeProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_nova_descricao);
            Controls.Add(label4);
            Controls.Add(btn_Excluir_Produto);
            Controls.Add(dataGridView_Produto);
            Controls.Add(btn_cadastrar_novo_produto);
            Controls.Add(txt_novo_preco);
            Controls.Add(txt_novo_produto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroDeProdutos";
            Text = "CadastroDeProdutos";
            Load += CadastroDeProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Excluir_Produto;
        private DataGridView dataGridView_Produto;
        private Button btn_cadastrar_novo_produto;
        private TextBox txt_novo_preco;
        private TextBox txt_novo_produto;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_nova_descricao;
        private Label label4;
    }
}