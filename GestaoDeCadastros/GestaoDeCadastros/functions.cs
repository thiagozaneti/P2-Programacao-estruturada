using System;
using System.Collections.Generic;
using System.Data;
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




        //Crud Usuario

        //funcao de adicionar usuario
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

        //funcao de leitura de arquivo usuario
        public static DataTable LerDatabaseUsuario()
        {
            DataTable dt = new DataTable();

            if (!File.Exists(caminhoArquivoCsvUsuarios)) return dt;

            using (StreamReader sr = new StreamReader(caminhoArquivoCsvUsuarios))
            {
                string linha;
                bool primeiraLinha = true;
                int numeroColunas = 0;

                while ((linha = sr.ReadLine()) != null)
                {
                    // Ignora linhas em branco
                    if (string.IsNullOrWhiteSpace(linha))
                        continue;

                    string[] campos = linha.Split(',');

                    if (primeiraLinha)
                    {
                        foreach (string col in campos)
                            dt.Columns.Add(col.Trim());
                        numeroColunas = dt.Columns.Count;
                        primeiraLinha = false;
                    }
                    else
                    {
                        // Só adiciona se a quantidade de campos for igual ao número de colunas
                        if (campos.Length == numeroColunas)
                            dt.Rows.Add(campos.Select(c => c.Trim()).ToArray());
                        
                    }
                }
            }

            return dt;
        }


        //funcao para remover usuario
        public static void RemoverUsuario(string usuario)
        {
            //verificação se o arquivo não existe
            if (!File.Exists(caminhoArquivoCsvUsuarios))
                CriarArquivosSeNaoExistir();
            //armazenar o conteúdo do arquivo em uma lista
            var linhas = File.ReadAllLines(caminhoArquivoCsvUsuarios).ToList();

            // Pular a primeira linha (cabeçalho) e regravar o arquivo
            using (StreamWriter sw = new StreamWriter(caminhoArquivoCsvUsuarios))
            {
                // Verifica se a lista não está vazia
                sw.WriteLine(linhas[0]); // Cabeçalho

                // Percorre as linhas a partir da segunda linha 
                foreach (var linha in linhas.Skip(1))
                {
                    // Divide a linha em partes 
                    string[] partes = linha.Split(',');
                    // Verifica se a linha contém pelo menos duas partes e se o usuário não é o que está sendo removido
                    if (partes.Length >= 2 && partes[0].Trim() != usuario.Trim())
                    {
                        sw.WriteLine(linha);
                    }
                }
            }
        }

        //atualizar usuario 
        



        //Crud produtos 
        
        //-----------------------------//
        //funcao de adicionar produto
        public static void AdicionarProduto(string Nome, double preco, string descricao)
        {
            // Verifica se o arquivo existe
            if (!File.Exists(caminhoArquivoCsvProdutos))
            {
                CriarArquivosSeNaoExistir();
            }
            using (StreamWriter sw = new StreamWriter(caminhoArquivoCsvProdutos, true))
            {
                // Adiciona o novo usuário ao arquivo CSV
                sw.WriteLine($"{Nome}, {preco}, {descricao}");
            }
        }
        //função de leitura do arquivo CSV de produtos
        public static DataTable LerDatabaseProduto()
        {
            DataTable dt = new DataTable();

            if (!File.Exists(caminhoArquivoCsvProdutos)) return dt;

            using (StreamReader sr = new StreamReader(caminhoArquivoCsvProdutos))
            {
                string linha;
                bool primeiraLinha = true;
                int numeroColunas = 0;

                while ((linha = sr.ReadLine()) != null)
                {
                    // Ignora linhas em branco
                    if (string.IsNullOrWhiteSpace(linha))
                        continue;

                    string[] campos = linha.Split(',');

                    if (primeiraLinha)
                    {
                        foreach (string col in campos)
                            dt.Columns.Add(col.Trim());
                        numeroColunas = dt.Columns.Count;
                        primeiraLinha = false;
                    }
                    else
                    {
                        // Só adiciona se a quantidade de campos for igual ao número de colunas
                        if (campos.Length == numeroColunas)
                            dt.Rows.Add(campos.Select(c => c.Trim()).ToArray());
                    }
                }
            }

            return dt;
        }


        public static void RemoverProduto(string usuario)
        {
            //verificação se o arquivo não existe
            if (!File.Exists(caminhoArquivoCsvProdutos))
                CriarArquivosSeNaoExistir();
            //armazenar o conteúdo do arquivo em uma lista
            var linhas = File.ReadAllLines(caminhoArquivoCsvProdutos).ToList();

            // Pular a primeira linha (cabeçalho) e regravar o arquivo
            using (StreamWriter sw = new StreamWriter(caminhoArquivoCsvProdutos))
            {
                // Verifica se a lista não está vazia
                sw.WriteLine(linhas[0]); // Cabeçalho

                // Percorre as linhas a partir da segunda linha 
                foreach (var linha in linhas.Skip(1))
                {
                    // Divide a linha em partes 
                    string[] partes = linha.Split(',');
                    // Verifica se a linha contém pelo menos duas partes e se o usuário não é o que está sendo removido
                    if (partes.Length >= 2 && partes[0].Trim() != usuario.Trim())
                    {
                        sw.WriteLine(linha);
                    }
                }
            }
        }


        //-----------------------------//




        //Crud Clientes
        public static void AdicionarCliente(string Nome, string cpf, string email, string telefone, string whatsapp, string cep,
            string logradouro, string numero, string bairro, string cidade, string estado)
        {
            // Verifica se o arquivo existe
            if (!File.Exists(caminhoArquivoCsvClientes))
            {
                CriarArquivosSeNaoExistir();
            }
            using (StreamWriter sw = new StreamWriter(caminhoArquivoCsvClientes, true))
            {
                // Adiciona o novo usuário ao arquivo CSV
                sw.WriteLine($"{Nome}, {cpf}, {email}, {telefone},`{whatsapp}, {cep}, {logradouro},`{numero}, {bairro}, {cidade}, {estado}");
            }
        }


        //função para leitura de banco de dados para mostrar no data grid view
        public static DataTable LerDatabaseClientes()
        {
            DataTable dt = new DataTable();

            if (!File.Exists(caminhoArquivoCsvClientes)) return dt;

            using (StreamReader sr = new StreamReader(caminhoArquivoCsvClientes))
            {
                string linha;
                bool primeiraLinha = true;
                int numeroColunas = 0;

                while ((linha = sr.ReadLine()) != null)
                {
                    // Ignora linhas em branco
                    if (string.IsNullOrWhiteSpace(linha))
                        continue;

                    string[] campos = linha.Split(',');

                    if (primeiraLinha)
                    {
                        foreach (string col in campos)
                            dt.Columns.Add(col.Trim());
                        numeroColunas = dt.Columns.Count;
                        primeiraLinha = false;
                    }
                    else
                    {
                        // Só adiciona se a quantidade de campos for igual ao número de colunas
                        if (campos.Length == numeroColunas)
                            dt.Rows.Add(campos.Select(c => c.Trim()).ToArray());
                    }
                }
            }

            return dt;
        }

        public static void RemoverCliente(string usuario)
        {
            //verificação se o arquivo não existe
            if (!File.Exists(caminhoArquivoCsvClientes))
                CriarArquivosSeNaoExistir();
            //armazenar o conteúdo do arquivo em uma lista
            var linhas = File.ReadAllLines(caminhoArquivoCsvClientes).ToList();

            // Pular a primeira linha (cabeçalho) e regravar o arquivo
            using (StreamWriter sw = new StreamWriter(caminhoArquivoCsvClientes))
            {
                // Verifica se a lista não está vazia
                sw.WriteLine(linhas[0]); // Cabeçalho

                // Percorre as linhas a partir da segunda linha 
                foreach (var linha in linhas.Skip(1))
                {
                    // Divide a linha em partes 
                    string[] partes = linha.Split(',');
                    // Verifica se a linha contém pelo menos duas partes e se o usuário não é o que está sendo removido
                    if (partes.Length >= 2 && partes[0].Trim() != usuario.Trim())
                    {
                        sw.WriteLine(linha);
                    }
                }
            }
        }

    }
}
