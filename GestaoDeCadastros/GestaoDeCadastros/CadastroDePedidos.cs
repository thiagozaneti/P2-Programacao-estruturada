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

    }
}
