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
    public partial class CadastroDeProdutos : Form
    {
        public CadastroDeProdutos()
        {
            InitializeComponent();
            dataGridView_Produto.DataSource = functions.LerDatabaseProduto();
        }

        private void CadastroDeProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_novo_produto_Click(object sender, EventArgs e)
        {
            string novoNomeProduto = txt_novo_produto.Text.Trim();
            string novoPreco = txt_novo_preco.Text.Trim().Replace("R$", "").Replace(" ", "").Replace(",", ".");
            string novaDescricao = txt_nova_descricao.Text.Trim();

            if (string.IsNullOrEmpty(novoNomeProduto) || string.IsNullOrEmpty(novoPreco) || string.IsNullOrEmpty(novaDescricao))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            //conversão do preço para double - net
            if (!double.TryParse(novoPreco, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double precoDouble))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            functions.AdicionarProduto(novoNomeProduto, precoDouble, novaDescricao);

            MessageBox.Show("Produto cadastrado com sucesso");
            txt_novo_produto.Clear();
            txt_novo_preco.Clear();
            txt_nova_descricao.Clear();
            dataGridView_Produto.DataSource = functions.LerDatabaseProduto(); // Atualiza o DataGridView com os produtos cadastrados
        }

    }
}
