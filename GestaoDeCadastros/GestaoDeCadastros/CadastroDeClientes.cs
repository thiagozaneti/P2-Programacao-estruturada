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
