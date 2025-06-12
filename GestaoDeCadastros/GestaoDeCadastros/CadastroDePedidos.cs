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
    public partial class CadastroDePedidos : Form
    {
        public CadastroDePedidos()
        {
            InitializeComponent();
        }

        private void btn_pesquisar_cpf_Click(object sender, EventArgs e)
        {
            string cpfBusca = txt_cpf_cliente_busca.Text.Trim();
            lbl_cliente.Text = "";

            if (!File.Exists(functions.caminhoArquivoCsvClientes))
            {
                return;
            }

            //le o arquivo CSV e procura o CPF
            using (StreamReader sr = new StreamReader(functions.caminhoArquivoCsvClientes))
            {
                sr.ReadLine(); // Pular cabeçalho
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    var partes = linha.Split(',');
                    if (partes.Length >= 2 && partes[1].Trim() == cpfBusca)
                    {
                        lbl_cliente.Text = partes[0].Trim();
                        return;
                    }
                }
            }
            MessageBox.Show("Cliente não encontrado!");
        }

        //função que carrega produtos no combobox para o usuário selecionar
        private void CarregarProdutos()
        {
            comboBox_produtos.Items.Clear();
            if (!File.Exists(functions.caminhoArquivoCsvProdutos)) return;
            using (StreamReader sr = new StreamReader(functions.caminhoArquivoCsvProdutos))
            {
                sr.ReadLine(); // Pular cabeçalho
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    var partes = linha.Split(',');
                    if (partes.Length >= 2)
                        comboBox_produtos.Items.Add($"{partes[0].Trim()}|{partes[1].Trim()}");
                }
            }
        }
        private void AtualizarTotalPedido()
        {
            decimal soma = 0;
            foreach (DataGridViewRow row in dataGridView_Pedidos.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells[3].Value != null)
                    soma += decimal.Parse(row.Cells[3].Value.ToString());
            }
            lbl_total_Pedido.Text = "R$ " + soma.ToString("F2");
        }


        private void CadastroDePedidos_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void btn_adicionar_pedido_Click(object sender, EventArgs e)
        {
            if (comboBox_produtos.SelectedItem == null || string.IsNullOrWhiteSpace(txt_quantidade_produtos.Text))
            {
                MessageBox.Show("Selecione um produto e informe a quantidade");
                return;
            }

            var selecionado = comboBox_produtos.SelectedItem.ToString().Split('|');
            string nomeProduto = selecionado[0];
            decimal preco = decimal.Parse(selecionado[1]);
            int quantidade = int.Parse(txt_quantidade_produtos.Text.Trim());
            decimal totalItem = preco * quantidade;

            dataGridView_Pedidos.Rows.Add(nomeProduto, quantidade, preco.ToString("F2"), totalItem.ToString("F2"));

            AtualizarTotalPedido();
        }

        private void btn_gravar_pedido_Click(object sender, EventArgs e)
        {
            string cpf = txt_cpf_cliente_busca.Text.Trim();

            if (string.IsNullOrEmpty(cpf) || dataGridView_Pedidos.Rows.Count <= 1)
            {
                MessageBox.Show("Informe o CPF e adicione ao menos um produto");
                return;
            }

            double totalPedido = functions.CalcularTotalPedido(dataGridView_Pedidos);

            foreach (DataGridViewRow row in dataGridView_Pedidos.Rows)
            {
                if (row.IsNewRow) continue;
                string produto = row.Cells[0].Value.ToString();
                string quantidade = row.Cells[1].Value.ToString();
                string valor = row.Cells[3].Value.ToString();

                functions.AdicionarPedido(cpf, produto, quantidade, valor);
            }

            MessageBox.Show($"Pedido gravado\nValor total: R$ {totalPedido:0.00}");

            // Limpar para próximo pedido
            txt_cpf_cliente_busca.Clear();
            lbl_cliente.Text = "";
            dataGridView_Pedidos.Rows.Clear();
            lbl_total_Pedido.Text = "R$ 0,00";
        }
    }
}
