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
        public string userNameInHomepage = "";

        public homePage()
        {
            InitializeComponent();
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

        }

        private void cadastrarProdutosNavbar_Click(object sender, EventArgs e)
        {
            paginaDeCadastroDeProdutos.ShowDialog(); //exibindo a pagina de cadastro de produtos
        }
    }
}
