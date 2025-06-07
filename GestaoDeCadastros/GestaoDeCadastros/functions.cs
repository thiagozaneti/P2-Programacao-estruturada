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
        public static string CaminhoUsuarioLogado = @"C:\Users\Public\Documents\usuario_logado.txt";



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
                    File.WriteAllText(CaminhoUsuarioLogado, usuario.Trim());
                    return true; // Login bem-sucedido
                }
            }
            return false; // Login falhou
        }
        //-------------------------//


        //funcao para salvar o usuário logado
        public static string ObterUsuarioLogado()
        {
            if (File.Exists(CaminhoUsuarioLogado))
            {
                return File.ReadAllText(CaminhoUsuarioLogado).Trim();
            }
            return "";
        }

        public static void Logout()
        {
            if (File.Exists(CaminhoUsuarioLogado))
            {
                File.Delete(CaminhoUsuarioLogado);
            }
        }
        //-------------------------//



        public static void AdicionarUsuario(string usuario, string senha)
        {
            // Verifica se o arquivo existe
            if (!File.Exists(caminhoArquivoCsvUsuarios))
            {
                CriarArquivosSeNaoExistir();
            }
            using(StreamWriter sw = new StreamWriter(caminhoArquivoCsvUsuarios, true))
            {
                // Adiciona o novo usuário ao arquivo CSV
                sw.WriteLine($"{usuario}, {senha}");
            }
        }

    }
}
