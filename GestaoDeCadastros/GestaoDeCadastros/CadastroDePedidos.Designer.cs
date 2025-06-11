namespace GestaoDeCadastros
{
    partial class CadastroDePedidos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_cpf_cliente_busca = new TextBox();
            txt_quantidade_produtos = new TextBox();
            btn_pesquisar_cpf = new Button();
            label5 = new Label();
            comboBox_produtos = new ComboBox();
            btn_adicionar_pedido = new Button();
            dataGridView_Pedidos = new DataGridView();
            label6 = new Label();
            lbl_total_Pedido = new Label();
            lbl_cliente = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Pedidos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 44);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "CPF do cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 9);
            label2.Name = "label2";
            label2.Size = new Size(196, 20);
            label2.TabIndex = 12;
            label2.Text = "CADASTRAR NOVO PEDIDO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 117);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 13;
            label3.Text = "Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 120);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 14;
            label4.Text = "Quantidade do produto";
            // 
            // txt_cpf_cliente_busca
            // 
            txt_cpf_cliente_busca.Location = new Point(142, 44);
            txt_cpf_cliente_busca.Name = "txt_cpf_cliente_busca";
            txt_cpf_cliente_busca.Size = new Size(196, 27);
            txt_cpf_cliente_busca.TabIndex = 15;
            // 
            // txt_quantidade_produtos
            // 
            txt_quantidade_produtos.Location = new Point(486, 117);
            txt_quantidade_produtos.Name = "txt_quantidade_produtos";
            txt_quantidade_produtos.Size = new Size(196, 27);
            txt_quantidade_produtos.TabIndex = 17;
            // 
            // btn_pesquisar_cpf
            // 
            btn_pesquisar_cpf.Location = new Point(356, 40);
            btn_pesquisar_cpf.Name = "btn_pesquisar_cpf";
            btn_pesquisar_cpf.Size = new Size(124, 34);
            btn_pesquisar_cpf.TabIndex = 18;
            btn_pesquisar_cpf.Text = "Pesquisar";
            btn_pesquisar_cpf.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 77);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 19;
            label5.Text = "cliente:";
            // 
            // comboBox_produtos
            // 
            comboBox_produtos.FormattingEnabled = true;
            comboBox_produtos.Location = new Point(101, 117);
            comboBox_produtos.Name = "comboBox_produtos";
            comboBox_produtos.Size = new Size(196, 28);
            comboBox_produtos.TabIndex = 20;
            // 
            // btn_adicionar_pedido
            // 
            btn_adicionar_pedido.Location = new Point(688, 115);
            btn_adicionar_pedido.Name = "btn_adicionar_pedido";
            btn_adicionar_pedido.Size = new Size(100, 29);
            btn_adicionar_pedido.TabIndex = 21;
            btn_adicionar_pedido.Text = "Adicionar Pedido";
            btn_adicionar_pedido.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Pedidos
            // 
            dataGridView_Pedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Pedidos.Location = new Point(33, 168);
            dataGridView_Pedidos.Name = "dataGridView_Pedidos";
            dataGridView_Pedidos.RowHeadersWidth = 51;
            dataGridView_Pedidos.Size = new Size(755, 257);
            dataGridView_Pedidos.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 456);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 23;
            label6.Text = "Total do pedido:";
            // 
            // lbl_total_Pedido
            // 
            lbl_total_Pedido.AutoSize = true;
            lbl_total_Pedido.Location = new Point(164, 456);
            lbl_total_Pedido.Name = "lbl_total_Pedido";
            lbl_total_Pedido.Size = new Size(17, 20);
            lbl_total_Pedido.TabIndex = 24;
            lbl_total_Pedido.Text = "0";
            // 
            // lbl_cliente
            // 
            lbl_cliente.AutoSize = true;
            lbl_cliente.Location = new Point(95, 77);
            lbl_cliente.Name = "lbl_cliente";
            lbl_cliente.Size = new Size(45, 20);
            lbl_cliente.TabIndex = 25;
            lbl_cliente.Text = "None";
            // 
            // CadastroDePedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 524);
            Controls.Add(lbl_cliente);
            Controls.Add(lbl_total_Pedido);
            Controls.Add(label6);
            Controls.Add(dataGridView_Pedidos);
            Controls.Add(btn_adicionar_pedido);
            Controls.Add(comboBox_produtos);
            Controls.Add(label5);
            Controls.Add(btn_pesquisar_cpf);
            Controls.Add(txt_quantidade_produtos);
            Controls.Add(txt_cpf_cliente_busca);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroDePedidos";
            Text = "CadastroDePedidos";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Pedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_cpf_cliente_busca;
        private TextBox txt_quantidade_produtos;
        private Button btn_pesquisar_cpf;
        private Label label5;
        private ComboBox comboBox_produtos;
        private Button btn_adicionar_pedido;
        private DataGridView dataGridView_Pedidos;
        private Label label6;
        private Label lbl_total_Pedido;
        private Label lbl_cliente;
    }
}