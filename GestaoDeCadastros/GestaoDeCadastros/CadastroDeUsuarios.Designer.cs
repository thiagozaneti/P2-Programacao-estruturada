namespace GestaoDeCadastros
{
    partial class CadastroDeUsuarios
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
            txt_novo_usuario = new TextBox();
            txt_nova_senha = new TextBox();
            txt_alterar_senha_usuario_comum = new TextBox();
            lbl_aviso_de_usuario_comum = new Label();
            btn_alterar_senha_usuario_comum = new Button();
            btn_cadastrar_novo_usuario = new Button();
            dataGridView_Admin = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Admin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(205, 20);
            label1.TabIndex = 0;
            label1.Text = "CADASTRAR NOVO USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 186);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 258);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // txt_novo_usuario
            // 
            txt_novo_usuario.Location = new Point(26, 209);
            txt_novo_usuario.Name = "txt_novo_usuario";
            txt_novo_usuario.Size = new Size(125, 27);
            txt_novo_usuario.TabIndex = 3;
            // 
            // txt_nova_senha
            // 
            txt_nova_senha.Location = new Point(26, 281);
            txt_nova_senha.Name = "txt_nova_senha";
            txt_nova_senha.Size = new Size(125, 27);
            txt_nova_senha.TabIndex = 4;
            // 
            // txt_alterar_senha_usuario_comum
            // 
            txt_alterar_senha_usuario_comum.Location = new Point(26, 84);
            txt_alterar_senha_usuario_comum.Name = "txt_alterar_senha_usuario_comum";
            txt_alterar_senha_usuario_comum.Size = new Size(125, 27);
            txt_alterar_senha_usuario_comum.TabIndex = 5;
            // 
            // lbl_aviso_de_usuario_comum
            // 
            lbl_aviso_de_usuario_comum.AutoSize = true;
            lbl_aviso_de_usuario_comum.Location = new Point(26, 61);
            lbl_aviso_de_usuario_comum.Name = "lbl_aviso_de_usuario_comum";
            lbl_aviso_de_usuario_comum.Size = new Size(374, 20);
            lbl_aviso_de_usuario_comum.TabIndex = 6;
            lbl_aviso_de_usuario_comum.Text = "Você possui propriedade apenas para alterar sua senha";
            // 
            // btn_alterar_senha_usuario_comum
            // 
            btn_alterar_senha_usuario_comum.Location = new Point(26, 117);
            btn_alterar_senha_usuario_comum.Name = "btn_alterar_senha_usuario_comum";
            btn_alterar_senha_usuario_comum.Size = new Size(125, 29);
            btn_alterar_senha_usuario_comum.TabIndex = 7;
            btn_alterar_senha_usuario_comum.Text = "Alterar Senha";
            btn_alterar_senha_usuario_comum.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar_novo_usuario
            // 
            btn_cadastrar_novo_usuario.Location = new Point(26, 331);
            btn_cadastrar_novo_usuario.Name = "btn_cadastrar_novo_usuario";
            btn_cadastrar_novo_usuario.Size = new Size(94, 29);
            btn_cadastrar_novo_usuario.TabIndex = 8;
            btn_cadastrar_novo_usuario.Text = "Cadastrar";
            btn_cadastrar_novo_usuario.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Admin
            // 
            dataGridView_Admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Admin.Location = new Point(261, 132);
            dataGridView_Admin.Name = "dataGridView_Admin";
            dataGridView_Admin.RowHeadersWidth = 51;
            dataGridView_Admin.Size = new Size(496, 306);
            dataGridView_Admin.TabIndex = 9;
            // 
            // CadastroDeUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 450);
            Controls.Add(dataGridView_Admin);
            Controls.Add(btn_cadastrar_novo_usuario);
            Controls.Add(btn_alterar_senha_usuario_comum);
            Controls.Add(lbl_aviso_de_usuario_comum);
            Controls.Add(txt_alterar_senha_usuario_comum);
            Controls.Add(txt_nova_senha);
            Controls.Add(txt_novo_usuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroDeUsuarios";
            Text = "CadastroDeUsuarios";
            Load += CadastroDeUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Admin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_novo_usuario;
        private TextBox txt_nova_senha;
        private TextBox txt_alterar_senha_usuario_comum;
        private Label lbl_aviso_de_usuario_comum;
        private Button btn_alterar_senha_usuario_comum;
        private Button btn_cadastrar_novo_usuario;
        private DataGridView dataGridView_Admin;
    }
}