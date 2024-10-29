using AgendaMortifera.Data;
using MySql.Data.MySqlClient;
using System.Xml.Linq;

namespace AgendaMortifera
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {
            // Validação dos dados dos TextBox's

            if (tbxUser.Text != "" && tbxPassword.Text.Length > 8)
            {
                btnLogin.Enabled = true;
            }

            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            frmCadastrar screenCadastro = new frmCadastrar();

            screenCadastro.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            conexao.Open();

            MySqlCommand cmdVerificacao = new MySqlCommand(
                "SELECT * FROM tb_usuarios WHERE tb_usuarios.usuario = @usuario AND tb_usuarios.senha = @senha",
                conexao
            );

            cmdVerificacao.Parameters.AddWithValue("@usuario", tbxUser.Text);

            cmdVerificacao.Parameters.AddWithValue("@senha", tbxPassword.Text);

            // O comando retornará algum valor (ExecuteReader)
            MySqlDataReader retornoVerificacao = cmdVerificacao.ExecuteReader();

            if (retornoVerificacao.Read() == true)
            {
                // O usuário está autenticado

                MessageBox.Show($"Prazer, eu sou o Satánas. Vamos tratar do seu pecado: {retornoVerificacao["pecado"]} do melhor jeito em nosso centro de reabilitação.", $"Bem-Vindo Sr. (a) {retornoVerificacao["nome"]}");
            }

            else
            {
                // Usuário ou senha incorreta

                MessageBox.Show("Usuário ou senha incorreta.", "Tente Novamente!");
            }
        }
    }
}
