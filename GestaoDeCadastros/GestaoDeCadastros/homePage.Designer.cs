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
            cadastrarProdutosNavbar = new ToolStripMenuItem();
            cadastrarPedidosNavbar = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarUsuarioNavbar, cadastrarClientesNavbar, cadastrarProdutosNavbar, cadastrarPedidosNavbar });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
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
            // 
            // cadastrarProdutosNavbar
            // 
            cadastrarProdutosNavbar.Name = "cadastrarProdutosNavbar";
            cadastrarProdutosNavbar.Size = new Size(149, 24);
            cadastrarProdutosNavbar.Text = "Cadastrar Produtos";
            cadastrarProdutosNavbar.Click += cadastrarPedidosToolStripMenuItem_Click;
            // 
            // cadastrarPedidosNavbar
            // 
            cadastrarPedidosNavbar.Name = "cadastrarPedidosNavbar";
            cadastrarPedidosNavbar.Size = new Size(142, 24);
            cadastrarPedidosNavbar.Text = "Cadastrar Pedidos";
            // 
            // homePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_userNameInHompage);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "homePage";
            Text = "homePage";
            Load += homePage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_userNameInHompage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarUsuarioNavbar;
        private ToolStripMenuItem cadastrarClientesNavbar;
        private ToolStripMenuItem cadastrarProdutosNavbar;
        private ToolStripMenuItem cadastrarPedidosNavbar;
    }
}