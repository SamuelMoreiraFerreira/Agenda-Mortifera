using AgendaMortifera.Controllers;
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
            // Valida��o dos dados dos TextBox's

            if (tbxUser.Text != "" && tbxPassword.Text.Length >= 8)
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
            UserController userController = new UserController();

            bool retornoVerificacao = userController.UserExists(tbxUser.Text, tbxPassword.Text);

            if (retornoVerificacao == true)
            {
                // O usu�rio est� autenticado

                frmPerfil screenPerfil = new frmPerfil()
                {
                    // Atribuindo o usuario da inst�ncia
                    usuario = tbxUser.Text
                };

                screenPerfil.ShowDialog();
            }

            else
            {
                // Usu�rio ou senha incorreta

                MessageBox.Show("Usu�rio ou senha incorreta.", "Tente Novamente!");
            }
        }
    }
}
