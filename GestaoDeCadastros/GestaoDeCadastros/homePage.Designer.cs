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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarUsuarioNavbar, cadastrarClientesNavbar, cadastrarPedidosNavbar, toolStripMenuItem1, cadastrarProdutosNavbar });
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
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(22, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(869, 633);
            dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeight = 29;
            dataGridView2.Location = new Point(937, 132);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(930, 633);
            dataGridView2.TabIndex = 3;
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
            // homePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_userNameInHompage);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "homePage";
            Text = "homePage";
            WindowState = FormWindowState.Maximized;
            Load += homePage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
    }
}