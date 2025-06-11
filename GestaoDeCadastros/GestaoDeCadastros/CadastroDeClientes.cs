using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeCadastros
{
    public partial class CadastroDeClientes : Form
    {
        public string cep = "";
        public string logradouro = "";
        public string bairro = "";
        public string cidade = "";
        public string estado = "";

        public CadastroDeClientes()
        {
            InitializeComponent();
        }
        private static readonly HttpClient client = new HttpClient();

        private async Task BuscarCepViaCepAsync(string cep)
        {
            try
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                using (JsonDocument doc = JsonDocument.Parse(responseBody))
                {
                    var root = doc.RootElement;


                    logradouro = root.GetProperty("logradouro").GetString();
                    bairro = root.GetProperty("bairro").GetString();
                    cidade = root.GetProperty("localidade").GetString();
                    estado = root.GetProperty("uf").GetString();

                    MessageBox.Show(
                        $"Logradouro: {logradouro}\nBairro: {bairro}\nCidade: {cidade}\nEstado: {estado}",
                        "Endereço encontrado");
                }
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Erro na requisição GET: " + e.Message);
            }
        }

        private async void btn_cadastrar_cliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome_cliente.Text) || txt_nome_cliente.TextLength < 3)
            {
                MessageBox.Show("Por favor, insira um Nome válido ou maior que três caracteres");
            }
            if (string.IsNullOrEmpty(txt_cpf_cliente.Text) || txt_cpf_cliente.TextLength < 11)
            {
                MessageBox.Show("Por favor, insira um CPF válido");
            }
            if (string.IsNullOrEmpty(txt_email_cliente.Text))
            {
                MessageBox.Show("Por favor, insira um Email válido");
            }
            if (string.IsNullOrEmpty(txt_telefone.Text) && string.IsNullOrEmpty(txt_whatsapp.Text))
            {
                MessageBox.Show("Por favor, preencha os campos de telefone e whatsapp");
            }
            if(string.IsNullOrEmpty(txt_cep.Text) && string.IsNullOrEmpty(txt_logradouro.Text) && string.IsNullOrEmpty(txt_numero.Text)
                && string.IsNullOrEmpty(txt_bairro.Text) && string.IsNullOrEmpty(txt_cidade.Text) && string.IsNullOrEmpty(txt_estado.Text)){
                MessageBox.Show("Por favor, insira os campos de endereço");
            }
            functions.AdicionarCliente(Nome: txt_nome_cliente.Text.Trim(),
                cpf: txt_cpf_cliente.Text.Trim(),
                email: txt_email_cliente.Text.Trim(),
                telefone: txt_telefone.Text.Trim(),
                whatsapp: txt_whatsapp.Text.Trim(),
                cep: txt_cep.Text.Trim(),
                logradouro: txt_logradouro.Text.Trim(),
                numero: txt_numero.Text.Trim(),
                bairro: txt_bairro.Text.Trim(),
                cidade: txt_cidade.Text.Trim(),
                estado: txt_estado.Text.Trim());
            MessageBox.Show("Cliente cadastrado com sucesso");

            //fim das verificações

        }

        private async void btn_buscar_cep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cep.Text))
            {
                MessageBox.Show("Por favor, insira um CEP válido.");
            }
            else
            {
                await BuscarCepViaCepAsync(txt_cep.Text.Trim());
                txt_bairro.Text = bairro;
                txt_cidade.Text = cidade;
                txt_estado.Text = estado;
                txt_logradouro.Text = logradouro;
            }
        }

    }
}
