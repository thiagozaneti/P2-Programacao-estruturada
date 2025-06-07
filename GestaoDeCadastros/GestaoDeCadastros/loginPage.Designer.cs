namespace GestaoDeCadastros
{
    partial class loginPage
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
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 63);
            label1.Name = "label1";
            label1.Size = new Size(479, 54);
            label1.TabIndex = 0;
            label1.Text = "GESTÃO DE CADASTROS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 183);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 278);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(239, 206);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(285, 27);
            txt_usuario.TabIndex = 3;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(239, 301);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(285, 27);
            txt_senha.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(282, 346);
            button1.Name = "button1";
            button1.Size = new Size(199, 44);
            button1.TabIndex = 5;
            button1.Text = "Logar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "loginPage";
            Text = "loginPage";
            Load += loginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Button button1;
    }
}