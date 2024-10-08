using MySql.Data.MySqlClient;
using System.Xml.Linq;

namespace AgendaMortifera
{
    public partial class frmLogin : Form
    {

        // String contendo as credencias para a conexão
        private readonly string token = "Server=localhost;Database=db_agenda;User ID=root;Password=root;";

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
            // Estabelecendo a conexão
            MySqlConnection conexao = new MySqlConnection(token);

            conexao.Open();

            MySqlCommand cmdVerificacao = new MySqlCommand(
                $"SELECT * FROM tb_usuarios WHERE tb_usuarios.usuario = @usuario AND tb_usuarios.senha = @senha",
                conexao
            );

            cmdVerificacao.Parameters.AddWithValue("@usuario", tbxUser.Text);

            cmdVerificacao.Parameters.AddWithValue("@senha", tbxPassword.Text);

            MySqlDataReader retornoVerificacao = cmdVerificacao.ExecuteReader();

            // O usuário está autenticado
            if (retornoVerificacao.Read() == true)
            {
                MessageBox.Show($"Prazer, eu sou o Satánas. Vamos tratar do seu pecado: {retornoVerificacao["pecado"]}.", $"Bem-Vindo Sr. (a) {retornoVerificacao["nome"]}");
            }

            // Usuário ou senha incorreta
            else
            {
                MessageBox.Show("Usuário ou senha incorreta.", "Tente Novamente!");
            }
        }
    }
}
