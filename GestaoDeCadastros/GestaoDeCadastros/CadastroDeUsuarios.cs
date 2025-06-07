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
            dataGridView_Admin.DataSource = functions.LerDatabaseUsuario();
        }

        private void CadastroDeUsuarios_Load(object sender, EventArgs e)
        {
            if (functions.ObterUsuarioLogado() != "ADMIN")
            {
                // Esconder campos de admin para usuários comuns
                label2.Visible = false;
                label3.Visible = false;
                btn_Excluir_Usuario.Visible = false;
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
            string novoUsuario = txt_novo_usuario.Text.Trim();
            string novaSenha = txt_nova_senha.Text.Trim();

            if (string.IsNullOrEmpty(novoUsuario) || string.IsNullOrEmpty(novaSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            functions.AdicionarUsuario(novoUsuario, novaSenha);
            MessageBox.Show("Usuário cadastrado com sucesso!");
            // Limpar os campos após o cadastro
            txt_novo_usuario.Clear();
            txt_nova_senha.Clear();
            // Atualizar o DataGridView
            dataGridView_Admin.DataSource = functions.LerDatabaseUsuario();
        }

        private void btn_Excluir_Usuario_Click(object sender, EventArgs e)
        {
            // Verifica se existe alguma linha selecionada
            if (dataGridView_Admin.SelectedRows.Count > 0)
            {
                // Obtém o nome do usuário da primeira célula da linha selecionada
                string usuario = dataGridView_Admin.SelectedRows[0].Cells[0].Value?.ToString();
                // Não permitir excluir o ADMIN
                if (usuario == "ADMIN")
                {
                    MessageBox.Show("Não é permitido excluir o usuário ADMIN!");
                    return;
                }
                // Confirma exclusão
                var confirm = MessageBox.Show($"Tem certeza que deseja excluir o usuário '{usuario}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    functions.RemoverUsuario(usuario);
                    MessageBox.Show("Usuário excluído com sucesso!");
                    // Atualiza o DataGridView
                    dataGridView_Admin.DataSource = functions.LerDatabaseUsuario();
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário para excluir.");
            }
        }

    }
}
