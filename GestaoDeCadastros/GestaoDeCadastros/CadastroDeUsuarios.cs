using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeCadastros
{
    public partial class CadastroDeUsuarios : Form
    {
        public CadastroDeUsuarios()
        {
            InitializeComponent();
        }

        private void CadastroDeUsuarios_Load(object sender, EventArgs e)
        {
            if (functions.ObterUsuarioLogado() != "ADMIN")
            {
                // Esconder campos de admin para usuários comuns

                txt_novo_usuario.Visible = false;
                txt_nova_senha.Visible = false;
                btn_cadastrar_novo_usuario.Visible = false;
                dataGridView_Admin.Visible = false;

                // Mostrar campos do usuário comum
                txt_alterar_senha_usuario_comum.Visible = true;
                btn_alterar_senha_usuario_comum.Visible = true;
            }
            else
            {
                // Mostrar campos de admin
                txt_novo_usuario.Visible = true;
                txt_nova_senha.Visible = true;
                btn_cadastrar_novo_usuario.Visible = true;
                dataGridView_Admin.Visible = true;

                // Esconder campos do usuário comum
                lbl_aviso_de_usuario_comum.Visible = false;
                txt_alterar_senha_usuario_comum.Visible = false;
                btn_alterar_senha_usuario_comum.Visible = false;
            }
        }

        private void btn_cadastrar_novo_usuario_Click(object sender, EventArgs e)
        {
            

        }
    }
}
