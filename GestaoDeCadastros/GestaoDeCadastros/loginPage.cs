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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            functions.CriarArquivosSeNaoExistir();
        }

        //botao de logar
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txt_usuario.Text;
            string userPassword = txt_senha.Text;
            if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("Preencha os campos de usuário e senha.");
            }
            if (functions.EfetuarLogin(userName, userPassword))
            {
                MessageBox.Show($"Login realizado com sucesso! Bem vindo {userName}");
                //formulario principal
                this.Hide();
            }

        }
    }
}
