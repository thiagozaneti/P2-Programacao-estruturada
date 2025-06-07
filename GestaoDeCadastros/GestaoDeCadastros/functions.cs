using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeCadastros
{
    class functions
    {
        public static string caminhoArquivoCsvUsuarios = @"C:\Users\Public\Documents\users.csv";
        public static string caminhoArquivoCsvClientes = @"C:\Users\Public\Documents\clients.csv";
        public static string caminhoArquivoCsvProdutos = @"C:\Users\Public\Documents\products.csv";
        public static string caminhoArquivoCsvPedidos = @"C:\Users\Public\Documents\orders.txt";



        //essa função cria os arquivos se não existirem
        public static void CriarArquivosSeNaoExistir()
        {
            string pastaDestino = @"C:\Users\Public\Documents";


            // Caminho para o arquivo de usuários
            if (!Directory.Exists(pastaDestino))
            {
                Directory.CreateDirectory(pastaDestino);
            }

            // Cria arquivo de usuários se não existir
            if (!File.Exists(caminhoArquivoCsvUsuarios))
            {
                using (StreamWriter sw = new StreamWriter(caminhoArquivoCsvUsuarios))
                {
                    sw.WriteLine("usuario, senha");
                    sw.WriteLine("ADMIN, 123");
                }
            }
            if (!File.Exists(caminhoArquivoCsvClientes))
            {
                using (StreamWriter sw = new StreamWriter(caminhoArquivoCsvClientes))
                {
                    sw.WriteLine("Nome, CPF, Email, CEP, Logradouro, Numero, Bairro, Cidade, Estado, Telefone, Whatsapp");
                    
                }
            }
            if (!File.Exists(caminhoArquivoCsvProdutos))
            {
                using (StreamWriter sw = new StreamWriter(caminhoArquivoCsvProdutos))
                {
                    sw.WriteLine("Nome, Descricao, Preco");
                }
            }
            if (!File.Exists(caminhoArquivoCsvPedidos))
            {
                using (StreamWriter sw = new StreamWriter(caminhoArquivoCsvPedidos))
                {
                    sw.WriteLine("CPF, Produto, Quantidade, Total");
                }
            }


        }

        //------------------------//




        //funcao de login
        public static bool EfetuarLogin(string usuario, string senha)
        {
            // Lê o arquivo CSV de usuários
            string[] linhas = File.ReadAllLines(caminhoArquivoCsvUsuarios);
            // Verifica se o usuário e senha estão corretos
            foreach (string linha in linhas.Skip(1)) // Pula o cabeçalho
            {
                string[] partes = linha.Split(',');
                if (partes.Length >= 2 && partes[0].Trim() == usuario && partes[1].Trim() == senha)
                {
                    return true; // Login bem-sucedido
                }
            }
            return false; // Login falhou
        }
        //-------------------------//



    }
}
