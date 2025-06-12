namespace GestaoDeCadastros
{
    partial class homePage
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
            lbl_userNameInHompage = new Label();
            menuStrip1 = new MenuStrip();
            cadastrarUsuarioNavbar = new ToolStripMenuItem();
            cadastrarClientesNavbar = new ToolStripMenuItem();
            cadastrarPedidosNavbar = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            cadastrarProdutosNavbar = new ToolStripMenuItem();
            dataGridView_produtos = new DataGridView();
            dataGridView_pedidos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            pesquisar_pedidos_navbar = new ToolStripMenuItem();
            btn_Excluir_Pedidos = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_produtos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_pedidos).BeginInit();
            SuspendLayout();
            // 
            // lbl_userNameInHompage
            // 
            lbl_userNameInHompage.AutoSize = true;
            lbl_userNameInHompage.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_userNameInHompage.Location = new Point(22, 53);
            lbl_userNameInHompage.Name = "lbl_userNameInHompage";
            lbl_userNameInHompage.Size = new Size(94, 31);
            lbl_userNameInHompage.TabIndex = 0;
            lbl_userNameInHompage.Text = "Usuário";
            lbl_userNameInHompage.Click += lbl_userNameInHompage_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarUsuarioNavbar, cadastrarClientesNavbar, cadastrarPedidosNavbar, toolStripMenuItem1, cadastrarProdutosNavbar, pesquisar_pedidos_navbar });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarUsuarioNavbar
            // 
            cadastrarUsuarioNavbar.Name = "cadastrarUsuarioNavbar";
            cadastrarUsuarioNavbar.Size = new Size(140, 24);
            cadastrarUsuarioNavbar.Text = "Cadastrar Usuario";
            cadastrarUsuarioNavbar.Click += cadastrarUsuarioNavbar_Click;
            // 
            // cadastrarClientesNavbar
            // 
            cadastrarClientesNavbar.Name = "cadastrarClientesNavbar";
            cadastrarClientesNavbar.Size = new Size(142, 24);
            cadastrarClientesNavbar.Text = "Cadastrar Clientes";
            cadastrarClientesNavbar.Click += cadastrarClientesNavbar_Click;
            // 
            // cadastrarPedidosNavbar
            // 
            cadastrarPedidosNavbar.Name = "cadastrarPedidosNavbar";
            cadastrarPedidosNavbar.Size = new Size(142, 24);
            cadastrarPedidosNavbar.Text = "Cadastrar Pedidos";
            cadastrarPedidosNavbar.Click += cadastrarPedidosNavbar_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // cadastrarProdutosNavbar
            // 
            cadastrarProdutosNavbar.Name = "cadastrarProdutosNavbar";
            cadastrarProdutosNavbar.Size = new Size(149, 24);
            cadastrarProdutosNavbar.Text = "Cadastrar Produtos";
            cadastrarProdutosNavbar.Click += cadastrarProdutosNavbar_Click;
            // 
            // dataGridView_produtos
            // 
            dataGridView_produtos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView_produtos.ColumnHeadersHeight = 29;
            dataGridView_produtos.Location = new Point(22, 132);
            dataGridView_produtos.Name = "dataGridView_produtos";
            dataGridView_produtos.RowHeadersWidth = 51;
            dataGridView_produtos.Size = new Size(869, 633);
            dataGridView_produtos.TabIndex = 2;
            // 
            // dataGridView_pedidos
            // 
            dataGridView_pedidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView_pedidos.ColumnHeadersHeight = 29;
            dataGridView_pedidos.Location = new Point(937, 132);
            dataGridView_pedidos.Name = "dataGridView_pedidos";
            dataGridView_pedidos.RowHeadersWidth = 51;
            dataGridView_pedidos.Size = new Size(930, 633);
            dataGridView_pedidos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 99);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 4;
            label1.Text = "Visualizar Produtos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(937, 99);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 5;
            label2.Text = "Visualizar Pedidos";
            // 
            // pesquisar_pedidos_navbar
            // 
            pesquisar_pedidos_navbar.Name = "pesquisar_pedidos_navbar";
            pesquisar_pedidos_navbar.Size = new Size(140, 24);
            pesquisar_pedidos_navbar.Text = "Pesquisar Pedidos";
            // 
            // btn_Excluir_Pedidos
            // 
            btn_Excluir_Pedidos.BackColor = Color.Red;
            btn_Excluir_Pedidos.Location = new Point(1750, 87);
            btn_Excluir_Pedidos.Name = "btn_Excluir_Pedidos";
            btn_Excluir_Pedidos.Size = new Size(117, 32);
            btn_Excluir_Pedidos.TabIndex = 22;
            btn_Excluir_Pedidos.Text = "Excluir";
            btn_Excluir_Pedidos.UseVisualStyleBackColor = false;
            // 
            // homePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btn_Excluir_Pedidos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView_pedidos);
            Controls.Add(dataGridView_produtos);
            Controls.Add(lbl_userNameInHompage);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "homePage";
            Text = "homePage";
            WindowState = FormWindowState.Maximized;
            Load += homePage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_produtos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_pedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_userNameInHompage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarUsuarioNavbar;
        private ToolStripMenuItem cadastrarClientesNavbar;
        private ToolStripMenuItem cadastrarPedidosNavbar;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem cadastrarProdutosNavbar;
        private DataGridView dataGridView_produtos;
        private DataGridView dataGridView_pedidos;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem pesquisar_pedidos_navbar;
        private Button btn_Excluir_Pedidos;
    }
}