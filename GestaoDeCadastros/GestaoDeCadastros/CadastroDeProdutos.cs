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
        }

        private void CadastroDeProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_novo_produto_Click(object sender, EventArgs e)
        {
            string novoNome = txt_novo_produto.Text.Trim();
            string novoPreco = txt_novo_preco.ToString().Trim();
            string novaDescricao = txt_nova_descricao.Text.Trim();


            if (string.IsNullOrEmpty(novoNome) || string.IsNullOrEmpty(novoPreco) || string.IsNullOrEmpty(novaDescricao))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
           

            functions.AdicionarProduto(novoNome, Convert.ToDouble(novoPreco), novaDescricao);

        }
    }
}
