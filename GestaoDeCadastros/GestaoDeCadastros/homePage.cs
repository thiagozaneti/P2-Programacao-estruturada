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

    public partial class homePage : Form
    {

        CadastroDeUsuarios paginaDeCadastroDeUsuario = new CadastroDeUsuarios();
        CadastroDeProdutos paginaDeCadastroDeProdutos = new CadastroDeProdutos();
        CadastroDeClientes paginaDeCadastroDeClientes = new CadastroDeClientes();
        CadastroDePedidos paginaDeCadastroDePedidos = new CadastroDePedidos();
        public string userNameInHomepage = "";

        public homePage()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            dataGridView_pedidos.DataSource = functions.LerDatabasePedidos(); // Carrega os pedidos no DataGridView ao iniciar a homePage
            dataGridView_produtos.DataSource = functions.LerDatabaseProduto();
        }


        private void homePage_Load(object sender, EventArgs e)
        {
            lbl_userNameInHompage.Text = $"Bem vindo {userNameInHomepage}"; //exibindo o nome do usuário na homePage
        }

        private void lbl_userNameInHompage_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarUsuarioNavbar_Click(object sender, EventArgs e)
        {
            paginaDeCadastroDeUsuario.ShowDialog(); //exibindo a pagina de cadastro de usuario
        }

        private void cadastrarPedidosNavbar_Click(object sender, EventArgs e)
        {
            paginaDeCadastroDePedidos.ShowDialog(); //exibindo a pagina de cadastro de pedidos
        }

        private void cadastrarProdutosNavbar_Click(object sender, EventArgs e)
        {
            paginaDeCadastroDeProdutos.ShowDialog(); //exibindo a pagina de cadastro de produtos
        }

        private void cadastrarClientesNavbar_Click(object sender, EventArgs e)
        {
            paginaDeCadastroDeClientes.ShowDialog(); //exibindo a pagina de cadastro de clientes
        }

        private void btn_Excluir_Pedidos_Click(object sender, EventArgs e)
        {
            // Verifica se existe alguma linha selecionada
            if (dataGridView_pedidos.SelectedRows.Count > 0)
            {
                string pedido = dataGridView_pedidos.SelectedRows[0].Cells[0].Value?.ToString();
                // Confirma exclusão
                var confirm = MessageBox.Show($"Tem certeza que deseja excluir o pedido '{pedido}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    functions.RemoverPedido(pedido);
                    MessageBox.Show("Usuário excluído com sucesso!");
                    // Atualiza o DataGridView
                    dataGridView_pedidos.DataSource = functions.LerDatabaseUsuario();
                }
            }
            else
            {
                MessageBox.Show("Selecione um pedido para excluir.");
            }
        }
    }
}
