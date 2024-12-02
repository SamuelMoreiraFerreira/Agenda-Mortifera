using AgendaMortifera.Controllers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMortifera
{
    public partial class frmCadastrar : Form
    {

        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {
            // Validação dos dados dos TextBox's

            if (

                tbxNome.Text != ""

                && tbxUsuario.Text != ""

                && cbxPecado.Text != ""

                && tbxPassword.Text.Length >= 8

                && tbxRPassword.Text != ""

                && tbxPassword.Text == tbxRPassword.Text

            )

            {
                btnSign.Enabled = true;
            }

            else
            {
                btnSign.Enabled = false;
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            // Cadastrando 

            bool cadastro = new UserController().CreateUser(cbxPecado.Text, tbxNome.Text, tbxUsuario.Text, tbxPassword.Text, tbxTelefone.Text);

            if (cadastro)
            {
                this.Close();

                // Sucesso

                MessageBox.Show("Você agora está cadastrado no livro do Diabo!", "Bem-Vindo ao Érebro");

            }

            else
            {
                // Erro

                MessageBox.Show("Ocorreu um erro ao cadastrar. Tente novamente!", "Problemas Técnicos");
            }
        }
    }
}
